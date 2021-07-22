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
    public partial class ModifyCustomerScreen : Form
    {
        // Properties ------------------------------------------------------------------------------------------------------
        public mainScreen mainScreen;
        public bool validName = false;
        public bool validAddress1 = false;
        public bool validCity = false;
        public bool validCountry = false;
        public bool validPostalCode = false;
        public bool validPhoneNumber = false;

        public int customerAddressID;
        public int customerCityID;
        public int customerCountryID;
        public string customerAddress1;
        public string customerAddress2;
        public string customerPostalCode;
        public string customerPhoneNumber;
        public int customerStatus;
        public int customerID;

        // Constructors ----------------------------------------------------------------------------------------------------
        public ModifyCustomerScreen(mainScreen mainScreen)
        {
            this.mainScreen = mainScreen;
            InitializeComponent();

            customerID = (int)mainScreen.customersTable.Rows[mainScreen.currentSelectedCustomerIndex][0];
            nameTextbox.Text = mainScreen.customersTable.Rows[mainScreen.currentSelectedCustomerIndex][1].ToString();
            customerAddressID = (int)mainScreen.customersTable.Rows[mainScreen.currentSelectedCustomerIndex][2];

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

                Connections.mySqlCommand.CommandText = "SELECT * FROM U07wVX.city;";
                Connections.mySqlCommand.Connection = DatabaseConnection;
                DataTable cityTable = new DataTable();
                cityTable.Load(Connections.mySqlCommand.ExecuteReader());
                cityComboBox.DataSource = cityTable;
                cityComboBox.DisplayMember = "city";
                cityComboBox.ValueMember = "cityId";

                Connections.mySqlCommand.CommandText = "SELECT address, address2, cityId, postalCode, Phone FROM U07wVX.address WHERE addressId = " + customerAddressID + ";";
                Connections.mySqlCommand.Connection = DatabaseConnection;
                DataTable customerAddressInfo = new DataTable();
                customerAddressInfo.Load(Connections.mySqlCommand.ExecuteReader());
                customerAddress1 = customerAddressInfo.Rows[0][0].ToString();
                customerAddress2 = customerAddressInfo.Rows[0][1].ToString();
                customerCityID = Convert.ToInt32(customerAddressInfo.Rows[0][2]);
                customerPostalCode = customerAddressInfo.Rows[0][3].ToString();
                customerPhoneNumber = customerAddressInfo.Rows[0][4].ToString();

                Connections.mySqlCommand.CommandText = "SELECT countryId FROM U07wVX.city WHERE cityId = " + customerCityID + ";";
                Connections.mySqlCommand.Connection = DatabaseConnection;
                customerCountryID = (int)Connections.mySqlCommand.ExecuteScalar();
            }

            countryComboBox.SelectedValue = customerCountryID;
            cityComboBox.SelectedValue = customerCityID;
            address1Textbox.Text = customerAddress1;
            address2Textbox.Text = customerAddress2;
            postalCodeTextbox.Text = customerPostalCode;
            phoneNumberTextbox.Text = customerPhoneNumber;

            if (mainScreen.customersTable.Rows[mainScreen.currentSelectedCustomerIndex][3].ToString() == "True")
            {
                activeButton.Checked = true;
            }
            else
            {
                inactiveButton.Checked = true;
            }

        }

        public ModifyCustomerScreen()
        {
            InitializeComponent();
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
                        break;

                    case 1:
                        Connections.mySqlCommand.CommandText = "SELECT * FROM U07wVX.city WHERE countryId = 2;";
                        Connections.mySqlCommand.Connection = DatabaseConnection;
                        DatabaseConnection.Open();
                        cityTable.Load(Connections.mySqlCommand.ExecuteReader());
                        cityComboBox.DataSource = cityTable;
                        cityComboBox.DisplayMember = "city";
                        break;

                    case 2:
                        Connections.mySqlCommand.CommandText = "SELECT * FROM U07wVX.city WHERE countryId = 3;";
                        Connections.mySqlCommand.Connection = DatabaseConnection;
                        DatabaseConnection.Open();
                        cityTable.Load(Connections.mySqlCommand.ExecuteReader());
                        cityComboBox.DataSource = cityTable;
                        cityComboBox.DisplayMember = "city";
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
            else
            {
                phoneNumberTextbox.BackColor = Color.White;
                validPhoneNumber = true;
            }

            saveButton.Enabled = allowSave(validName, validAddress1, validCity, validCountry, validPostalCode, validPhoneNumber);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (activeButton.Checked)
            {
                customerStatus = 1;
            }
            else if (inactiveButton.Checked)
            {
                customerStatus = 0;
            }

            using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
            {
                try
                {
                    Connections.mySqlCommand.CommandText = "UPDATE address " +
                        "SET address = '" + address1Textbox.Text + "', " +
                        "address2 = '" + address2Textbox.Text + "', " +
                        "cityId = " + cityComboBox.SelectedValue + ", " +
                        "postalCode = '" + postalCodeTextbox.Text + "', " +
                        "phone = '" + phoneNumberTextbox.Text + "', " +
                        "lastUpdate = CURRENT_TIMESTAMP(), " +
                        "lastUpdateBy = 'test' " +
                        "WHERE addressId = " + customerAddressID + ";";
                    Connections.mySqlCommand.Connection = DatabaseConnection;
                    DatabaseConnection.Open();
                    Connections.mySqlCommand.ExecuteNonQuery();

                    Connections.mySqlCommand.CommandText = "UPDATE customer " +
                        "SET customerName = '" + nameTextbox.Text + "', " +
                        "active = " + customerStatus + ", " +
                        "lastUpdate = CURRENT_TIMESTAMP(), " +
                        "lastUpdateBy = 'test' " +
                        "WHERE customerId = " + customerID + ";";
                    Connections.mySqlCommand.Connection = DatabaseConnection;
                    Connections.mySqlCommand.ExecuteNonQuery();

                    Connections.mySqlCommand.CommandText = "SELECT customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy FROM U07wVX.customer;";
                    mainScreen.customersTable.Load(Connections.mySqlCommand.ExecuteReader());

                    mainScreen.Show();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error");
                }
            }
            mainScreen.Show();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            mainScreen.Show();
            this.Close();
        }
    }
}
