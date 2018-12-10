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
    public partial class bill_usercontrol : UserControl
    {
        private static bill_usercontrol _instance;

        public static bill_usercontrol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new bill_usercontrol();
                }
                return _instance;
            }
        }
        public bill_usercontrol()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
        private void bill_usercontrol_Load(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BillSearch_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_ssn", textBox1.Text);
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
                    MessageBox.Show("Invalid SQL Operation:" + ex);
                }
                con.Close();
                dataGridView1.DataSource = DS.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
