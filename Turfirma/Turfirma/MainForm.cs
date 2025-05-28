using System;
using System.Data;
using System.Windows.Forms;
using Npgsql; //Áèáëèîòåêà äëÿ ðàáîòû ñ ÁÄ Postgres
using ClosedXML.Excel; // Ïîäêëþ÷àåì êëàññ äëÿ ðàáîòû ñ EXCEL
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace Turfirma
{
    public partial class TurFirma : Form
    {
        //ïîäêëþ÷åíèå ê ÁÄ
        private NpgsqlConnection con;
        private string connString =
        "Host=127.0.0.1;Username=postgres;Password=postpass;Database=Tyr_Firma";
        public TurFirma()
        {
            InitializeComponent();
            con = new NpgsqlConnection(connString);
            con.Open();
            loadTourists(); //Äåëàåì âûáîðêó äàííûõ èç òàáëèöû tourists
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
            //Ôîðìèðóåì çàïðîñ ê ÁÄ (âûáîðêà äàííûõ)
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM Tourists", con);
            adap.Fill(dt);
            //Îòîáðàæàåì äàííûå â dataGridView1
            dataGridViewTourists.DataSource = dt;
        }
        private void loadTouristInfo()
        {
            DataTable dt = new DataTable();
            //Ôîðìèðóåì çàïðîñ ê ÁÄ (âûáîðêà äàííûõ)
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM TouristInfo", con);
            adap.Fill(dt);
            //Îòîáðàæàåì äàííûå â dataGridView1
            dataGridViewTouristInfo.DataSource = dt;
        }
        private void loadTours()
        {
            DataTable dt = new DataTable();
            //Ôîðìèðóåì çàïðîñ ê ÁÄ (âûáîðêà äàííûõ)
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM Tours", con);
            adap.Fill(dt);
            //Îòîáðàæàåì äàííûå â dataGridView1
            dataGridViewTours.DataSource = dt;
        }
        private void loadSeasons()
        {
            DataTable dt = new DataTable();
            //Ôîðìèðóåì çàïðîñ ê ÁÄ (âûáîðêà äàííûõ)
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM Seasons", con);
            adap.Fill(dt);
            //Îòîáðàæàåì äàííûå â dataGridView1
            dataGridViewSeasons.DataSource = dt;
        }
        private void loadBookings()
        {
            DataTable dt = new DataTable();
            //Ôîðìèðóåì çàïðîñ ê ÁÄ (âûáîðêà äàííûõ)
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM Bookings", con);
            adap.Fill(dt);
            //Îòîáðàæàåì äàííûå â dataGridView1
            dataGridViewBookings.DataSource = dt;
        }
        private void loadPayments()
        {
            DataTable dt = new DataTable();
            //Ôîðìèðóåì çàïðîñ ê ÁÄ (âûáîðêà äàííûõ)
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM Payments", con);
            adap.Fill(dt);
            //Îòîáðàæàåì äàííûå â dataGridView1
            dataGridViewPayments.DataSource = dt;
        }

        private void buttonTouristsAdd_Click(object sender, EventArgs e)
        {
            // Ñîçäàåì ýêçåìïëÿð ìîäàëüíîãî îêíà
            ModalFormTouristsAdd modalForm = new ModalFormTouristsAdd(this.con);
            // ëèáî Modal modalForm = new Modal();
            // Îòêðûâàåì ìîäàëüíîå îêíî
            DialogResult result = modalForm.ShowDialog();

            // Îáðàáàòûâàåì ðåçóëüòàò ïîñëå çàêðûòèÿ ìîäàëüíîãî îêíà
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Òóðèñò äîáàâëåí!");
                loadTourists();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Äîáàâëåíèå òóðèñòà îòìåíåíî");
            }
        }

        private void buttonTouristsChange_Click(object sender, EventArgs e)
        {
            // Äîñòà¸ì âûáðàííóþ ñòðîêó äëÿ èçìåíåíèÿ
            DataGridViewRow selectedRow = dataGridViewTourists.SelectedRows[0];

            ModalFormTouristsChange modalForm = new ModalFormTouristsChange(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Òóðèñò èçìåí¸í!");
                loadTourists();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Èçìåíåíèå òóðèñòà îòìåíåíî");
            }
        }

        private void buttonTouristsDelete_Click(object sender, EventArgs e)
        {
            // Äîñòà¸ì âûáðàííóþ ñòðîêó äëÿ èçìåíåíèÿ
            DataGridViewRow selectedRow = dataGridViewTourists.SelectedRows[0];

            ModalFormTouristsDelete modalForm = new ModalFormTouristsDelete(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Òóðèñò óäàë¸í!");
                loadTourists();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Óäàëåíèå òóðèñòà îòìåíåíî");
            }
        }

        private void buttonTouristInfoAdd_Click(object sender, EventArgs e)
        {
            ModalFormTouristInfoAdd modalForm = new ModalFormTouristInfoAdd(this.con);
            DialogResult result = modalForm.ShowDialog();

            // Îáðàáàòûâàåì ðåçóëüòàò ïîñëå çàêðûòèÿ ìîäàëüíîãî îêíà
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Èíôîðìàöèÿ î òóðèñòå äîáàâëåíà!");
                loadTouristInfo();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Äîáàâëåíèå èíôîðìàöèè î òóðèñòå îòìåíåíî");
            }
        }

        private void buttonTouristInfoChange_Click(object sender, EventArgs e)
        {
            // Äîñòà¸ì âûáðàííóþ ñòðîêó äëÿ èçìåíåíèÿ
            DataGridViewRow selectedRow = dataGridViewTouristInfo.SelectedRows[0];

            ModalFormTouristInfoChange modalForm = new ModalFormTouristInfoChange(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            // Îáðàáàòûâàåì ðåçóëüòàò ïîñëå çàêðûòèÿ ìîäàëüíîãî îêíà
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Èíôîðìàöèÿ î òóðèñòå èçìåíåíà!");
                loadTouristInfo();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Èçìåíåíèå èíôîðìàöèè î òóðèñòå îòìåíåíî");
            }
        }

        private void buttonTouristInfoDelete_Click(object sender, EventArgs e)
        {
            // Äîñòà¸ì âûáðàííóþ ñòðîêó äëÿ èçìåíåíèÿ
            DataGridViewRow selectedRow = dataGridViewTouristInfo.SelectedRows[0];

            ModalFormTouristInfoDelete modalForm = new ModalFormTouristInfoDelete(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Èíôîðìàöèÿ î òóðèñòå óäàë¸íà!");
                loadTouristInfo();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Óäàëåíèå èíôîðìàöèè î òóðèñòå îòìåíåíî");
            }
        }

        private void buttonToursAdd_Click(object sender, EventArgs e)
        {
            ModalFormToursAdd modalForm = new ModalFormToursAdd(this.con);
            DialogResult result = modalForm.ShowDialog();

            // Îáðàáàòûâàåì ðåçóëüòàò ïîñëå çàêðûòèÿ ìîäàëüíîãî îêíà
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Èíôîðìàöèÿ î òóðå äîáàâëåíà!");
                loadTours();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Äîáàâëåíèå èíôîðìàöèè î òóðå îòìåíåíî");
            }
        }

        private void buttonToursChange_Click(object sender, EventArgs e)
        {
            // Äîñòà¸ì âûáðàííóþ ñòðîêó äëÿ èçìåíåíèÿ
            DataGridViewRow selectedRow = dataGridViewTours.SelectedRows[0];

            ModalFormToursChange modalForm = new ModalFormToursChange(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            // Îáðàáàòûâàåì ðåçóëüòàò ïîñëå çàêðûòèÿ ìîäàëüíîãî îêíà
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Èíôîðìàöèÿ î òóðå èçìåíåíà!");
                loadTours();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Èçìåíåíèå èíôîðìàöèè î òóðå îòìåíåíî");
            }
        }

        private void buttonToursDelete_Click(object sender, EventArgs e)
        {
            // Äîñòà¸ì âûáðàííóþ ñòðîêó äëÿ èçìåíåíèÿ
            DataGridViewRow selectedRow = dataGridViewTours.SelectedRows[0];

            ModalFormToursDelete modalForm = new ModalFormToursDelete(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Èíôîðìàöèÿ î òóðå óäàë¸íà!");
                loadTours();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Óäàëåíèå èíôîðìàöèè î òóðå îòìåíåíî");
            }
        }

        private void buttonSeasonsAdd_Click(object sender, EventArgs e)
        {
            ModalFormSeasonsAdd modalForm = new ModalFormSeasonsAdd(this.con);
            DialogResult result = modalForm.ShowDialog();

            // Îáðàáàòûâàåì ðåçóëüòàò ïîñëå çàêðûòèÿ ìîäàëüíîãî îêíà
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Èíôîðìàöèÿ î ñåçîíå äîáàâëåíà!");
                loadSeasons();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Äîáàâëåíèå èíôîðìàöèè î ñåçîíå îòìåíåíî");
            }
        }

        private void buttonSeasonsChange_Click(object sender, EventArgs e)
        {
            // Äîñòà¸ì âûáðàííóþ ñòðîêó äëÿ èçìåíåíèÿ
            DataGridViewRow selectedRow = dataGridViewSeasons.SelectedRows[0];

            ModalFormSeasonsChange modalForm = new ModalFormSeasonsChange(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            // Îáðàáàòûâàåì ðåçóëüòàò ïîñëå çàêðûòèÿ ìîäàëüíîãî îêíà
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Èíôîðìàöèÿ î ñåçîíå èçìåíåíà!");
                loadSeasons();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Èçìåíåíèå èíôîðìàöèè î ñåçîíå îòìåíåíî");
            }
        }

        private void buttonSeasonsDelete_Click(object sender, EventArgs e)
        {
            // Äîñòà¸ì âûáðàííóþ ñòðîêó äëÿ èçìåíåíèÿ
            DataGridViewRow selectedRow = dataGridViewSeasons.SelectedRows[0];

            ModalFormSeasonsDelete modalForm = new ModalFormSeasonsDelete(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Èíôîðìàöèÿ î ñåçîíå óäàë¸íà!");
                loadSeasons();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Óäàëåíèå èíôîðìàöèè î ñåçîíå îòìåíåíî");
            }
        }

        private void buttonBookingsAdd_Click(object sender, EventArgs e)
        {
            ModalFormBookingsAdd modalForm = new ModalFormBookingsAdd(this.con);
            DialogResult result = modalForm.ShowDialog();

            // Îáðàáàòûâàåì ðåçóëüòàò ïîñëå çàêðûòèÿ ìîäàëüíîãî îêíà
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Èíôîðìàöèÿ î ïóò¸âêå äîáàâëåíà!");
                loadBookings();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Äîáàâëåíèå èíôîðìàöèè î ïóò¸âêå îòìåíåíî");
            }
        }

        private void buttonBookingsChange_Click(object sender, EventArgs e)
        {
            // Äîñòà¸ì âûáðàííóþ ñòðîêó äëÿ èçìåíåíèÿ
            DataGridViewRow selectedRow = dataGridViewBookings.SelectedRows[0];

            ModalFormBookingsChange modalForm = new ModalFormBookingsChange(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            // Îáðàáàòûâàåì ðåçóëüòàò ïîñëå çàêðûòèÿ ìîäàëüíîãî îêíà
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Èíôîðìàöèÿ î ïóò¸âêå èçìåíåíà!");
                loadBookings();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Èçìåíåíèå èíôîðìàöèè î ïóò¸âêå îòìåíåíî");
            }
        }

        private void buttonBookingsDelete_Click(object sender, EventArgs e)
        {
            // Äîñòà¸ì âûáðàííóþ ñòðîêó äëÿ èçìåíåíèÿ
            DataGridViewRow selectedRow = dataGridViewBookings.SelectedRows[0];

            ModalFormBookingsDelete modalForm = new ModalFormBookingsDelete(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Èíôîðìàöèÿ î ïóò¸âêå óäàë¸íà!");
                loadBookings();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Óäàëåíèå èíôîðìàöèè î ïóò¸âêå îòìåíåíî");
            }
        }

        private void buttonPaymentsAdd_Click(object sender, EventArgs e)
        {
            ModalFormPaymentsAdd modalForm = new ModalFormPaymentsAdd(this.con);
            DialogResult result = modalForm.ShowDialog();

            // Îáðàáàòûâàåì ðåçóëüòàò ïîñëå çàêðûòèÿ ìîäàëüíîãî îêíà
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Èíôîðìàöèÿ îá îïëàòå äîáàâëåíà!");
                loadPayments();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Äîáàâëåíèå èíôîðìàöèè îá îïëàòå îòìåíåíî");
            }
        }

        private void buttonPaymentsChange_Click(object sender, EventArgs e)
        {
            // Äîñòà¸ì âûáðàííóþ ñòðîêó äëÿ èçìåíåíèÿ
            DataGridViewRow selectedRow = dataGridViewPayments.SelectedRows[0];

            ModalFormPaymentsChange modalForm = new ModalFormPaymentsChange(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            // Îáðàáàòûâàåì ðåçóëüòàò ïîñëå çàêðûòèÿ ìîäàëüíîãî îêíà
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Èíôîðìàöèÿ îá îïëàòå èçìåíåíà!");
                loadPayments();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Èçìåíåíèå èíôîðìàöèè îá îïëàòå îòìåíåíî");
            }
        }

        private void buttonPaymentsDelete_Click(object sender, EventArgs e)
        {
            // Äîñòà¸ì âûáðàííóþ ñòðîêó äëÿ èçìåíåíèÿ
            DataGridViewRow selectedRow = dataGridViewPayments.SelectedRows[0];

            ModalFormPaymentsDelete modalForm = new ModalFormPaymentsDelete(this.con, selectedRow);
            DialogResult result = modalForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Èíôîðìàöèÿ îá îïëàòå óäàë¸íà!");
                loadPayments();
            }

            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Óäàëåíèå èíôîðìàöèè îá îïëàòå îòìåíåíî");
            }
        }

        private void buttonRequestsAgregation_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = this.textBoxRequestsAgregation.Text;
                DataTable dt = new DataTable();
                //Ôîðìèðóåì çàïðîñ ê ÁÄ (âûáîðêà äàííûõ)
                NpgsqlDataAdapter adap = new NpgsqlDataAdapter(sql, con);
                adap.Fill(dt);
                //Îòîáðàæàåì äàííûå â dataGridView1
                dataGridViewRequests.DataSource = dt;
            }
            catch (Exception ex)
            {
                string errorText = $"Ïðîèçîøëà îøèáêà! {ex.Message}";
                MessageBox.Show(errorText);
            }
        }

        private void buttonRequestsParameterized_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = this.richTextBoxRequestsParameterized.Text;
                DataTable dt = new DataTable();
                //Ôîðìèðóåì çàïðîñ ê ÁÄ (âûáîðêà äàííûõ)
                NpgsqlDataAdapter adap = new NpgsqlDataAdapter(sql, con);
                adap.Fill(dt);
                //Îòîáðàæàåì äàííûå â dataGridView1
                dataGridViewRequests.DataSource = dt;
            }
            catch (Exception ex)
            {
                string errorText = $"Ïðîèçîøëà îøèáêà! {ex.Message}";
                MessageBox.Show(errorText);
            }
        }

        private void loadRequests()
        {
            comboBoxRequestsAgregation.Items.Add("Ìàêñèìàëüíàÿ öåíà òóðà");
            comboBoxRequestsAgregation.Items.Add("Ñðåäíÿÿ öåíà òóðà");
            comboBoxRequestsAgregation.Items.Add("Êîëè÷åñòâî òóðèñòîâ");
            comboBoxRequestsAgregation.Items.Add("Ñâîé çàïðîñ (íàïèøèòå êîä íèæå)");
            comboBoxRequestsAgregation.SelectedIndex = 3;
            comboBoxRequestsParameterized.Items.Add("Òóðèñòû ñ òóðîì, ñòîÿùèì áîëåå 55000");
            comboBoxRequestsParameterized.Items.Add("Càìûå ïîïóëÿðíûå òóðû (ïî êîë-âó áðîíèðîâàíèé)");
            comboBoxRequestsParameterized.Items.Add("Òóðèñòû, êîòîðûå ïîòðàòèëè áîëüøå âñåãî äåíåã");
            comboBoxRequestsParameterized.Items.Add("Ñâîé çàïðîñ (íàïèøèòå êîä íèæå)");
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
            // Çàïðîñ äëÿ êðóãîâîé äèàãðàììû
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

            // Êðóãîâàÿ äèàãðàììà
            Chart PieChart = new Chart();
            PieChart.Titles.Add("Ïðîöåíò âûêóïà òóðîâ");
            PieChart.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);
            PieChart.Location = new Point(10, 75);
            PieChart.Size = new Size(400, 400);
            tabControl1.TabPages[7].Controls.Add(PieChart);
            PieChart.ChartAreas.Add(new ChartArea());

            Series PieSeries = new Series("PaymentPercentage");
            PieSeries.ChartType = SeriesChartType.Pie;

            // Çàïîëíåíèå äàííûõ
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

            // Íàñòðîéêà ëåãåíäû
            Legend pieLegend = new Legend();
            pieLegend.Docking = Docking.Bottom;
            pieLegend.Alignment = StringAlignment.Center;
            pieLegend.Font = new Font("Arial", 8);
            PieChart.Legends.Add(pieLegend);

            // 3D-ýôôåêò
            PieChart.ChartAreas[0].Area3DStyle.Enable3D = true;
            PieChart.ChartAreas[0].Area3DStyle.Inclination = 60;

            // Çàïðîñ äëÿ ñòîëá÷àòîé äèàãðàììû
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

            // Ñòîëá÷àòàÿ äèàãðàììà
            Chart BarChart = new Chart();
            BarChart.Titles.Add("Ñóììà âûêóïà òóðîâ");
            BarChart.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);
            BarChart.Location = new Point(400, 75);
            BarChart.Size = new Size(400, 400);
            tabControl1.TabPages[7].Controls.Add(BarChart);
            BarChart.ChartAreas.Add(new ChartArea());

            Series BarSeries = new Series("TotalPayments");
            BarSeries.ChartType = SeriesChartType.Column;
            BarSeries.IsValueShownAsLabel = true;
            BarSeries.LabelFormat = "C2"; // Ôîðìàò âàëþòû

            // Çàïîëíåíèå äàííûõ äëÿ ñòîëá÷àòîé äèàãðàììû
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

            // Íàñòðîéêà âíåøíåãî âèäà ñòîëá÷àòîé äèàãðàììû
            BarChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            BarChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8);
            BarChart.ChartAreas[0].AxisY.LabelStyle.Format = "C0";
            BarChart.ChartAreas[0].AxisY.Title = "Ñóììà";
            BarChart.ChartAreas[0].AxisX.Title = "Òóð";
        }

        private void buttonExportExcel_Click(object sender, EventArgs e)
        {

            try
            {
                // Ïðîâåðÿåì, åñòü ëè äàííûå â dataGridView
                if (dataGridViewRequests.Rows.Count == 0)
                {
                    MessageBox.Show("Íåò äàííûõ äëÿ ýêñïîðòà!", "Èíôîðìàöèÿ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Ñîçäàåì äèàëîã ñîõðàíåíèÿ ôàéëà
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Ñîõðàíèòü Excel ôàéë";
                saveFileDialog.FileName = "Ýêñïîðò äàííûõ.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Ñîçäàåì íîâóþ êíèãó Excel
                    using (var workbook = new XLWorkbook())
                    {
                        // Äîáàâëÿåì ëèñò â êíèãó
                        var worksheet = workbook.Worksheets.Add("Ýêñïîðò äàííûõ");

                        // Çàïèñûâàåì çàãîëîâêè ñòîëáöîâ
                        for (int i = 0; i < dataGridViewRequests.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dataGridViewRequests.Columns[i].HeaderText;
                        }

                        // Çàïèñûâàåì äàííûå
                        for (int i = 0; i < dataGridViewRequests.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridViewRequests.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dataGridViewRequests.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        // Àâòîíàñòðîéêà øèðèíû ñòîëáöîâ
                        worksheet.Columns().AdjustToContents();

                        // Ñîõðàíÿåì êíèãó
                        workbook.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Äàííûå óñïåøíî ýêñïîðòèðîâàíû â Excel!", "Óñïåõ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                string errorText = $"Ïðîèçîøëà îøèáêà ïðè ýêñïîðòå â Excel! {ex.Message}";
                MessageBox.Show(errorText, "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Ñîçäàåì äèàëîã îòêðûòèÿ ôàéëà
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                openFileDialog.Title = "Âûáåðèòå Excel ôàéë";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Çàãðóæàåì êíèãó Excel
                    using (var workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        // Ïîëó÷àåì ïåðâûé ëèñò (ìîæíî èçìåíèòü, åñëè íóæíî âûáðàòü êîíêðåòíûé ëèñò)
                        var worksheet = workbook.Worksheet(1);

                        // Ñîçäàåì DataTable äëÿ õðàíåíèÿ äàííûõ
                        DataTable dt = new DataTable();

                        // Îïðåäåëÿåì äèàïàçîí äàííûõ (ìîæíî èñïîëüçîâàòü è äðóãèå ñïîñîáû)
                        var range = worksheet.RangeUsed();
                        if (range == null)
                        {
                            MessageBox.Show("Â âûáðàííîì ôàéëå íåò äàííûõ!", "Èíôîðìàöèÿ",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // ×èòàåì çàãîëîâêè ñòîëáöîâ (ïåðâàÿ ñòðîêà)
                        foreach (var cell in range.Row(1).Cells())
                        {
                            dt.Columns.Add(cell.Value.ToString());
                        }

                        // ×èòàåì äàííûå (íà÷èíàÿ ñî âòîðîé ñòðîêè)
                        for (int row = 2; row <= range.RowCount(); row++)
                        {
                            DataRow dr = dt.NewRow();
                            for (int col = 1; col <= dt.Columns.Count; col++)
                            {
                                dr[col - 1] = worksheet.Cell(row, col).Value.ToString();
                            }
                            dt.Rows.Add(dr);
                        }

                        // Îòîáðàæàåì äàííûå â dataGridView
                        dataGridViewRequests.DataSource = dt;

                        MessageBox.Show("Äàííûå óñïåøíî èìïîðòèðîâàíû èç Excel!", "Óñïåõ",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                string errorText = $"Ïðîèçîøëà îøèáêà ïðè èìïîðòå èç Excel! {ex.Message}";
                MessageBox.Show(errorText, "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonExportXmlWriter_Click(object sender, EventArgs e)
        {
            try
            {
                // Ïðîâåðÿåì, åñòü ëè äàííûå â dataGridView
                if (dataGridViewRequests.Rows.Count == 0)
                {
                    MessageBox.Show("Íåò äàííûõ äëÿ ýêñïîðòà!", "Èíôîðìàöèÿ",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Ñîçäàåì äèàëîã ñîõðàíåíèÿ ôàéëà
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XML Files|*.xml";
                saveFileDialog.Title = "Ñîõðàíèòü XML ôàéë";
                saveFileDialog.FileName = "Ýêñïîðò äàííûõ.xml";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Íàñòðîéêè äëÿ XmlWriter
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;
                    settings.IndentChars = "  ";
                    settings.NewLineChars = "\n";
                    settings.OmitXmlDeclaration = false;

                    // Ñîçäàåì XmlWriter
                    using (XmlWriter writer = XmlWriter.Create(saveFileDialog.FileName, settings))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("Data");

                        // Çàïèñûâàåì çàãîëîâêè ñòîëáöîâ êàê àòðèáóòû
                        writer.WriteStartElement("Columns");
                        foreach (DataGridViewColumn column in dataGridViewRequests.Columns)
                        {
                            writer.WriteElementString("Column", column.HeaderText);
                        }
                        writer.WriteEndElement(); // Columns

                        // Çàïèñûâàåì äàííûå
                        writer.WriteStartElement("Rows");
                        foreach (DataGridViewRow row in dataGridViewRequests.Rows)
                        {
                            if (!row.IsNewRow) // Ïðîïóñêàåì íîâóþ ñòðîêó (åñëè åñòü)
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

                    MessageBox.Show("Äàííûå óñïåøíî ýêñïîðòèðîâàíû â XML!", "Óñïåõ",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string errorText = $"Ïðîèçîøëà îøèáêà ïðè ýêñïîðòå â XML! {ex.Message}";
                MessageBox.Show(errorText, "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonImportXmlReader_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "XML Files|*.xml";
                openFileDialog.Title = "Âûáåðèòå XML ôàéë";

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
                                            // Ñîçäàåì êîëîíêó ïðè ïåðâîì óïîìèíàíèè
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
                                                // Äîáàâëÿåì êîëîíêó, åñëè å¸ åù¸ íåò
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

                    // Ïðîâåðÿåì, åñòü ëè äàííûå
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("XML ôàéë íå ñîäåðæèò äàííûõ èëè èìååò íåïðàâèëüíûé ôîðìàò",
                                      "Èíôîðìàöèÿ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    dataGridViewRequests.DataSource = dt;
                    MessageBox.Show($"Äàííûå óñïåøíî èìïîðòèðîâàíû èç XML!", "Óñïåõ",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ïðîèçîøëà îøèáêà ïðè èìïîðòå èç XML! {ex.Message}", "Îøèáêà",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExportXmlDocument_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewRequests.Rows.Count == 0)
                {
                    MessageBox.Show("Íåò äàííûõ äëÿ ýêñïîðòà!", "Èíôîðìàöèÿ",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XML Files|*.xml";
                saveFileDialog.Title = "Ñîõðàíèòü XML ôàéë";
                saveFileDialog.FileName = "Ýêñïîðò äàííûõ.xml";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    xmlDoc.AppendChild(xmlDeclaration);

                    XmlElement rootElement = xmlDoc.CreateElement("Data");
                    xmlDoc.AppendChild(rootElement);

                    // Ýêñïîðò çàãîëîâêîâ
                    XmlElement columnsElement = xmlDoc.CreateElement("Columns");
                    foreach (DataGridViewColumn column in dataGridViewRequests.Columns)
                    {
                        XmlElement columnElement = xmlDoc.CreateElement("Column");
                        columnElement.InnerText = column.HeaderText;
                        columnsElement.AppendChild(columnElement);
                    }
                    rootElement.AppendChild(columnsElement);

                    // Ýêñïîðò äàííûõ
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
                    MessageBox.Show($"Äàííûå óñïåøíî ýêñïîðòèðîâàíû â XML!", "Óñïåõ",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ïðîèçîøëà îøèáêà ïðè ýêñïîðòå â XML! {ex.Message}", "Îøèáêà",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonImportXmlDocument_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "XML Files|*.xml";
                openFileDialog.Title = "Âûáåðèòå XML ôàéë";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = new DataTable();
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(openFileDialog.FileName);

                    // Çàãðóçêà ñòðóêòóðû êîëîíîê
                    XmlNodeList columnNodes = xmlDoc.SelectNodes("/Data/Columns/Column");
                    foreach (XmlNode columnNode in columnNodes)
                    {
                        if (!dt.Columns.Contains(columnNode.InnerText))
                        {
                            dt.Columns.Add(columnNode.InnerText);
                        }
                    }

                    // Çàãðóçêà äàííûõ
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
                        MessageBox.Show("XML ôàéë íå ñîäåðæèò äàííûõ èëè èìååò íåïðàâèëüíûé ôîðìàò",
                                      "Èíôîðìàöèÿ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    dataGridViewRequests.DataSource = dt;
                    MessageBox.Show($"Äàííûå óñïåøíî èìïîðòèðîâàíû èç XML!", "Óñïåõ",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ïðîèçîøëà îøèáêà ïðè èìïîðòå èç XML! {ex.Message}", "Îøèáêà",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTrigger_Click(object sender, EventArgs e)
        {
            try
            {
                // Âñòàâëÿåì òåñòîâóþ çàïèñü â òàáëèöó Tourists
                string insertQuery = "INSERT INTO Tourists (LastName, FirstName, MiddleName) " +
                                    "VALUES ('Òåñòîâûé', 'Êëèåíò', 'Òðèããåðîâè÷') RETURNING TouristID";

                using (NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, con))
                {
                    // Âûïîëíÿåì çàïðîñ è ïîëó÷àåì ID íîâîãî òóðèñòà
                    int testTouristId = (int)cmd.ExecuteScalar();

                    // Ïåðåêëþ÷àåìñÿ íà âêëàäêó "Ïóò¸âêè" (TabPage[4])
                    tabControl1.SelectedIndex = 4;

                    // Îáíîâëÿåì òàáëèöû
                    loadTourists();
                    loadBookings();

                    MessageBox.Show($"Òðèããåð ñðàáîòàë óñïåøíî! Äîáàâëåíû íîâûé òóðèñò (id = {testTouristId}) è ñîîòâåòñòâóþùàÿ ïóò¸âêà.",
                          "Óñïåõ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Îøèáêà ïðè âûïîëíåíèè òðèããåðà: " + ex.Message,
                              "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
