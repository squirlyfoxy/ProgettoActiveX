using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveXLib
{
    [ProgId("ControlloActiveX")]
    [ComVisible(true)]
    [Guid("56362344-52FD-4911-B745-007D8F8A2842")]
    public partial class ControlloActiveX : UserControl
    {
        public ControlloActiveX()
        {
            InitializeComponent();
        }
    }
}
