using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace Subd
{
    static class SQL
    {
        public static SqlConnection conn;
        public static string strConnection;

        public static SqlCommand cmd;
        public static SqlDataAdapter adapter;

        public static string strCars;

        public static void Connect()
        {
            strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\base\CarBase.mdf;Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(strConnection);
            conn.Open();
        }

        public static void setCmd(string strCmd, DataTable table, DataGridView dataGridView)
        {
            cmd = new SqlCommand(strCmd, conn);
            setTable(cmd, table, dataGridView);
        }

        private static void setTable(SqlCommand cmd, DataTable table, DataGridView dataGridView)
        {
            adapter = new SqlDataAdapter(cmd);

            table = new DataTable();
            adapter.Fill(table);

            dataGridView.DataSource = table;

        }
        

        public static void DeleteCar(int CarID, DataTable table, DataGridView dataGridView)
        {
            setCmd($"DELETE FROM Cars WHERE CarID = {CarID} DBCC checkident (Cars, reseed, {CarID - 1})", table, dataGridView);
            UpdateCars(table, dataGridView);
        }


        public static void DeleteCarFromKorzina(int CarID, DataTable table, DataGridView dataGridView)
        {
            setCmd($"DELETE FROM Korzina WHERE CarID = {CarID}", table, dataGridView);
            UpdateKorzina(table, dataGridView);
        }

        public static void ClearKorzina(DataTable table, DataGridView dataGridView)
        {
            setCmd("DELETE FROM Korzina", table, dataGridView);
            UpdateKorzina(table, dataGridView);
        }

        public static void DeleteOrder(int OrderID, DataTable table, DataGridView dataGridView)
        {
            setCmd($"DELETE FROM Orders WHERE OrderID = {OrderID} DBCC checkident (Orders, reseed, {OrderID - 1})", table, dataGridView);
            UpdateOrders(table, dataGridView);
        }

        public static void OrderComplete(int OrderID, DataTable table, DataGridView dataGridView)
        {
            setCmd($"DELETE FROM Orders WHERE OrderID = {OrderID}", table, dataGridView);
            UpdateOrders(table, dataGridView);
        }

        public static void DeleteClient(int ClientID, DataTable table, DataGridView dataGridView)
        {
            setCmd($"DELETE FROM Clients WHERE ClientID = {ClientID} DBCC checkident (Clients, reseed, {ClientID - 1})", table, dataGridView);
            UpdateClients(table, dataGridView);
        }


        public static string GetValueFromTable(string tableName, string valueName, int id)
        {
            string PrimaryKey = GetPrimaryKey(tableName);
            string command = $"SELECT {valueName} FROM {tableName} WHERE {PrimaryKey} = {id}";
            cmd = new SqlCommand(command, conn);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string value = dr.GetValue(0).ToString().Trim();
                dr.Close();
                return value;
            }
            else
            {
                dr.Close();
                return null;
            }
     
        }


        public static string ExecuteCommand(string command)
        {
            cmd = new SqlCommand(command, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string result = dr.GetValue(0).ToString().Trim();
                dr.Close();
                return result;
            }
            else
            {
                dr.Close();
                return null;
            }
        }


        private static string GetPrimaryKey(string tableName)
        {
            string command = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE TABLE_NAME = '{tableName}'";
            cmd = new SqlCommand(command, conn);
            string PrimaryKey = cmd.ExecuteScalar().ToString().Trim();

            if (PrimaryKey != null)
            {
                return PrimaryKey;
            }
            return null;
        }


        public static void setComboBoxItem(string tableName, string valueName, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add(valueName);


            string temp = "";

            string PrimaryKey = GetPrimaryKey(tableName);
            string command = $"SELECT DISTINCT {PrimaryKey} FROM Cars";
            cmd = new SqlCommand(command, conn);

            adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);


            foreach(DataRow row in table.Rows)
            {
                int id = Convert.ToInt32(row[0].ToString());
                command = $"SELECT DISTINCT {valueName} FROM {tableName} WHERE {PrimaryKey} = {id}";

                cmd = new SqlCommand(command, conn);

                string result = cmd.ExecuteScalar().ToString().Trim();

                if (result.Equals(temp))
                {
                    
                }
                else
                {
                    comboBox.Items.Add(result);
                    comboBox.SelectedIndex = 0;
                    temp = result;
                }
            }

        }



        public static void SelectCarByMark (ComboBox comboBox1, ComboBox comboBox2, DataTable Cars, DataGridView dataCars)
        {
            int index1 = comboBox1.SelectedIndex;
            strCars = "SELECT * FROM Cars";


            string command = "SELECT MarkID FROM Cars";
            cmd = new SqlCommand(command, conn);

            adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);

            string temp = string.Empty;

            if (index1 > 0)
            {
                foreach (DataRow row in table.Rows)
                {

                    string name = comboBox1.Text.ToString().Trim();

                    int MarkID = Convert.ToInt32(row[0].ToString());

                    command = $"SELECT Marka FROM Marks WHERE MarkID = {MarkID}";

                    cmd = new SqlCommand(command, conn);

                    string result = cmd.ExecuteScalar().ToString().Trim();


                    if (result == name)
                    {
                        temp += MarkID.ToString() + ",";
                    }

                }

                if (string.IsNullOrEmpty(temp))
                {

                }

                else
                {
                    strCars += $" WHERE MarkID in ({temp.TrimEnd(',')})";
                    SQL.setCmd(strCars, Cars, dataCars);
                    comboBox2.SelectedIndex = 0;
                    comboBox2.Visible = true;
                }
            }

            else
            {
                SQL.setCmd(strCars, Cars, dataCars);
                comboBox2.Visible = false;
            }
        }


        public static void SelectCarByMarkAndType(ComboBox comboBox1, ComboBox comboBox2, DataTable Cars, DataGridView dataCars)
        {
            int index2 = comboBox2.SelectedIndex;

            string command = "SELECT TypeID FROM Cars";
            cmd = new SqlCommand(command, conn);

            adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);


            if (index2 > 0)
            {
                foreach (DataRow row in table.Rows)
                {

                    string Type = comboBox2.Text.ToString().Trim();

                    int TypeID = Convert.ToInt32(row[0].ToString());

                    command = $"SELECT Type FROM Types WHERE TypeID = {TypeID}";

                    cmd = new SqlCommand(command, conn);

                    string result = cmd.ExecuteScalar().ToString().Trim();


                    if (result == Type)
                    {
                        string Marka = comboBox1.Text.ToString().Trim();

                        int MarkID = Convert.ToInt32(SQL.ExecuteCommand($"SELECT MarkID FROM Marks WHERE TypeID = {TypeID} AND Marka = N'{Marka}'"));

                        SQL.setCmd($"SELECT * FROM Cars WHERE MarkID = N'{MarkID}' AND TypeID = {TypeID}", Cars, dataCars);

                    }

                }
            }

            else
            {
                SQL.setCmd(strCars, Cars, dataCars);
            }
        }


        public static int GetClientID(string clientName, long number)
        {
            string command = $"SELECT ClientID FROM Clients WHERE ClientName = N'{clientName}' AND ClientPhone = {number}";
            cmd = new SqlCommand(command, conn);

            int ClientID = Convert.ToInt32(cmd.ExecuteScalar().ToString().Trim());

            if (ClientID != 0)
            {
                return ClientID;
            }

            return 0;
        }


        public static void UpdateCars(DataTable table, DataGridView dataGridView)
        {
            setCmd($"SELECT * FROM Cars", table, dataGridView);
        }

        public static void UpdateKorzina(DataTable table, DataGridView dataGridView)
        {
            setCmd($"SELECT * FROM Korzina", table, dataGridView);
        }

        public static void UpdateClients(DataTable table, DataGridView dataGridView)
        {
            setCmd($"SELECT * FROM Clients", table, dataGridView);
        }
        
        public static void UpdateOrders(DataTable table, DataGridView dataGridView)
        {
            setCmd($"SELECT * FROM Orders", table, dataGridView);
        }

        public static void UpdateSales(DataTable table, DataGridView dataGridView)
        {
            setCmd($"SELECT * FROM Sales", table, dataGridView);
        }

    }
}
