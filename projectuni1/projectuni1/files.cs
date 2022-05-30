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
    public partial class files : UserControl
    {
        private static files _Instance;

        public static files instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new files();
                return _Instance;
            }
        }
        public files()
        {
            InitializeComponent();
        }
    }
}
