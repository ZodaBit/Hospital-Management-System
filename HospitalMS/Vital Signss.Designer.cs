namespace HospitalMS
{
    partial class Vital_Signss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vital_Signss));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.toolStrip32 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton131 = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.paitentid = new DevExpress.XtraEditors.LabelControl();
            this.physicianname = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.dates = new DevExpress.XtraEditors.LabelControl();
            this.Date = new DevExpress.XtraEditors.LabelControl();
            this.Age = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.sex = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.fathername = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.name = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.toolStrip32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(12, 121);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1131, 451);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // toolStrip32
            // 
            this.toolStrip32.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip32.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton131});
            this.toolStrip32.Location = new System.Drawing.Point(0, 0);
            this.toolStrip32.Name = "toolStrip32";
            this.toolStrip32.Size = new System.Drawing.Size(1143, 25);
            this.toolStrip32.TabIndex = 39;
            this.toolStrip32.Text = "toolStrip32";
            // 
            // toolStripButton131
            // 
            this.toolStripButton131.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton131.Image")));
            this.toolStripButton131.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton131.Name = "toolStripButton131";
            this.toolStripButton131.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton131.Text = "Print";
            this.toolStripButton131.Click += new System.EventHandler(this.toolStripButton131_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.paitentid);
            this.panelControl1.Controls.Add(this.physicianname);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl18);
            this.panelControl1.Controls.Add(this.dates);
            this.panelControl1.Controls.Add(this.Date);
            this.panelControl1.Controls.Add(this.Age);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.sex);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.fathername);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.name);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 38);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1088, 77);
            this.panelControl1.TabIndex = 41;
            // 
            // paitentid
            // 
            this.paitentid.Location = new System.Drawing.Point(964, 9);
            this.paitentid.Name = "paitentid";
            this.paitentid.Size = new System.Drawing.Size(6, 13);
            this.paitentid.TabIndex = 32;
            this.paitentid.Text = "0";
            // 
            // physicianname
            // 
            this.physicianname.Location = new System.Drawing.Point(719, 44);
            this.physicianname.Name = "physicianname";
            this.physicianname.Size = new System.Drawing.Size(0, 13);
            this.physicianname.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(945, 10);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(13, 15);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "ID";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Location = new System.Drawing.Point(628, 43);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(85, 15);
            this.labelControl18.TabIndex = 10;
            this.labelControl18.Text = "Physician Name";
            // 
            // dates
            // 
            this.dates.Location = new System.Drawing.Point(719, 13);
            this.dates.Name = "dates";
            this.dates.Size = new System.Drawing.Size(0, 13);
            this.dates.TabIndex = 9;
            // 
            // Date
            // 
            this.Date.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(628, 13);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(25, 15);
            this.Date.TabIndex = 8;
            this.Date.Text = "Date";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(361, 42);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(0, 13);
            this.Age.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(335, 39);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(20, 15);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Age";
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(361, 12);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(0, 13);
            this.sex.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(335, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 15);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Sex";
            // 
            // fathername
            // 
            this.fathername.Location = new System.Drawing.Point(84, 42);
            this.fathername.Name = "fathername";
            this.fathername.Size = new System.Drawing.Size(0, 13);
            this.fathername.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(6, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 15);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Father Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(84, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 13);
            this.name.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(6, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 15);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Name";
            // 
            // Vital_Signss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 498);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip32);
            this.Controls.Add(this.gridControl1);
            this.Name = "Vital_Signss";
            this.Text = "Vital_Signss";
            this.Load += new System.EventHandler(this.Vital_Signss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.toolStrip32.ResumeLayout(false);
            this.toolStrip32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private System.Windows.Forms.ToolStrip toolStrip32;
        private System.Windows.Forms.ToolStripButton toolStripButton131;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl paitentid;
        private DevExpress.XtraEditors.LabelControl physicianname;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl dates;
        private DevExpress.XtraEditors.LabelControl Date;
        private DevExpress.XtraEditors.LabelControl Age;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl sex;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl fathername;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.LabelControl name;


    }
}