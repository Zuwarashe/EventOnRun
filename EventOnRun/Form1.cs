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

   public delegate void MyDataSender(string data);


    public partial class Form1 : Form
    {

   //---------------------------------------------------------------------------------------------------------------------------------------------//
       

        public Form1()
        {
            InitializeComponent(); 
        }

  //---------------------------------------------------------------------------------------------------------------------------------------//

        private void Action_Click(object sender, EventArgs e)
        {
            var form = new PW(textBox1.Text);
            form.DataSender += Form_DataSender;
            form.ShowDialog();
        }

  //---------------------------------------------------------------------------------------------------------------------------------------//

        private void Form_DataSender(string data)
        {
            this.label1.Text = data;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

 //----------------------------------------------------------------------------- end of file ------------------------------------------------------------//
