using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Subd
{
    public partial class FormToOrder : Form
    {

        public ClientsForm clientsForm;
        public FormOrder formOrder;
        public MainForm form1;

        public FormToOrder()
        {
            InitializeComponent();
        }


        private void FormToOrder_Load(object sender, EventArgs e)
        {
            clientsForm = new ClientsForm();
            formOrder = new FormOrder();
        }

        private void buttonMakeToOrder_Click(object sender, EventArgs e)
        {

            try
            {
                SQL.Connect();


                string clientName = textBoxName.Text;
                long number = long.Parse(textBoxNumber.Text);

                int CarID = Convert.ToInt32(textBoxCarID.Text);


                SQL.setCmd("INSERT INTO Clients(ClientName, ClientPhone) " +
            $"VALUES (N'{clientName}', {number})", clientsForm.Clients, clientsForm.dataClients);

                int ClientID = SQL.GetClientID(clientName, number);


                SQL.setCmd("INSERT INTO Orders(CarID, ClientID, ClientName, ClientPhone) " +
                    $"VALUES ({CarID}, {ClientID}, N'{clientName}', {number})", formOrder.Orders, formOrder.dataOrder);


                this.Close();

                MessageBox.Show("Заказ успешно оформлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            catch (FormatException)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
