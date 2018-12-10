using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Medical_management_system
{
    public partial class settings_usercontrol : UserControl
    {
        private static settings_usercontrol _instance;

        public static settings_usercontrol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new settings_usercontrol();
                }
                return _instance;
            }
        }
        public settings_usercontrol()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
        private void settings_usercontrol_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UserAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@USERNAME", textBox1.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", textBox2.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid SQL OPERATION:" + ex);
            }
            con.Close();
            refresh_DataGridView();
        }
        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllUsers1_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid SQL OPERATION:" + ex);
                }
                con.Close();
                dataGridView1.DataSource = DS.Tables[0];

            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("DeleteUser_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USERNAME", textBox1.Text);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Sql Operation: " + ex);

                }
                con.Close();
                refresh_DataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
