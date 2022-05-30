using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectuni1
{
    public partial class StuffPage : UserControl
    {
        private static StuffPage _Instance;

        public static StuffPage instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new StuffPage();
                return _Instance;
            }
        }
        public StuffPage()
        {
            InitializeComponent();
        }
    }
}
