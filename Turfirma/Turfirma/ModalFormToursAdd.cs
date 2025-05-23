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
    public partial class ModalFormToursAdd : Form
    {
        // Подключение к БД
        private NpgsqlConnection con;
        public ModalFormToursAdd(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Tours (tourname, price, description) VALUES (@tourname, @price, @description)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            // Явно указываем тип для каждого параметра
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
