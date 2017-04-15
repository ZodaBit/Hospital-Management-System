namespace HospitalMS
{
    partial class bedwards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bedwards));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl17 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl18 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl75 = new DevExpress.XtraEditors.PanelControl();
            this.roomstatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelControl74 = new DevExpress.XtraEditors.PanelControl();
            this.label24 = new System.Windows.Forms.Label();
            this.roomid = new DevExpress.XtraEditors.SpinEdit();
            this.toolStrip8 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton31 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton32 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton33 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton34 = new System.Windows.Forms.ToolStripButton();
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
            this.assignedfor = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl17)).BeginInit();
            this.panelControl17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl18)).BeginInit();
            this.panelControl18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl75)).BeginInit();
            this.panelControl75.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomstatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl74)).BeginInit();
            this.panelControl74.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomid.Properties)).BeginInit();
            this.toolStrip8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignedfor.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedfor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl17);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1063, 541);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Bed/Ward Requst";
            // 
            // panelControl17
            // 
            this.panelControl17.Controls.Add(this.panelControl18);
            this.panelControl17.Controls.Add(this.toolStrip8);
            this.panelControl17.Location = new System.Drawing.Point(18, 117);
            this.panelControl17.Name = "panelControl17";
            this.panelControl17.Size = new System.Drawing.Size(974, 484);
            this.panelControl17.TabIndex = 45;
            // 
            // panelControl18
            // 
            this.panelControl18.Controls.Add(this.panelControl75);
            this.panelControl18.Controls.Add(this.panelControl74);
            this.panelControl18.Location = new System.Drawing.Point(14, 30);
            this.panelControl18.Name = "panelControl18";
            this.panelControl18.Size = new System.Drawing.Size(923, 267);
            this.panelControl18.TabIndex = 27;
            // 
            // panelControl75
            // 
            this.panelControl75.Controls.Add(this.roomstatus);
            this.panelControl75.Controls.Add(this.label20);
            this.panelControl75.Controls.Add(this.label14);
            this.panelControl75.Controls.Add(this.assignedfor);
            this.panelControl75.Location = new System.Drawing.Point(5, 89);
            this.panelControl75.Name = "panelControl75";
            this.panelControl75.Size = new System.Drawing.Size(436, 91);
            this.panelControl75.TabIndex = 53;
            // 
            // roomstatus
            // 
            this.roomstatus.Location = new System.Drawing.Point(94, 50);
            this.roomstatus.Name = "roomstatus";
            this.roomstatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.roomstatus.Properties.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th"});
            this.roomstatus.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.roomstatus.Size = new System.Drawing.Size(190, 20);
            this.roomstatus.TabIndex = 52;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "AssignFor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Room Status";
            // 
            // panelControl74
            // 
            this.panelControl74.Controls.Add(this.label24);
            this.panelControl74.Controls.Add(this.roomid);
            this.panelControl74.Location = new System.Drawing.Point(5, 14);
            this.panelControl74.Name = "panelControl74";
            this.panelControl74.Size = new System.Drawing.Size(284, 46);
            this.panelControl74.TabIndex = 52;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 22);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 13);
            this.label24.TabIndex = 26;
            this.label24.Text = "RoomID";
            // 
            // roomid
            // 
            this.roomid.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.roomid.Location = new System.Drawing.Point(85, 15);
            this.roomid.Name = "roomid";
            this.roomid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.roomid.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.roomid.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.roomid.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.roomid.Size = new System.Drawing.Size(190, 20);
            this.roomid.TabIndex = 27;
            // 
            // toolStrip8
            // 
            this.toolStrip8.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton31,
            this.toolStripButton32,
            this.toolStripButton33,
            this.toolStripButton34});
            this.toolStrip8.Location = new System.Drawing.Point(2, 2);
            this.toolStrip8.Name = "toolStrip8";
            this.toolStrip8.Size = new System.Drawing.Size(970, 25);
            this.toolStrip8.TabIndex = 25;
            this.toolStrip8.Text = "toolStrip8";
            // 
            // toolStripButton31
            // 
            this.toolStripButton31.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton31.Image")));
            this.toolStripButton31.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton31.Name = "toolStripButton31";
            this.toolStripButton31.Size = new System.Drawing.Size(51, 22);
            this.toolStripButton31.Text = "Save";
            this.toolStripButton31.Click += new System.EventHandler(this.toolStripButton31_Click);
            // 
            // toolStripButton32
            // 
            this.toolStripButton32.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton32.Image")));
            this.toolStripButton32.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton32.Name = "toolStripButton32";
            this.toolStripButton32.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton32.Text = "Edit";
            this.toolStripButton32.Click += new System.EventHandler(this.toolStripButton32_Click);
            // 
            // toolStripButton33
            // 
            this.toolStripButton33.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton33.Image")));
            this.toolStripButton33.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton33.Name = "toolStripButton33";
            this.toolStripButton33.Size = new System.Drawing.Size(67, 22);
            this.toolStripButton33.Text = "Deleted";
            this.toolStripButton33.Click += new System.EventHandler(this.toolStripButton33_Click);
            // 
            // toolStripButton34
            // 
            this.toolStripButton34.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton34.Image")));
            this.toolStripButton34.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton34.Name = "toolStripButton34";
            this.toolStripButton34.Size = new System.Drawing.Size(54, 22);
            this.toolStripButton34.Text = "Clear";
            this.toolStripButton34.Click += new System.EventHandler(this.toolStripButton34_Click);
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
            this.panelControl1.Location = new System.Drawing.Point(12, 34);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1039, 77);
            this.panelControl1.TabIndex = 44;
            // 
            // paitentid
            // 
            this.paitentid.Location = new System.Drawing.Point(938, 10);
            this.paitentid.Name = "paitentid";
            this.paitentid.Size = new System.Drawing.Size(0, 13);
            this.paitentid.TabIndex = 32;
            // 
            // physicianname
            // 
            this.physicianname.Location = new System.Drawing.Point(691, 40);
            this.physicianname.Name = "physicianname";
            this.physicianname.Size = new System.Drawing.Size(0, 13);
            this.physicianname.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(919, 11);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(13, 15);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "ID";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Location = new System.Drawing.Point(600, 39);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(85, 15);
            this.labelControl18.TabIndex = 10;
            this.labelControl18.Text = "Physician Name";
            // 
            // dates
            // 
            this.dates.Location = new System.Drawing.Point(691, 9);
            this.dates.Name = "dates";
            this.dates.Size = new System.Drawing.Size(0, 13);
            this.dates.TabIndex = 9;
            // 
            // Date
            // 
            this.Date.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(600, 9);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(25, 15);
            this.Date.TabIndex = 8;
            this.Date.Text = "Date";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(347, 43);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(0, 13);
            this.Age.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(321, 40);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(20, 15);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Age";
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(347, 13);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(0, 13);
            this.sex.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(321, 12);
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
            // assignedfor
            // 
            this.assignedfor.EditValue = null;
            this.assignedfor.Location = new System.Drawing.Point(94, 15);
            this.assignedfor.Name = "assignedfor";
            this.assignedfor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.assignedfor.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.assignedfor.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.assignedfor.Properties.Mask.EditMask = "";
            this.assignedfor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.assignedfor.Size = new System.Drawing.Size(190, 20);
            this.assignedfor.TabIndex = 50;
            // 
            // bedwards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 541);
            this.Controls.Add(this.groupControl1);
            this.Name = "bedwards";
            this.Text = "bedwards";
            this.Load += new System.EventHandler(this.bedwards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl17)).EndInit();
            this.panelControl17.ResumeLayout(false);
            this.panelControl17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl18)).EndInit();
            this.panelControl18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl75)).EndInit();
            this.panelControl75.ResumeLayout(false);
            this.panelControl75.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomstatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl74)).EndInit();
            this.panelControl74.ResumeLayout(false);
            this.panelControl74.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomid.Properties)).EndInit();
            this.toolStrip8.ResumeLayout(false);
            this.toolStrip8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignedfor.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedfor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
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
        private DevExpress.XtraEditors.LabelControl name;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl17;
        private DevExpress.XtraEditors.PanelControl panelControl18;
        private DevExpress.XtraEditors.PanelControl panelControl75;
        private DevExpress.XtraEditors.ComboBoxEdit roomstatus;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.PanelControl panelControl74;
        private System.Windows.Forms.Label label24;
        private DevExpress.XtraEditors.SpinEdit roomid;
        private System.Windows.Forms.ToolStrip toolStrip8;
        private System.Windows.Forms.ToolStripButton toolStripButton31;
        private System.Windows.Forms.ToolStripButton toolStripButton32;
        private System.Windows.Forms.ToolStripButton toolStripButton33;
        private System.Windows.Forms.ToolStripButton toolStripButton34;
        private DevExpress.XtraEditors.DateEdit assignedfor;
    }
}