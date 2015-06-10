using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopGuide
{
    public partial class fa17_2 : MyForm
    {
        public fa17_2()
        {
            InitializeComponent();            
        }        

        private void myButton1_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa02());
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa02());
        }                

        private void myButton4_Click_1(object sender, EventArgs e)
        {
            MoveToSlide(new fa28());
        }

        private void myButton3_Click(object sender, EventArgs e)
        {
            MoveToSlide(new fa11());
        }
    }
}
