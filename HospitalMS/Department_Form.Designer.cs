namespace HospitalMS
{
    partial class Department_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department_Form));
            this.DepNametextbox = new DevExpress.XtraEditors.TextEdit();
            this.panelControl25 = new DevExpress.XtraEditors.PanelControl();
            this.DepRemarkstextbox = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.DepBranchtextbox = new DevExpress.XtraEditors.TextEdit();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.DepartmentIdtextbox = new DevExpress.XtraEditors.TextEdit();
            this.label38 = new System.Windows.Forms.Label();
            this.panelControl24 = new DevExpress.XtraEditors.PanelControl();
            this.toolStrip12 = new System.Windows.Forms.ToolStrip();
            this.SavetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EdittoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeletetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CleartoolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DepNametextbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl25)).BeginInit();
            this.panelControl25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepRemarkstextbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepBranchtextbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentIdtextbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl24)).BeginInit();
            this.panelControl24.SuspendLayout();
            this.toolStrip12.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepNametextbox
            // 
            this.DepNametextbox.Location = new System.Drawing.Point(102, 47);
            this.DepNametextbox.Name = "DepNametextbox";
            this.DepNametextbox.Size = new System.Drawing.Size(190, 20);
            this.DepNametextbox.TabIndex = 29;
            this.DepNametextbox.Click += new System.EventHandler(this.DepNametextbox_Click);
            // 
            // panelControl25
            // 
            this.panelControl25.Controls.Add(this.DepRemarkstextbox);
            this.panelControl25.Controls.Add(this.label1);
            this.panelControl25.Controls.Add(this.DepBranchtextbox);
            this.panelControl25.Controls.Add(this.label36);
            this.panelControl25.Controls.Add(this.DepNametextbox);
            this.panelControl25.Controls.Add(this.label37);
            this.panelControl25.Controls.Add(this.DepartmentIdtextbox);
            this.panelControl25.Controls.Add(this.label38);
            this.panelControl25.Location = new System.Drawing.Point(19, 40);
            this.panelControl25.Name = "panelControl25";
            this.panelControl25.Size = new System.Drawing.Size(344, 168);
            this.panelControl25.TabIndex = 27;
            // 
            // DepRemarkstextbox
            // 
            this.DepRemarkstextbox.Location = new System.Drawing.Point(102, 118);
            this.DepRemarkstextbox.Name = "DepRemarkstextbox";
            this.DepRemarkstextbox.Size = new System.Drawing.Size(190, 20);
            this.DepRemarkstextbox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Remarks";
            // 
            // DepBranchtextbox
            // 
            this.DepBranchtextbox.Location = new System.Drawing.Point(102, 77);
            this.DepBranchtextbox.Name = "DepBranchtextbox";
            this.DepBranchtextbox.Size = new System.Drawing.Size(190, 20);
            this.DepBranchtextbox.TabIndex = 31;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(5, 84);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(41, 13);
            this.label36.TabIndex = 30;
            this.label36.Text = "Branch";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(5, 50);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(93, 13);
            this.label37.TabIndex = 28;
            this.label37.Text = "Department Name";
            // 
            // DepartmentIdtextbox
            // 
            this.DepartmentIdtextbox.Location = new System.Drawing.Point(102, 10);
            this.DepartmentIdtextbox.Name = "DepartmentIdtextbox";
            this.DepartmentIdtextbox.Size = new System.Drawing.Size(190, 20);
            this.DepartmentIdtextbox.TabIndex = 27;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(5, 17);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(73, 13);
            this.label38.TabIndex = 26;
            this.label38.Text = "DepartmentID";
            // 
            // panelControl24
            // 
            this.panelControl24.Controls.Add(this.panelControl25);
            this.panelControl24.Controls.Add(this.toolStrip12);
            this.panelControl24.Location = new System.Drawing.Point(8, 12);
            this.panelControl24.Name = "panelControl24";
            this.panelControl24.Size = new System.Drawing.Size(415, 285);
            this.panelControl24.TabIndex = 6;
            // 
            // toolStrip12
            // 
            this.toolStrip12.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip12.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavetoolStripButton,
            this.EdittoolStripButton,
            this.DeletetoolStripButton,
            this.CleartoolStripButton});
            this.toolStrip12.Location = new System.Drawing.Point(2, 2);
            this.toolStrip12.Name = "toolStrip12";
            this.toolStrip12.Size = new System.Drawing.Size(411, 25);
            this.toolStrip12.TabIndex = 25;
            this.toolStrip12.Text = "toolStrip12";
            // 
            // SavetoolStripButton
            // 
            this.SavetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SavetoolStripButton.Image")));
            this.SavetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SavetoolStripButton.Name = "SavetoolStripButton";
            this.SavetoolStripButton.Size = new System.Drawing.Size(51, 22);
            this.SavetoolStripButton.Text = "Save";
            this.SavetoolStripButton.Click += new System.EventHandler(this.SavetoolStripButton_Click);
            // 
            // EdittoolStripButton
            // 
            this.EdittoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EdittoolStripButton.Image")));
            this.EdittoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EdittoolStripButton.Name = "EdittoolStripButton";
            this.EdittoolStripButton.Size = new System.Drawing.Size(47, 22);
            this.EdittoolStripButton.Text = "Edit";
            this.EdittoolStripButton.Click += new System.EventHandler(this.EdittoolStripButton_Click);
            // 
            // DeletetoolStripButton
            // 
            this.DeletetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeletetoolStripButton.Image")));
            this.DeletetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeletetoolStripButton.Name = "DeletetoolStripButton";
            this.DeletetoolStripButton.Size = new System.Drawing.Size(67, 22);
            this.DeletetoolStripButton.Text = "Deleted";
            this.DeletetoolStripButton.Click += new System.EventHandler(this.DeletetoolStripButton_Click);
            // 
            // CleartoolStripButton
            // 
            this.CleartoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CleartoolStripButton.Image")));
            this.CleartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CleartoolStripButton.Name = "CleartoolStripButton";
            this.CleartoolStripButton.Size = new System.Drawing.Size(54, 22);
            this.CleartoolStripButton.Text = "Clear";
            this.CleartoolStripButton.Click += new System.EventHandler(this.CleartoolStripButton_Click);
            // 
            // Department_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 322);
            this.Controls.Add(this.panelControl24);
            this.Name = "Department_Form";
            this.Text = "Department_Form";
            ((System.ComponentModel.ISupportInitialize)(this.DepNametextbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl25)).EndInit();
            this.panelControl25.ResumeLayout(false);
            this.panelControl25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepRemarkstextbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepBranchtextbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentIdtextbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl24)).EndInit();
            this.panelControl24.ResumeLayout(false);
            this.panelControl24.PerformLayout();
            this.toolStrip12.ResumeLayout(false);
            this.toolStrip12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit DepNametextbox;
        private DevExpress.XtraEditors.PanelControl panelControl25;
        private DevExpress.XtraEditors.TextEdit DepRemarkstextbox;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit DepBranchtextbox;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private DevExpress.XtraEditors.TextEdit DepartmentIdtextbox;
        private System.Windows.Forms.Label label38;
        private DevExpress.XtraEditors.PanelControl panelControl24;
        private System.Windows.Forms.ToolStrip toolStrip12;
        private System.Windows.Forms.ToolStripButton SavetoolStripButton;
        private System.Windows.Forms.ToolStripButton EdittoolStripButton;
        private System.Windows.Forms.ToolStripButton DeletetoolStripButton;
        private System.Windows.Forms.ToolStripButton CleartoolStripButton;
    }
}