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

    public partial class TeacherPage : UserControl
    {
        private static TeacherPage _Instance;

        public static TeacherPage instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new TeacherPage();
                return _Instance;
            }
        }
        public TeacherPage()
        {
            InitializeComponent();
        }
    }
}
