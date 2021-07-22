
namespace C969___Scheduler_App
{
    partial class ReportScreen
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
            this.reportResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.titleLabel = new System.Windows.Forms.Label();
            this.customersReportRadioButton = new System.Windows.Forms.RadioButton();
            this.consultantReportRadioButton = new System.Windows.Forms.RadioButton();
            this.appointmentsReportRadioButton = new System.Windows.Forms.RadioButton();
            this.monthsComboBox = new System.Windows.Forms.ComboBox();
            this.consultantsComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generatedLabel = new System.Windows.Forms.Label();
            this.timeStampLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reportResultsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportResultsDataGridView
            // 
            this.reportResultsDataGridView.AllowUserToAddRows = false;
            this.reportResultsDataGridView.AllowUserToDeleteRows = false;
            this.reportResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportResultsDataGridView.Location = new System.Drawing.Point(237, 56);
            this.reportResultsDataGridView.Name = "reportResultsDataGridView";
            this.reportResultsDataGridView.Size = new System.Drawing.Size(455, 291);
            this.reportResultsDataGridView.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 53);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(146, 20);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Available Reporting";
            // 
            // customersReportRadioButton
            // 
            this.customersReportRadioButton.AutoSize = true;
            this.customersReportRadioButton.Location = new System.Drawing.Point(16, 131);
            this.customersReportRadioButton.Name = "customersReportRadioButton";
            this.customersReportRadioButton.Size = new System.Drawing.Size(173, 17);
            this.customersReportRadioButton.TabIndex = 4;
            this.customersReportRadioButton.Text = "Number of Customers by Status";
            this.customersReportRadioButton.UseVisualStyleBackColor = true;
            this.customersReportRadioButton.CheckedChanged += new System.EventHandler(this.customersReportRadioButton_CheckedChanged);
            // 
            // consultantReportRadioButton
            // 
            this.consultantReportRadioButton.AutoSize = true;
            this.consultantReportRadioButton.Checked = true;
            this.consultantReportRadioButton.Location = new System.Drawing.Point(16, 85);
            this.consultantReportRadioButton.Name = "consultantReportRadioButton";
            this.consultantReportRadioButton.Size = new System.Drawing.Size(166, 17);
            this.consultantReportRadioButton.TabIndex = 3;
            this.consultantReportRadioButton.TabStop = true;
            this.consultantReportRadioButton.Text = "Schedule for Each Consultant";
            this.consultantReportRadioButton.UseVisualStyleBackColor = true;
            this.consultantReportRadioButton.CheckedChanged += new System.EventHandler(this.consultantReportRadioButton_CheckedChanged);
            // 
            // appointmentsReportRadioButton
            // 
            this.appointmentsReportRadioButton.AutoSize = true;
            this.appointmentsReportRadioButton.Location = new System.Drawing.Point(16, 108);
            this.appointmentsReportRadioButton.Name = "appointmentsReportRadioButton";
            this.appointmentsReportRadioButton.Size = new System.Drawing.Size(215, 17);
            this.appointmentsReportRadioButton.TabIndex = 2;
            this.appointmentsReportRadioButton.Text = "Number of Appointment Types by Month";
            this.appointmentsReportRadioButton.UseVisualStyleBackColor = true;
            this.appointmentsReportRadioButton.CheckedChanged += new System.EventHandler(this.appointmentsReportRadioButton_CheckedChanged);
            // 
            // monthsComboBox
            // 
            this.monthsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthsComboBox.FormattingEnabled = true;
            this.monthsComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthsComboBox.Location = new System.Drawing.Point(237, 29);
            this.monthsComboBox.Name = "monthsComboBox";
            this.monthsComboBox.Size = new System.Drawing.Size(152, 21);
            this.monthsComboBox.TabIndex = 5;
            this.monthsComboBox.SelectedIndexChanged += new System.EventHandler(this.monthsComboBox_SelectedIndexChanged);
            // 
            // consultantsComboBox
            // 
            this.consultantsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.consultantsComboBox.FormattingEnabled = true;
            this.consultantsComboBox.Items.AddRange(new object[] {
            "test"});
            this.consultantsComboBox.Location = new System.Drawing.Point(237, 29);
            this.consultantsComboBox.Name = "consultantsComboBox";
            this.consultantsComboBox.Size = new System.Drawing.Size(152, 21);
            this.consultantsComboBox.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customersReportRadioButton);
            this.panel1.Controls.Add(this.consultantReportRadioButton);
            this.panel1.Controls.Add(this.appointmentsReportRadioButton);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 206);
            this.panel1.TabIndex = 7;
            // 
            // generatedLabel
            // 
            this.generatedLabel.AutoSize = true;
            this.generatedLabel.Location = new System.Drawing.Point(321, 356);
            this.generatedLabel.Name = "generatedLabel";
            this.generatedLabel.Size = new System.Drawing.Size(112, 13);
            this.generatedLabel.TabIndex = 8;
            this.generatedLabel.Text = "Report Generated On:";
            this.generatedLabel.Visible = false;
            // 
            // timeStampLabel
            // 
            this.timeStampLabel.AutoSize = true;
            this.timeStampLabel.Location = new System.Drawing.Point(439, 356);
            this.timeStampLabel.Name = "timeStampLabel";
            this.timeStampLabel.Size = new System.Drawing.Size(0, 13);
            this.timeStampLabel.TabIndex = 9;
            // 
            // ReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 378);
            this.Controls.Add(this.timeStampLabel);
            this.Controls.Add(this.generatedLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.consultantsComboBox);
            this.Controls.Add(this.monthsComboBox);
            this.Controls.Add(this.reportResultsDataGridView);
            this.Name = "ReportScreen";
            this.Text = "Report Screen";
            ((System.ComponentModel.ISupportInitialize)(this.reportResultsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reportResultsDataGridView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RadioButton customersReportRadioButton;
        private System.Windows.Forms.RadioButton consultantReportRadioButton;
        private System.Windows.Forms.RadioButton appointmentsReportRadioButton;
        private System.Windows.Forms.ComboBox monthsComboBox;
        private System.Windows.Forms.ComboBox consultantsComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label generatedLabel;
        private System.Windows.Forms.Label timeStampLabel;
    }
}