using System;
using System.Linq;
using System.Windows.Forms;

namespace BaseConverter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }       

        private void btnConvert_Click(object sender, EventArgs e)
        {
            lblConvertedNum.Text = "";
            int CurrentNum = Convert.ToInt32(txtNum.Text);
            string converted = "";
            while (CurrentNum != 0)
            {
                int remainder = CurrentNum % Convert.ToInt32(txtBase.Text);
                CurrentNum = CurrentNum / Convert.ToInt32(txtBase.Text);
                converted += Convert.ToString(remainder);
            }
            lblConvertedNum.Text = new String(converted.Reverse().ToArray());
        }
    }
}
