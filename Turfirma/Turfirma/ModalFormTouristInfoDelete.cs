using Npgsql;

namespace Turfirma
{
    public partial class ModalFormTouristInfoDelete : Form
    {
        //подключение к БД
        private NpgsqlConnection con;
        // Первая выбранная строка
        private DataGridViewRow selectedRow;
        public ModalFormTouristInfoDelete(NpgsqlConnection con, DataGridViewRow selectedRow)
        {
            InitializeComponent();
            this.con = con;
            this.selectedRow = selectedRow;

            // Получаем данные из выбранной строки
            string touristid = selectedRow.Cells["touristid"].Value.ToString();
            string passportseries = selectedRow.Cells["passportseries"].Value.ToString();
            string city = selectedRow.Cells["city"].Value.ToString();
            string country = selectedRow.Cells["country"].Value.ToString();
            string phone = selectedRow.Cells["phone"].Value.ToString();
            string postalcode = selectedRow.Cells["postalcode"].Value.ToString();

            this.labelDown.Text = touristid + ":  " + passportseries + "  " + city + "  " + country + "  " + phone + "  " + postalcode + "?";
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(selectedRow.Cells["touristid"].Value);

            string sql = "DELETE FROM TouristInfo WHERE touristid = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            // Явно указываем тип для каждого параметра
            cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlTypes.NpgsqlDbType.Numeric)).Value = Id;

            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.labelDown.Text = "";
        }
    }
}
