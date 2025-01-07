using Microsoft.VisualBasic;

namespace DymasBOEC_IT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            i = 0;
            if (button1.Text == "Play")
            {
                button1.Text = "Win";
                i = i + 1;
            }
            if (button1.Text == "Win" && i == 0)
            { 
                button1.Text = "Play";
            }
            
            
        }
    }
}
   