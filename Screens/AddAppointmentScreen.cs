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
    public partial class AddAppointmentScreen : Form
    {
        // Properties ------------------------------------------------------------------------------------------------------
        public mainScreen mainScreen;
        public bool validCustomer = true;
        public bool validAppointmentName = false;
        public bool validType = false;
        public bool validStartTime = false;
        public bool validEndTime = false;
        public TimeSpan businessOpenTime = new TimeSpan(08, 0, 0);
        public TimeSpan businessCloseTime = new TimeSpan(17, 0, 0);


        // Constructors ----------------------------------------------------------------------------------------------------
        public AddAppointmentScreen(mainScreen mainScreen)
        {
            this.mainScreen = mainScreen;
            InitializeComponent();

            using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
            {
                Connections.mySqlCommand.CommandText = "SELECT * FROM U07wVX.customer;";
                Connections.mySqlCommand.Connection = DatabaseConnection;
                DatabaseConnection.Open();
                DataTable customerTable = new DataTable();
                customerTable.Load(Connections.mySqlCommand.ExecuteReader());
                customerComboBox.DataSource = customerTable;
                customerComboBox.DisplayMember = "customerName";
                customerComboBox.ValueMember = "customerId";

            }
        }

        public AddAppointmentScreen()
        {
            InitializeComponent();

            using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
            {
                Connections.mySqlCommand.CommandText = "SELECT * FROM U07wVX.customer;";
                Connections.mySqlCommand.Connection = DatabaseConnection;
                DatabaseConnection.Open();
                DataTable customerTable = new DataTable();
                customerTable.Load(Connections.mySqlCommand.ExecuteReader());
                customerComboBox.DataSource = customerTable;
                customerComboBox.DisplayMember = "customerName";
                customerComboBox.ValueMember = "customerId";

            }
        }

        // Events & Methods ---------------------------------------------------------------------------------------------------
        public bool allowSave(bool validCustomer, bool validAppointmentName, bool validType, bool validStartTime, bool validEndTime)
        {
            return (validCustomer &&
                validAppointmentName &&
                validType &&
                validStartTime &&
                validEndTime);
        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = allowSave(validCustomer, validAppointmentName, validType, validStartTime, validEndTime);
        }

        private void appointmentNameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(appointmentNameTextbox.Text))
            {
                appointmentNameTextbox.BackColor = Color.Salmon;
                validAppointmentName = false;
            }
            else
            {
                appointmentNameTextbox.BackColor = Color.White;
                validAppointmentName = true;
            }

            saveButton.Enabled = saveButton.Enabled = allowSave(validCustomer, validAppointmentName, validType, validStartTime, validEndTime);
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            validType = true;
            saveButton.Enabled = saveButton.Enabled = allowSave(validCustomer, validAppointmentName, validType, validStartTime, validEndTime);
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan startTime = startDateTimePicker.Value.TimeOfDay;

            if ((TimeSpan.Compare(startTime, businessOpenTime) < 0) || (TimeSpan.Compare(startTime, businessCloseTime) > 0))
            {
                MessageBox.Show("Start time is outside of business hours (8 AM - 5 PM). Please choose new start time.", "Outside Business Hours");
                validStartTime = false;
            }
            else
            {
                validStartTime = true;
            }

            saveButton.Enabled = allowSave(validCustomer, validAppointmentName, validType, validStartTime, validEndTime);
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan endTime = endDateTimePicker.Value.TimeOfDay;

            if ((TimeSpan.Compare(endTime, businessOpenTime) < 0) || (TimeSpan.Compare(endTime, businessCloseTime) > 0))
            {
                MessageBox.Show("End time is outside of business hours (8 AM - 5 PM). Please choose new end time.", "Outside Business Hours");
                validEndTime = false;
            }
            else
            {
                validEndTime = true;
            }

            saveButton.Enabled = allowSave(validCustomer, validAppointmentName, validType, validStartTime, validEndTime);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DateTime appointmentStart = TimeZoneInfo.ConvertTimeToUtc(startDateTimePicker.Value, TimeZoneInfo.Local);
            DateTime appointmentEnd = TimeZoneInfo.ConvertTimeToUtc(endDateTimePicker.Value, TimeZoneInfo.Local);

            if (DateTime.Compare(appointmentStart, appointmentEnd) > 0)
            {
                MessageBox.Show("End time cannot be prior to start time. Please choose later end time.", "Invalid Start/End Times");
            }
            else
            {
                try
                {
                    using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
                    {
                        Connections.mySqlCommand.CommandText = "SELECT COUNT(appointmentId) " +
                            "FROM U07wVX.appointment " +
                            "WHERE (start <= '" + appointmentStart.ToString("yyyy-MM-dd HH:mm:00") + "' " +
                            "AND end >= '" + appointmentStart.ToString("yyyy-MM-dd HH:mm:00") + "') " +
                            "OR (start <= '" + appointmentEnd.ToString("yyyy-MM-dd HH:mm:00") + "' " +
                            " AND end >= '" + appointmentEnd.ToString("yyyy-MM-dd HH:mm:00") + "');";
                        Connections.mySqlCommand.Connection = DatabaseConnection;
                        DatabaseConnection.Open();
                        int conflict = Convert.ToInt32(Connections.mySqlCommand.ExecuteScalar());

                        if (conflict != 0)
                        {
                            MessageBox.Show("The requested appointment conflicts with an existing appointment. Please choose a new appointment window.", "Appointment Conflict");
                        }
                        else
                        {
                            Connections.mySqlCommand.CommandText = "INSERT INTO U07wVX.appointment (customerId, userId, title, description, location, contact, type, " +
                                "url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                                // Customer ID
                                "VALUES (" + customerComboBox.SelectedValue + ", " +
                                // User ID
                                "1, " +
                                // Title
                                "'" + appointmentNameTextbox.Text + "', " +
                                // Description
                                "'not needed', " +
                                // Location
                                "'not needed', " +
                                // Contact
                                "'not needed', " +
                                // Type 
                                "'" + typeComboBox.Text + "', " +
                                // URL
                                "'not needed', " +
                                // Start 
                                "'" + appointmentStart.ToString("yyyy-MM-dd HH:mm:00") + "', " +
                                // End 
                                "'" + appointmentEnd.ToString("yyyy-MM-dd HH:mm:00") + "', " +
                                // Created Date 
                                "CURRENT_DATE(), " +
                                // Created By 
                                "'test', " +
                                // Last Update 
                                "CURRENT_DATE(), " +
                                // Last Update By
                                "'test');";
                            Connections.mySqlCommand.ExecuteNonQuery();

                            mainScreen.appointmentsTable.Clear();
                            Connections.mySqlCommand.CommandText = "SELECT appointmentId, title, type, customerId, start, end, createDate, createdBy, lastUpdate, lastUpdateBy FROM U07wVX.appointment;";
                            mainScreen.appointmentsTable.Load(Connections.mySqlCommand.ExecuteReader());

                            for (int index = 0; index < mainScreen.appointmentsTable.Rows.Count; index++)
                            {
                                mainScreen.appointmentsTable.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)mainScreen.appointmentsTable.Rows[index]["start"], TimeZoneInfo.Local).ToString();
                                mainScreen.appointmentsTable.Rows[index]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)mainScreen.appointmentsTable.Rows[index]["end"], TimeZoneInfo.Local).ToString();
                            }

                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error");
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpScreen helpScreen = new HelpScreen(this);
            helpScreen.ShowDialog();
        }
    }
}
