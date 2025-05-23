using Npgsql;

namespace Turfirma
{
    public partial class ModalFormBookingsChange : Form
    {
        //подключение к БД
        private NpgsqlConnection con;
        // Первая выбранная строка
        private DataGridViewRow selectedRow;
        public ModalFormBookingsChange(NpgsqlConnection con, DataGridViewRow selectedRow)
        {
            InitializeComponent();
            this.con = con;
            this.selectedRow = selectedRow;

            // Получаем данные из выбранной строки
            string touristid = selectedRow.Cells["touristid"].Value.ToString();
            string seasonid = selectedRow.Cells["seasonid"].Value.ToString();

            this.textBoxTouristid.Text = touristid;
            this.textBoxSeasonid.Text = seasonid;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(selectedRow.Cells["bookingid"].Value);

            string sql = "UPDATE Bookings SET touristid = @touristid, seasonid = @seasonid WHERE bookingid = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            // Явно указываем тип для каждого параметра
            cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlTypes.NpgsqlDbType.Numeric)).Value = Id;
            cmd.Parameters.Add(new NpgsqlParameter("touristid", NpgsqlTypes.NpgsqlDbType.Integer)).Value = Convert.ToInt32(this.textBoxTouristid.Text);
            cmd.Parameters.Add(new NpgsqlParameter("seasonid", NpgsqlTypes.NpgsqlDbType.Integer)).Value = Convert.ToInt32(this.textBoxSeasonid.Text);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.textBoxTouristid.Text = "";
            this.textBoxSeasonid.Text = "";
        }
    }
}
