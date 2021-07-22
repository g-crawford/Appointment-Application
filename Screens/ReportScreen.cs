using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace C969___Scheduler_App
{
    public partial class ReportScreen : Form
    {
        // Properties -------------------------------------------------------------------------------------------------------
        public DataTable appointmentReportResults = new DataTable();
        public DataTable consultantReportResults = new DataTable();
        public DataTable customerReportResults = new DataTable();

        // Constructors ------------------------------------------------------------------------------------------------------
        public ReportScreen()
        {
            InitializeComponent();
            monthsComboBox.Hide();
            reportResultsDataGridView.DataSource = consultantReportResults;
            consultantsComboBox.SelectedIndex = 0;

            try
            {
                using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
                {
                    Connections.mySqlCommand.CommandText = "SELECT appointmentId, " +
                        "customerId, " +
                        "title, " +
                        "start, " +
                        "end " +
                        "FROM U07wVX.appointment " +
                        "WHERE userId = 1;";
                    Connections.mySqlCommand.Connection = DatabaseConnection;
                    DatabaseConnection.Open();
                    consultantReportResults.Load(Connections.mySqlCommand.ExecuteReader());
                    generatedLabel.Visible = true;
                    timeStampLabel.Visible = true;
                    timeStampLabel.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }


        // Events & Methods ---------------------------------------------------------------------------------------------------
        private void appointmentsReportRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            monthsComboBox.Show();
            consultantsComboBox.Hide();
            monthsComboBox.SelectedIndex = 0;
            reportResultsDataGridView.DataSource = appointmentReportResults;
            timeStampLabel.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }

        private void consultantReportRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            monthsComboBox.Hide();
            consultantsComboBox.Show();
            consultantsComboBox.SelectedIndex = 0;
            reportResultsDataGridView.DataSource = consultantReportResults;

            try
            {
                using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
                {
                    consultantReportResults.Clear();
                    Connections.mySqlCommand.CommandText = "SELECT appointmentId, " +
                        "customerId, " +
                        "title, " +
                        "start, " +
                        "end " +
                        "FROM U07wVX.appointment " +
                        "WHERE userId = 1;";
                    Connections.mySqlCommand.Connection = DatabaseConnection;
                    DatabaseConnection.Open();
                    consultantReportResults.Load(Connections.mySqlCommand.ExecuteReader());
                    timeStampLabel.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }

        private void customersReportRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            monthsComboBox.Hide();
            consultantsComboBox.Hide();
            reportResultsDataGridView.DataSource = customerReportResults;

            try
            {
                using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
                {
                    customerReportResults.Clear();
                    Connections.mySqlCommand.CommandText = "SELECT CASE WHEN active = 1 THEN 'Active' " +
                        "ELSE 'Inactive' " +
                        "END AS Status, COUNT(customerId) AS '# of Customers' " +
                        "FROM U07wVX.customer " +
                        "GROUP BY active;";
                    Connections.mySqlCommand.Connection = DatabaseConnection;
                    DatabaseConnection.Open();
                    customerReportResults.Load(Connections.mySqlCommand.ExecuteReader());
                    timeStampLabel.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void monthsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMonth = (monthsComboBox.SelectedIndex + 1);

            try
            {
                using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
                {
                    appointmentReportResults.Clear();
                    Connections.mySqlCommand.CommandText = "SELECT type, COUNT(appointmentId) AS '# of Appts' " +
                        "FROM U07wVX.appointment " +
                        "WHERE MONTH(start) = " + selectedMonth + " " +
                        "GROUP BY type;";
                    Connections.mySqlCommand.Connection = DatabaseConnection;
                    DatabaseConnection.Open();
                    appointmentReportResults.Load(Connections.mySqlCommand.ExecuteReader());
                    timeStampLabel.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
