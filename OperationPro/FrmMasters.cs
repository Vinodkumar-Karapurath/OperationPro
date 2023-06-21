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
    public partial class FrmMasters : DevExpress.XtraEditors.XtraForm
    {
        public int MasterType;
        public FrmMasters(int _masterType)
        {
            InitializeComponent();
            MasterType = _masterType;
        }

        private void FrmMasters_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }


        public void LoadGrid()
        {
            if (MasterType == 1) //company
            {
                OperationPro.OperationProEntities opro = new OperationProEntities();
                gridControl1.DataSource = opro.TBL_Company.Select(s => new { s.ID, s.Company }).ToList();
                gridControl1.Refresh();
            }
            else if (MasterType == 2) //Department
            {
                OperationPro.OperationProEntities opro = new OperationProEntities();
                gridControl1.DataSource = opro.TBL_Department.Select(s => new { s.ID, s.Department }).ToList();
                gridControl1.Refresh();
            }
            else if (MasterType == 3) //Job
            {
                OperationPro.OperationProEntities opro = new OperationProEntities();
                gridControl1.DataSource = opro.TBL_JOB.Select(s => new { s.ID, s.JobTitle }).ToList();
                gridControl1.Refresh();
            }
            else if (MasterType == 4) //Location
            {
                OperationPro.OperationProEntities opro = new OperationProEntities();
                gridControl1.DataSource = opro.TBL_Location.Select(s => new { s.ID, s.Location }).ToList();
                gridControl1.Refresh();
            }
            else if (MasterType == 5) //VehicleType
            {
                OperationPro.OperationProEntities opro = new OperationProEntities();
                gridControl1.DataSource = opro.TBL_Type.Select(s => new { s.ID, s.Type }).ToList();
                gridControl1.Refresh();
            }
        }
        private void barnew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmCurdMaster frmcrud = new FrmCurdMaster(MasterType, 0, 0, "");
                frmcrud.ShowDialog();
                LoadGrid();
            }
            catch (Exception ex)
            {

            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int tRcvrLineID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                string tRcvrName = "";
                if (MasterType == 1) //company
                {
                    tRcvrName = gridView1.GetFocusedRowCellValue("Company").ToString();
                }
                else if (MasterType == 2) //Department
                {
                    tRcvrName = gridView1.GetFocusedRowCellValue("Department").ToString();

                }
                else if (MasterType == 3) //Job
                {
                    tRcvrName = gridView1.GetFocusedRowCellValue("JobTitle").ToString();

                }
                else if (MasterType == 4) //Location
                {
                    tRcvrName = gridView1.GetFocusedRowCellValue("Location").ToString();

                }
                else if (MasterType == 5) //VehicleType
                {
                    tRcvrName = gridView1.GetFocusedRowCellValue("Type").ToString();

                }
                FrmCurdMaster frmcrud = new FrmCurdMaster(MasterType, 1, tRcvrLineID, tRcvrName);
                frmcrud.ShowDialog();
                LoadGrid();
            }
            catch (Exception ex)
            {

            }
        }

        private void baredit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int tRcvrLineID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                string tRcvrName = "";
                if (MasterType == 1) //company
                {
                    tRcvrName = gridView1.GetFocusedRowCellValue("company").ToString();
                }
                else if (MasterType == 2) //Department
                {
                    tRcvrName = gridView1.GetFocusedRowCellValue("Department").ToString();
                    
                }
                else if (MasterType == 3) //Job
                {
                    tRcvrName = gridView1.GetFocusedRowCellValue("JobTitle").ToString();
                    
                }
                else if (MasterType == 4) //Location
                {
                    tRcvrName = gridView1.GetFocusedRowCellValue("Location").ToString();
                   
                }
                else if (MasterType == 5) //VehicleType
                {
                    tRcvrName = gridView1.GetFocusedRowCellValue("Type").ToString();
                   
                }
                FrmCurdMaster frmcrud = new FrmCurdMaster(MasterType, 1, tRcvrLineID, tRcvrName);
                frmcrud.ShowDialog();
                LoadGrid();
            }
            catch (Exception ex)
            {

            }
        }

        private void bardel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the record?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
                try
            {
                OperationPro.OperationProEntities opro = new OperationProEntities();
            int IDkey = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
           
                if (MasterType == 1)
                {

                    TBL_Company tb = opro.TBL_Company.Where(d => d.ID == IDkey).First();
                    opro.Entry(tb).State = System.Data.Entity.EntityState.Deleted;
                    opro.SaveChanges();
                }
                else if (MasterType == 2)
                {

                    TBL_Department tb = opro.TBL_Department.Where(d => d.ID == IDkey).First();
                    opro.Entry(tb).State = System.Data.Entity.EntityState.Deleted;
                    opro.SaveChanges();

                }
                else if (MasterType == 3)
                {

                    TBL_JOB tb = opro.TBL_JOB.Where(d => d.ID == IDkey).First();
                    opro.Entry(tb).State = System.Data.Entity.EntityState.Deleted;
                    opro.SaveChanges();
                }
                else if (MasterType == 4)
                {

                    TBL_Location tb = opro.TBL_Location.Where(d => d.ID == IDkey).First();
                    opro.Entry(tb).State = System.Data.Entity.EntityState.Deleted;
                    opro.SaveChanges();
                }
                else if (MasterType == 5)
                {

                    TBL_Type tb = opro.TBL_Type.Where(d => d.ID == IDkey).First();
                    opro.Entry(tb).State = System.Data.Entity.EntityState.Deleted;
                    opro.SaveChanges();
                }
                LoadGrid();
            }
            catch (Exception ex)
            {

            }

        }

        private void barclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}