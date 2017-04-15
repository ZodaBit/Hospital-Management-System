namespace HospitalMS
{
    partial class AllPatientsForm
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
            this.gvAllPatients = new DevExpress.XtraGrid.GridControl();
            this.foPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaternalState = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvAllPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvAllPatients
            // 
            this.gvAllPatients.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvAllPatients.DataSource = this.foPatientBindingSource;
            this.gvAllPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvAllPatients.Location = new System.Drawing.Point(0, 0);
            this.gvAllPatients.MainView = this.gridView1;
            this.gvAllPatients.Name = "gvAllPatients";
            this.gvAllPatients.Size = new System.Drawing.Size(788, 437);
            this.gvAllPatients.TabIndex = 0;
            this.gvAllPatients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gvAllPatients.Click += new System.EventHandler(this.gvAllPatients_Click);
            // 
            // foPatientBindingSource
            // 
            this.foPatientBindingSource.DataSource = typeof(HospitalMS.foPatient);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFirstName,
            this.colMiddleName,
            this.colLastName,
            this.colSex,
            this.colDateOfBirth,
            this.colPhone,
            this.colMobile,
            this.colEmail,
            this.colAge,
            this.colMaternalState});
            this.gridView1.GridControl = this.gvAllPatients;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colMiddleName
            // 
            this.colMiddleName.FieldName = "MiddleName";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.Visible = true;
            this.colMiddleName.VisibleIndex = 2;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 3;
            // 
            // colSex
            // 
            this.colSex.FieldName = "Sex";
            this.colSex.Name = "colSex";
            this.colSex.Visible = true;
            this.colSex.VisibleIndex = 4;
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.FieldName = "DateOfBirth";
            this.colDateOfBirth.Name = "colDateOfBirth";
            this.colDateOfBirth.Visible = true;
            this.colDateOfBirth.VisibleIndex = 5;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 6;
            // 
            // colMobile
            // 
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 7;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 8;
            // 
            // colAge
            // 
            this.colAge.FieldName = "Age";
            this.colAge.Name = "colAge";
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 9;
            // 
            // colMaternalState
            // 
            this.colMaternalState.FieldName = "MaternalState";
            this.colMaternalState.Name = "colMaternalState";
            this.colMaternalState.Visible = true;
            this.colMaternalState.VisibleIndex = 10;
            // 
            // AllPatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 437);
            this.Controls.Add(this.gvAllPatients);
            this.Name = "AllPatientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAllPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gvAllPatients;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource foPatientBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
        private DevExpress.XtraGrid.Columns.GridColumn colMaternalState;
    }
}