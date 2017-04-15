namespace HospitalMS
{
    partial class Labrprt
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.uperbund = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lwrbund = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.normalrange = new DevExpress.XtraEditors.LabelControl();
            this.labelControl120 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl123 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.result = new DevExpress.XtraEditors.TextEdit();
            this.labelControl102 = new DevExpress.XtraEditors.LabelControl();
            this.unit = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.subentity = new DevExpress.XtraEditors.TextEdit();
            this.investigationentity = new DevExpress.XtraEditors.TextEdit();
            this.InvestigationType = new DevExpress.XtraEditors.TextEdit();
            this.status = new DevExpress.XtraEditors.TextEdit();
            this.description = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subentity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investigationentity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvestigationType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.description.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataGridView1);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1118, 541);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "LabResult";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1114, 374);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1114, 144);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.description);
            this.panelControl2.Controls.Add(this.uperbund);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Controls.Add(this.lwrbund);
            this.panelControl2.Controls.Add(this.labelControl11);
            this.panelControl2.Controls.Add(this.normalrange);
            this.panelControl2.Controls.Add(this.labelControl120);
            this.panelControl2.Controls.Add(this.labelControl123);
            this.panelControl2.Controls.Add(this.labelControl13);
            this.panelControl2.Controls.Add(this.result);
            this.panelControl2.Controls.Add(this.labelControl102);
            this.panelControl2.Controls.Add(this.unit);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.subentity);
            this.panelControl2.Controls.Add(this.investigationentity);
            this.panelControl2.Controls.Add(this.InvestigationType);
            this.panelControl2.Controls.Add(this.status);
            this.panelControl2.Location = new System.Drawing.Point(10, 15);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1091, 116);
            this.panelControl2.TabIndex = 41;
            // 
            // uperbund
            // 
            this.uperbund.Location = new System.Drawing.Point(453, 39);
            this.uperbund.Name = "uperbund";
            this.uperbund.Size = new System.Drawing.Size(13, 13);
            this.uperbund.TabIndex = 63;
            this.uperbund.Text = "UB";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(434, 39);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(13, 13);
            this.labelControl10.TabIndex = 62;
            this.labelControl10.Text = "UB";
            // 
            // lwrbund
            // 
            this.lwrbund.Location = new System.Drawing.Point(335, 39);
            this.lwrbund.Name = "lwrbund";
            this.lwrbund.Size = new System.Drawing.Size(63, 13);
            this.lwrbund.TabIndex = 61;
            this.lwrbund.Text = "labelControl8";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(605, 8);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(53, 13);
            this.labelControl11.TabIndex = 56;
            this.labelControl11.Text = "Description";
            // 
            // normalrange
            // 
            this.normalrange.Location = new System.Drawing.Point(318, 39);
            this.normalrange.Name = "normalrange";
            this.normalrange.Size = new System.Drawing.Size(11, 13);
            this.normalrange.TabIndex = 31;
            this.normalrange.Text = "LB";
            // 
            // labelControl120
            // 
            this.labelControl120.Location = new System.Drawing.Point(288, 71);
            this.labelControl120.Name = "labelControl120";
            this.labelControl120.Size = new System.Drawing.Size(97, 13);
            this.labelControl120.TabIndex = 25;
            this.labelControl120.Text = "Investigation Status";
            // 
            // labelControl123
            // 
            this.labelControl123.Location = new System.Drawing.Point(16, 8);
            this.labelControl123.Name = "labelControl123";
            this.labelControl123.Size = new System.Drawing.Size(87, 13);
            this.labelControl123.TabIndex = 29;
            this.labelControl123.Text = "InvestigationType";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(16, 76);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(49, 13);
            this.labelControl13.TabIndex = 59;
            this.labelControl13.Text = "Sub Entity";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(322, 5);
            this.result.Name = "result";
            this.result.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.result.Size = new System.Drawing.Size(158, 20);
            this.result.TabIndex = 28;
            // 
            // labelControl102
            // 
            this.labelControl102.Location = new System.Drawing.Point(16, 43);
            this.labelControl102.Name = "labelControl102";
            this.labelControl102.Size = new System.Drawing.Size(94, 13);
            this.labelControl102.TabIndex = 3;
            this.labelControl102.Text = "Investigation Entity";
            // 
            // unit
            // 
            this.unit.Location = new System.Drawing.Point(486, 12);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(19, 13);
            this.unit.TabIndex = 57;
            this.unit.Text = "Unit";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(286, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Result";
            // 
            // subentity
            // 
            this.subentity.Location = new System.Drawing.Point(122, 68);
            this.subentity.Name = "subentity";
            this.subentity.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.subentity.Size = new System.Drawing.Size(158, 20);
            this.subentity.TabIndex = 60;
            // 
            // investigationentity
            // 
            this.investigationentity.Location = new System.Drawing.Point(122, 36);
            this.investigationentity.Name = "investigationentity";
            this.investigationentity.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.investigationentity.Size = new System.Drawing.Size(158, 20);
            this.investigationentity.TabIndex = 30;
            // 
            // InvestigationType
            // 
            this.InvestigationType.Location = new System.Drawing.Point(122, 5);
            this.InvestigationType.Name = "InvestigationType";
            this.InvestigationType.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.InvestigationType.Size = new System.Drawing.Size(158, 20);
            this.InvestigationType.TabIndex = 25;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(391, 64);
            this.status.Name = "status";
            this.status.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.status.Size = new System.Drawing.Size(158, 20);
            this.status.TabIndex = 58;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(664, 10);
            this.description.Name = "description";
            this.description.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.description.Size = new System.Drawing.Size(406, 96);
            this.description.TabIndex = 64;
            // 
            // Labrprt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 541);
            this.Controls.Add(this.groupControl1);
            this.Name = "Labrprt";
            this.Text = "LabReport";
            this.Load += new System.EventHandler(this.Labrprt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subentity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investigationentity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvestigationType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.description.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl uperbund;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl lwrbund;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl normalrange;
        private DevExpress.XtraEditors.LabelControl labelControl120;
        private DevExpress.XtraEditors.LabelControl labelControl123;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit result;
        private DevExpress.XtraEditors.LabelControl labelControl102;
        private DevExpress.XtraEditors.LabelControl unit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit subentity;
        private DevExpress.XtraEditors.TextEdit investigationentity;
        private DevExpress.XtraEditors.TextEdit InvestigationType;
        private DevExpress.XtraEditors.TextEdit status;
        private DevExpress.XtraEditors.MemoEdit description;
    }
}