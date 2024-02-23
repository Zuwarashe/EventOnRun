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
    public partial class PW : Form
    {

        public event MyDataSender DataSender;

  //---------------------------------------------------------------------------------------------------------------------------------------//
         protected virtual void OnDataSender(string data)
        {
            DataSender?.Invoke(data);
        }

  //---------------------------------------------------------------------------------------------------------------------------------------//
        public PW(string dataIn)
        {
            InitializeComponent();
            label1.Text = dataIn;
        }

  //---------------------------------------------------------------------------------------------------------------------------------------//

        private void button1_Click(object sender, EventArgs e)
        {
          this.OnDataSender("Are we done");
        }

    }
}

//----------------------------------------------------------------------------- end of file ------------------------------------------------------------//