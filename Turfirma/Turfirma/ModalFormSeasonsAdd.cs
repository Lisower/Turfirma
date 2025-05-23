using Npgsql;

namespace Turfirma
{
    public partial class ModalFormSeasonsAdd : Form
    {
        // Подключение к БД
        private NpgsqlConnection con;
        public ModalFormSeasonsAdd(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Seasons (tourid, startdate, enddate, isseasonclosed, availablespots) VALUES (@tourid, @startdate, @enddate, @isseasonclosed, @availablespots)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            // Преобразуем строки в даты
            DateTime startDate = DateTime.Parse(this.textBoxStartdate.Text);
            DateTime endDate = DateTime.Parse(this.textBoxEnddate.Text);

            // Явно указываем тип для каждого параметра
            cmd.Parameters.Add(new NpgsqlParameter("tourid", NpgsqlTypes.NpgsqlDbType.Integer)).Value = Convert.ToInt32(this.textBoxTourid.Text);
            cmd.Parameters.Add(new NpgsqlParameter("startdate", NpgsqlTypes.NpgsqlDbType.Date)).Value = startDate;
            cmd.Parameters.Add(new NpgsqlParameter("enddate", NpgsqlTypes.NpgsqlDbType.Date)).Value = endDate;
            cmd.Parameters.Add(new NpgsqlParameter("isseasonclosed", NpgsqlTypes.NpgsqlDbType.Boolean)).Value = this.checkBoxIsClosed.Checked;
            cmd.Parameters.Add(new NpgsqlParameter("availablespots", NpgsqlTypes.NpgsqlDbType.Integer)).Value = Convert.ToInt32(this.textBoxAvailableSpots.Text);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.textBoxTourid.Text = "";
            this.textBoxStartdate.Text = "";
            this.textBoxEnddate.Text = "";
            this.checkBoxIsClosed.Checked = false;
            this.textBoxAvailableSpots.Text = "";
        }
    }
}
