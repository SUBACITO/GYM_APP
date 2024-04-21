using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapQuanLy.Forms
{
    public partial class Frm_Messages : Form
    {
        public Frm_Messages()
        {
            InitializeComponent();
            new makeFormRounded(this);
        }
    }
}
