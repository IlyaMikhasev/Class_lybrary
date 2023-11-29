using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_lybrary
{    public class Message
    {
        public static void GetMessage(string message) {
            MessageBox.Show(message,"Сообщение",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
