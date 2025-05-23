using Npgsql;

namespace Turfirma
{
    public partial class ModalFormTouristsChange : Form
    {
        // Подключение к БД
        private NpgsqlConnection con;
        // Первая выбранная строка
        private DataGridViewRow selectedRow;
        public ModalFormTouristsChange(NpgsqlConnection con, DataGridViewRow selectedRow)
        {
            InitializeComponent();
            this.con = con;
            this.selectedRow = selectedRow;

            // Получаем данные из выбранной строки
            string lastName = selectedRow.Cells["lastname"].Value.ToString();
            string firstName = selectedRow.Cells["firstname"].Value.ToString();
            string middleName = selectedRow.Cells["middlename"].Value.ToString();

            this.textBoxLastname.Text = lastName;
            this.textBoxFirstname.Text = firstName;
            this.textBoxMiddlename.Text = middleName;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(selectedRow.Cells["touristid"].Value);

            string sql = "UPDATE Tourists SET lastname = @lastname, firstname = @firstname, middlename = @middlename WHERE touristid = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            // Явно указываем тип для каждого параметра
            cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlTypes.NpgsqlDbType.Numeric)).Value = Id;
            cmd.Parameters.Add(new NpgsqlParameter("lastname", NpgsqlTypes.NpgsqlDbType.Text)).Value = this.textBoxLastname.Text;
            cmd.Parameters.Add(new NpgsqlParameter("firstname", NpgsqlTypes.NpgsqlDbType.Text)).Value = this.textBoxFirstname.Text;
            cmd.Parameters.Add(new NpgsqlParameter("middlename", NpgsqlTypes.NpgsqlDbType.Text)).Value = this.textBoxMiddlename.Text;

            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.textBoxLastname.Text = "";
            this.textBoxFirstname.Text = "";
            this.textBoxMiddlename.Text = "";
        }
    }
}
