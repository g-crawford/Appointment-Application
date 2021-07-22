using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969___Scheduler_App
{
    public partial class HelpScreen : Form
    {

        // Properties -------------------------------------------------------------------------------------------------------
        public AddCustomerScreen addCustomerScreen;
        public AddAppointmentScreen addAppointmentScreen;


        // Constructors ------------------------------------------------------------------------------------------------------

        // CAPSTONE COMMENT: The below use of overloaded constructors for the help page demostrate polymorphism. 
        // Polymorphism: We see the page transform and present itself differently using by way of different methods depending on the parameters it is passed

        public HelpScreen()
        {
            InitializeComponent();
        }

        public HelpScreen(AddCustomerScreen addCustomerScreen)
        {
            this.addCustomerScreen = addCustomerScreen;
            InitializeComponent();
            base.Text = "Add Customer Help";
            titleLabel.Text = "Help with Adding Customer";
            hideAppointmentHelp();
            displayCustomerHelp();
        }

        public HelpScreen(AddAppointmentScreen addAppointmentScreen)
        {
            this.addAppointmentScreen = addAppointmentScreen;
            InitializeComponent();
            base.Text = "Add Appointment Help";
            titleLabel.Text = "Help with Adding Appointment";
            hideCustomerHelp();
            displayAppointmentHelp();
        }

        // Events & Methods ---------------------------------------------------------------------------------------------------

        // CAPSTONE COMMENT: The below functions serve as another form of encapsulation

        public void displayCustomerHelp()
        {
            customerPostalCodeLabel.Visible = true;
            customerCountryLabel.Visible = true;
            customerCityLabel.Visible = true;
            customerAddress1Label.Visible = true;
            customerAddress2Label.Visible = true;
            customerInactiveButton.Visible = true;
            customerActiveButton.Visible = true;
            customerPhoneNumberLabel.Visible = true;
            customerStatusLabel.Visible = true;
            customerNameTextbox.Visible = true;
            customerNameLabel.Visible = true;
            customerCountryTextBox.Visible = true;
            customerAddress1Textbox.Visible = true;
            customerAddress2Textbox.Visible = true;
            customerCityTextbox.Visible = true;
            customerPostalCodeTextbox.Visible = true;
            customerRadioButtonTextbox.Visible = true;
            customerPhoneNumberTextbox.Visible = true;
        }

        public void hideCustomerHelp()
        {
            customerPostalCodeLabel.Visible = false;
            customerCountryLabel.Visible = false;
            customerCityLabel.Visible = false;
            customerAddress1Label.Visible = false;
            customerAddress2Label.Visible = false;
            customerInactiveButton.Visible = false;
            customerActiveButton.Visible = false;
            customerPhoneNumberLabel.Visible = false;
            customerStatusLabel.Visible = false;
            customerNameTextbox.Visible = false;
            customerNameLabel.Visible = false;
            customerCountryTextBox.Visible = false;
            customerAddress1Textbox.Visible = false;
            customerAddress2Textbox.Visible = false;
            customerCityTextbox.Visible = false;
            customerPostalCodeTextbox.Visible = false;
            customerRadioButtonTextbox.Visible = false;
            customerPhoneNumberTextbox.Visible = false;
        }

        public void displayAppointmentHelp()
        {
            appointmentEndLabel.Visible = true;
            appointmentStartLabel.Visible = true;
            appointmentTypeLabel.Visible = true;
            appointmentNameLabel.Visible = true;
            appointmentCustomerLabel.Visible = true;
            appointmentCustomerTextbox.Visible = true;
            appointmentNameTextbox.Visible = true;
            appointmentTypeTextbox.Visible = true;
            appointmentStartTextbox.Visible = true;
            appointmentEndTextbox.Visible = true;
            appointmentTimesLabel.Visible = true;
            appointmentOverlapLabel.Visible = true;
        }

        public void hideAppointmentHelp()
        {
            appointmentEndLabel.Visible = false;
            appointmentStartLabel.Visible = false;
            appointmentTypeLabel.Visible = false;
            appointmentNameLabel.Visible = false;
            appointmentCustomerLabel.Visible = false;
            appointmentCustomerTextbox.Visible = false;
            appointmentNameTextbox.Visible = false;
            appointmentTypeTextbox.Visible = false;
            appointmentStartTextbox.Visible = false;
            appointmentEndTextbox.Visible = false;
            appointmentTimesLabel.Visible = false;
            appointmentOverlapLabel.Visible = false;
        }
    }
}
