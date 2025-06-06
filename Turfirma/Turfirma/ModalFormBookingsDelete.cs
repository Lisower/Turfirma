﻿using Npgsql;

namespace Turfirma
{
    public partial class ModalFormBookingsDelete : Form
    {
        // Подключение к БД
        private NpgsqlConnection con;
        // Первая выбранная строка
        private DataGridViewRow selectedRow;
        public ModalFormBookingsDelete(NpgsqlConnection con, DataGridViewRow selectedRow)
        {
            InitializeComponent();
            this.con = con;
            this.selectedRow = selectedRow;

            // Получаем данные из выбранной строки
            string bookingid = selectedRow.Cells["bookingid"].Value.ToString();
            string touristid = selectedRow.Cells["touristid"].Value.ToString();
            string seasonid = selectedRow.Cells["seasonid"].Value.ToString();

            this.labelDown.Text = bookingid + ":  " + touristid + "  " + seasonid + "?";
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(selectedRow.Cells["bookingid"].Value);

            string sql = "DELETE FROM Bookings WHERE bookingid = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            // Явно указываем тип для каждого параметра
            cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlTypes.NpgsqlDbType.Numeric)).Value = Id;

            cmd.Prepare();

            cmd.ExecuteNonQuery();
            this.labelDown.Text = "";
        }
    }
}
