/**

 *

 * Name: Tyler Marten    

 * Teacher: Mr. Hardman

 * Assignment 2, Program ?

 * Date Last Modified: 10/14/16

 *

 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World_V2
{
    public partial class frmHelloWorldV2 : Form
    {
        //creates a new version of the frm can be used to change to robots question
        public frmHelloWorldV2()
        {
            InitializeComponent();
            lblOutput.Text = "Hello there... ummmm whats your name again";
        }
        //puts the new question in the question box (output)
        public frmHelloWorldV2(string newQuestion)
        {
            InitializeComponent();
            lblOutput.Text = newQuestion;
        }

        private void txtOutput_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            //checks if the output (the robots question) is still Hello there... ummmm whats your name again
            if ( (lblOutput.Text).Equals("Hello there... ummmm whats your name again") == true)
            {
                //turns the inputted text into all uper cases, and if the answer is equal to YES 
                if ( (txtInput.Text).ToUpper().Equals("YES"))
                {

                }
            }


           
        }
    }
}
