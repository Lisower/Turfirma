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
    public partial class ModalFormToursChange : Form
    {
        // Подключение к БД
        private NpgsqlConnection con;
        // Первая выбранная строка
        private DataGridViewRow selectedRow;
        public ModalFormToursChange(NpgsqlConnection con, DataGridViewRow selectedRow)
        {
            InitializeComponent();
            this.con = con;
            this.selectedRow = selectedRow;

            // Получаем данные из выбранной строки
            string tourname = selectedRow.Cells["tourname"].Value.ToString();
            string price = selectedRow.Cells["price"].Value.ToString();
            string description = selectedRow.Cells["description"].Value.ToString();

            this.textBoxTourname.Text = tourname;
            this.textBoxPrice.Text = price;
            this.textBoxDescription.Text = description;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(selectedRow.Cells["tourid"].Value);

            string sql = "UPDATE Tours SET tourname = @tourname, price = @price, description = @description WHERE tourid = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            // Явно указываем тип для каждого параметра
            cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlTypes.NpgsqlDbType.Numeric)).Value = Id;
            cmd.Parameters.Add(new NpgsqlParameter("tourname", NpgsqlTypes.NpgsqlDbType.Text)).Value = this.textBoxTourname.Text;
            cmd.Parameters.Add(new NpgsqlParameter("price", NpgsqlTypes.NpgsqlDbType.Money)).Value = Convert.ToDecimal(this.textBoxPrice.Text);
            cmd.Parameters.Add(new NpgsqlParameter("description", NpgsqlTypes.NpgsqlDbType.Text)).Value = this.textBoxDescription.Text;

            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.textBoxTourname.Text = "";
            this.textBoxPrice.Text = "";
            this.textBoxDescription.Text = "";
        }
    }
}
