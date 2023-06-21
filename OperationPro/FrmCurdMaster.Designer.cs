namespace OperationPro
{
    partial class FrmCurdMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCurdMaster));
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.btndel = new DevExpress.XtraEditors.SimpleButton();
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // labelControl1
            // 
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(85, 49);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "IDNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(85, 94);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 3;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(38, 149);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(56, 42);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(103, 149);
            this.btndel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(56, 42);
            this.btndel.TabIndex = 4;
            this.btndel.Text = "Delete";
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(167, 149);
            this.btnclose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(56, 42);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // FrmCurdMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 249);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCurdMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCurdMaster";
            this.Load += new System.EventHandler(this.FrmCurdMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtname;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private DevExpress.XtraEditors.SimpleButton btndel;
        private DevExpress.XtraEditors.SimpleButton btnclose;
    }
}