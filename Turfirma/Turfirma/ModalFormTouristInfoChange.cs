using Npgsql;

namespace Turfirma
{
    public partial class ModalFormTouristInfoChange : Form
    {
        //подключение к БД
        private NpgsqlConnection con;
        // Первая выбранная строка
        private DataGridViewRow selectedRow;
        public ModalFormTouristInfoChange(NpgsqlConnection con, DataGridViewRow selectedRow)
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

            this.textBoxPassportseries.Text = passportseries;
            this.textBoxCity.Text = city;
            this.textBoxCountry.Text = country;
            this.textBoxPhone.Text = phone;
            this.textBoxPostalcode.Text = postalcode;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(selectedRow.Cells["touristid"].Value);

            string sql = "UPDATE TouristInfo SET passportseries = @passportseries, city = @city, country = @country, phone = @phone, postalcode = @postalcode WHERE touristid = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            // Явно указываем тип для каждого параметра
            cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlTypes.NpgsqlDbType.Numeric)).Value = Id;
            cmd.Parameters.Add(new NpgsqlParameter("passportseries", NpgsqlTypes.NpgsqlDbType.Text)).Value = this.textBoxPassportseries.Text;
            cmd.Parameters.Add(new NpgsqlParameter("city", NpgsqlTypes.NpgsqlDbType.Text)).Value = this.textBoxCity.Text;
            cmd.Parameters.Add(new NpgsqlParameter("country", NpgsqlTypes.NpgsqlDbType.Text)).Value = this.textBoxCountry.Text;
            cmd.Parameters.Add(new NpgsqlParameter("phone", NpgsqlTypes.NpgsqlDbType.Text)).Value = this.textBoxPhone.Text;
            cmd.Parameters.Add(new NpgsqlParameter("postalcode", NpgsqlTypes.NpgsqlDbType.Integer)).Value = Convert.ToInt32(this.textBoxPostalcode.Text);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.textBoxPassportseries.Text = "";
            this.textBoxCity.Text = "";
            this.textBoxCountry.Text = "";
            this.textBoxPhone.Text = "";
            this.textBoxPostalcode.Text = "";
        }
    }
}
