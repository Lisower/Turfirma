using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turfirma
{
    public partial class ModalFormToursDelete : Form
    {
        //подключение к БД
        private NpgsqlConnection con;
        // Первая выбранная строка
        private DataGridViewRow selectedRow;
        public ModalFormToursDelete(NpgsqlConnection con, DataGridViewRow selectedRow)
        {
            InitializeComponent();
            this.con = con;
            this.selectedRow = selectedRow;

            // Получаем данные из выбранной строки
            string Id = selectedRow.Cells["tourid"].Value.ToString();
            string tourname = selectedRow.Cells["tourname"].Value.ToString();
            string price = selectedRow.Cells["price"].Value.ToString();
            string description = selectedRow.Cells["description"].Value.ToString();

            this.labelDown.Text = Id + ":  " + tourname + "  " + price + "\n" + description + "?";
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(selectedRow.Cells["tourid"].Value);

            string sql = "DELETE FROM Tours WHERE tourid = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            // Явно указываем тип для каждого параметра
            cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlTypes.NpgsqlDbType.Numeric)).Value = Id;

            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.labelDown.Text = "";
        }
    }
}
