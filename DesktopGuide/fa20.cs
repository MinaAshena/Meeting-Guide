using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopGuide
{
    public partial class fa20 : MyForm
    {
        public fa20()
        {
            InitializeComponent();
        }

        private void myButton1_Click_1(object sender, EventArgs e)
        {
            MoveToSlide(new fa02());
        }

        private void myButton3_Click_1(object sender, EventArgs e)
        {
            MoveToSlide(new fa21());
        }

        private void myButton2_Click_1(object sender, EventArgs e)
        {
            MoveToSlide(new fa02());
        }
    }
}
