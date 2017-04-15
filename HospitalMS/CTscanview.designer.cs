namespace HospitalMS
{
    partial class CTscanview
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
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.imagestudyfindings = new DevExpress.XtraRichEdit.RichEditControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl4);
            this.groupControl1.Controls.Add(this.dataGridView1);
            this.groupControl1.Location = new System.Drawing.Point(12, 22);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1136, 523);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "CTscan Description";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.groupControl4);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 138);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1132, 383);
            this.panelControl4.TabIndex = 2;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.imagestudyfindings);
            this.groupControl4.Location = new System.Drawing.Point(5, 15);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(1111, 336);
            this.groupControl4.TabIndex = 65;
            this.groupControl4.Text = "Image Studding Findings";
            // 
            // imagestudyfindings
            // 
            this.imagestudyfindings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagestudyfindings.EnableToolTips = true;
            this.imagestudyfindings.Location = new System.Drawing.Point(2, 21);
            this.imagestudyfindings.Name = "imagestudyfindings";
            this.imagestudyfindings.Options.Comments.ShowAllAuthors = true;
            this.imagestudyfindings.Options.Comments.Visibility = DevExpress.XtraRichEdit.Options.RichEditCommentVisibility.Auto;
            this.imagestudyfindings.Options.CopyPaste.MaintainDocumentSectionSettings = false;
            this.imagestudyfindings.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.imagestudyfindings.Options.MailMerge.KeepLastParagraph = false;
            this.imagestudyfindings.Size = new System.Drawing.Size(1107, 313);
            this.imagestudyfindings.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(2, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1132, 117);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // CTscanview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 537);
            this.Controls.Add(this.groupControl1);
            this.Name = "CTscanview";
            this.Text = "CTscanview";
            this.Load += new System.EventHandler(this.CTscanview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraRichEdit.RichEditControl imagestudyfindings;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}