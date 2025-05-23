using Npgsql;

namespace Turfirma
{
    public partial class ModalFormSeasonsDelete : Form
    {
        // Подключение к БД
        private NpgsqlConnection con;
        // Первая выбранная строка
        private DataGridViewRow selectedRow;
        public ModalFormSeasonsDelete(NpgsqlConnection con, DataGridViewRow selectedRow)
        {
            InitializeComponent();
            this.con = con;
            this.selectedRow = selectedRow;

            // Получаем данные из выбранной строки
            string seasonid = selectedRow.Cells["seasonid"].Value.ToString();
            string tourid = selectedRow.Cells["tourid"].Value.ToString();
            string startdate = selectedRow.Cells["startdate"].Value.ToString();
            string enddate = selectedRow.Cells["enddate"].Value.ToString();
            string isseasonclosed = selectedRow.Cells["isseasonclosed"].Value.ToString();
            string availablespots = selectedRow.Cells["availablespots"].Value.ToString();

            this.labelDown.Text = seasonid + ":  " + tourid + "  " + startdate + "  " + enddate + "  " + isseasonclosed + "  " + availablespots + "?";
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(selectedRow.Cells["seasonid"].Value);

            string sql = "DELETE FROM Seasons WHERE seasonid = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            // Явно указываем тип для каждого параметра
            cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlTypes.NpgsqlDbType.Numeric)).Value = Id;

            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.labelDown.Text = "";
        }
    }
}
