using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyHS_GV_THPT.GUI
{
    public partial class ucHDSD : UserControl
    {
        public ucHDSD()
        {
            InitializeComponent();
        }

        private void pdfViewer1_Load(object sender, EventArgs e)
        {
             pdfViewer1.DocumentFilePath = @"43_huong_dan_QLHS_tieu_hoc.pdf";
        }
    }
}
