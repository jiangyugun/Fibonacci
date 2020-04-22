using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnclickthis_Click(object sender, EventArgs e)
        {
                Int64 n = int.Parse(fibonacciinput.Text);

                Int64[] array = new Int64[] { 0, 1 };

                Int64 tmp = 0;

                String labeloutput="";

                for (int i = 0; i < n; i++)

                {

                    if (i == 0 || i == 1)

                        labeloutput += array[i].ToString() + ",";

                    else

                    {

                        tmp = array[0] + array[1];

                        labeloutput += tmp.ToString() + ",";

                        array[0] = array[1];

                        array[1] = tmp;

                    }

                }

                label1.Text = labeloutput;
            }
    }
}
