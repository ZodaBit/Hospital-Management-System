namespace HospitalMS
{
    partial class Front_Office
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Front_Office));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuPatient = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnNewPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAllPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWaitingList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAppointment = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerRight = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.previusillineseTableAdapter1 = new HospitalMS.HMSDataSet1TableAdapters.PreviusillineseTableAdapter();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.hideContainerRight.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPatient,
            this.btnAppointment,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1196, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // menuPatient
            // 
            this.menuPatient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewPatient,
            this.btnAllPatient,
            this.btnWaitingList});
            this.menuPatient.Image = ((System.Drawing.Image)(resources.GetObject("menuPatient.Image")));
            this.menuPatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuPatient.Name = "menuPatient";
            this.menuPatient.Size = new System.Drawing.Size(73, 22);
            this.menuPatient.Text = "Patient";
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnNewPatient.Image")));
            this.btnNewPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnNewPatient.Size = new System.Drawing.Size(177, 22);
            this.btnNewPatient.Text = "New Paient";
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // btnAllPatient
            // 
            this.btnAllPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnAllPatient.Image")));
            this.btnAllPatient.Name = "btnAllPatient";
            this.btnAllPatient.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.btnAllPatient.Size = new System.Drawing.Size(177, 22);
            this.btnAllPatient.Text = "All Patients";
            this.btnAllPatient.Click += new System.EventHandler(this.btnAllPatient_Click);
            // 
            // btnWaitingList
            // 
            this.btnWaitingList.Image = ((System.Drawing.Image)(resources.GetObject("btnWaitingList.Image")));
            this.btnWaitingList.Name = "btnWaitingList";
            this.btnWaitingList.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.btnWaitingList.Size = new System.Drawing.Size(177, 22);
            this.btnWaitingList.Text = "Waiting List";
            this.btnWaitingList.Click += new System.EventHandler(this.btnWaitingList_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnAppointment.Image")));
            this.btnAppointment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(98, 22);
            this.btnAppointment.Text = "Appointment";
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(105, 22);
            this.toolStripButton1.Text = "Service Charge";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton2.Text = "Bed/ward";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(88, 22);
            this.toolStripButton3.Text = "Reservation";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton4.Text = "Schedule ";
            // 
            // dockManager1
            // 
            this.dockManager1.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerRight});
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // hideContainerRight
            // 
            this.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.hideContainerRight.Controls.Add(this.dockPanel1);
            this.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideContainerRight.Location = new System.Drawing.Point(1196, 0);
            this.hideContainerRight.Name = "hideContainerRight";
            this.hideContainerRight.Size = new System.Drawing.Size(19, 711);
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel1.ID = new System.Guid("7a3af648-84d9-48aa-bb7d-29620517773c");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(253, 200);
            this.dockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel1.SavedIndex = 0;
            this.dockPanel1.Size = new System.Drawing.Size(253, 711);
            this.dockPanel1.Text = "Information Disk";
            this.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(245, 684);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1196, 686);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // previusillineseTableAdapter1
            // 
            this.previusillineseTableAdapter1.ClearBeforeFill = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1196, 25);
            this.toolStrip2.TabIndex = 11;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Action";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Paid ",
            "Hold",
            "Credit "});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // Front_Office
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 711);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.hideContainerRight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Front_Office";
            this.Text = "FrontOffice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Front_Office_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.hideContainerRight.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton menuPatient;
        private System.Windows.Forms.ToolStripMenuItem btnNewPatient;
        private System.Windows.Forms.ToolStripMenuItem btnAllPatient;
        private System.Windows.Forms.ToolStripMenuItem btnWaitingList;
        private System.Windows.Forms.ToolStripButton btnAppointment;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerRight;
        private HMSDataSet1TableAdapters.PreviusillineseTableAdapter previusillineseTableAdapter1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}