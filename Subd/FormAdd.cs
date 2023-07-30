using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Subd
{
    public partial class FormAdd : Form
    {

        public MainForm form1;


        public FormAdd()
        {
            InitializeComponent();
        }



        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            
            if (form1.dataCars.RowCount == 1)
            {
                SQL.setCmd("DBCC checkident (Cars, reseed, 0)", form1.Cars, form1.dataCars);
            }

            try
            {
                int TypeID = Convert.ToInt32(textBoxTypeID.Text);
                int MarkID = Convert.ToInt32(textBoxMarkID.Text);
                string Model = textBoxModel.Text.ToString();
                string Color = textBoxColor.Text;
                double Price = Convert.ToDouble(textBoxPrice.Text);

                SQL.Connect();

                SQL.setCmd("INSERT INTO Cars(TypeID, MarkID, Model, Color, Price) " +
                 $"VALUES ({TypeID}, {MarkID}, N'{Model}', N'{Color}', {Price})", form1.Cars, form1.dataCars);

                SQL.UpdateCars(form1.Cars, form1.dataCars);

                SQL.setComboBoxItem("Marks", "Marka", form1.comboBox1);

                this.Close();
            }

            catch (FormatException)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (SqlException)
            {
                MessageBox.Show("Произошла ошибка при добавлении данных в таблицу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

    }
}
