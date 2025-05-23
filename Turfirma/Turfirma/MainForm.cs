using System;
using System.Data;
using System.Windows.Forms;
using Npgsql; //Библиотека для работы с БД Postgres
using ClosedXML.Excel; // Подключаем класс для работы с EXCEL
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace Turfirma
{
    public partial class TurFirma : Form
    {
        //подключение к БД
        private NpgsqlConnection con;
        private string connString =
        "Host=127.0.0.1;Username=postgres;Password=postpass;Database=Tyr_Firma";
        // "Host=127.0.0.1;Username=postgres;Password=Poisk2004;Database=Turfirma";
        public TurFirma()
        {
            InitializeComponent();
            con = new NpgsqlConnection(connString);
            con.Open();
            loadTourists(); //Делаем выборку данных из таблицы tourists
            loadTouristInfo();
            loadTours();
            loadSeasons();
            loadBookings();
            loadPayments();
            loadRequests();
            loadDiagrams();
        }
        private void loadTourists()
        {
            DataTable dt = new DataTable();
            //Формируем запрос к БД (выборка данных)
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM Tourists", con);
            adap.Fill(dt);
            //Отображаем данные в dataGridView1
            dataGridViewTourists.DataSource = dt;
        }
        private void loadTouristInfo()
        {
            DataTable dt = new DataTable();
            //Формируем запрос к БД (выборка данных)
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM TouristInfo", con);
            adap.Fill(dt);
            //Отображаем данные в dataGridView1
            dataGridViewTouristInfo.DataSource = dt;
        }
        private void loadTours()
        {
            DataTable dt = new DataTable();
            //Формируем запрос к БД (выборка данных)
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM Tours", con);
            adap.Fill(dt);
            //Отображаем данные в dataGridView1
            dataGridViewTours.DataSource = dt;
        }
        private void loadSeasons()
        {
            DataTable dt = new DataTable();
            //Формируем запрос к БД (выборка данных)
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM Seasons", con);
            adap.Fill(dt);
            //Отображаем данные в dataGridView1
            dataGridViewSeasons.DataSource = dt;
        }
        private void loadBookings()
        {
            DataTable dt = new DataTable();
            //Формируем запрос к БД (выборка данных)
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM Bookings", con);
            adap.Fill(dt);
            //Отображаем данные в dataGridView1
            dataGridViewBookings.DataSource = dt;
        }
        private void loadPayments()
        {
            DataTable dt = new DataTable();
            //Формируем запрос к БД (выборка данных)
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM Payments", con);
            adap.Fill(dt);
            //Отображаем данные в dataGridView1
            dataGridViewPayments.DataSource = dt;
        }

        private void buttonTouristsAdd_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр модального окна
            ModalFormTouristsAdd modalForm = new ModalFormTouristsAdd(this.con);
            // либо Modal modalForm = new Modal();
            // Открываем модальное окно
            DialogResult result = modalForm.ShowDialog();

            // Обрабатываем результат после закрытия модального окна
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Турист добавлен!");
                loadTourists();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Добавление туриста отменено");
            }
        }

        private void buttonTouristsChange_Click(object sender, EventArgs e)
        {
            // Достаём выбранную строку для изменения
            DataGridViewRow selectedRow = dataGridViewTourists.SelectedRows[0];

            ModalFormTouristsChange modalForm = new ModalFormTouristsChange(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Турист изменён!");
                loadTourists();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Изменение туриста отменено");
            }
        }

        private void buttonTouristsDelete_Click(object sender, EventArgs e)
        {
            // Достаём выбранную строку для изменения
            DataGridViewRow selectedRow = dataGridViewTourists.SelectedRows[0];

            ModalFormTouristsDelete modalForm = new ModalFormTouristsDelete(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Турист удалён!");
                loadTourists();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Удаление туриста отменено");
            }
        }

        private void buttonTouristInfoAdd_Click(object sender, EventArgs e)
        {
            ModalFormTouristInfoAdd modalForm = new ModalFormTouristInfoAdd(this.con);
            DialogResult result = modalForm.ShowDialog();

            // Обрабатываем результат после закрытия модального окна
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Информация о туристе добавлена!");
                loadTouristInfo();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Добавление информации о туристе отменено");
            }
        }

        private void buttonTouristInfoChange_Click(object sender, EventArgs e)
        {
            // Достаём выбранную строку для изменения
            DataGridViewRow selectedRow = dataGridViewTouristInfo.SelectedRows[0];

            ModalFormTouristInfoChange modalForm = new ModalFormTouristInfoChange(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            // Обрабатываем результат после закрытия модального окна
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Информация о туристе изменена!");
                loadTouristInfo();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Изменение информации о туристе отменено");
            }
        }

        private void buttonTouristInfoDelete_Click(object sender, EventArgs e)
        {
            // Достаём выбранную строку для изменения
            DataGridViewRow selectedRow = dataGridViewTouristInfo.SelectedRows[0];

            ModalFormTouristInfoDelete modalForm = new ModalFormTouristInfoDelete(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Информация о туристе удалёна!");
                loadTouristInfo();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Удаление информации о туристе отменено");
            }
        }

        private void buttonToursAdd_Click(object sender, EventArgs e)
        {
            ModalFormToursAdd modalForm = new ModalFormToursAdd(this.con);
            DialogResult result = modalForm.ShowDialog();

            // Обрабатываем результат после закрытия модального окна
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Информация о туре добавлена!");
                loadTours();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Добавление информации о туре отменено");
            }
        }

        private void buttonToursChange_Click(object sender, EventArgs e)
        {
            // Достаём выбранную строку для изменения
            DataGridViewRow selectedRow = dataGridViewTours.SelectedRows[0];

            ModalFormToursChange modalForm = new ModalFormToursChange(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            // Обрабатываем результат после закрытия модального окна
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Информация о туре изменена!");
                loadTours();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Изменение информации о туре отменено");
            }
        }

        private void buttonToursDelete_Click(object sender, EventArgs e)
        {
            // Достаём выбранную строку для изменения
            DataGridViewRow selectedRow = dataGridViewTours.SelectedRows[0];

            ModalFormToursDelete modalForm = new ModalFormToursDelete(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Информация о туре удалёна!");
                loadTours();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Удаление информации о туре отменено");
            }
        }

        private void buttonSeasonsAdd_Click(object sender, EventArgs e)
        {
            ModalFormSeasonsAdd modalForm = new ModalFormSeasonsAdd(this.con);
            DialogResult result = modalForm.ShowDialog();

            // Обрабатываем результат после закрытия модального окна
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Информация о сезоне добавлена!");
                loadSeasons();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Добавление информации о сезоне отменено");
            }
        }

        private void buttonSeasonsChange_Click(object sender, EventArgs e)
        {
            // Достаём выбранную строку для изменения
            DataGridViewRow selectedRow = dataGridViewSeasons.SelectedRows[0];

            ModalFormSeasonsChange modalForm = new ModalFormSeasonsChange(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            // Обрабатываем результат после закрытия модального окна
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Информация о сезоне изменена!");
                loadSeasons();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Изменение информации о сезоне отменено");
            }
        }

        private void buttonSeasonsDelete_Click(object sender, EventArgs e)
        {
            // Достаём выбранную строку для изменения
            DataGridViewRow selectedRow = dataGridViewSeasons.SelectedRows[0];

            ModalFormSeasonsDelete modalForm = new ModalFormSeasonsDelete(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Информация о сезоне удалёна!");
                loadSeasons();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Удаление информации о сезоне отменено");
            }
        }

        private void buttonBookingsAdd_Click(object sender, EventArgs e)
        {
            ModalFormBookingsAdd modalForm = new ModalFormBookingsAdd(this.con);
            DialogResult result = modalForm.ShowDialog();

            // Обрабатываем результат после закрытия модального окна
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Информация о путёвке добавлена!");
                loadBookings();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Добавление информации о путёвке отменено");
            }
        }

        private void buttonBookingsChange_Click(object sender, EventArgs e)
        {
            // Достаём выбранную строку для изменения
            DataGridViewRow selectedRow = dataGridViewBookings.SelectedRows[0];

            ModalFormBookingsChange modalForm = new ModalFormBookingsChange(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            // Обрабатываем результат после закрытия модального окна
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Информация о путёвке изменена!");
                loadBookings();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Изменение информации о путёвке отменено");
            }
        }

        private void buttonBookingsDelete_Click(object sender, EventArgs e)
        {
            // Достаём выбранную строку для изменения
            DataGridViewRow selectedRow = dataGridViewBookings.SelectedRows[0];

            ModalFormBookingsDelete modalForm = new ModalFormBookingsDelete(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Информация о путёвке удалёна!");
                loadBookings();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Удаление информации о путёвке отменено");
            }
        }

        private void buttonPaymentsAdd_Click(object sender, EventArgs e)
        {
            ModalFormPaymentsAdd modalForm = new ModalFormPaymentsAdd(this.con);
            DialogResult result = modalForm.ShowDialog();

            // Обрабатываем результат после закрытия модального окна
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Информация об оплате добавлена!");
                loadPayments();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Добавление информации об оплате отменено");
            }
        }

        private void buttonPaymentsChange_Click(object sender, EventArgs e)
        {
            // Достаём выбранную строку для изменения
            DataGridViewRow selectedRow = dataGridViewPayments.SelectedRows[0];

            ModalFormPaymentsChange modalForm = new ModalFormPaymentsChange(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            // Обрабатываем результат после закрытия модального окна
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Информация об оплате изменена!");
                loadPayments();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Изменение информации об оплате отменено");
            }
        }

        private void buttonPaymentsDelete_Click(object sender, EventArgs e)
        {
            // Достаём выбранную строку для изменения
            DataGridViewRow selectedRow = dataGridViewPayments.SelectedRows[0];

            ModalFormPaymentsDelete modalForm = new ModalFormPaymentsDelete(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Информация об оплате удалёна!");
                loadPayments();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Удаление информации об оплате отменено");
            }
        }

        private void buttonRequestsAgregation_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = this.textBoxRequestsAgregation.Text;
                DataTable dt = new DataTable();
                //Формируем запрос к БД (выборка данных)
                NpgsqlDataAdapter adap = new NpgsqlDataAdapter(sql, con);
                adap.Fill(dt);
                //Отображаем данные в dataGridView1
                dataGridViewRequests.DataSource = dt;
            }
            catch (Exception ex)
            {
                string errorText = $"Произошла ошибка! {ex.Message}";
                MessageBox.Show(errorText);
            }
        }

        private void buttonRequestsParameterized_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = this.richTextBoxRequestsParameterized.Text;
                DataTable dt = new DataTable();
                //Формируем запрос к БД (выборка данных)
                NpgsqlDataAdapter adap = new NpgsqlDataAdapter(sql, con);
                adap.Fill(dt);
                //Отображаем данные в dataGridView1
                dataGridViewRequests.DataSource = dt;
            }
            catch (Exception ex)
            {
                string errorText = $"Произошла ошибка! {ex.Message}";
                MessageBox.Show(errorText);
            }
        }

        private void loadRequests()
        {
            comboBoxRequestsAgregation.Items.Add("Максимальная цена тура");
            comboBoxRequestsAgregation.Items.Add("Средняя цена тура");
            comboBoxRequestsAgregation.Items.Add("Количество туристов");
            comboBoxRequestsAgregation.Items.Add("Свой запрос (напишите код ниже)");
            comboBoxRequestsAgregation.SelectedIndex = 3;
            comboBoxRequestsParameterized.Items.Add("Туристы с туром, стоящим более 55000");
            comboBoxRequestsParameterized.Items.Add("Cамые популярные туры (по кол-ву бронирований)");
            comboBoxRequestsParameterized.Items.Add("Туристы, которые потратили больше всего денег");
            comboBoxRequestsParameterized.Items.Add("Свой запрос (напишите код ниже)");
            comboBoxRequestsParameterized.SelectedIndex = 3;
        }

        private void comboBoxRequestsAgregation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRequestsAgregation.SelectedIndex == 0)
            {
                textBoxRequestsAgregation.Text = "SELECT MAX(price) AS MaxPrice FROM Tours;";
            }
            if (comboBoxRequestsAgregation.SelectedIndex == 1)
            {
                textBoxRequestsAgregation.Text = "SELECT ROUND(AVG(price::numeric),2) AS AvgPrice FROM Tours;";
            }
            if (comboBoxRequestsAgregation.SelectedIndex == 2)
            {
                textBoxRequestsAgregation.Text = "SELECT COUNT(*) AS CountTourists FROM Tourists;";
            }
            if (comboBoxRequestsAgregation.SelectedIndex == 3)
            {
                textBoxRequestsAgregation.Text = "";
            }
        }

        private void comboBoxRequestsParameterized_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRequestsParameterized.SelectedIndex == 0)
            {
                richTextBoxRequestsParameterized.Text = $"SELECT lastname, firstname, middlename, price\n" +
                    $"FROM Tourists\n" +
                    $"JOIN Bookings ON Tourists.touristid = Bookings.touristid\n" +
                    $"JOIN Seasons ON Seasons.seasonid = Bookings.seasonid\n" +
                    $"JOIN Tours ON Tours.tourid = Seasons.tourid\n" +
                    $"WHERE Tours.price::numeric > 55000";
            }
            if (comboBoxRequestsParameterized.SelectedIndex == 1)
            {
                richTextBoxRequestsParameterized.Text = $"SELECT t.tourname, COUNT(b.bookingid) AS bookings_count,\n" +
                    $"SUM(p.amount::numeric) AS total_revenue\n" +
                    $"FROM tours t\n" +
                    $"JOIN seasons s ON t.tourid = s.tourid\n" +
                    $"JOIN bookings b ON s.seasonid = b.seasonid\n" +
                    $"JOIN payments p ON b.bookingid = p.bookingid\n" +
                    $"GROUP BY t.tourname\n" +
                    $"ORDER BY bookings_count DESC;";
            }
            if (comboBoxRequestsParameterized.SelectedIndex == 2)
            {
                richTextBoxRequestsParameterized.Text = "SELECT tr.lastname, tr.firstname,\n" +
                    $"SUM(p.amount::numeric) AS total_spent,\n" +
                    $"COUNT(DISTINCT t.tourid) AS tours_count\n" +
                    $"FROM tourists tr\n" +
                    $"JOIN bookings b ON tr.touristid = b.touristid\n" +
                    $"JOIN seasons s ON b.seasonid = s.seasonid\n" +
                    $"JOIN tours t ON s.tourid = t.tourid\n" +
                    $"JOIN payments p ON b.bookingid = p.bookingid\n" +
                    $"GROUP BY tr.touristid, tr.lastname, tr.firstname\n" +
                    $"ORDER BY total_spent DESC\n" +
                    $"LIMIT 10;";
            }
            if (comboBoxRequestsParameterized.SelectedIndex == 3)
            {
                richTextBoxRequestsParameterized.Text = "";
            }
        }
        private void loadDiagrams()
        {
            // Запрос для круговой диаграммы
            string sqlPie = "SELECT " +
                "t.tourname, " +
                "ROUND(COUNT(p.paymentid) * 100.0 / NULLIF(COUNT(b.bookingid), 0), 2) AS payment_percentage " +
                "FROM " +
                "tours t " +
                "LEFT JOIN " +
                "seasons s ON t.tourid = s.tourid " +
                "LEFT JOIN " +
                "bookings b ON s.seasonid = b.seasonid " +
                "LEFT JOIN " +
                "payments p ON b.bookingid = p.bookingid " +
                "GROUP BY " +
                "t.tourname " +
                "HAVING COUNT(b.bookingid) > 0 " +
                "ORDER BY " +
                "payment_percentage DESC;";

            // Круговая диаграмма
            Chart PieChart = new Chart();
            PieChart.Titles.Add("Процент выкупа туров");
            PieChart.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);
            PieChart.Location = new Point(10, 75);
            PieChart.Size = new Size(400, 400);
            tabControl1.TabPages[7].Controls.Add(PieChart);
            PieChart.ChartAreas.Add(new ChartArea());

            Series PieSeries = new Series("PaymentPercentage");
            PieSeries.ChartType = SeriesChartType.Pie;

            // Заполнение данных
            using (NpgsqlCommand cmdPie = new NpgsqlCommand(sqlPie, this.con))
            {
                using (NpgsqlDataReader reader = cmdPie.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tourName = reader["tourname"].ToString();
                        double percentage = Convert.ToDouble(reader["payment_percentage"]);
                        PieSeries.Points.AddXY(tourName, percentage);
                    }
                }
            }

            PieSeries.Label = "#PERCENT{P0}";
            PieSeries.LegendText = "#VALX";
            PieSeries.Font = new Font("Arial", 8);
            PieChart.Series.Add(PieSeries);

            // Настройка легенды
            Legend pieLegend = new Legend();
            pieLegend.Docking = Docking.Bottom;
            pieLegend.Alignment = StringAlignment.Center;
            pieLegend.Font = new Font("Arial", 8);
            PieChart.Legends.Add(pieLegend);

            // 3D-эффект
            PieChart.ChartAreas[0].Area3DStyle.Enable3D = true;
            PieChart.ChartAreas[0].Area3DStyle.Inclination = 60;

            // Запрос для столбчатой диаграммы
            string sqlBar = "SELECT " +
                "t.tourname, " +
                "COALESCE(SUM(p.amount::numeric), 0) AS total_payments " +
                "FROM " +
                "tours t " +
                "LEFT JOIN " +
                "seasons s ON t.tourid = s.tourid " +
                "LEFT JOIN " +
                "bookings b ON s.seasonid = b.seasonid " +
                "LEFT JOIN " +
                "payments p ON b.bookingid = p.bookingid " +
                "GROUP BY " +
                "t.tourname " +
                "ORDER BY " +
                "total_payments DESC;";

            // Столбчатая диаграмма
            Chart BarChart = new Chart();
            BarChart.Titles.Add("Сумма выкупа туров");
            BarChart.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);
            BarChart.Location = new Point(400, 75);
            BarChart.Size = new Size(400, 400);
            tabControl1.TabPages[7].Controls.Add(BarChart);
            BarChart.ChartAreas.Add(new ChartArea());

            Series BarSeries = new Series("TotalPayments");
            BarSeries.ChartType = SeriesChartType.Column;
            BarSeries.IsValueShownAsLabel = true;
            BarSeries.LabelFormat = "C2"; // Формат валюты

            // Заполнение данных для столбчатой диаграммы
            using (NpgsqlCommand cmdBar = new NpgsqlCommand(sqlBar, this.con))
            {
                using (NpgsqlDataReader reader = cmdBar.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tourName = reader["tourname"].ToString();
                        decimal total = Convert.ToDecimal(reader["total_payments"]);
                        BarSeries.Points.AddXY(tourName, total);
                    }
                }
            }

            BarChart.Series.Add(BarSeries);
            BarChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            // Настройка внешнего вида столбчатой диаграммы
            BarChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            BarChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8);
            BarChart.ChartAreas[0].AxisY.LabelStyle.Format = "C0";
            BarChart.ChartAreas[0].AxisY.Title = "Сумма";
            BarChart.ChartAreas[0].AxisX.Title = "Тур";
        }

        private void buttonExportExcel_Click(object sender, EventArgs e)
        {

            try
            {
                // Проверяем, есть ли данные в dataGridView
                if (dataGridViewRequests.Rows.Count == 0)
                {
                    MessageBox.Show("Нет данных для экспорта!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Создаем диалог сохранения файла
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Сохранить Excel файл";
                saveFileDialog.FileName = "Экспорт данных.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Создаем новую книгу Excel
                    using (var workbook = new XLWorkbook())
                    {
                        // Добавляем лист в книгу
                        var worksheet = workbook.Worksheets.Add("Экспорт данных");

                        // Записываем заголовки столбцов
                        for (int i = 0; i < dataGridViewRequests.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dataGridViewRequests.Columns[i].HeaderText;
                        }

                        // Записываем данные
                        for (int i = 0; i < dataGridViewRequests.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridViewRequests.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dataGridViewRequests.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        // Автонастройка ширины столбцов
                        worksheet.Columns().AdjustToContents();

                        // Сохраняем книгу
                        workbook.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Данные успешно экспортированы в Excel!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                string errorText = $"Произошла ошибка при экспорте в Excel! {ex.Message}";
                MessageBox.Show(errorText, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем диалог открытия файла
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                openFileDialog.Title = "Выберите Excel файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Загружаем книгу Excel
                    using (var workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        // Получаем первый лист (можно изменить, если нужно выбрать конкретный лист)
                        var worksheet = workbook.Worksheet(1);

                        // Создаем DataTable для хранения данных
                        DataTable dt = new DataTable();

                        // Определяем диапазон данных (можно использовать и другие способы)
                        var range = worksheet.RangeUsed();
                        if (range == null)
                        {
                            MessageBox.Show("В выбранном файле нет данных!", "Информация",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // Читаем заголовки столбцов (первая строка)
                        foreach (var cell in range.Row(1).Cells())
                        {
                            dt.Columns.Add(cell.Value.ToString());
                        }

                        // Читаем данные (начиная со второй строки)
                        for (int row = 2; row <= range.RowCount(); row++)
                        {
                            DataRow dr = dt.NewRow();
                            for (int col = 1; col <= dt.Columns.Count; col++)
                            {
                                dr[col - 1] = worksheet.Cell(row, col).Value.ToString();
                            }
                            dt.Rows.Add(dr);
                        }

                        // Отображаем данные в dataGridView
                        dataGridViewRequests.DataSource = dt;

                        MessageBox.Show("Данные успешно импортированы из Excel!", "Успех",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                string errorText = $"Произошла ошибка при импорте из Excel! {ex.Message}";
                MessageBox.Show(errorText, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonExportXmlWriter_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, есть ли данные в dataGridView
                if (dataGridViewRequests.Rows.Count == 0)
                {
                    MessageBox.Show("Нет данных для экспорта!", "Информация",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Создаем диалог сохранения файла
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XML Files|*.xml";
                saveFileDialog.Title = "Сохранить XML файл";
                saveFileDialog.FileName = "Экспорт данных.xml";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Настройки для XmlWriter
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;
                    settings.IndentChars = "  ";
                    settings.NewLineChars = "\n";
                    settings.OmitXmlDeclaration = false;

                    // Создаем XmlWriter
                    using (XmlWriter writer = XmlWriter.Create(saveFileDialog.FileName, settings))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("Data");

                        // Записываем заголовки столбцов как атрибуты
                        writer.WriteStartElement("Columns");
                        foreach (DataGridViewColumn column in dataGridViewRequests.Columns)
                        {
                            writer.WriteElementString("Column", column.HeaderText);
                        }
                        writer.WriteEndElement(); // Columns

                        // Записываем данные
                        writer.WriteStartElement("Rows");
                        foreach (DataGridViewRow row in dataGridViewRequests.Rows)
                        {
                            if (!row.IsNewRow) // Пропускаем новую строку (если есть)
                            {
                                writer.WriteStartElement("Row");
                                for (int i = 0; i < dataGridViewRequests.Columns.Count; i++)
                                {
                                    writer.WriteStartElement("Cell");
                                    writer.WriteAttributeString("Column", dataGridViewRequests.Columns[i].HeaderText);
                                    writer.WriteString(row.Cells[i].Value?.ToString() ?? string.Empty);
                                    writer.WriteEndElement(); // Cell
                                }
                                writer.WriteEndElement(); // Row
                            }
                        }
                        writer.WriteEndElement(); // Rows

                        writer.WriteEndElement(); // Data
                        writer.WriteEndDocument();
                    }

                    MessageBox.Show("Данные успешно экспортированы в XML!", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string errorText = $"Произошла ошибка при экспорте в XML! {ex.Message}";
                MessageBox.Show(errorText, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonImportXmlReader_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "XML Files|*.xml";
                openFileDialog.Title = "Выберите XML файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = new DataTable();
                    bool isInsideRow = false;
                    DataRow currentRow = null;

                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.IgnoreWhitespace = true;
                    settings.IgnoreComments = true;

                    using (XmlReader reader = XmlReader.Create(openFileDialog.FileName, settings))
                    {
                        while (reader.Read())
                        {
                            if (reader.NodeType == XmlNodeType.Element)
                            {
                                switch (reader.Name)
                                {
                                    case "Column":
                                        if (reader.Read())
                                        {
                                            // Создаем колонку при первом упоминании
                                            if (!dt.Columns.Contains(reader.Value))
                                            {
                                                dt.Columns.Add(reader.Value);
                                            }
                                        }
                                        break;

                                    case "Row":
                                        isInsideRow = true;
                                        currentRow = dt.NewRow();
                                        break;

                                    case "Cell":
                                        if (isInsideRow && currentRow != null)
                                        {
                                            string columnName = reader.GetAttribute("Column");
                                            if (reader.Read())
                                            {
                                                // Добавляем колонку, если её ещё нет
                                                if (!dt.Columns.Contains(columnName))
                                                {
                                                    dt.Columns.Add(columnName);
                                                }

                                                currentRow[columnName] = reader.Value;
                                            }
                                        }
                                        break;
                                }
                            }
                            else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Row")
                            {
                                if (currentRow != null)
                                {
                                    dt.Rows.Add(currentRow);
                                    currentRow = null;
                                }
                                isInsideRow = false;
                            }
                        }
                    }

                    // Проверяем, есть ли данные
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("XML файл не содержит данных или имеет неправильный формат",
                                      "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    dataGridViewRequests.DataSource = dt;
                    MessageBox.Show($"Данные успешно импортированы из XML!", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при импорте из XML! {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExportXmlDocument_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewRequests.Rows.Count == 0)
                {
                    MessageBox.Show("Нет данных для экспорта!", "Информация",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XML Files|*.xml";
                saveFileDialog.Title = "Сохранить XML файл";
                saveFileDialog.FileName = "Экспорт данных.xml";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    xmlDoc.AppendChild(xmlDeclaration);

                    XmlElement rootElement = xmlDoc.CreateElement("Data");
                    xmlDoc.AppendChild(rootElement);

                    // Экспорт заголовков
                    XmlElement columnsElement = xmlDoc.CreateElement("Columns");
                    foreach (DataGridViewColumn column in dataGridViewRequests.Columns)
                    {
                        XmlElement columnElement = xmlDoc.CreateElement("Column");
                        columnElement.InnerText = column.HeaderText;
                        columnsElement.AppendChild(columnElement);
                    }
                    rootElement.AppendChild(columnsElement);

                    // Экспорт данных
                    XmlElement rowsElement = xmlDoc.CreateElement("Rows");
                    foreach (DataGridViewRow row in dataGridViewRequests.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            XmlElement rowElement = xmlDoc.CreateElement("Row");
                            for (int i = 0; i < dataGridViewRequests.Columns.Count; i++)
                            {
                                XmlElement cellElement = xmlDoc.CreateElement("Cell");
                                cellElement.SetAttribute("Column", dataGridViewRequests.Columns[i].HeaderText);
                                cellElement.InnerText = row.Cells[i].Value?.ToString() ?? string.Empty;
                                rowElement.AppendChild(cellElement);
                            }
                            rowsElement.AppendChild(rowElement);
                        }
                    }
                    rootElement.AppendChild(rowsElement);

                    xmlDoc.Save(saveFileDialog.FileName);
                    MessageBox.Show($"Данные успешно экспортированы в XML!", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при экспорте в XML! {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonImportXmlDocument_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "XML Files|*.xml";
                openFileDialog.Title = "Выберите XML файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = new DataTable();
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(openFileDialog.FileName);

                    // Загрузка структуры колонок
                    XmlNodeList columnNodes = xmlDoc.SelectNodes("/Data/Columns/Column");
                    foreach (XmlNode columnNode in columnNodes)
                    {
                        if (!dt.Columns.Contains(columnNode.InnerText))
                        {
                            dt.Columns.Add(columnNode.InnerText);
                        }
                    }

                    // Загрузка данных
                    XmlNodeList rowNodes = xmlDoc.SelectNodes("/Data/Rows/Row");
                    foreach (XmlNode rowNode in rowNodes)
                    {
                        DataRow dr = dt.NewRow();
                        foreach (XmlNode cellNode in rowNode.SelectNodes("Cell"))
                        {
                            string columnName = cellNode.Attributes["Column"].Value;
                            if (!dt.Columns.Contains(columnName))
                            {
                                dt.Columns.Add(columnName);
                            }
                            dr[columnName] = cellNode.InnerText;
                        }
                        dt.Rows.Add(dr);
                    }

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("XML файл не содержит данных или имеет неправильный формат",
                                      "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    dataGridViewRequests.DataSource = dt;
                    MessageBox.Show($"Данные успешно импортированы из XML!", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при импорте из XML! {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTrigger_Click(object sender, EventArgs e)
        {
            try
            {
                // Вставляем тестовую запись в таблицу Tourists
                string insertQuery = "INSERT INTO Tourists (LastName, FirstName, MiddleName) " +
                                    "VALUES ('Тестовый', 'Клиент', 'Триггерович') RETURNING TouristID";

                using (NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, con))
                {
                    // Выполняем запрос и получаем ID нового туриста
                    int testTouristId = (int)cmd.ExecuteScalar();

                    // Переключаемся на вкладку "Путёвки" (TabPage[4])
                    tabControl1.SelectedIndex = 4;

                    // Обновляем таблицы
                    loadTourists();
                    loadBookings();

                    MessageBox.Show($"Триггер сработал успешно! Добавлены новый турист (id = {testTouristId}) и соответствующая путёвка.",
                          "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении триггера: " + ex.Message,
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}