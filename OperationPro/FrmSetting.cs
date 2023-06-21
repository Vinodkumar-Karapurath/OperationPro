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
    public partial class FrmSetting : DevExpress.XtraEditors.XtraForm
    {
        int ID;
        public FrmSetting()
        {
            InitializeComponent();
            OperationPro.OperationProEntities dbContext = new OperationPro.OperationProEntities();
            var valu = dbContext.TBL_WarningDays.Select(s => new { s.ID, s.IqamaExpWarnDay, s.SarExpWarnDay, s.PassportExpWarnDay, s.VehicleWarnDay, s.InsuranceWarnDay, s.AuthorizationWarnDay}).First();
            ID = valu.ID;
            numiqama.Value = Decimal.Parse(valu.IqamaExpWarnDay.ToString());
            numsar.Value = Decimal.Parse(valu.SarExpWarnDay.ToString());
            numpass.Value = Decimal.Parse(valu.PassportExpWarnDay.ToString());
            numauth.Value = Decimal.Parse(valu.AuthorizationWarnDay.ToString());
            numreg.Value = Decimal.Parse(valu.VehicleWarnDay.ToString());
            numinsure.Value = Decimal.Parse(valu.InsuranceWarnDay.ToString());
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            OperationPro.OperationProEntities opro = new OperationProEntities();
            TBL_WarningDays tb = opro.TBL_WarningDays.Where(s => s.ID == ID).First();

            tb.IqamaExpWarnDay =int.Parse( numiqama.Value.ToString());
            tb.SarExpWarnDay = int.Parse(numsar.Value.ToString());
            tb.PassportExpWarnDay = int.Parse(numpass.Value.ToString());
            tb.AuthorizationWarnDay = int.Parse(numauth.Value.ToString());
            tb.VehicleWarnDay = int.Parse(numreg.Value.ToString());
            tb.InsuranceWarnDay = int.Parse(numinsure.Value.ToString());

            opro.SaveChanges();
        }
    }
}