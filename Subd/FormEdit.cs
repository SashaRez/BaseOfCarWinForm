using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Subd
{
    public partial class FormEdit : Form
    {

        public MainForm form1;


        public FormEdit()
        {
            InitializeComponent();

        }


        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                SQL.Connect();

                int TypeID = Convert.ToInt32(textBoxTypeID.Text);
                int MarkID = Convert.ToInt32(textBoxMarkID.Text);
                string Model = textBoxModel.Text.ToString();
                string Color = textBoxColor.Text;
                double Price = Convert.ToDouble(textBoxPrice.Text);

                int CarID = Convert.ToInt32(form1.dataCars.CurrentRow.Cells["CarID"].Value.ToString());

                SQL.setCmd($"UPDATE Cars SET TypeID = {TypeID}, MarkID = {MarkID}, Model = N'{Model}', Color = N'{Color}', Price = {Price} WHERE CarID = {CarID}", form1.Cars, form1.dataCars);
                
                SQL.setCmd($"UPDATE Korzina SET Marka = N'{SQL.GetValueFromTable("Marks", "Marka", MarkID)}', " +
                    $"Model = N'{Model}', Type = N'{SQL.GetValueFromTable("Types", "Type", TypeID)}', Color = N'{Color}', " +
                    $"Price = { Convert.ToDouble(SQL.GetValueFromTable("Cars", "Price", CarID)) * Convert.ToDouble(SQL.GetValueFromTable("Korzina", "Kol", CarID)) } " +
                    $"WHERE CarID = {CarID}", form1.Korzina, form1.dataKorzina);

                SQL.UpdateCars(form1.Cars, form1.dataCars);

                SQL.UpdateKorzina(form1.Korzina, form1.dataKorzina);

                form1.check_Sum();

                this.Close();

            }


            catch (FormatException)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (SqlException)
            {
                MessageBox.Show("Произошла ошибка при внесении данных в таблицу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
