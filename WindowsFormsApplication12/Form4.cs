using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                if (Application.OpenForms[1].Name == "Form3")
                {
                    Application.OpenForms[1].Close();
                }
            }

            this.Close();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }
    }
}
