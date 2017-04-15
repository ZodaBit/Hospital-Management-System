using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMS
{
    class HMSSecurity
    {
        public static void ApplySecurityToUi(DevExpress.XtraEditors.XtraForm form)
        {
            appylySecurity(form, Global.currentUser);
        }

        private static void appylySecurity(Control control, secUser user)
        {
            foreach (Control c in control.Controls)
            {
                if (c.GetType() == typeof(DevExpress.XtraEditors.SimpleButton))
                {
                var theControl = c as DevExpress.XtraEditors.SimpleButton;

                if (theControl.Tag != null && theControl.Tag.ToString() != "")
                {
                    var requiredPermission = Convert.ToInt32(c.Tag.ToString());
                    if (!doesUserHaveThisPermission(user, requiredPermission))
                        theControl.Enabled = false;
                }
               }
                appylySecurity(c, user);
            }
        }

        private static bool doesUserHaveThisPermission(secUser user, int permission)
        {
            var userHaveThePermission = user.secPermissions.Where(p => p.Id == permission).FirstOrDefault();

            return userHaveThePermission != null ? true : false;
        }
    }
}
