using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBot.Classes
{
    public static class Extensions
    {

        private delegate void SetPropertyThreadSafeDelegate(
            Control control,
            string propertyName,
            object propertyValue);

        private delegate object GetPropertyThreadSafeDelegate(
            Control control,
            string propertyName);

        public static void SetPropertyThreadSafe(
            this Control control,
            string propertyName,
            object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetPropertyThreadSafeDelegate
                (SetPropertyThreadSafe),
                new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(
                    propertyName,
                    BindingFlags.SetProperty,
                    null,
                    control,
                    new object[] { propertyValue });
            }
        }
        public static object GetPropertyThreadSafe(
           this Control control,
           string propertyName
        )
        {
            if (control.InvokeRequired)
            {
                return control.Invoke(new GetPropertyThreadSafeDelegate
                (GetPropertyThreadSafe),
                new object[] { control, propertyName });
            }
            else
            {
                return control.GetType().InvokeMember(
                    propertyName,
                    BindingFlags.GetProperty,
                    null,
                    control,
                    null);
            }
        }

    }
}
