using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Medical_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(" Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;


        private String getuser()
        {
            con.Open();
            String syntax = " SELECT Value FROM System where property='Username'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;

        }
    
    
        private String getpass(String uname)
        {
            con.Open();
           
            String syntax = $"SELECT password FROM [System] where [username]='{uname}'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
                return temp;
            

        }

       private void button1_Click(object sender, EventArgs e)
        {
            String uname = textBox1.Text, upass = getpass(uname),  pass= nu.Text;
            if(pass.Equals(upass))
            {
                //Login
                label5.Hide();
              //  MessageBox.Show("Login Success");
               DOCTOR obj = new DOCTOR();
                this.Hide();
                obj.Show();
            }
            else
            {
                //Dont Login
                label5.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
           String uname = getuser(), upass = getpass(uname), name, pass;
            name = textBox1.Text;
            pass = nu.Text;
            if (name.Equals(uname) && pass.Equals(upass))
            {
                //Login
                label5.Hide();
                MessageBox.Show("Login Success");
                
            }
            else
            {
                //Dont Login
                label5.Show();
            }
        }
    }


    
}
