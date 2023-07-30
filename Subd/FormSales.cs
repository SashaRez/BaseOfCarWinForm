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
    public partial class FormSales : Form
    {

        public DataTable Sales;

        public FormSales()
        {
            InitializeComponent();
        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            SQL.Connect();
            SQL.setCmd("SELECT * FROM Sales", Sales, dataSales);

            FormOrder formOrder = new FormOrder();
            formOrder.formSales = this;
        }
    }
}
