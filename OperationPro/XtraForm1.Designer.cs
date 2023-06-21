namespace OperationPro
{
    partial class XtraForm1
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.textBox1);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(497, 465);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 73);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(497, 387);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(497, 0);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 465);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pdfViewer1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(503, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(91, 465);
            this.panelControl2.TabIndex = 2;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.Location = new System.Drawing.Point(2, 2);
            this.pdfViewer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(87, 461);
            this.pdfViewer1.TabIndex = 0;
            this.pdfViewer1.Load += new System.EventHandler(this.pdfViewer1_Load);
            this.pdfViewer1.DoubleClick += new System.EventHandler(this.pdfViewer1_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cardView1
            // 
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 465);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
    }
}