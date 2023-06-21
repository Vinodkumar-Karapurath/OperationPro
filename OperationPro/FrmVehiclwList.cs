﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace OperationPro
{
    public partial class FrmVehiclwList : DevExpress.XtraEditors.XtraForm
    {
        public FrmVehiclwList()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            OperationPro.OperationProEntities dbContext = new OperationPro.OperationProEntities();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.TBL_Vehicle.Load();
            // This line of code is generated by Data Source Configuration Wizard
            gridControl1.DataSource =        dbContext.TBL_Vehicle.Select(s => new { s.ID, s.Vehicle, s.plateNo, s.Model, s.TBL_Type.Type, s.VehicleExpDate, s.InsuranceExpDate, s.TBL_MainMaster.EmpName, s.TBL_MainMaster.EMPID, s.AuthorizationExpDate }).ToList();
        }

        private void cardView1_DoubleClick(object sender, EventArgs e)
        {
            int tRcvrLineID = int.Parse(cardView1.GetFocusedRowCellValue("ID").ToString());
            FrmVehicleMaster frmVehicleMaster = new FrmVehicleMaster(tRcvrLineID);
            frmVehicleMaster.MdiParent = this.MdiParent;
            frmVehicleMaster.Show();
        }
    }
}