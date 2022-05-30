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
    public partial class StudentPage : UserControl
    {
        private static StudentPage _Instance;

        public static StudentPage instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new StudentPage();
                return _Instance;
            }
        }
        public StudentPage()
        {
            InitializeComponent();
        }
    }
}
