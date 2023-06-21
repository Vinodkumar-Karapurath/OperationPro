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
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtpass.Properties.PasswordChar = '*';
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OperationPro.OperationProEntities pr = new OperationProEntities();
            if(pr.TBL_UserMaster.Where(s=> s.Username == txtuser.Text && 
            s.Password == txtpass.Text).Count() == 0)
            {
                MessageBox.Show("Worng Username or Password");
            }
            else
            {
                this.Hide();
                new FrmMain().Show();
            }
        }
    }
}