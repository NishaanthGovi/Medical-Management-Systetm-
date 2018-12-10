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
    public partial class patient_usercontrol : UserControl
    {
        private static patient_usercontrol _instance;

        public static patient_usercontrol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new patient_usercontrol();
                }
                return _instance;
            }
        }
        public patient_usercontrol()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");

        private void patient_usercontrol_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllPatData_SP", con);
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
                    MessageBox.Show("         <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                con.Close();

                dataGridView1.DataSource = DS.Tables[0];

                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("PatAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@p_ssn", p_ssn.Text);
            cmd.Parameters.AddWithValue("@p_name", p_name.Text);
            cmd.Parameters.AddWithValue("@phone", phone.Text);
            cmd.Parameters.AddWithValue("@p_address", p_address.Text);
            cmd.Parameters.AddWithValue("@dob", dob.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("<<<INVALID SQL OPERATION>>>" + ex);

            }
            con.Close();
            refresh_DataGridView();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PatDelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_ssn", p_ssn.Text);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("<<<INVALID SQL OPERATION>>>" + ex);

                }
                con.Close();
                refresh_DataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            p_ssn.Text = "";
            p_name.Text = "";
            p_address.Text = "";
            dob.Text = "";
            phone.Text = "";
        }
    }
}
