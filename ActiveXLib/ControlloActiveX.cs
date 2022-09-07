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
    [Guid("C13246C6-D0D2-4FCD-BB4F-58C9B9097FD1")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IActiveXInterface
    {
        [DispId(1)]
        void UpdateLabel(string value);
    }

    [ProgId("ControlloActiveX")]
    [ComVisible(true)]
    [Guid("56362344-52FD-4911-B745-007D8F8A2842")]
    public partial class ControlloActiveX : UserControl, IActiveXInterface
    {
        public ControlloActiveX()
        {
            InitializeComponent();
        }

        [ComVisible(true)]
        public void UpdateLabel(string value)
        {
            label1.Text = value;
        }
    }
}
