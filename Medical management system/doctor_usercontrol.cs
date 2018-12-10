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
    public partial class doctor_usercontrol : UserControl
    {
        private static doctor_usercontrol _instance;

        public static doctor_usercontrol Instance
        {
            get
            {
                if(_instance==null)
                {
                    _instance = new doctor_usercontrol();
                }
                return _instance;
            }

}
        public doctor_usercontrol()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
        private void doctor_usercontrol_Load(object sender, EventArgs e)
        {
             refresh_DataGridView(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DocDelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@d_ssn", d_ssn.Text);
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
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
           
        }
        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllDocData_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("         <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                con.Close();

                dataGridView1.DataSource = DS.Tables[0];

                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DocAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@d_ssn", d_ssn.Text);
            cmd.Parameters.AddWithValue("@d_name", d_name.Text); 
            cmd.Parameters.AddWithValue("@phone", phone.Text);
            cmd.Parameters.AddWithValue("@d_address", d_address.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show("<<<INVALID SQL OPERATION>>>"+ex);

            }
            con.Close();
            refresh_DataGridView();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            d_name.Text = "";
            d_ssn.Text = "";
            phone.Text = "";
            d_address.Text = "";
        }
    }
}
