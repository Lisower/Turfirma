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
    public partial class ModalFormSeasonsChange : Form
    {
        //подключение к БД
        private NpgsqlConnection con;
        // Первая выбранная строка
        private DataGridViewRow selectedRow;
        public ModalFormSeasonsChange(NpgsqlConnection con, DataGridViewRow selectedRow)
        {
            InitializeComponent();
            this.con = con;
            this.selectedRow = selectedRow;

            // Получаем данные из выбранной строки
            string tourid = selectedRow.Cells["tourid"].Value.ToString();
            string startdate = selectedRow.Cells["startdate"].Value.ToString();
            string enddate = selectedRow.Cells["enddate"].Value.ToString();
            bool isseasonclosed = (bool)selectedRow.Cells["isseasonclosed"].Value;
            string availablespots = selectedRow.Cells["availablespots"].Value.ToString();

            this.textBoxTourid.Text = tourid;
            this.textBoxStartdate.Text = startdate;
            this.textBoxEnddate.Text = enddate;
            this.checkBoxIsClosed.Checked = isseasonclosed;
            this.textBoxAvailableSpots.Text = availablespots;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(selectedRow.Cells["seasonid"].Value);

            string sql = "UPDATE Seasons SET tourid = @tourid, startdate = @startdate, enddate = @enddate, isseasonclosed = @isseasonclosed, availablespots = @availablespots WHERE seasonid = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            // Преобразуем строки в даты
            DateTime startDate = DateTime.Parse(this.textBoxStartdate.Text);
            DateTime endDate = DateTime.Parse(this.textBoxEnddate.Text);

            // Явно указываем тип для каждого параметра
            cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlTypes.NpgsqlDbType.Numeric)).Value = Id;
            cmd.Parameters.Add(new NpgsqlParameter("tourid", NpgsqlTypes.NpgsqlDbType.Integer)).Value = Convert.ToInt32(this.textBoxTourid.Text);
            cmd.Parameters.Add(new NpgsqlParameter("startdate", NpgsqlTypes.NpgsqlDbType.Date)).Value = startDate;
            cmd.Parameters.Add(new NpgsqlParameter("enddate", NpgsqlTypes.NpgsqlDbType.Date)).Value = endDate;
            cmd.Parameters.Add(new NpgsqlParameter("isseasonclosed", NpgsqlTypes.NpgsqlDbType.Boolean)).Value = this.checkBoxIsClosed.Checked;
            cmd.Parameters.Add(new NpgsqlParameter("availablespots", NpgsqlTypes.NpgsqlDbType.Integer)).Value = Convert.ToInt32(this.textBoxAvailableSpots.Text);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.textBoxTourid.Text = "";
            this.textBoxStartdate.Text = "";
            this.textBoxEnddate.Text = "";
            this.checkBoxIsClosed.Checked = false;
            this.textBoxAvailableSpots.Text = "";
        }
    }
}
