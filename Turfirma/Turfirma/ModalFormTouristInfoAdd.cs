using Npgsql;

namespace Turfirma
{
    public partial class ModalFormTouristInfoAdd : Form
    {
        // Подключение к БД
        private NpgsqlConnection con;
        public ModalFormTouristInfoAdd(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO TouristInfo (touristid, passportseries, city, country, phone, postalcode) VALUES (@touristid, @passportseries, @city, @country, @phone, @postalcode)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            // Явно указываем тип для каждого параметра
            cmd.Parameters.Add(new NpgsqlParameter("touristid", NpgsqlTypes.NpgsqlDbType.Integer)).Value = Convert.ToInt32(this.textBoxTouristid.Text);
            cmd.Parameters.Add(new NpgsqlParameter("passportseries", NpgsqlTypes.NpgsqlDbType.Text)).Value = this.textBoxPassportseries.Text;
            cmd.Parameters.Add(new NpgsqlParameter("city", NpgsqlTypes.NpgsqlDbType.Text)).Value = this.textBoxCity.Text;
            cmd.Parameters.Add(new NpgsqlParameter("country", NpgsqlTypes.NpgsqlDbType.Text)).Value = this.textBoxCountry.Text;
            cmd.Parameters.Add(new NpgsqlParameter("phone", NpgsqlTypes.NpgsqlDbType.Text)).Value = this.textBoxPhone.Text;
            cmd.Parameters.Add(new NpgsqlParameter("postalcode", NpgsqlTypes.NpgsqlDbType.Integer)).Value = Convert.ToInt32(this.textBoxPostalcode.Text);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.textBoxTouristid.Text = "";
            this.textBoxPassportseries.Text = "";
            this.textBoxCity.Text = "";
            this.textBoxCountry.Text = "";
            this.textBoxPhone.Text = "";
            this.textBoxPostalcode.Text = "";
        }
    }
}
