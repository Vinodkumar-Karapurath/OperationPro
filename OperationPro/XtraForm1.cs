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
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            OperationPro.OperationProEntities dbContext = new OperationPro.OperationProEntities();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.TBL_Vehicle.Load();
            // This line of code is generated by Data Source Configuration Wizard
            gridControl1.DataSource = dbContext.TBL_Vehicle.Local.ToBindingList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void pdfViewer1_Load(object sender, EventArgs e)
        {

        }

        private void pdfViewer1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
           pdfViewer1.LoadDocument(openFileDialog1.FileName);
        }
    }
}