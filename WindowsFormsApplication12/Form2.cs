using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.IO;

namespace WindowsFormsApplication12
{
    public partial class Form2 : Form
    {
        private string[] vid = Directory.GetFiles(@"c:/vipo12/");
        

        public Form2()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            panel1.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - panel1.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - panel1.Height) / 2);
            label1.Visible = false;        
            
        }

        private void axWindowsMediaPlayer1_EndOfStream(object sender, AxWMPLib._WMPOCXEvents_EndOfStreamEvent e)
        {
          
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {

                for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
                {
                    if (Application.OpenForms[1].Name == "Form1")
                    {
                        Application.OpenForms[1].Close();
                    }
                }
                Form3 rat = new Form3();
                rat.StartPosition = FormStartPosition.Manual;
                rat.Location = new Point(
              this.ClientSize.Width / 2 - 80 - rat.Size.Width/2,
              this.ClientSize.Height / 2 - panel1.Size.Height / 2-rat.Size.Height/2);
                panel1.Anchor = AnchorStyles.None;
                rat.StartPosition = FormStartPosition.Manual;
                rat.Location = new Point(this.ClientSize.Width / 2 - panel1.Width / 2 + rat.Width / 2 + 10, this.ClientSize.Height / 2 + 100 + rat.Height / 2);
                rat.passvalz = textBox1.Text;
                rat.passcnt = textBox2.Text;
                rat.passfnm = textBox3.Text;
                rat.passlst = textBox4.Text;
                rat.ShowDialog();
              
            }
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(1);
            for (int v=0 ;v<vid.Length;v++)
            {
                panel1.Location = new Point(
               this.ClientSize.Width / 2 - panel1.Size.Width / 2,
               this.ClientSize.Height / 2 - panel1.Size.Height / 2);
                panel1.Anchor = AnchorStyles.None;
                axWindowsMediaPlayer1.uiMode = "none";

                axWindowsMediaPlayer1.URL = vid[v];
                axWindowsMediaPlayer1.Show();
                WMPLib.IWMPMedia ci = axWindowsMediaPlayer1.currentMedia;
                textBox1.Text = ci.name;
                label1.Visible = false;
                if (textBox1.Text == "A02" ||textBox1.Text == "B02" ||textBox1.Text == "C02" ||textBox1.Text == "D02" ||textBox1.Text == "E02" ||textBox1.Text == "F02" ||textBox1.Text=="G02"||textBox1.Text == "H02" ||textBox1.Text == "I02" ||textBox1.Text == "J02" ||textBox1.Text == "K02" ||textBox1.Text == "L02" ||textBox1.Text == "M02" ||textBox1.Text == "N02" ||textBox1.Text == "O02"||textBox1.Text == "WA02" ||textBox1.Text == "WB02" ||textBox1.Text == "WC02" ||textBox1.Text == "WD02" ||textBox1.Text == "WE02" ||textBox1.Text == "WF02" ||textBox1.Text=="WG02"||textBox1.Text == "WH02" ||textBox1.Text == "WI02" ||textBox1.Text == "WJ02" || textBox1.Text == "WK02" ||textBox1.Text == "WL02" ||textBox1.Text == "WM02" ||textBox1.Text == "WN02" ||textBox1.Text == "WO02")
                {
              label1.Location = new Point(
              this.ClientSize.Width-80 - this.Size.Width / 2,
              this.ClientSize.Height - panel1.Size.Height / 2 -20- this.Size.Height / 2);
                    label1.Visible = true;
                }
                int cnt = vid.Length;
                string count = Convert.ToString(cnt);
                textBox2.Text = count;
                if (v == 0)
                    textBox3.Text = textBox1.Text;
                Refresh();
                Form4 shw = new Form4();
                shw.StartPosition = FormStartPosition.Manual;
                shw.Location = new Point(
              this.ClientSize.Width - shw.Size.Width / 2,
              this.ClientSize.Height - shw.Size.Height / 2);
                panel1.Anchor = AnchorStyles.None;
                shw.ShowDialog();
                textBox1.Text = ci.name;
                int i = Convert.ToInt32(textBox4.Text);
                i += 1;
                textBox4.Text = Convert.ToString(i);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
