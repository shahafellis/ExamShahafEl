using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamShahafEl
{
    public partial class Form1 : Form
    {
       
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void putNumTxtBx_TextChanged(object sender, EventArgs e)
        {
            int b = 0;
            bool a = Int32.TryParse(putNumTxtBx.Text, out b);
            if (b == 0)
            {
                resultLbl.Text = "zero";

            }
            else if (b < 0)
            {



                resultLbl.Text = "Negative";

            }


            else
            {
                resultLbl.Text = "Positive";

            }

            if (Int32.TryParse(putNumTxtBx.Text, out b) == false)
            {

                resultLbl.Text = "Nan";
            }


            
              
            
            
            

            
            

            
                

                
        
        }

        
    }
}
