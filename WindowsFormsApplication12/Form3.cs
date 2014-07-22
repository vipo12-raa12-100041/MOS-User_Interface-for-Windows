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
    public partial class Form3 : Form
    {
        private string nm;
        private string cn;
        private string fnm;
        private string last;

        public string passlst
        {
            get { return last; }
            set { last = value; }
        }
        public string passvalz
        {
            get
            {
                return nm;
            }
            set { nm = value; }
        }
        public string passcnt
        {
            get
            {
                return cn;
            }
            set { cn = value; }
        }
        public string passfnm
        {
            get
            {
                return fnm;
            }
            set { fnm = value; }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked)
            {
                MessageBox.Show("Please Rate");
            }
            else
            {


                string conString = "SERVER=localhost;" + "DATABASE=vipo12;" + "UID=root;";
                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand command = con.CreateCommand();
                //MySqlDataReader Reader;
                con.Open();
                command.CommandText = "CREATE TABLE IF NOT EXISTS `ratings` (Id INT PRIMARY KEY AUTO_INCREMENT)";
                command.ExecuteNonQuery();
                command.CommandText = "select * from ratings;";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable tblrat = new DataTable();
                tblrat.Load(reader);
                int numr = tblrat.Columns.Count;
                string nnn = Convert.ToString(numr);
                
                int ct = Convert.ToInt32(cn);
                reader.Close();
                int cnt = ct + 1;
                if (numr < cnt)
                {
                    if (numr == 1)
                    {
                        command.CommandText = "ALTER TABLE ratings ADD COLUMN " + nm + " VARCHAR(5) NOT NULL";
                        command.ExecuteNonQuery();
                        command.CommandText = "INSERT INTO `ratings` (`" + nm + "`) VALUES (@nm)";
                        if (radioButton1.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 1);
                        }
                        if (radioButton2.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 2);
                        }
                        if (radioButton3.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 3);
                        }
                        if (radioButton4.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 4);
                        }
                        if (radioButton5.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 5);
                        }

                        command.ExecuteNonQuery();
                    }
                    else
                    {


                        command.CommandText = "select * from ratings;";
                        MySqlDataReader read = command.ExecuteReader();
                        DataTable tblra = new DataTable();
                        tblra.Load(read);
                        int id = tblrat.Rows.Count;
                        read.Close();
                       string mm = Convert.ToString(id);
                        
                        if (id == 1)
                        {
                            command.CommandText = "ALTER TABLE ratings ADD COLUMN " + nm + " VARCHAR(5) NOT NULL";
                            command.ExecuteNonQuery();
                        }
                        command.CommandText = "UPDATE ratings SET " + nm + "=@nm WHERE id =" + id;
                        if (radioButton1.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 1);
                        }
                        if (radioButton2.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 2);
                        }
                        if (radioButton3.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 3);
                        }
                        if (radioButton4.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 4);
                        }
                        if (radioButton5.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 5);
                        }

                        command.ExecuteNonQuery();
                        int ls = Convert.ToInt32(last);

                        if (nm == "O9")
                        {

                            MessageBox.Show("REFRESH   Click 'OK' AFTER REFRESHMENT...!!");
                        }
                        if (ct == ls)
                        {
                            MessageBox.Show("THANK YOU FOR YOUR VALUABLE ASSESSMENT");
                            Form close = new Form2();
                            close.Close();

                        }
                    }
                }
                else
                {
                    string first = fnm;
                    //MessageBox.Show(first);
                    bool res = nm.Equals(first, StringComparison.Ordinal);
                    if (res == true)
                    {

                        command.CommandText = "INSERT INTO `ratings` (`" + nm + "`) VALUES (@nm)";
                        if (radioButton1.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 1);
                        }
                        if (radioButton2.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 2);
                        }
                        if (radioButton3.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 3);
                        }
                        if (radioButton4.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 4);
                        }
                        if (radioButton5.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 5);
                        }

                        command.ExecuteNonQuery();
                    }
                    else
                    {

                        command.CommandText = "select * from ratings;";
                        MySqlDataReader read = command.ExecuteReader();
                        DataTable tblra = new DataTable();
                        tblra.Load(read);
                        int id = tblrat.Rows.Count;
                        read.Close();
                        command.CommandText = "UPDATE ratings SET " + nm + "=@nm WHERE id =" + id;
                        if (radioButton1.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 1);
                        }
                        if (radioButton2.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 2);
                        }
                        if (radioButton3.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 3);
                        }
                        if (radioButton4.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 4);
                        }
                        if (radioButton5.Checked)
                        {
                            command.Parameters.AddWithValue("@nm", 5);
                        }

                        command.ExecuteNonQuery();
                        int ls = Convert.ToInt32(last);

                        if (nm == "O9")
                        {
                            MessageBox.Show("REFRESH Click 'OK' AFTER REFRESHMENT...!!");
                        }
                        if (ct == ls)
                        {
                            MessageBox.Show("THANK YOU FOR YOUR VALUABLE ASSESSMENT");
                        }
                    }
                }

                con.Close();
                this.Close();
                

            }
            
            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                if (Application.OpenForms[1].Name == "Form4")
                {
                    Application.OpenForms[1].Close();
                }
            }
        }
         
    }
}
