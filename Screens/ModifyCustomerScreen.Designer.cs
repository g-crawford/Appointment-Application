
namespace C969___Scheduler_App
{
    partial class ModifyCustomerScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.countryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.u07wVXDataSet = new C969___Scheduler_App.U07wVXDataSet();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.postalCodeTextbox = new System.Windows.Forms.TextBox();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.address2Textbox = new System.Windows.Forms.TextBox();
            this.address2Label = new System.Windows.Forms.Label();
            this.inactiveButton = new System.Windows.Forms.RadioButton();
            this.activeButton = new System.Windows.Forms.RadioButton();
            this.phoneNumberTextbox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.address1Textbox = new System.Windows.Forms.TextBox();
            this.streetAddressLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.countryTableAdapter = new C969___Scheduler_App.U07wVXDataSetTableAdapters.countryTableAdapter();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u07wVXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // countryBindingSource1
            // 
            this.countryBindingSource1.DataMember = "country";
            this.countryBindingSource1.DataSource = this.u07wVXDataSet;
            // 
            // u07wVXDataSet
            // 
            this.u07wVXDataSet.DataSetName = "U07wVXDataSet";
            this.u07wVXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "country";
            this.countryBindingSource.DataSource = this.u07wVXDataSet;
            // 
            // cityComboBox
            // 
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(182, 163);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(147, 21);
            this.cityComboBox.TabIndex = 42;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            // 
            // countryComboBox
            // 
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            "US"});
            this.countryComboBox.Location = new System.Drawing.Point(182, 84);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(147, 21);
            this.countryComboBox.TabIndex = 41;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            // 
            // postalCodeTextbox
            // 
            this.postalCodeTextbox.Location = new System.Drawing.Point(182, 190);
            this.postalCodeTextbox.MaxLength = 6;
            this.postalCodeTextbox.Name = "postalCodeTextbox";
            this.postalCodeTextbox.Size = new System.Drawing.Size(147, 20);
            this.postalCodeTextbox.TabIndex = 40;
            this.postalCodeTextbox.TextChanged += new System.EventHandler(this.postalCodeTextbox_TextChanged);
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Location = new System.Drawing.Point(107, 193);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(67, 13);
            this.postalCodeLabel.TabIndex = 39;
            this.postalCodeLabel.Text = "Postal Code:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(128, 87);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(46, 13);
            this.countryLabel.TabIndex = 38;
            this.countryLabel.Text = "Country:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(141, 166);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 37;
            this.cityLabel.Text = "City:";
            // 
            // address2Textbox
            // 
            this.address2Textbox.Location = new System.Drawing.Point(182, 137);
            this.address2Textbox.Name = "address2Textbox";
            this.address2Textbox.Size = new System.Drawing.Size(147, 20);
            this.address2Textbox.TabIndex = 36;
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Location = new System.Drawing.Point(119, 140);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(57, 13);
            this.address2Label.TabIndex = 35;
            this.address2Label.Text = "Address 2:";
            // 
            // inactiveButton
            // 
            this.inactiveButton.AutoSize = true;
            this.inactiveButton.Location = new System.Drawing.Point(255, 253);
            this.inactiveButton.Name = "inactiveButton";
            this.inactiveButton.Size = new System.Drawing.Size(63, 17);
            this.inactiveButton.TabIndex = 34;
            this.inactiveButton.Text = "Inactive";
            this.inactiveButton.UseVisualStyleBackColor = true;
            // 
            // activeButton
            // 
            this.activeButton.AutoSize = true;
            this.activeButton.Checked = true;
            this.activeButton.Location = new System.Drawing.Point(194, 253);
            this.activeButton.Name = "activeButton";
            this.activeButton.Size = new System.Drawing.Size(55, 17);
            this.activeButton.TabIndex = 33;
            this.activeButton.TabStop = true;
            this.activeButton.Text = "Active";
            this.activeButton.UseVisualStyleBackColor = true;
            // 
            // phoneNumberTextbox
            // 
            this.phoneNumberTextbox.Location = new System.Drawing.Point(182, 216);
            this.phoneNumberTextbox.MaxLength = 15;
            this.phoneNumberTextbox.Name = "phoneNumberTextbox";
            this.phoneNumberTextbox.Size = new System.Drawing.Size(147, 20);
            this.phoneNumberTextbox.TabIndex = 32;
            this.phoneNumberTextbox.TextChanged += new System.EventHandler(this.phoneNumberTextbox_TextChanged);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(93, 219);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumberLabel.TabIndex = 31;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(335, 304);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 29);
            this.cancelButton.TabIndex = 30;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(247, 304);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 29);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(91, 255);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(83, 13);
            this.statusLabel.TabIndex = 28;
            this.statusLabel.Text = "Active/Inactive:";
            // 
            // address1Textbox
            // 
            this.address1Textbox.Location = new System.Drawing.Point(182, 111);
            this.address1Textbox.Name = "address1Textbox";
            this.address1Textbox.Size = new System.Drawing.Size(147, 20);
            this.address1Textbox.TabIndex = 27;
            this.address1Textbox.TextChanged += new System.EventHandler(this.address1Textbox_TextChanged);
            // 
            // streetAddressLabel
            // 
            this.streetAddressLabel.AutoSize = true;
            this.streetAddressLabel.Location = new System.Drawing.Point(119, 114);
            this.streetAddressLabel.Name = "streetAddressLabel";
            this.streetAddressLabel.Size = new System.Drawing.Size(57, 13);
            this.streetAddressLabel.TabIndex = 26;
            this.streetAddressLabel.Text = "Address 1:";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(182, 58);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(147, 20);
            this.nameTextbox.TabIndex = 25;
            this.nameTextbox.TextChanged += new System.EventHandler(this.nameTextbox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(138, 61);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 24;
            this.nameLabel.Text = "Name:";
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(23, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(128, 20);
            this.titleLabel.TabIndex = 23;
            this.titleLabel.Text = "Modify Customer";
            // 
            // ModifyCustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 354);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.postalCodeTextbox);
            this.Controls.Add(this.postalCodeLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.address2Textbox);
            this.Controls.Add(this.address2Label);
            this.Controls.Add(this.inactiveButton);
            this.Controls.Add(this.activeButton);
            this.Controls.Add(this.phoneNumberTextbox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.address1Textbox);
            this.Controls.Add(this.streetAddressLabel);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "ModifyCustomerScreen";
            this.Text = "Modify Customer";
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u07wVXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource countryBindingSource1;
        private U07wVXDataSet u07wVXDataSet;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.TextBox postalCodeTextbox;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox address2Textbox;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.RadioButton inactiveButton;
        private System.Windows.Forms.RadioButton activeButton;
        private System.Windows.Forms.TextBox phoneNumberTextbox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox address1Textbox;
        private System.Windows.Forms.Label streetAddressLabel;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label nameLabel;
        private U07wVXDataSetTableAdapters.countryTableAdapter countryTableAdapter;
        private System.Windows.Forms.Label titleLabel;
    }
}