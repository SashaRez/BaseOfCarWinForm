using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Subd
{
    public partial class FormKorzina : Form
    {

        public MainForm form1;

        public FormKorzina()
        {
            InitializeComponent();
        }


        private void buttonAdd_toKorzina_Click(object sender, EventArgs e)
        {

            try
            {
                SQL.Connect();

                int CarID = Convert.ToInt32(textBoxCarID.Text);
                string Mark = textBoxMarka.Text.ToString();
                string Model = textBoxModel.Text.ToString();
                string Type = textBoxType.Text.ToString();
                string Color = textBoxColor.Text.ToString();
                int Count = Convert.ToInt32(textBoxCount.Text);
                int Cost = Convert.ToInt32(Convert.ToDouble(textBoxPrice.Text));
                int Price = Cost * Count;

                int CarIDKorzina = Convert.ToInt32(SQL.GetValueFromTable("Korzina", "CarID", CarID));


                if (CarID == CarIDKorzina)
                {
                    SQL.setCmd($"UPDATE Korzina SET Marka = N'{Mark}', Model = N'{Model}', Type = N'{Type}', Color = N'{Color}', Kol = {Count}, Price = {Price} WHERE CarID = {CarIDKorzina}", form1.Korzina, form1.dataKorzina);
                }

                else
                {
                    SQL.setCmd("INSERT INTO Korzina (CarID, Marka, Model, Type, Color, Kol, Price) " +
                $"VALUES ({CarID}, N'{Mark}', N'{Model}', N'{Type}', N'{Color}', {Count}, {Price})", form1.Korzina, form1.dataKorzina);
                }

                SQL.UpdateKorzina(form1.Korzina, form1.dataKorzina);

                form1.check_Sum();

                this.Close();

            }


            catch (FormatException)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


       

        }

    }
}

