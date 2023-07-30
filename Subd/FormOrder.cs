using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Subd
{
    public partial class FormOrder : Form
    {

        public ClientsForm clientsForm;

        public FormSales formSales;

        public MainForm form1;

        public DataTable Orders;

        public FormOrder()
        {
            InitializeComponent();

            FormToOrder formToOrder = new FormToOrder();
            formToOrder.formOrder = this;
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            SQL.Connect();
            SQL.setCmd("SELECT *  FROM  Orders", Orders, dataOrder);

            clientsForm = new ClientsForm();
            formSales = new FormSales();

        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {

            DataGridViewRow curRow = dataOrder.CurrentRow;

            if (curRow == null)
            {
                MessageBox.Show("Заказы в таблице отсутствуют!", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int OrderID = Convert.ToInt32(curRow.Cells["OrderID"].Value.ToString());

                string Name = curRow.Cells["ClientName"].Value.ToString();
                long Number = long.Parse(curRow.Cells["ClientPhone"].Value.ToString());

                SQL.DeleteOrder(OrderID, Orders, dataOrder);

                int ClientID = SQL.GetClientID(Name, Number);

                SQL.DeleteClient(ClientID, clientsForm.Clients, clientsForm.dataClients);

                MessageBox.Show("Заказ успешно отменён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonAcceptOrder_Click(object sender, EventArgs e)
        {
            DataGridViewRow curRow = dataOrder.CurrentRow;

            if (curRow == null)
            {
                MessageBox.Show("Заказы в таблице отсутствуют!", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                int OrderID = Convert.ToInt32(curRow.Cells["OrderID"].Value.ToString());
                int ClientID = Convert.ToInt32(curRow.Cells["ClientID"].Value.ToString());
                int CarID = Convert.ToInt32(curRow.Cells["CarID"].Value.ToString());


                string Marka = SQL.GetValueFromTable("Korzina", "Marka", CarID);

                string Model = SQL.GetValueFromTable("Korzina", "Model", CarID);

                string Type = SQL.GetValueFromTable("Korzina", "Type", CarID);

                string Color = SQL.GetValueFromTable("Korzina", "Color", CarID);

                int Kol = Convert.ToInt32(SQL.GetValueFromTable("Korzina", "Kol", CarID));

                double Price = Convert.ToDouble(SQL.GetValueFromTable("Korzina", "Price", CarID));

                string Name = SQL.GetValueFromTable("Clients", "ClientName", ClientID);
                long Number = long.Parse(SQL.GetValueFromTable("Clients", "ClientPhone", ClientID));

                SQL.setCmd("INSERT INTO Sales(OrderID, ClientID, Marka, Model, Type, Color, Kol, Price, ClientName, ClientPhone) " +
                    $"VALUES ({OrderID}, {ClientID}, N'{Marka}', N'{Model}', N'{Type}', N'{Color}', {Kol}, {Price}, N'{Name}', {Number})", formSales.Sales, formSales.dataSales);
               
                SQL.UpdateSales(formSales.Sales, formSales.dataSales);

                SQL.OrderComplete(OrderID, Orders, dataOrder);

                SQL.DeleteCarFromKorzina(CarID, form1.Korzina, form1.dataKorzina);

                MessageBox.Show("Заказ успешно оплачен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
