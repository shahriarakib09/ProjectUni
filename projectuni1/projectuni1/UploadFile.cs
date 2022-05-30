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

    public partial class UploadFile : UserControl
    {

        private static UploadFile _Instance;

        public static UploadFile instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new UploadFile();
                return _Instance;
            }
        }
        public UploadFile()
        {
            InitializeComponent();
        }

        private void UploadFile_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            txtBoxFileName.Text = filename;
        }

        private void txtBoxTeachersId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtboxCourseId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
