using Npgsql;

namespace Turfirma
{
    public partial class ModalFormPaymentsChange : Form
    {
        //подключение к БД
        private NpgsqlConnection con;
        // Первая выбранная строка
        private DataGridViewRow selectedRow;
        public ModalFormPaymentsChange(NpgsqlConnection con, DataGridViewRow selectedRow)
        {
            InitializeComponent();
            this.con = con;
            this.selectedRow = selectedRow;

            // Получаем данные из выбранной строки
            string bookingid = selectedRow.Cells["bookingid"].Value.ToString();
            string paymentdate = selectedRow.Cells["paymentdate"].Value.ToString();
            string amount = selectedRow.Cells["amount"].Value.ToString();

            this.textBoxBookingid.Text = bookingid;
            this.textBoxPaymentDate.Text = paymentdate;
            this.textBoxAmount.Text = amount;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(selectedRow.Cells["paymentid"].Value);

            string sql = "UPDATE Payments SET bookingid = @bookingid, paymentdate = @paymentdate, amount = @amount WHERE paymentid = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            // Явно указываем тип для каждого параметра
            cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlTypes.NpgsqlDbType.Numeric)).Value = Id;
            cmd.Parameters.Add(new NpgsqlParameter("bookingid", NpgsqlTypes.NpgsqlDbType.Integer)).Value = Convert.ToInt32(this.textBoxBookingid.Text);
            cmd.Parameters.Add(new NpgsqlParameter("paymentdate", NpgsqlTypes.NpgsqlDbType.Date)).Value = DateTime.Parse(this.textBoxPaymentDate.Text);
            cmd.Parameters.Add(new NpgsqlParameter("amount", NpgsqlTypes.NpgsqlDbType.Money)).Value = Convert.ToDecimal(this.textBoxAmount.Text);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.textBoxBookingid.Text = "";
            this.textBoxPaymentDate.Text = "";
            this.textBoxAmount.Text = "";
        }
    }
}
