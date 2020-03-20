using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForms
{
    class MySuperLogic
    {
        public void Msg()
        {
            MessageBox.Show("Hello");
        }

        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
