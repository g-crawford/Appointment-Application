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
    public partial class AddCustomerScreen : Form
    {
        // Properties ------------------------------------------------------------------------------------------------------
        public mainScreen mainScreen;
        public bool validName = false;
        public bool validAddress1 = false;
        public bool validCity = false;
        public bool validCountry = false;
        public bool validPostalCode = false;
        public bool validPhoneNumber = false;


        // Constructors ----------------------------------------------------------------------------------------------------
        public AddCustomerScreen(mainScreen mainScreen)
        {
            this.mainScreen = mainScreen;
            InitializeComponent();

            // Load list of countries
            using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
            {
                Connections.mySqlCommand.CommandText = "SELECT * FROM U07wVX.country;";
                Connections.mySqlCommand.Connection = DatabaseConnection;
                DatabaseConnection.Open();
                DataTable countryTable = new DataTable();
                countryTable.Load(Connections.mySqlCommand.ExecuteReader());
                countryComboBox.DataSource = countryTable;
                countryComboBox.DisplayMember = "country";
                countryComboBox.ValueMember = "countryId";
            }
        }

        public AddCustomerScreen()
        {
            InitializeComponent();

            // Load list of countries
            using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
            {
                Connections.mySqlCommand.CommandText = "SELECT * FROM U07wVX.country;";
                Connections.mySqlCommand.Connection = DatabaseConnection;
                DatabaseConnection.Open();
                DataTable countryTable = new DataTable();
                countryTable.Load(Connections.mySqlCommand.ExecuteReader());
                countryComboBox.DataSource = countryTable;
                countryComboBox.DisplayMember = "country";
                countryComboBox.ValueMember = "countryId";
            }
        }


        // Events & Methods ---------------------------------------------------------------------------------------------------
        public bool allowSave(bool validName, bool validAddress1, bool validCity, bool validCountry, bool validPostalCode, bool validPhoneNumber)
        {
            return (validName &&
                validAddress1 &&
                validCity &&
                validCountry &&
                validPostalCode &&
                validPhoneNumber);
        }

        private void nameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextbox.Text))
            {
                nameTextbox.BackColor = Color.Salmon;
                validName = false;
            }
            else
            {
                nameTextbox.BackColor = Color.White;
                validName = true;
            }

            saveButton.Enabled = allowSave(validName, validAddress1, validCity, validCountry, validPostalCode, validPhoneNumber);
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
            {
                DataTable cityTable = new DataTable();

                switch (countryComboBox.SelectedIndex)
                {
                    case 0:
                        Connections.mySqlCommand.CommandText = "SELECT * FROM U07wVX.city WHERE countryId = 1;";
                        Connections.mySqlCommand.Connection = DatabaseConnection;
                        DatabaseConnection.Open();
                        cityTable.Load(Connections.mySqlCommand.ExecuteReader());
                        cityComboBox.DataSource = cityTable;
                        cityComboBox.DisplayMember = "city";
                        cityComboBox.ValueMember = "cityId";
                        break;

                    case 1:
                        Connections.mySqlCommand.CommandText = "SELECT * FROM U07wVX.city WHERE countryId = 2;";
                        Connections.mySqlCommand.Connection = DatabaseConnection;
                        DatabaseConnection.Open();
                        cityTable.Load(Connections.mySqlCommand.ExecuteReader());
                        cityComboBox.DataSource = cityTable;
                        cityComboBox.DisplayMember = "city";
                        cityComboBox.ValueMember = "cityId";
                        break;

                    case 2:
                        Connections.mySqlCommand.CommandText = "SELECT * FROM U07wVX.city WHERE countryId = 3;";
                        Connections.mySqlCommand.Connection = DatabaseConnection;
                        DatabaseConnection.Open();
                        cityTable.Load(Connections.mySqlCommand.ExecuteReader());
                        cityComboBox.DataSource = cityTable;
                        cityComboBox.DisplayMember = "city";
                        cityComboBox.ValueMember = "cityID";
                        break;
                }
            }
            countryComboBox.BackColor = Color.White;
            validCountry = true;

            saveButton.Enabled = allowSave(validName, validAddress1, validCity, validCountry, validPostalCode, validPhoneNumber);
        }

        private void address1Textbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(address1Textbox.Text))
            {
                address1Textbox.BackColor = Color.Salmon;
                validAddress1 = false;
            }
            else
            {
                address1Textbox.BackColor = Color.White;
                validAddress1 = true;
            }

            saveButton.Enabled = allowSave(validName, validAddress1, validCity, validCountry, validPostalCode, validPhoneNumber);
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityComboBox.BackColor = Color.White;
            validCity = true;

            saveButton.Enabled = allowSave(validName, validAddress1, validCity, validCountry, validPostalCode, validPhoneNumber);
        }

        private void postalCodeTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(postalCodeTextbox.Text))
            {
                postalCodeTextbox.BackColor = Color.Salmon;
                validPostalCode = false;
            }
            else
            {
                postalCodeTextbox.BackColor = Color.White;
                validPostalCode = true;
            }

            saveButton.Enabled = allowSave(validName, validAddress1, validCity, validCountry, validPostalCode, validPhoneNumber);
        }

        private void phoneNumberTextbox_TextChanged(object sender, EventArgs e)
        {
            long i;

            if (!long.TryParse(phoneNumberTextbox.Text, out i))
            {
                MessageBox.Show("Phone number may not include special characters and must be numbers only. Please remove special characters.", "Invalid Characters");
                phoneNumberTextbox.BackColor = Color.Salmon;
                validPhoneNumber = false;
            }
            else if (string.IsNullOrWhiteSpace(phoneNumberTextbox.Text))
            {
                phoneNumberTextbox.BackColor = Color.Salmon;
                validPhoneNumber = false;
            }
            else
            {
                phoneNumberTextbox.BackColor = Color.White;
                validPhoneNumber = true;
            }

            saveButton.Enabled = allowSave(validName, validAddress1, validCity, validCountry, validPostalCode, validPhoneNumber);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // First, create the new address -----------------------------------------------------------------------
            // Address properties --------------------------------
            string customerAddress1 = address1Textbox.Text;
            string customerAddress2;
            if (address2Textbox.Text != null)
            {
                customerAddress2 = address2Textbox.Text;
            }
            else
            {
                customerAddress2 = "";
            }
            int customerCityID = (int)cityComboBox.SelectedValue;
            string customerPostalCode = postalCodeTextbox.Text;
            string customerPhoneNumber = phoneNumberTextbox.Text;
            string addressCreatedBy = "test";
            string addressLastUpdateBy = "test";

            //Then, insert address into MySQL table --------------
            using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
            {
                try
                {
                    Connections.mySqlCommand.CommandText = "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                        "VALUES ('"
                        + customerAddress1 + "', '"
                        + customerAddress2 + "', "
                        + customerCityID + ", "
                        + customerPostalCode + ", "
                        + customerPhoneNumber + ", " +
                        "CURRENT_DATE(), '"
                        + addressCreatedBy + "', " +
                        "CURRENT_DATE(), '"
                        + addressLastUpdateBy + "');";
                    Connections.mySqlCommand.Connection = DatabaseConnection;
                    DatabaseConnection.Open();
                    Connections.mySqlCommand.ExecuteNonQuery();

                    // Now, create the Customer ------------------------------------------
                    Connections.mySqlCommand.CommandText = "SELECT @@IDENTITY;";
                    int newAddressID = Convert.ToInt32(Connections.mySqlCommand.ExecuteScalar());
                    string customerName = nameTextbox.Text;
                    string customerStatus = "0";
                    if (activeButton.Checked)
                    {
                        customerStatus = "1";
                    }
                    else if (inactiveButton.Checked)
                    {
                        customerStatus = "0";
                    }
                    string customerCreatedBy = "test";
                    string customerLastUpdatedBy = "test";

                    Connections.mySqlCommand.CommandText = "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                        "VALUES ('"
                        + customerName + "', "
                        + newAddressID + ", "
                        + customerStatus + ", "
                        + "CURRENT_DATE(), '"
                        + customerCreatedBy + "', "
                        + "CURRENT_DATE(), '"
                        + customerLastUpdatedBy + "');";
                    Connections.mySqlCommand.ExecuteNonQuery();

                    Connections.mySqlCommand.CommandText = "SELECT customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy FROM U07wVX.customer;";
                    Connections.mySqlCommand.Connection = DatabaseConnection;
                    mainScreen.customersTable.Load(Connections.mySqlCommand.ExecuteReader());

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error");
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
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
