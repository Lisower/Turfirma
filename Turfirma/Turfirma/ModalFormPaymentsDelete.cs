using Npgsql;

namespace Turfirma
{
    public partial class ModalFormPaymentsDelete : Form
    {
        // Подключение к БД
        private NpgsqlConnection con;
        // Первая выбранная строка
        private DataGridViewRow selectedRow;
        public ModalFormPaymentsDelete(NpgsqlConnection con, DataGridViewRow selectedRow)
        {
            InitializeComponent();
            this.con = con;
            this.selectedRow = selectedRow;

            // Получаем данные из выбранной строки
            string paymentid = selectedRow.Cells["paymentid"].Value.ToString();
            string bookingid = selectedRow.Cells["bookingid"].Value.ToString();
            string paymentdate = selectedRow.Cells["paymentdate"].Value.ToString();
            string amount = selectedRow.Cells["amount"].Value.ToString();

            this.labelDown.Text = paymentid + ":  " + bookingid + "  " + paymentdate + "  " + amount + "?";
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(selectedRow.Cells["paymentid"].Value);

            string sql = "DELETE FROM Payments WHERE paymentid = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            // Явно указываем тип для каждого параметра
            cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlTypes.NpgsqlDbType.Numeric)).Value = Id;

            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.labelDown.Text = "";
        }
    }
}
