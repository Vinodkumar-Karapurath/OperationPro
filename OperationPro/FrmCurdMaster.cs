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
    public partial class FrmCurdMaster : DevExpress.XtraEditors.XtraForm
    {
        public int MasterType;
        public int EditType;
        public int IDkey;
        public string Name;
        public FrmCurdMaster(int _masterType, int _EditType, int _IDkey, string _Name)
        {
            InitializeComponent();
            MasterType = _masterType;
            EditType = _EditType;
            IDkey = _IDkey;
            Name = _Name;
        }

        private void FrmCurdMaster_Load(object sender, EventArgs e)
        {
            if (EditType == 0)
            {
                labelControl1.Text = "New";
            }
            else 
            {
                labelControl1.Text = IDkey.ToString();
                txtname.Text = Name;
            }
           
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Trim().Length == 0) return;

            OperationPro.OperationProEntities opro = new OperationProEntities();
            if (EditType == 0)
            {
                if (MasterType == 1)
                {

                    TBL_Company tb = new TBL_Company();
                    tb.Company = txtname.Text;
                    opro.TBL_Company.Add(tb);
                    opro.SaveChanges();
                    txtname.Text = "";
                }
                else if (MasterType == 2)
                {

                    TBL_Department tb = new TBL_Department();
                    tb.Department = txtname.Text;
                    opro.TBL_Department.Add(tb);
                    opro.SaveChanges();
                    txtname.Text = "";
                }
                else if (MasterType == 3)
                {

                    TBL_JOB tb = new TBL_JOB();
                    tb.JobTitle = txtname.Text;
                    opro.TBL_JOB.Add(tb);
                    opro.SaveChanges();
                    txtname.Text = "";
                }
                else if (MasterType == 4)
                {

                    TBL_Location tb = new TBL_Location();
                    tb.Location = txtname.Text;
                    opro.TBL_Location.Add(tb);
                    opro.SaveChanges();
                    txtname.Text = "";
                }
                else if (MasterType == 5)
                {

                    TBL_Type tb = new TBL_Type();
                    tb.Type = txtname.Text;
                    opro.TBL_Type.Add(tb);
                    opro.SaveChanges();
                    txtname.Text = "";
                }
                Close();

            }
            else if (EditType == 1) //Edit
            {
                if (MasterType == 1)
                {

                    TBL_Company tb = opro.TBL_Company.Where(d => d.ID == IDkey).First();
                    tb.Company = txtname.Text;
                    opro.SaveChanges();
                }
                else if (MasterType == 2)
                {

                    TBL_Department tb = opro.TBL_Department.Where(d => d.ID == IDkey).First();
                    tb.Department = txtname.Text;
                    opro.SaveChanges();
                    txtname.Text = "";
                }
                else if (MasterType == 3)
                {

                    TBL_JOB tb =  opro.TBL_JOB.Where(d => d.ID == IDkey).First();
                    tb.JobTitle = txtname.Text;
                    opro.SaveChanges();
                    txtname.Text = "";
                }
                else if (MasterType == 4)
                {

                    TBL_Location tb = opro.TBL_Location.Where(d => d.ID == IDkey).First();
                    tb.Location = txtname.Text;
                    opro.SaveChanges();
                    txtname.Text = "";
                }
                else if (MasterType == 5)
                {

                    TBL_Type tb = opro.TBL_Type.Where(d => d.ID == IDkey).First();
                    tb.Type = txtname.Text;
                    opro.SaveChanges();
                    txtname.Text = "";
                }
                Close();
            }
           
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            OperationPro.OperationProEntities opro = new OperationProEntities();
            if (EditType == 1) //Delete
            {
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
                txtname.Text = "";
                Close();
            }
        }
    }
}