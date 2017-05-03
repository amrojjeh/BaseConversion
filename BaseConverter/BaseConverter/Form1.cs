using System;
using System.Windows.Forms;

namespace BaseConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       

        private void btnConvert_Click(object sender, EventArgs e)
        {
            lblConvertedNum.Text = "";
            int CurrentNum = Convert.ToInt32(txtNum.Text);

            while (CurrentNum != 0)
            {
                int remainder = CurrentNum % Convert.ToInt32(txtBase.Text);
                CurrentNum = CurrentNum / Convert.ToInt32(txtBase.Text);
                lblConvertedNum.Text += Convert.ToString(remainder);
            } 
        }
    }
}
