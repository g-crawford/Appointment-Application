
namespace C969___Scheduler_App
{
    partial class mainScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.appointmentView = new System.Windows.Forms.TabPage();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.appointmentDeleteButton = new System.Windows.Forms.Button();
            this.appointmentEditButton = new System.Windows.Forms.Button();
            this.appointmentAddButton = new System.Windows.Forms.Button();
            this.allTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.upcomingAppointmentsLabel = new System.Windows.Forms.Label();
            this.appointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.u07wVXDataSet = new C969___Scheduler_App.U07wVXDataSet();
            this.byWeekRadioButton = new System.Windows.Forms.RadioButton();
            this.byMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.displayTypeLabel = new System.Windows.Forms.Label();
            this.customerView = new System.Windows.Forms.TabPage();
            this.customerDeleteButton = new System.Windows.Forms.Button();
            this.customerEditButton = new System.Windows.Forms.Button();
            this.customerAddButton = new System.Windows.Forms.Button();
            this.customersLabel = new System.Windows.Forms.Label();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateByDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.appointmentTableAdapter = new C969___Scheduler_App.U07wVXDataSetTableAdapters.appointmentTableAdapter();
            this.u07wVXDataSet1 = new C969___Scheduler_App.U07wVXDataSet();
            this.customerTableAdapter = new C969___Scheduler_App.U07wVXDataSetTableAdapters.customerTableAdapter();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.tabContainer.SuspendLayout();
            this.appointmentView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u07wVXDataSet)).BeginInit();
            this.customerView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u07wVXDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.appointmentView);
            this.tabContainer.Controls.Add(this.customerView);
            this.tabContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabContainer.Location = new System.Drawing.Point(12, 12);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(1122, 440);
            this.tabContainer.TabIndex = 0;
            // 
            // appointmentView
            // 
            this.appointmentView.Controls.Add(this.searchButton);
            this.appointmentView.Controls.Add(this.searchTextbox);
            this.appointmentView.Controls.Add(this.searchLabel);
            this.appointmentView.Controls.Add(this.calendar);
            this.appointmentView.Controls.Add(this.appointmentDeleteButton);
            this.appointmentView.Controls.Add(this.appointmentEditButton);
            this.appointmentView.Controls.Add(this.appointmentAddButton);
            this.appointmentView.Controls.Add(this.allTimeRadioButton);
            this.appointmentView.Controls.Add(this.upcomingAppointmentsLabel);
            this.appointmentView.Controls.Add(this.appointmentsDataGridView);
            this.appointmentView.Controls.Add(this.byWeekRadioButton);
            this.appointmentView.Controls.Add(this.byMonthRadioButton);
            this.appointmentView.Controls.Add(this.displayTypeLabel);
            this.appointmentView.Location = new System.Drawing.Point(4, 22);
            this.appointmentView.Name = "appointmentView";
            this.appointmentView.Padding = new System.Windows.Forms.Padding(3);
            this.appointmentView.Size = new System.Drawing.Size(1114, 414);
            this.appointmentView.TabIndex = 0;
            this.appointmentView.Text = "Appointments";
            this.appointmentView.UseVisualStyleBackColor = true;
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(9, 169);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 11;
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateSelected);
            // 
            // appointmentDeleteButton
            // 
            this.appointmentDeleteButton.Location = new System.Drawing.Point(1014, 354);
            this.appointmentDeleteButton.Name = "appointmentDeleteButton";
            this.appointmentDeleteButton.Size = new System.Drawing.Size(84, 22);
            this.appointmentDeleteButton.TabIndex = 9;
            this.appointmentDeleteButton.Text = "Delete";
            this.appointmentDeleteButton.UseVisualStyleBackColor = true;
            this.appointmentDeleteButton.Click += new System.EventHandler(this.appointmentDeleteButton_Click);
            // 
            // appointmentEditButton
            // 
            this.appointmentEditButton.Location = new System.Drawing.Point(924, 354);
            this.appointmentEditButton.Name = "appointmentEditButton";
            this.appointmentEditButton.Size = new System.Drawing.Size(84, 22);
            this.appointmentEditButton.TabIndex = 8;
            this.appointmentEditButton.Text = "Edit";
            this.appointmentEditButton.UseVisualStyleBackColor = true;
            this.appointmentEditButton.Click += new System.EventHandler(this.appointmentEditButton_Click);
            // 
            // appointmentAddButton
            // 
            this.appointmentAddButton.Location = new System.Drawing.Point(834, 354);
            this.appointmentAddButton.Name = "appointmentAddButton";
            this.appointmentAddButton.Size = new System.Drawing.Size(84, 22);
            this.appointmentAddButton.TabIndex = 7;
            this.appointmentAddButton.Text = "Add";
            this.appointmentAddButton.UseVisualStyleBackColor = true;
            this.appointmentAddButton.Click += new System.EventHandler(this.appointmentAddButton_Click);
            // 
            // allTimeRadioButton
            // 
            this.allTimeRadioButton.AutoSize = true;
            this.allTimeRadioButton.Location = new System.Drawing.Point(24, 80);
            this.allTimeRadioButton.Name = "allTimeRadioButton";
            this.allTimeRadioButton.Size = new System.Drawing.Size(62, 17);
            this.allTimeRadioButton.TabIndex = 6;
            this.allTimeRadioButton.Text = "All Time";
            this.allTimeRadioButton.UseVisualStyleBackColor = true;
            this.allTimeRadioButton.CheckedChanged += new System.EventHandler(this.allTimeRadioButton_CheckedChanged);
            // 
            // upcomingAppointmentsLabel
            // 
            this.upcomingAppointmentsLabel.AutoSize = true;
            this.upcomingAppointmentsLabel.Location = new System.Drawing.Point(251, 25);
            this.upcomingAppointmentsLabel.Name = "upcomingAppointmentsLabel";
            this.upcomingAppointmentsLabel.Size = new System.Drawing.Size(122, 13);
            this.upcomingAppointmentsLabel.TabIndex = 5;
            this.upcomingAppointmentsLabel.Text = "Upcoming Appointments";
            // 
            // appointmentsDataGridView
            // 
            this.appointmentsDataGridView.AllowUserToAddRows = false;
            this.appointmentsDataGridView.AllowUserToDeleteRows = false;
            this.appointmentsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appointmentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.appointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.customerId,
            this.startDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.lastUpdateDataGridViewTextBoxColumn,
            this.lastUpdateByDataGridViewTextBoxColumn});
            this.appointmentsDataGridView.DataSource = this.appointmentBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.appointmentsDataGridView.DefaultCellStyle = dataGridViewCellStyle17;
            this.appointmentsDataGridView.Location = new System.Drawing.Point(254, 41);
            this.appointmentsDataGridView.Name = "appointmentsDataGridView";
            this.appointmentsDataGridView.ReadOnly = true;
            this.appointmentsDataGridView.Size = new System.Drawing.Size(844, 307);
            this.appointmentsDataGridView.TabIndex = 4;
            this.appointmentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentsDataGridView_CellClick);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerId
            // 
            this.customerId.DataPropertyName = "customerId";
            this.customerId.HeaderText = "customerId";
            this.customerId.Name = "customerId";
            this.customerId.ReadOnly = true;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn.HeaderText = "start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "end";
            this.endDataGridViewTextBoxColumn.HeaderText = "end";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            this.endDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "createDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "createDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "createdBy";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "createdBy";
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            this.createdByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastUpdateDataGridViewTextBoxColumn
            // 
            this.lastUpdateDataGridViewTextBoxColumn.DataPropertyName = "lastUpdate";
            this.lastUpdateDataGridViewTextBoxColumn.HeaderText = "lastUpdate";
            this.lastUpdateDataGridViewTextBoxColumn.Name = "lastUpdateDataGridViewTextBoxColumn";
            this.lastUpdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastUpdateByDataGridViewTextBoxColumn
            // 
            this.lastUpdateByDataGridViewTextBoxColumn.DataPropertyName = "lastUpdateBy";
            this.lastUpdateByDataGridViewTextBoxColumn.HeaderText = "lastUpdateBy";
            this.lastUpdateByDataGridViewTextBoxColumn.Name = "lastUpdateByDataGridViewTextBoxColumn";
            this.lastUpdateByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "appointment";
            this.appointmentBindingSource.DataSource = this.u07wVXDataSet;
            // 
            // u07wVXDataSet
            // 
            this.u07wVXDataSet.DataSetName = "U07wVXDataSet";
            this.u07wVXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // byWeekRadioButton
            // 
            this.byWeekRadioButton.AutoSize = true;
            this.byWeekRadioButton.Location = new System.Drawing.Point(24, 140);
            this.byWeekRadioButton.Name = "byWeekRadioButton";
            this.byWeekRadioButton.Size = new System.Drawing.Size(54, 17);
            this.byWeekRadioButton.TabIndex = 2;
            this.byWeekRadioButton.Text = "Week";
            this.byWeekRadioButton.UseVisualStyleBackColor = true;
            this.byWeekRadioButton.CheckedChanged += new System.EventHandler(this.byWeekRadioButton_CheckedChanged);
            // 
            // byMonthRadioButton
            // 
            this.byMonthRadioButton.AutoSize = true;
            this.byMonthRadioButton.Location = new System.Drawing.Point(24, 110);
            this.byMonthRadioButton.Name = "byMonthRadioButton";
            this.byMonthRadioButton.Size = new System.Drawing.Size(55, 17);
            this.byMonthRadioButton.TabIndex = 1;
            this.byMonthRadioButton.Text = "Month";
            this.byMonthRadioButton.UseVisualStyleBackColor = true;
            this.byMonthRadioButton.CheckedChanged += new System.EventHandler(this.byMonthRadioButton_CheckedChanged);
            // 
            // displayTypeLabel
            // 
            this.displayTypeLabel.AutoSize = true;
            this.displayTypeLabel.Location = new System.Drawing.Point(21, 55);
            this.displayTypeLabel.Name = "displayTypeLabel";
            this.displayTypeLabel.Size = new System.Drawing.Size(125, 13);
            this.displayTypeLabel.TabIndex = 0;
            this.displayTypeLabel.Text = "Display Appointments by:";
            // 
            // customerView
            // 
            this.customerView.Controls.Add(this.customerDeleteButton);
            this.customerView.Controls.Add(this.customerEditButton);
            this.customerView.Controls.Add(this.customerAddButton);
            this.customerView.Controls.Add(this.customersLabel);
            this.customerView.Controls.Add(this.customersDataGridView);
            this.customerView.Location = new System.Drawing.Point(4, 22);
            this.customerView.Name = "customerView";
            this.customerView.Padding = new System.Windows.Forms.Padding(3);
            this.customerView.Size = new System.Drawing.Size(1114, 414);
            this.customerView.TabIndex = 1;
            this.customerView.Text = "Customers";
            this.customerView.UseVisualStyleBackColor = true;
            // 
            // customerDeleteButton
            // 
            this.customerDeleteButton.Location = new System.Drawing.Point(863, 353);
            this.customerDeleteButton.Name = "customerDeleteButton";
            this.customerDeleteButton.Size = new System.Drawing.Size(84, 22);
            this.customerDeleteButton.TabIndex = 9;
            this.customerDeleteButton.Text = "Delete";
            this.customerDeleteButton.UseVisualStyleBackColor = true;
            this.customerDeleteButton.Click += new System.EventHandler(this.customerDeleteButton_Click);
            // 
            // customerEditButton
            // 
            this.customerEditButton.Location = new System.Drawing.Point(773, 353);
            this.customerEditButton.Name = "customerEditButton";
            this.customerEditButton.Size = new System.Drawing.Size(84, 22);
            this.customerEditButton.TabIndex = 8;
            this.customerEditButton.Text = "Edit";
            this.customerEditButton.UseVisualStyleBackColor = true;
            this.customerEditButton.Click += new System.EventHandler(this.customerEditButton_Click);
            // 
            // customerAddButton
            // 
            this.customerAddButton.Location = new System.Drawing.Point(683, 353);
            this.customerAddButton.Name = "customerAddButton";
            this.customerAddButton.Size = new System.Drawing.Size(84, 22);
            this.customerAddButton.TabIndex = 7;
            this.customerAddButton.Text = "Add";
            this.customerAddButton.UseVisualStyleBackColor = true;
            this.customerAddButton.Click += new System.EventHandler(this.customerAddButton_Click);
            // 
            // customersLabel
            // 
            this.customersLabel.AutoSize = true;
            this.customersLabel.Location = new System.Drawing.Point(201, 24);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(94, 13);
            this.customersLabel.TabIndex = 6;
            this.customersLabel.Text = "Customer Records";
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            this.customersDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.addressIdDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.createDateDataGridViewTextBoxColumn1,
            this.createdByDataGridViewTextBoxColumn1,
            this.lastUpdateDataGridViewTextBoxColumn1,
            this.lastUpdateByDataGridViewTextBoxColumn1});
            this.customersDataGridView.DataSource = this.customerBindingSource;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customersDataGridView.DefaultCellStyle = dataGridViewCellStyle19;
            this.customersDataGridView.Location = new System.Drawing.Point(204, 40);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.customersDataGridView.Size = new System.Drawing.Size(743, 307);
            this.customersDataGridView.TabIndex = 0;
            this.customersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataGridView_CellClick);
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "customerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressIdDataGridViewTextBoxColumn
            // 
            this.addressIdDataGridViewTextBoxColumn.DataPropertyName = "addressId";
            this.addressIdDataGridViewTextBoxColumn.HeaderText = "addressId";
            this.addressIdDataGridViewTextBoxColumn.Name = "addressIdDataGridViewTextBoxColumn";
            this.addressIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // createDateDataGridViewTextBoxColumn1
            // 
            this.createDateDataGridViewTextBoxColumn1.DataPropertyName = "createDate";
            this.createDateDataGridViewTextBoxColumn1.HeaderText = "createDate";
            this.createDateDataGridViewTextBoxColumn1.Name = "createDateDataGridViewTextBoxColumn1";
            this.createDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // createdByDataGridViewTextBoxColumn1
            // 
            this.createdByDataGridViewTextBoxColumn1.DataPropertyName = "createdBy";
            this.createdByDataGridViewTextBoxColumn1.HeaderText = "createdBy";
            this.createdByDataGridViewTextBoxColumn1.Name = "createdByDataGridViewTextBoxColumn1";
            this.createdByDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastUpdateDataGridViewTextBoxColumn1
            // 
            this.lastUpdateDataGridViewTextBoxColumn1.DataPropertyName = "lastUpdate";
            this.lastUpdateDataGridViewTextBoxColumn1.HeaderText = "lastUpdate";
            this.lastUpdateDataGridViewTextBoxColumn1.Name = "lastUpdateDataGridViewTextBoxColumn1";
            this.lastUpdateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastUpdateByDataGridViewTextBoxColumn1
            // 
            this.lastUpdateByDataGridViewTextBoxColumn1.DataPropertyName = "lastUpdateBy";
            this.lastUpdateByDataGridViewTextBoxColumn1.HeaderText = "lastUpdateBy";
            this.lastUpdateByDataGridViewTextBoxColumn1.Name = "lastUpdateByDataGridViewTextBoxColumn1";
            this.lastUpdateByDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.u07wVXDataSet;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1087, 458);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(43, 30);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // u07wVXDataSet1
            // 
            this.u07wVXDataSet1.DataSetName = "U07wVXDataSet";
            this.u07wVXDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "customer";
            this.customerBindingSource1.DataSource = this.u07wVXDataSet;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(16, 458);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(74, 30);
            this.reportButton.TabIndex = 12;
            this.reportButton.Text = "Reports";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(794, 18);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(81, 13);
            this.searchLabel.TabIndex = 12;
            this.searchLabel.Text = "Search by Title:";
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(881, 15);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(159, 20);
            this.searchTextbox.TabIndex = 13;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1046, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(52, 25);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 500);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tabContainer);
            this.Name = "mainScreen";
            this.Text = "Main Screen";
            this.tabContainer.ResumeLayout(false);
            this.appointmentView.ResumeLayout(false);
            this.appointmentView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u07wVXDataSet)).EndInit();
            this.customerView.ResumeLayout(false);
            this.customerView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u07wVXDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage appointmentView;
        private System.Windows.Forms.TabPage customerView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton byWeekRadioButton;
        private System.Windows.Forms.RadioButton byMonthRadioButton;
        private System.Windows.Forms.Label displayTypeLabel;
        private System.Windows.Forms.Label upcomingAppointmentsLabel;
        private System.Windows.Forms.DataGridView appointmentsDataGridView;
        private U07wVXDataSet u07wVXDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private U07wVXDataSetTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.RadioButton allTimeRadioButton;
        private U07wVXDataSet u07wVXDataSet1;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.Button appointmentDeleteButton;
        private System.Windows.Forms.Button appointmentEditButton;
        private System.Windows.Forms.Button appointmentAddButton;
        private System.Windows.Forms.Button customerDeleteButton;
        private System.Windows.Forms.Button customerEditButton;
        private System.Windows.Forms.Button customerAddButton;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private U07wVXDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateByDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Button searchButton;
    }
}

