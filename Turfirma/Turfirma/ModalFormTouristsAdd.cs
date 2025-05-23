using Npgsql;

namespace Turfirma
{
    public partial class ModalFormTouristsAdd : Form
    {
        // Подключение к БД
        private NpgsqlConnection con;
        public ModalFormTouristsAdd(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Tourists (lastname, firstname, middlename) VALUES (@lastname, @firstname, @middlename)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            // Явно указываем тип для каждого параметра
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
