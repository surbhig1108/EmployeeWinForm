namespace sur_Employee
{
    partial class FRM_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Employee));
            this.GRP_Emp = new DevExpress.XtraEditors.GroupControl();
            this.BTN_New = new System.Windows.Forms.Button();
            this.TE_EmpSalary = new DevExpress.XtraEditors.TextEdit();
            this.TE_EmpMobile = new DevExpress.XtraEditors.TextEdit();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.GR_Employee = new DevExpress.XtraGrid.GridControl();
            this.GV_Employee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.COL_EMPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_EmpName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_EmpDOB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_EmpDOJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_EmpDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_EmpDesignation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_EmpSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_EmpMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_EmpCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemHyperLinkEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.CMB_EmpCity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.DTP_EmpDOJ = new System.Windows.Forms.DateTimePicker();
            this.DTP_EmpDOB = new System.Windows.Forms.DateTimePicker();
            this.TB_EmpDesignation = new System.Windows.Forms.TextBox();
            this.TB_EmpDepartment = new System.Windows.Forms.TextBox();
            this.TB_EmpName = new System.Windows.Forms.TextBox();
            this.BTN_Showdetail = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_EmpCity = new System.Windows.Forms.Label();
            this.LBL_EmpSalary = new System.Windows.Forms.Label();
            this.LBL_EmpDesignation = new System.Windows.Forms.Label();
            this.LBL_EmpDepartment = new System.Windows.Forms.Label();
            this.LBL_EmpDOJ = new System.Windows.Forms.Label();
            this.LBL_EmpDOB = new System.Windows.Forms.Label();
            this.LBL_Emp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GRP_Emp)).BeginInit();
            this.GRP_Emp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TE_EmpSalary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_EmpMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GR_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMB_EmpCity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GRP_Emp
            // 
            this.GRP_Emp.Appearance.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRP_Emp.Appearance.Options.UseFont = true;
            this.GRP_Emp.Appearance.Options.UseTextOptions = true;
            this.GRP_Emp.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GRP_Emp.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GRP_Emp.AppearanceCaption.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRP_Emp.AppearanceCaption.Options.UseFont = true;
            this.GRP_Emp.AppearanceCaption.Options.UseTextOptions = true;
            this.GRP_Emp.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GRP_Emp.Controls.Add(this.BTN_New);
            this.GRP_Emp.Controls.Add(this.TE_EmpSalary);
            this.GRP_Emp.Controls.Add(this.TE_EmpMobile);
            this.GRP_Emp.Controls.Add(this.BTN_Delete);
            this.GRP_Emp.Controls.Add(this.BTN_Edit);
            this.GRP_Emp.Controls.Add(this.GR_Employee);
            this.GRP_Emp.Controls.Add(this.CMB_EmpCity);
            this.GRP_Emp.Controls.Add(this.DTP_EmpDOJ);
            this.GRP_Emp.Controls.Add(this.DTP_EmpDOB);
            this.GRP_Emp.Controls.Add(this.TB_EmpDesignation);
            this.GRP_Emp.Controls.Add(this.TB_EmpDepartment);
            this.GRP_Emp.Controls.Add(this.TB_EmpName);
            this.GRP_Emp.Controls.Add(this.BTN_Showdetail);
            this.GRP_Emp.Controls.Add(this.BTN_Save);
            this.GRP_Emp.Controls.Add(this.label1);
            this.GRP_Emp.Controls.Add(this.LBL_EmpCity);
            this.GRP_Emp.Controls.Add(this.LBL_EmpSalary);
            this.GRP_Emp.Controls.Add(this.LBL_EmpDesignation);
            this.GRP_Emp.Controls.Add(this.LBL_EmpDepartment);
            this.GRP_Emp.Controls.Add(this.LBL_EmpDOJ);
            this.GRP_Emp.Controls.Add(this.LBL_EmpDOB);
            this.GRP_Emp.Controls.Add(this.LBL_Emp);
            this.GRP_Emp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRP_Emp.Location = new System.Drawing.Point(0, 0);
            this.GRP_Emp.LookAndFeel.SkinName = "Office 2010 Silver";
            this.GRP_Emp.LookAndFeel.UseDefaultLookAndFeel = false;
            this.GRP_Emp.Name = "GRP_Emp";
            this.GRP_Emp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GRP_Emp.Size = new System.Drawing.Size(609, 384);
            this.GRP_Emp.TabIndex = 0;
            this.GRP_Emp.Text = "EMPLOYEE";
            // 
            // BTN_New
            // 
            this.BTN_New.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTN_New.Location = new System.Drawing.Point(38, 161);
            this.BTN_New.Name = "BTN_New";
            this.BTN_New.Size = new System.Drawing.Size(75, 23);
            this.BTN_New.TabIndex = 28;
            this.BTN_New.Text = "New";
            this.BTN_New.UseVisualStyleBackColor = true;
            this.BTN_New.Click += new System.EventHandler(this.BTN_New_Click);
            // 
            // TE_EmpSalary
            // 
            this.TE_EmpSalary.Location = new System.Drawing.Point(451, 95);
            this.TE_EmpSalary.Name = "TE_EmpSalary";
            this.TE_EmpSalary.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TE_EmpSalary.Properties.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TE_EmpSalary_Properties_KeyPress);
            this.TE_EmpSalary.Size = new System.Drawing.Size(100, 20);
            this.TE_EmpSalary.TabIndex = 27;
            // 
            // TE_EmpMobile
            // 
            this.TE_EmpMobile.EditValue = "";
            this.TE_EmpMobile.Location = new System.Drawing.Point(128, 125);
            this.TE_EmpMobile.Name = "TE_EmpMobile";
            this.TE_EmpMobile.Properties.Mask.EditMask = "d";
            this.TE_EmpMobile.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TE_EmpMobile.Properties.MaxLength = 10;
            this.TE_EmpMobile.Size = new System.Drawing.Size(153, 20);
            this.TE_EmpMobile.TabIndex = 26;
            this.TE_EmpMobile.EditValueChanged += new System.EventHandler(this.TE_EmpMobile_EditValueChanged);
            this.TE_EmpMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TE_EmpMobile_KeyPress);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(390, 161);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(75, 23);
            this.BTN_Delete.TabIndex = 25;
            this.BTN_Delete.Text = "Delete";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Location = new System.Drawing.Point(266, 161);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(75, 23);
            this.BTN_Edit.TabIndex = 24;
            this.BTN_Edit.Text = "Edit";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // GR_Employee
            // 
            this.GR_Employee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GR_Employee.Location = new System.Drawing.Point(2, 198);
            this.GR_Employee.LookAndFeel.SkinName = "Office 2010 Blue";
            this.GR_Employee.LookAndFeel.UseDefaultLookAndFeel = false;
            this.GR_Employee.MainView = this.GV_Employee;
            this.GR_Employee.Name = "GR_Employee";
            this.GR_Employee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemHyperLinkEdit2});
            this.GR_Employee.Size = new System.Drawing.Size(605, 184);
            this.GR_Employee.TabIndex = 22;
            this.GR_Employee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Employee});
            this.GR_Employee.DoubleClick += new System.EventHandler(this.GR_Employee_DoubleClick);
            // 
            // GV_Employee
            // 
            this.GV_Employee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.COL_EMPNO,
            this.COL_EmpName,
            this.COL_EmpDOB,
            this.COL_EmpDOJ,
            this.COL_EmpDepartment,
            this.COL_EmpDesignation,
            this.COL_EmpSalary,
            this.COL_EmpMobile,
            this.COL_EmpCity});
            this.GV_Employee.GridControl = this.GR_Employee;
            this.GV_Employee.Name = "GV_Employee";
            this.GV_Employee.OptionsView.ColumnAutoWidth = false;
            this.GV_Employee.OptionsView.ShowGroupPanel = false;
            // 
            // COL_EMPNO
            // 
            this.COL_EMPNO.Caption = "S.NO";
            this.COL_EMPNO.FieldName = "SerialNumber";
            this.COL_EMPNO.Name = "COL_EMPNO";
            this.COL_EMPNO.OptionsColumn.AllowEdit = false;
            this.COL_EMPNO.Visible = true;
            this.COL_EMPNO.VisibleIndex = 0;
            this.COL_EMPNO.Width = 35;
            // 
            // COL_EmpName
            // 
            this.COL_EmpName.Caption = "Name";
            this.COL_EmpName.FieldName = "EmployeeName";
            this.COL_EmpName.Name = "COL_EmpName";
            this.COL_EmpName.OptionsColumn.AllowEdit = false;
            this.COL_EmpName.Visible = true;
            this.COL_EmpName.VisibleIndex = 1;
            this.COL_EmpName.Width = 79;
            // 
            // COL_EmpDOB
            // 
            this.COL_EmpDOB.Caption = "DOB";
            this.COL_EmpDOB.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.COL_EmpDOB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.COL_EmpDOB.FieldName = "EmployeeDOB";
            this.COL_EmpDOB.Name = "COL_EmpDOB";
            this.COL_EmpDOB.OptionsColumn.AllowEdit = false;
            this.COL_EmpDOB.Visible = true;
            this.COL_EmpDOB.VisibleIndex = 2;
            this.COL_EmpDOB.Width = 102;
            // 
            // COL_EmpDOJ
            // 
            this.COL_EmpDOJ.Caption = "DOJ";
            this.COL_EmpDOJ.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.COL_EmpDOJ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.COL_EmpDOJ.FieldName = "EmployeeDOJ";
            this.COL_EmpDOJ.Name = "COL_EmpDOJ";
            this.COL_EmpDOJ.OptionsColumn.AllowEdit = false;
            this.COL_EmpDOJ.Visible = true;
            this.COL_EmpDOJ.VisibleIndex = 3;
            // 
            // COL_EmpDepartment
            // 
            this.COL_EmpDepartment.Caption = "Department";
            this.COL_EmpDepartment.FieldName = "EmployeeDepartment";
            this.COL_EmpDepartment.Name = "COL_EmpDepartment";
            this.COL_EmpDepartment.OptionsColumn.AllowEdit = false;
            this.COL_EmpDepartment.Visible = true;
            this.COL_EmpDepartment.VisibleIndex = 4;
            this.COL_EmpDepartment.Width = 113;
            // 
            // COL_EmpDesignation
            // 
            this.COL_EmpDesignation.Caption = "Designation";
            this.COL_EmpDesignation.FieldName = "EmployeeDesignation";
            this.COL_EmpDesignation.Name = "COL_EmpDesignation";
            this.COL_EmpDesignation.OptionsColumn.AllowEdit = false;
            this.COL_EmpDesignation.Visible = true;
            this.COL_EmpDesignation.VisibleIndex = 5;
            this.COL_EmpDesignation.Width = 91;
            // 
            // COL_EmpSalary
            // 
            this.COL_EmpSalary.Caption = "Salary";
            this.COL_EmpSalary.DisplayFormat.FormatString = "0.0000";
            this.COL_EmpSalary.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.COL_EmpSalary.FieldName = "EmployeeSalary";
            this.COL_EmpSalary.Name = "COL_EmpSalary";
            this.COL_EmpSalary.OptionsColumn.AllowEdit = false;
            this.COL_EmpSalary.Visible = true;
            this.COL_EmpSalary.VisibleIndex = 6;
            // 
            // COL_EmpMobile
            // 
            this.COL_EmpMobile.Caption = "Mobile";
            this.COL_EmpMobile.FieldName = "EmployeeMobile";
            this.COL_EmpMobile.Name = "COL_EmpMobile";
            this.COL_EmpMobile.OptionsColumn.AllowEdit = false;
            this.COL_EmpMobile.Visible = true;
            this.COL_EmpMobile.VisibleIndex = 7;
            // 
            // COL_EmpCity
            // 
            this.COL_EmpCity.Caption = "City";
            this.COL_EmpCity.FieldName = "EmployeeCity";
            this.COL_EmpCity.Name = "COL_EmpCity";
            this.COL_EmpCity.OptionsColumn.AllowEdit = false;
            this.COL_EmpCity.Visible = true;
            this.COL_EmpCity.VisibleIndex = 8;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // repositoryItemHyperLinkEdit2
            // 
            this.repositoryItemHyperLinkEdit2.AutoHeight = false;
            this.repositoryItemHyperLinkEdit2.Name = "repositoryItemHyperLinkEdit2";
            // 
            // CMB_EmpCity
            // 
            this.CMB_EmpCity.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.CMB_EmpCity.EditValue = "<SELECT CITY>";
            this.CMB_EmpCity.Location = new System.Drawing.Point(451, 125);
            this.CMB_EmpCity.Name = "CMB_EmpCity";
            this.CMB_EmpCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CMB_EmpCity.Properties.Items.AddRange(new object[] {
            "Indore",
            "Bhopal",
            "Delhi",
            "Mumbai"});
            this.CMB_EmpCity.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CMB_EmpCity.Size = new System.Drawing.Size(100, 20);
            this.CMB_EmpCity.TabIndex = 21;
            // 
            // DTP_EmpDOJ
            // 
            this.DTP_EmpDOJ.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_EmpDOJ.Location = new System.Drawing.Point(451, 69);
            this.DTP_EmpDOJ.Name = "DTP_EmpDOJ";
            this.DTP_EmpDOJ.Size = new System.Drawing.Size(100, 20);
            this.DTP_EmpDOJ.TabIndex = 20;
            // 
            // DTP_EmpDOB
            // 
            this.DTP_EmpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_EmpDOB.Location = new System.Drawing.Point(451, 37);
            this.DTP_EmpDOB.Name = "DTP_EmpDOB";
            this.DTP_EmpDOB.Size = new System.Drawing.Size(98, 20);
            this.DTP_EmpDOB.TabIndex = 19;
            // 
            // TB_EmpDesignation
            // 
            this.TB_EmpDesignation.Location = new System.Drawing.Point(128, 95);
            this.TB_EmpDesignation.MaxLength = 50;
            this.TB_EmpDesignation.Name = "TB_EmpDesignation";
            this.TB_EmpDesignation.Size = new System.Drawing.Size(153, 20);
            this.TB_EmpDesignation.TabIndex = 15;
            // 
            // TB_EmpDepartment
            // 
            this.TB_EmpDepartment.Location = new System.Drawing.Point(128, 69);
            this.TB_EmpDepartment.Name = "TB_EmpDepartment";
            this.TB_EmpDepartment.Size = new System.Drawing.Size(153, 20);
            this.TB_EmpDepartment.TabIndex = 13;
            // 
            // TB_EmpName
            // 
            this.TB_EmpName.Location = new System.Drawing.Point(128, 37);
            this.TB_EmpName.Name = "TB_EmpName";
            this.TB_EmpName.Size = new System.Drawing.Size(153, 20);
            this.TB_EmpName.TabIndex = 11;
            // 
            // BTN_Showdetail
            // 
            this.BTN_Showdetail.Location = new System.Drawing.Point(513, 161);
            this.BTN_Showdetail.Name = "BTN_Showdetail";
            this.BTN_Showdetail.Size = new System.Drawing.Size(75, 23);
            this.BTN_Showdetail.TabIndex = 10;
            this.BTN_Showdetail.Text = "Show detail";
            this.BTN_Showdetail.UseVisualStyleBackColor = true;
            this.BTN_Showdetail.Click += new System.EventHandler(this.BTN_Showdetail_Click);
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(152, 161);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(75, 23);
            this.BTN_Save.TabIndex = 8;
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee Mobile*";
            // 
            // LBL_EmpCity
            // 
            this.LBL_EmpCity.AutoSize = true;
            this.LBL_EmpCity.Location = new System.Drawing.Point(341, 128);
            this.LBL_EmpCity.Name = "LBL_EmpCity";
            this.LBL_EmpCity.Size = new System.Drawing.Size(77, 13);
            this.LBL_EmpCity.TabIndex = 7;
            this.LBL_EmpCity.Text = "Employee City*";
            // 
            // LBL_EmpSalary
            // 
            this.LBL_EmpSalary.AutoSize = true;
            this.LBL_EmpSalary.Location = new System.Drawing.Point(341, 98);
            this.LBL_EmpSalary.Name = "LBL_EmpSalary";
            this.LBL_EmpSalary.Size = new System.Drawing.Size(89, 13);
            this.LBL_EmpSalary.TabIndex = 5;
            this.LBL_EmpSalary.Text = "Employee Salary*";
            // 
            // LBL_EmpDesignation
            // 
            this.LBL_EmpDesignation.AutoSize = true;
            this.LBL_EmpDesignation.Location = new System.Drawing.Point(12, 98);
            this.LBL_EmpDesignation.Name = "LBL_EmpDesignation";
            this.LBL_EmpDesignation.Size = new System.Drawing.Size(112, 13);
            this.LBL_EmpDesignation.TabIndex = 4;
            this.LBL_EmpDesignation.Text = "Employee Designation";
            // 
            // LBL_EmpDepartment
            // 
            this.LBL_EmpDepartment.AutoSize = true;
            this.LBL_EmpDepartment.Location = new System.Drawing.Point(12, 72);
            this.LBL_EmpDepartment.Name = "LBL_EmpDepartment";
            this.LBL_EmpDepartment.Size = new System.Drawing.Size(115, 13);
            this.LBL_EmpDepartment.TabIndex = 3;
            this.LBL_EmpDepartment.Text = "Employee Department*";
            // 
            // LBL_EmpDOJ
            // 
            this.LBL_EmpDOJ.AutoSize = true;
            this.LBL_EmpDOJ.Location = new System.Drawing.Point(341, 72);
            this.LBL_EmpDOJ.Name = "LBL_EmpDOJ";
            this.LBL_EmpDOJ.Size = new System.Drawing.Size(81, 13);
            this.LBL_EmpDOJ.TabIndex = 2;
            this.LBL_EmpDOJ.Text = "Employee DOJ*";
            // 
            // LBL_EmpDOB
            // 
            this.LBL_EmpDOB.AutoSize = true;
            this.LBL_EmpDOB.Location = new System.Drawing.Point(341, 41);
            this.LBL_EmpDOB.Name = "LBL_EmpDOB";
            this.LBL_EmpDOB.Size = new System.Drawing.Size(83, 13);
            this.LBL_EmpDOB.TabIndex = 1;
            this.LBL_EmpDOB.Text = "Employee DOB*";
            // 
            // LBL_Emp
            // 
            this.LBL_Emp.AutoSize = true;
            this.LBL_Emp.Location = new System.Drawing.Point(12, 37);
            this.LBL_Emp.Name = "LBL_Emp";
            this.LBL_Emp.Size = new System.Drawing.Size(88, 13);
            this.LBL_Emp.TabIndex = 0;
            this.LBL_Emp.Text = "Employee Name*";
            // 
            // FRM_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 384);
            this.Controls.Add(this.GRP_Emp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.GRP_Emp)).EndInit();
            this.GRP_Emp.ResumeLayout(false);
            this.GRP_Emp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TE_EmpSalary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_EmpMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GR_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMB_EmpCity.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GRP_Emp;
        private System.Windows.Forms.TextBox TB_EmpDesignation;
        private System.Windows.Forms.TextBox TB_EmpDepartment;
        private System.Windows.Forms.TextBox TB_EmpName;
        private System.Windows.Forms.Button BTN_Showdetail;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Label LBL_EmpCity;
        private System.Windows.Forms.Label LBL_EmpSalary;
        private System.Windows.Forms.Label LBL_EmpDesignation;
        private System.Windows.Forms.Label LBL_EmpDepartment;
        private System.Windows.Forms.Label LBL_EmpDOJ;
        private System.Windows.Forms.Label LBL_EmpDOB;
        private System.Windows.Forms.Label LBL_Emp;
        private System.Windows.Forms.DateTimePicker DTP_EmpDOB;
        private System.Windows.Forms.DateTimePicker DTP_EmpDOJ;
        private DevExpress.XtraEditors.ComboBoxEdit CMB_EmpCity;
        private DevExpress.XtraGrid.GridControl GR_Employee;
        private DevExpress.XtraGrid.Views.Grid.GridView GV_Employee;
        private DevExpress.XtraGrid.Columns.GridColumn COL_EmpName;
        private DevExpress.XtraGrid.Columns.GridColumn COL_EmpDOB;
        private DevExpress.XtraGrid.Columns.GridColumn COL_EmpDOJ;
        private DevExpress.XtraGrid.Columns.GridColumn COL_EmpDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn COL_EmpDesignation;
        private DevExpress.XtraGrid.Columns.GridColumn COL_EmpSalary;
        private DevExpress.XtraGrid.Columns.GridColumn COL_EmpMobile;
        private DevExpress.XtraGrid.Columns.GridColumn COL_EmpCity;
        private DevExpress.XtraGrid.Columns.GridColumn COL_EMPNO;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Button BTN_Delete;
        private DevExpress.XtraEditors.TextEdit TE_EmpSalary;
        private DevExpress.XtraEditors.TextEdit TE_EmpMobile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_New;

    }
}

