using Npgsql;

namespace Turfirma
{
    public partial class ModalFormBookingsAdd : Form
    {
        // Подключение к БД
        private NpgsqlConnection con;
        public ModalFormBookingsAdd(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Bookings (touristid, seasonid) VALUES (@touristid, @seasonid)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            // Явно указываем тип для каждого параметра
            cmd.Parameters.Add(new NpgsqlParameter("touristid", NpgsqlTypes.NpgsqlDbType.Integer)).Value = Convert.ToInt32(this.textBoxTouristid.Text);
            cmd.Parameters.Add(new NpgsqlParameter("seasonid", NpgsqlTypes.NpgsqlDbType.Integer)).Value = Convert.ToInt32(this.textBoxSeasonid.Text);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.textBoxTouristid.Text = "";
            this.textBoxSeasonid.Text = "";
        }
    }
}
