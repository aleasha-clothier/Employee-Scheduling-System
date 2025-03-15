using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public class GloballyAvailable
    {


        public static string conn { get; set; } = "server=localhost;uid=root;pwd=floodscape;database=dbo";
    }
}
