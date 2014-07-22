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
namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label8.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label9.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label9.Visible = false;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            label10.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            label12.Visible = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            label12.Visible = false;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            label15.Visible = true;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            label15.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] newTextBox = { textBox1, textBox2, textBox3, textBox5, textBox6 };
            for (int inti = 0; inti < newTextBox.Length; inti++)
            {
                if (newTextBox[inti].Text == string.Empty)
                {
                    MessageBox.Show("All text Boxes are mandotory please fill..!");
                    newTextBox[inti].Focus();
                    return;

                }


            }
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Missing wathced onlines before");
                return;
            }
            if (!radioButton13.Checked && !radioButton14.Checked && !radioButton15.Checked && !radioButton16.Checked && !radioButton17.Checked && !radioButton18.Checked)
            {
                MessageBox.Show("Feeling Field is Missing...!!");
                return;
            }
            if (!radioButton11.Checked && !radioButton12.Checked)
            {
                MessageBox.Show("Taken online test before Field is Missing...!!");
                return;
            }

            string qq = textBox1.Text;
            string ww = textBox2.Text;
            string ee = textBox3.Text;
            string rr = textBox5.Text;
            string tt = textBox6.Text;
            string yy = comboBox1.Text;
            if (qq != string.Empty && tt != string.Empty && ww != string.Empty && ee != string.Empty && rr != string.Empty && yy != string.Empty)
            {
                string conString = "SERVER=localhost;" + "DATABASE=vipo12;" + "UID=root;";
                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand command = con.CreateCommand();
                //MySqlDataReader Reader;
                con.Open();
                //Reader = command.ExecuteReader();
                //while (Reader.Read())

                command.CommandText = "INSERT INTO `usr_table`(`name`, `sex`, `Age`, `occupation`, `nationality`, `residence`, `Vid_exp`, `frqncy`, `type`, `feel`, `tst_exp`) VALUES (@name,@sex,@age,@occupation,@nationality,@residence,@vid_exp,@frqncy,@type,@feel,@test)";
                command.Parameters.AddWithValue("@name", textBox1.Text);
                command.Parameters.AddWithValue("@sex", comboBox1.Text);
                command.Parameters.AddWithValue("@age", textBox2.Text);
                command.Parameters.AddWithValue("@occupation", textBox3.Text);
                command.Parameters.AddWithValue("@nationality", textBox5.Text);
                command.Parameters.AddWithValue("@residence", textBox6.Text);
                if (radioButton1.Checked == true)
                {
                    command.Parameters.AddWithValue("@vid_exp", radioButton1.Text);
                }
                else if (radioButton2.Checked == true)
                {
                    command.Parameters.AddWithValue("@vid_exp", radioButton2.Text);
                }
                if (radioButton3.Checked == true)
                {
                    command.Parameters.AddWithValue("@frqncy", radioButton3.Text);
                }
                else if (radioButton4.Checked == true)
                {
                    command.Parameters.AddWithValue("@frqncy", radioButton4.Text);
                }
                else if (radioButton5.Checked == true)
                {
                    command.Parameters.AddWithValue("@frqncy", radioButton5.Text);
                }
                else if (radioButton6.Checked == true)
                {
                    command.Parameters.AddWithValue("@frqncy", radioButton6.Text);
                }
                else
                {

                    command.Parameters.AddWithValue("@frqncy", null);
                }
                if (radioButton7.Checked == true)
                {
                    command.Parameters.AddWithValue("@type", radioButton7.Text);
                }
                else if (radioButton8.Checked == true)
                {
                    command.Parameters.AddWithValue("@type", radioButton8.Text);
                }
                else if (radioButton9.Checked == true)
                {
                    command.Parameters.AddWithValue("@type", radioButton9.Text);
                }
                else if (radioButton10.Checked == true)
                {
                    command.Parameters.AddWithValue("@type", radioButton10.Text);
                }
                else
                {
                    command.Parameters.AddWithValue("@type", null);
                }

                if (radioButton13.Checked == true)
                {
                    command.Parameters.AddWithValue("@feel", radioButton13.Text);
                }
                else if (radioButton14.Checked == true)
                {
                    command.Parameters.AddWithValue("@feel", radioButton14.Text);
                }
                else if (radioButton15.Checked == true)
                {
                    command.Parameters.AddWithValue("@feel", radioButton15.Text);
                }
                else if (radioButton16.Checked == true)
                {
                    command.Parameters.AddWithValue("@feel", radioButton16.Text);
                }
                else if (radioButton17.Checked == true)
                {
                    command.Parameters.AddWithValue("@feel", radioButton17.Text);
                }
                else if (radioButton18.Checked == true)
                {
                    command.Parameters.AddWithValue("@feel", radioButton18.Text);
                }

                if (radioButton11.Checked == true)
                {
                    command.Parameters.AddWithValue("@test", radioButton11.Text);
                }
                else if (radioButton12.Checked == true)
                {
                    command.Parameters.AddWithValue("@test", radioButton12.Text);
                }

                command.ExecuteNonQuery();
                con.Close();

                this.Close();
            }
            else
            {
                MessageBox.Show("You missed mandatory fields");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
            { e.Handled = true; }
        }

        


        
        
    
    
    }
}
