namespace OperationPro
{
    partial class FrmDashboard
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutView2 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewCard2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(676, 534);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1,
            this.layoutView2,
            this.tileView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Appearance.FocusedCardCaption.Options.UseImage = true;
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            this.layoutView1.DoubleClick += new System.EventHandler(this.layoutView1_DoubleClick);
            // 
            // layoutView2
            // 
            this.layoutView2.GridControl = this.gridControl1;
            this.layoutView2.Name = "layoutView2";
            this.layoutView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.layoutView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.layoutView2.OptionsBehavior.Editable = false;
            this.layoutView2.TemplateCard = this.layoutViewCard2;
            // 
            // layoutViewCard2
            // 
            this.layoutViewCard2.CustomizationFormText = "TemplateCard";
            this.layoutViewCard2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard2.Name = "layoutViewCard2";
            this.layoutViewCard2.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard2.Text = "TemplateCard";
            // 
            // tileView1
            // 
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            this.layoutViewCard1.TextLocation = DevExpress.Utils.Locations.Default;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 534);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}