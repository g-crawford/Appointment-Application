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
    public partial class mainScreen : Form

    // CAPSTONE COMMENT: Throughout this program, inheritance is demonstrated by the use of WinForms. Each Screen in the Screen folder inherits from the Form base class.

    {
        // Properties -------------------------------------------------------------------------------------------------------
        public loginScreen loginScreen;
        public static DataTable customersTable = new DataTable();
        public static DataTable appointmentsTable = new DataTable();
        public DateTime currentDate = DateTime.Now;
        public DateTime userLoginTime = DateTime.Now;
        public static int currentSelectedCustomerIndex { get; set; }
        public static int currentSelectedCustomerID { get; set; }
        public static int currentSelectedCustomerAddressID { get; set; }
        public static int currentSelectedAppointmentIndex { get; set; }
        public static int currentSelectedAppointmentID { get; set; }
        

        // Constructors ------------------------------------------------------------------------------------------------------
        public mainScreen()
        {
            InitializeComponent();
            try
            {
                using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
                {
                    Connections.mySqlCommand.CommandText = "SELECT customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy FROM U07wVX.customer;";
                    Connections.mySqlCommand.Connection = DatabaseConnection;
                    DatabaseConnection.Open();
                    customersTable.Load(Connections.mySqlCommand.ExecuteReader());
                    customersDataGridView.DataSource = customersTable;

                    Connections.mySqlCommand.CommandText = "SELECT appointmentId, title, type, customerId, start, end, createDate, createdBy, lastUpdate, lastUpdateBy FROM U07wVX.appointment;";
                    appointmentsTable.Load(Connections.mySqlCommand.ExecuteReader());
                    appointmentsDataGridView.DataSource = appointmentsTable;

                    for (int index = 0; index < appointmentsTable.Rows.Count; index++)
                    {
                        appointmentsTable.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)appointmentsTable.Rows[index]["start"], TimeZoneInfo.Local).ToString();
                        appointmentsTable.Rows[index]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)appointmentsTable.Rows[index]["end"], TimeZoneInfo.Local).ToString();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }


            foreach (DataGridViewRow appointment in appointmentsDataGridView.Rows)
            {
                DateTime appointmentStart = (DateTime)appointment.Cells[3].Value;
                TimeSpan timeRemaining = userLoginTime - appointmentStart;

                if (timeRemaining.TotalMinutes >= -15 && timeRemaining.TotalMinutes <= 1)
                {
                    MessageBox.Show($"Reminder: You have an upcoming {appointment.Cells[1].Value} appointment starting {appointment.Cells[3].Value}.", "Appointment Reminder");
                }
            }
        }

        public mainScreen(loginScreen loginScreen)
        {
            this.loginScreen = loginScreen;
            InitializeComponent();
            try
            {
                using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
                {
                    Connections.mySqlCommand.CommandText = "SELECT customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy FROM U07wVX.customer;";
                    Connections.mySqlCommand.Connection = DatabaseConnection;
                    DatabaseConnection.Open();
                    customersTable.Load(Connections.mySqlCommand.ExecuteReader());
                    customersDataGridView.DataSource = customersTable;

                    Connections.mySqlCommand.CommandText = "SELECT appointmentId, title, type, customerId, start, end, createDate, createdBy, lastUpdate, lastUpdateBy FROM U07wVX.appointment;";
                    appointmentsTable.Load(Connections.mySqlCommand.ExecuteReader());
                    appointmentsDataGridView.DataSource = appointmentsTable;

                    for (int index = 0; index < appointmentsTable.Rows.Count; index++)
                    {
                        appointmentsTable.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)appointmentsTable.Rows[index]["start"], TimeZoneInfo.Local).ToString();
                        appointmentsTable.Rows[index]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)appointmentsTable.Rows[index]["end"], TimeZoneInfo.Local).ToString();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }


            foreach (DataGridViewRow appointment in appointmentsDataGridView.Rows)
            {
                DateTime appointmentStart = (DateTime)appointment.Cells[3].Value;
                TimeSpan timeRemaining = userLoginTime - appointmentStart;

                if (timeRemaining.TotalMinutes >= -15 && timeRemaining.TotalMinutes <= 1)
                {
                    MessageBox.Show($"Reminder: You have an upcoming {appointment.Cells[1].Value} appointment starting {appointment.Cells[3].Value}.", "Appointment Reminder");
                }
            }
        }

        // Events & Methods ---------------------------------------------------------------------------------------------------

        // Lambda #1 --------- By adding this Lambda, we increase the code's readability and scalability. Execution time for this action becomes slightly faster.
        Action moveToAddCustomerScreen = () => { AddCustomerScreen addCustomerScreen = new AddCustomerScreen(); addCustomerScreen.ShowDialog(); };

        // Lambda #2 --------- Like the above, the addition of this lambda is to make the code more readable and scalable, as well as increases executionm speed.
        Action moveToAddAppointmentScreen = () => { AddAppointmentScreen addAppointmentScreen = new AddAppointmentScreen(); addAppointmentScreen.ShowDialog(); };

        // Lambda #3 --------- Although not required, it serves the same purpose as the above. 
        Action moveToReportScreen = () => { ReportScreen reportScreen = new ReportScreen(); reportScreen.ShowDialog(); };

        // CAPSTONE COMMENT: Here, we define the methods to be encapsulated

        public void loadAllTime()
        {
            try
            {
                using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
                {
                    appointmentsTable.Clear();
                    Connections.mySqlCommand.CommandText = "SELECT appointmentId, title, type, customerId, start, end, createDate, createdBy, lastUpdate, lastUpdateBy FROM U07wVX.appointment;";
                    Connections.mySqlCommand.Connection = DatabaseConnection;
                    DatabaseConnection.Open();
                    appointmentsTable.Load(Connections.mySqlCommand.ExecuteReader());

                    for (int index = 0; index < appointmentsTable.Rows.Count; index++)
                    {
                        appointmentsTable.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)appointmentsTable.Rows[index]["start"], TimeZoneInfo.Local).ToString();
                        appointmentsTable.Rows[index]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)appointmentsTable.Rows[index]["end"], TimeZoneInfo.Local).ToString();
                    }
                    appointmentsDataGridView.DataSource = appointmentsTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        public void loadByMonth()
        {
            appointmentsTable.Clear();
            int selectedMonth = currentDate.Month;
            int selectedYear = currentDate.Year;

            try
            {
                using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
                {
                    appointmentsTable.Clear();
                    Connections.mySqlCommand.CommandText = "SELECT appointmentId, title, type, customerId, start, end, createDate, createdBy, lastUpdate, lastUpdateBy FROM U07wVX.appointment " +
                        "WHERE MONTH(start) = " + selectedMonth + " " +
                        "AND YEAR(start) = " + selectedYear;
                    Connections.mySqlCommand.Connection = DatabaseConnection;
                    DatabaseConnection.Open();
                    appointmentsTable.Load(Connections.mySqlCommand.ExecuteReader());

                    for (int index = 0; index < appointmentsTable.Rows.Count; index++)
                    {
                        appointmentsTable.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)appointmentsTable.Rows[index]["start"], TimeZoneInfo.Local).ToString();
                        appointmentsTable.Rows[index]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)appointmentsTable.Rows[index]["end"], TimeZoneInfo.Local).ToString();
                    }
                    appointmentsDataGridView.DataSource = appointmentsTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        public void loadByWeek()
        {
            appointmentsTable.Clear();
            int dayOfWeek = (int)currentDate.DayOfWeek;
            string startDate = currentDate.AddDays(-dayOfWeek).ToString("yyyy-MM-dd");
            string endDate = currentDate.AddDays(7 - dayOfWeek).ToString("yyyy-MM-dd");

            try
            {
                using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
                {
                    appointmentsTable.Clear();
                    Connections.mySqlCommand.CommandText = "SELECT appointmentId, title, type, customerId, start, end, createDate, createdBy, lastUpdate, lastUpdateBy FROM U07wVX.appointment " +
                        "WHERE start BETWEEN '" + startDate + "' " +
                        "AND '" + endDate + "';";
                    Connections.mySqlCommand.Connection = DatabaseConnection;
                    DatabaseConnection.Open();
                    appointmentsTable.Load(Connections.mySqlCommand.ExecuteReader());

                    for (int index = 0; index < appointmentsTable.Rows.Count; index++)
                    {
                        appointmentsTable.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)appointmentsTable.Rows[index]["start"], TimeZoneInfo.Local).ToString();
                        appointmentsTable.Rows[index]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)appointmentsTable.Rows[index]["end"], TimeZoneInfo.Local).ToString();
                    }
                    appointmentsDataGridView.DataSource = appointmentsTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }

        private void customersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentSelectedCustomerIndex = customersDataGridView.CurrentCell.RowIndex;
            currentSelectedCustomerID = (int)customersTable.Rows[currentSelectedCustomerIndex][0];
            currentSelectedCustomerAddressID = (int)customersTable.Rows[currentSelectedCustomerIndex][2];
        }

        private void appointmentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentSelectedAppointmentIndex = appointmentsDataGridView.CurrentCell.RowIndex;
            currentSelectedAppointmentID = (int)appointmentsTable.Rows[currentSelectedAppointmentIndex][0];
        }

        // CAPSTONE COMMENT: Here, we use use encapsulation to shorten the code executed below for ease of readability 

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            currentDate = e.Start;

            if (allTimeRadioButton.Checked == true)
            {
                loadAllTime();
            }
            else if (byMonthRadioButton.Checked == true)
            {
                loadByMonth();
            }
            else if (byWeekRadioButton.Checked == true)
            {
                loadByWeek();
            }
        }

        private void allTimeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            loadAllTime();
        }

        private void byMonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            loadByMonth();
        }

        private void byWeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            loadByWeek();
        }

        private void appointmentAddButton_Click(object sender, EventArgs e)
        {
            allTimeRadioButton.Checked = true;
            moveToAddAppointmentScreen();
        }

        private void appointmentEditButton_Click(object sender, EventArgs e)
        {
            allTimeRadioButton.Checked = true;
            ModifyAppointmentScreen modifyAppointmentScreen = new ModifyAppointmentScreen(this);
            modifyAppointmentScreen.ShowDialog();
        }

        private void appointmentDeleteButton_Click(object sender, EventArgs e)
        {
                var result = MessageBox.Show("Are you sure you want to delete this appointment? This cannot be undone.", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
                {
                    try
                    {
                        Connections.mySqlCommand.CommandText = "DELETE FROM appointment " +
                            "WHERE appointmentId = " + currentSelectedAppointmentID + ";";
                        Connections.mySqlCommand.Connection = DatabaseConnection;
                        DatabaseConnection.Open();
                        Connections.mySqlCommand.ExecuteNonQuery();

                        appointmentsTable.Clear();
                        Connections.mySqlCommand.CommandText = "SELECT appointmentId, title, type, customerId, start, end, createDate, createdBy, lastUpdate, lastUpdateBy FROM U07wVX.appointment;";
                        appointmentsTable.Load(Connections.mySqlCommand.ExecuteReader());

                        for (int index = 0; index < mainScreen.appointmentsTable.Rows.Count; index++)
                        {
                            mainScreen.appointmentsTable.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)mainScreen.appointmentsTable.Rows[index]["start"], TimeZoneInfo.Local).ToString();
                            mainScreen.appointmentsTable.Rows[index]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)mainScreen.appointmentsTable.Rows[index]["end"], TimeZoneInfo.Local).ToString();
                        }

                        allTimeRadioButton.Checked = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error");
                    }
                }
            }
            else
            {
                // Do nothing
            }
        }

        private void customerAddButton_Click(object sender, EventArgs e)
        {
            moveToAddCustomerScreen();
        }

        private void customerEditButton_Click(object sender, EventArgs e)
        {
             ModifyCustomerScreen modifyCustomerScreen = new ModifyCustomerScreen(this);
             modifyCustomerScreen.Show();
             this.Hide();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            moveToReportScreen();
        }

        private void customerDeleteButton_Click(object sender, EventArgs e)
        {
            if (currentSelectedCustomerIndex == 0)
            {
                MessageBox.Show("No customer selected. Please select customer.", "No Customer Selected");
            }
            else
            {
                var result = MessageBox.Show("Are you sure you want to delete this customer? This cannot be undone.", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
                    {
                        try
                        {
                            Connections.mySqlCommand.CommandText = "DELETE FROM customer " +
                                "WHERE customerId = " + currentSelectedCustomerID + ";";
                            Connections.mySqlCommand.Connection = DatabaseConnection;
                            DatabaseConnection.Open();
                            Connections.mySqlCommand.ExecuteNonQuery();
                            Connections.mySqlCommand.CommandText = "DELETE FROM address " +
                                "WHERE addressId = " + currentSelectedCustomerAddressID + ";";
                            Connections.mySqlCommand.ExecuteNonQuery();

                            customersTable.Clear();
                            Connections.mySqlCommand.CommandText = "SELECT customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy FROM U07wVX.customer;";
                            customersTable.Load(Connections.mySqlCommand.ExecuteReader());
                            customersDataGridView.DataSource = customersTable;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error");
                        }
                    }
                }
                else
                {
                    // Do nothing
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            appointmentsDataGridView.ClearSelection();
            bool found = false;
            if (searchTextbox.Text == "")
            {
                MessageBox.Show("No Appointment name was input. Please input an appointment name to search.", "Appointment Name Not Entered");
            }
            else
            {
                for (int i = 0; i < appointmentsTable.Rows.Count; i++)
                {
                    if (appointmentsTable.Rows[i]["title"].ToString().ToUpper().Contains(searchTextbox.Text.ToUpper()))
                    {
                        appointmentsDataGridView.Rows[i].Selected = true;
                        found = true;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("No appointment with matching name was found.", "No Appointment Found");
                }
            }
        }
    }
}