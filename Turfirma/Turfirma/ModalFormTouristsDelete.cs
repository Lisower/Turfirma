using Npgsql;

namespace Turfirma
{
    public partial class ModalFormTouristsDelete : Form
    {
        //подключение к БД
        private NpgsqlConnection con;
        // Первая выбранная строка
        private DataGridViewRow selectedRow;
        public ModalFormTouristsDelete(NpgsqlConnection con, DataGridViewRow selectedRow)
        {
            InitializeComponent();
            this.con = con;
            this.selectedRow = selectedRow;

            // Получаем данные из выбранной строки
            string Id = selectedRow.Cells["touristid"].Value.ToString();
            string lastName = selectedRow.Cells["lastname"].Value.ToString();
            string firstName = selectedRow.Cells["firstname"].Value.ToString();
            string middleName = selectedRow.Cells["middlename"].Value.ToString();

            this.labelDown.Text = Id + ":  " + lastName + "  " + firstName + "  " + middleName + "?";
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(selectedRow.Cells["touristid"].Value);

            string checksql = "SELECT COUNT(*) > 0 as has_references FROM Touristinfo WHERE touristid = @id";
            NpgsqlCommand checkcmd = new NpgsqlCommand(checksql, con);

            // Явно указываем тип для каждого параметра
            checkcmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlTypes.NpgsqlDbType.Numeric)).Value = Id;

            checkcmd.Prepare();

            bool has_references = (bool)checkcmd.ExecuteScalar();
            bool yes = true;

            if (has_references)
            {
                string errorText = $"Данная запись связана с другими таблицами! \n Вы хотите запустить каскадное удаление?";
                DialogResult result = MessageBox.Show(errorText, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result != DialogResult.OK)
                {
                    this.DialogResult = DialogResult.Cancel;
                    yes = false;
                }
            }
            if (yes)
            {
                string sql = "DELETE FROM Tourists WHERE touristid = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                // Явно указываем тип для каждого параметра
                cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlTypes.NpgsqlDbType.Numeric)).Value = Id;

                cmd.Prepare();

                cmd.ExecuteNonQuery();
                this.labelDown.Text = "";
            }
        }
    }
}
