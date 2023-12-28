using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int WS_EX_NOACTIVE = 0x08000000;
        protected override CreateParams CreateParams
        {
            get
            {
                var createParams = base.CreateParams;
                createParams.ExStyle |= WS_EX_NOACTIVE;
                return createParams;
            }
        }
        //On click function for alphanumeric buttons
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (checkBox1.Checked)
            {
                SendKeys.Send(btn.Text.ToUpper());
            }
            else
            {
                SendKeys.Send(btn.Text.ToLower());
            }
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            
        }
        //On click function for delete button
        private void button11_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }
        //On click function for delete button
        private void button37_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }
        //On click function for space button
        private void button38_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }
        //On click function for delete button
        private void button11_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void button36_Click(object sender, EventArgs e)
        {
        }
    }
}
