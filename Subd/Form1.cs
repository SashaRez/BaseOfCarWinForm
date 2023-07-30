using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Subd
{
    public partial class MainForm : Form
    {

        public SqlConnection conn;
        public string strConnectionCars;

        public SqlCommand cmd, cmdKorzina;
        public string strCmd;

        public SqlDataAdapter adapter, adapKorzina;

        public DataTable Cars, Korzina;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            SQL.Connect();


            SQL.setCmd("SELECT * FROM Cars", Cars, dataCars);

            //======================================================

            SQL.setCmd("SELECT * FROM Korzina", Korzina, dataKorzina);


            //======================================================
            SQL.setComboBoxItem("Marks", "Marka", comboBox1);
            SQL.setComboBoxItem("Types", "Type", comboBox2);

            comboBox2.Visible = false;

            check_Sum();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.Show();
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder();
            formOrder.form1 = this;
            formOrder.Show();
        }



        private void toolStripShowSales_Click(object sender, EventArgs e)
        {
            FormSales formSales = new FormSales();
            formSales.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.form1 = this;
            formAdd.Show();
        }


        private void buttonDeleteTovar_Click(object sender, EventArgs e)
        {

            DataGridViewRow curRow = dataKorzina.CurrentRow;


            if (curRow == null)
            {
                MessageBox.Show("Корзина уже очищена!", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CarID = Convert.ToInt32(curRow.Cells["CarID"].Value.ToString());
                SQL.DeleteCarFromKorzina(CarID, Korzina, dataKorzina);
                check_Sum();
            }


        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {

            DataGridViewRow curRow = dataKorzina.CurrentRow;


            if (curRow == null)
            {
                MessageBox.Show("Корзина уже очищена!", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SQL.ClearKorzina(Korzina, dataKorzina);
                check_Sum();
            }
        }



        private void buttonEdit_Click(object sender, EventArgs e)
        {

            FormEdit formEdit = new FormEdit();
            formEdit.form1 = this;

            DataGridViewRow curRow = dataCars.CurrentRow;

            if (curRow == null)
            {
                MessageBox.Show("Товар отсутствует в списке!", "Ошибка редактирования", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                formEdit.textBoxTypeID.Text = curRow.Cells["TypeID"].Value.ToString().Trim();
                formEdit.textBoxMarkID.Text = curRow.Cells["MarkID"].Value.ToString().Trim();
                formEdit.textBoxModel.Text = curRow.Cells["Model"].Value.ToString().Trim();
                formEdit.textBoxColor.Text = curRow.Cells["Color"].Value.ToString().Trim();
                formEdit.textBoxPrice.Text = curRow.Cells["Price"].Value.ToString().Trim();

                formEdit.Show();
            }


        }


        private void delete_Click(object sender, EventArgs e)
        {

            DataGridViewRow curRow = dataCars.CurrentRow;

            if (curRow == null)
            {
                MessageBox.Show("Записи в таблице отсутствуют!", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CarID = Convert.ToInt32(curRow.Cells["CarID"].Value.ToString());
                SQL.DeleteCar(CarID, Cars, dataCars);

                SQL.setComboBoxItem("Marks", "Marka", comboBox1);
            }
        }


        private void buttonAdd_toKorzina_Click(object sender, EventArgs e)
        {

            FormKorzina formKorzina = new FormKorzina();
            formKorzina.form1 = this;

            DataGridViewRow curRow = dataCars.CurrentRow;


            if (curRow == null)
            {
                MessageBox.Show("Товар для добавления в корзину отсутствует!", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int CarID = Convert.ToInt32(curRow.Cells["CarID"].Value.ToString());
                formKorzina.textBoxCarID.Text = SQL.GetValueFromTable("Cars", "CarID", CarID);

                int TypeID = Convert.ToInt32(curRow.Cells["TypeID"].Value.ToString());
                formKorzina.textBoxType.Text = SQL.GetValueFromTable("Types", "Type", TypeID);

                int MarkID = Convert.ToInt32(curRow.Cells["MarkID"].Value.ToString());
                formKorzina.textBoxMarka.Text = SQL.GetValueFromTable("Marks", "Marka", MarkID);

                formKorzina.textBoxModel.Text = SQL.GetValueFromTable("Cars", "Model", CarID);

                formKorzina.textBoxColor.Text = SQL.GetValueFromTable("Cars", "Color", CarID);

                formKorzina.textBoxPrice.Text = SQL.GetValueFromTable("Cars", "Price", CarID);

                formKorzina.textBoxCount.Text = 1.ToString();

                formKorzina.Show();
            }

        }


        private void buttonOrder_Click(object sender, EventArgs e)
        {
            FormToOrder formToOrder = new FormToOrder();
            formToOrder.form1 = this;

            DataGridViewRow curRow = dataKorzina.CurrentRow;

            if (curRow == null)
            {
                MessageBox.Show("Товар для оформления заказа отсутствует!", "Ошибка заказа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                formToOrder.textBoxCarID.Text = curRow.Cells["CarID"].Value.ToString().Trim();
                formToOrder.textBoxMarka.Text = curRow.Cells["Marka"].Value.ToString().Trim();
                formToOrder.textBoxModel.Text = curRow.Cells["Model"].Value.ToString().Trim();
                formToOrder.textBoxType.Text = curRow.Cells["Type"].Value.ToString().Trim();
                formToOrder.textBoxColor.Text = curRow.Cells["Color"].Value.ToString().Trim();
                formToOrder.textBoxCount.Text = curRow.Cells["Kol"].Value.ToString().Trim();
                formToOrder.textBoxPrice.Text = curRow.Cells["Price"].Value.ToString().Trim();

                formToOrder.Show();
            }

        }

        public void check_Sum()
        {
            double sum = 0;
            for (int i = 0; i < dataKorzina.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataKorzina.Rows[i].Cells[6].Value);
            }

            textBoxAllSum.Text = sum.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQL.SelectCarByMark(comboBox1, comboBox2, Cars, dataCars);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQL.SelectCarByMarkAndType(comboBox1, comboBox2, Cars, dataCars);
        }
    }
}
