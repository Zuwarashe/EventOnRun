using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventOnRun
{

    //delegate void (string Data);


    public partial class Form1 : Form
    {

        //---------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// 
        /// </summary>
        /// 

        public Form1()
        {
            InitializeComponent(); 
        }

       

        private void Form_DataSender(string data)
        {
            this.textBox1.Text = data;
        }

        private void Action_Click(object sender, EventArgs e)
        {
            var form = new PW(textBox1.Text);
           // form.DataSender += Form_DataSender;
            form.ShowDialog();
        }
    }
}//----------------------------------------------------------------------------- end of file ------------------------------------------------------------//
