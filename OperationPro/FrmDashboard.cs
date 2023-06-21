using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OperationPro
{
    public partial class FrmDashboard : DevExpress.XtraEditors.XtraForm
    {
        public FrmDashboard()
        {
            InitializeComponent();
            OperationPro.OperationProEntities dbContext = new OperationPro.OperationProEntities();
            
            gridControl1.DataSource = dbContext.SP_Warning().ToList();
            layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;

                }

        private void layoutView1_DoubleClick(object sender, EventArgs e)
        {
            int tRcvrLineID = int.Parse(layoutView1.GetFocusedRowCellValue("id").ToString());
            int tRVchLineID = int.Parse(layoutView1.GetFocusedRowCellValue("VehicleID").ToString());

            if ( tRVchLineID == 0)
            {

                //OperationPro.OperationProEntities opro = new OperationProEntities();
                //TBL_MainMaster tbMAS = opro.TBL_MainMaster.Where(s => s.ID == tRcvrLineID).First();

                FrmStaffNewEdit frmstaffnew = new FrmStaffNewEdit(2, tRcvrLineID);
                frmstaffnew.MdiParent = this.MdiParent;
                frmstaffnew.Show();
            }
            else
            {

                FrmVehicleMaster frmVehicleMaster = new FrmVehicleMaster(tRVchLineID);
                frmVehicleMaster.MdiParent = this.MdiParent; 
                frmVehicleMaster.Show();
            }

        }
    }
}