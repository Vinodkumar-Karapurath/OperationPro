using DevExpress.XtraTabbedMdi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OperationPro
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        XtraTabbedMdiManager mdiManager;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void barcompany_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMasters frmcomapany = new FrmMasters(1);
            frmcomapany.MdiParent = this;
            frmcomapany.Show();
        }

        private void barDepart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMasters frmcomapany = new FrmMasters(2);
            frmcomapany.MdiParent = this;
            frmcomapany.Show();
        }

        private void barJob_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMasters frmcomapany = new FrmMasters(3);
            frmcomapany.MdiParent = this;
            frmcomapany.Show();
        }

        private void barLocation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMasters frmcomapany = new FrmMasters(4);
            frmcomapany.MdiParent = this;
            frmcomapany.Show();
        }

        private void barVehicleType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMasters frmcomapany = new FrmMasters(5);
            frmcomapany.MdiParent = this;
            frmcomapany.Show();
        }

        private void barVehicleMas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmVehicleMaster frmVehicleMaster = new FrmVehicleMaster();
            frmVehicleMaster.MdiParent = this;
            frmVehicleMaster.Show();
        }

        private void barSatff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStaff frmstaff = new FrmStaff();
            frmstaff.MdiParent = this;
            frmstaff.Show();
        }

        private void barstaffnew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStaffNewEdit frmstaffnew = new FrmStaffNewEdit(1);
            frmstaffnew.MdiParent = this;
            frmstaffnew.Show();
        }

        private void bardash_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDashboard frmDash = new FrmDashboard();
            frmDash.MdiParent = this;
            frmDash.Show();
        }

        private void barset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSetting frmset = new FrmSetting();
            frmset.MdiParent = this;
            frmset.Show();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            mdiManager = new XtraTabbedMdiManager();
            mdiManager.MdiParent = this;
            mdiManager.PageAdded += MdiManager_PageAdded;
        }

        private void MdiManager_PageAdded(object sender, MdiTabPageEventArgs e)
        {
            XtraMdiTabPage page = e.Page;
            //page.Tooltip = "Tooltip for the page " + page.Text;
        }

        private void barvehList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmVehiclwList frmveh = new FrmVehiclwList();
            frmveh.MdiParent = this;
            frmveh.Show();
        }
    }
}
