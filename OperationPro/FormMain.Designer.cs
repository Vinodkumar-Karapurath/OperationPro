namespace OperationPro
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barcompany = new DevExpress.XtraBars.BarButtonItem();
            this.barDepart = new DevExpress.XtraBars.BarButtonItem();
            this.barJob = new DevExpress.XtraBars.BarButtonItem();
            this.barLocation = new DevExpress.XtraBars.BarButtonItem();
            this.barVehicleType = new DevExpress.XtraBars.BarButtonItem();
            this.barVehicleMas = new DevExpress.XtraBars.BarButtonItem();
            this.barSatff = new DevExpress.XtraBars.BarButtonItem();
            this.barstaffnew = new DevExpress.XtraBars.BarButtonItem();
            this.bardash = new DevExpress.XtraBars.BarButtonItem();
            this.barset = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.barvehList = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barcompany,
            this.barDepart,
            this.barJob,
            this.barLocation,
            this.barVehicleType,
            this.barVehicleMas,
            this.barSatff,
            this.barstaffnew,
            this.bardash,
            this.barset,
            this.barvehList});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(758, 143);
            // 
            // barcompany
            // 
            this.barcompany.Caption = "Company";
            this.barcompany.Glyph = ((System.Drawing.Image)(resources.GetObject("barcompany.Glyph")));
            this.barcompany.Id = 2;
            this.barcompany.Name = "barcompany";
            this.barcompany.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barcompany_ItemClick);
            // 
            // barDepart
            // 
            this.barDepart.Caption = "Department";
            this.barDepart.Glyph = ((System.Drawing.Image)(resources.GetObject("barDepart.Glyph")));
            this.barDepart.Id = 3;
            this.barDepart.Name = "barDepart";
            this.barDepart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDepart_ItemClick);
            // 
            // barJob
            // 
            this.barJob.Caption = "JobTitle";
            this.barJob.Glyph = ((System.Drawing.Image)(resources.GetObject("barJob.Glyph")));
            this.barJob.Id = 4;
            this.barJob.Name = "barJob";
            this.barJob.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barJob_ItemClick);
            // 
            // barLocation
            // 
            this.barLocation.Caption = "Location";
            this.barLocation.Glyph = ((System.Drawing.Image)(resources.GetObject("barLocation.Glyph")));
            this.barLocation.Id = 5;
            this.barLocation.Name = "barLocation";
            this.barLocation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLocation_ItemClick);
            // 
            // barVehicleType
            // 
            this.barVehicleType.Caption = "VehicleType";
            this.barVehicleType.Glyph = ((System.Drawing.Image)(resources.GetObject("barVehicleType.Glyph")));
            this.barVehicleType.Id = 6;
            this.barVehicleType.Name = "barVehicleType";
            this.barVehicleType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barVehicleType_ItemClick);
            // 
            // barVehicleMas
            // 
            this.barVehicleMas.Caption = "Vehicle Master";
            this.barVehicleMas.Glyph = ((System.Drawing.Image)(resources.GetObject("barVehicleMas.Glyph")));
            this.barVehicleMas.Id = 7;
            this.barVehicleMas.Name = "barVehicleMas";
            this.barVehicleMas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barVehicleMas_ItemClick);
            // 
            // barSatff
            // 
            this.barSatff.Caption = "Staff";
            this.barSatff.Glyph = ((System.Drawing.Image)(resources.GetObject("barSatff.Glyph")));
            this.barSatff.Id = 8;
            this.barSatff.Name = "barSatff";
            this.barSatff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSatff_ItemClick);
            // 
            // barstaffnew
            // 
            this.barstaffnew.Caption = "Staff New";
            this.barstaffnew.Glyph = ((System.Drawing.Image)(resources.GetObject("barstaffnew.Glyph")));
            this.barstaffnew.Id = 9;
            this.barstaffnew.Name = "barstaffnew";
            this.barstaffnew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barstaffnew_ItemClick);
            // 
            // bardash
            // 
            this.bardash.Caption = "DashBoard";
            this.bardash.Glyph = ((System.Drawing.Image)(resources.GetObject("bardash.Glyph")));
            this.bardash.Id = 10;
            this.bardash.Name = "bardash";
            this.bardash.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bardash_ItemClick);
            // 
            // barset
            // 
            this.barset.Caption = "Settings";
            this.barset.Glyph = ((System.Drawing.Image)(resources.GetObject("barset.Glyph")));
            this.barset.Id = 11;
            this.barset.Name = "barset";
            this.barset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barset_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Home";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bardash);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "DashBoard";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barcompany);
            this.ribbonPageGroup2.ItemLinks.Add(this.barDepart);
            this.ribbonPageGroup2.ItemLinks.Add(this.barJob);
            this.ribbonPageGroup2.ItemLinks.Add(this.barLocation);
            this.ribbonPageGroup2.ItemLinks.Add(this.barVehicleType);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Master";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barVehicleMas);
            this.ribbonPageGroup3.ItemLinks.Add(this.barSatff);
            this.ribbonPageGroup3.ItemLinks.Add(this.barstaffnew);
            this.ribbonPageGroup3.ItemLinks.Add(this.barvehList);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Operations";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barset);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Setting";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // barvehList
            // 
            this.barvehList.Caption = "Vechicle List";
            this.barvehList.Glyph = ((System.Drawing.Image)(resources.GetObject("barvehList.Glyph")));
            this.barvehList.Id = 12;
            this.barvehList.Name = "barvehList";
            this.barvehList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barvehList_ItemClick);
            // 
            // FrmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 581);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "OperationPro";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barcompany;
        private DevExpress.XtraBars.BarButtonItem barDepart;
        private DevExpress.XtraBars.BarButtonItem barJob;
        private DevExpress.XtraBars.BarButtonItem barLocation;
        private DevExpress.XtraBars.BarButtonItem barVehicleType;
        private DevExpress.XtraBars.BarButtonItem barVehicleMas;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barSatff;
        private DevExpress.XtraBars.BarButtonItem barstaffnew;
        private DevExpress.XtraBars.BarButtonItem bardash;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barset;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barvehList;
    }
}

