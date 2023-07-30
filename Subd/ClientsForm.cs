using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subd
{
    public partial class ClientsForm : Form
    {

        public DataTable Clients;
        

        public ClientsForm()
        {
            InitializeComponent();

            FormToOrder formToOrder = new FormToOrder();
            formToOrder.clientsForm = this;

            FormOrder formOrder = new FormOrder();
            formOrder.clientsForm = this;
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            SQL.Connect();
            SQL.setCmd("SELECT * FROM Clients", Clients, dataClients);
        }
    }
}
