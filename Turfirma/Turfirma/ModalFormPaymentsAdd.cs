using Npgsql;

namespace Turfirma
{
    public partial class ModalFormPaymentsAdd : Form
    {
        // Подключение к БД
        private NpgsqlConnection con;
        public ModalFormPaymentsAdd(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Payments (bookingid, paymentdate, amount) VALUES (@bookingid, @paymentdate, @amount)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            // Явно указываем тип для каждого параметра
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
