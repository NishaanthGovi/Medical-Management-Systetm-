using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_management_system
{
    public partial class DOCTOR : Form
    {
        public DOCTOR()
        {
            InitializeComponent();
            SPex = true;
            expandSPGUI();
        }

        private void appbody_Load(object sender, EventArgs e)
        {

        }

        bool SPex;
        const int minSP = 60;
        const int maxSP = 170;

        private void button5_Click(object sender, EventArgs e)

        {

            if (SPex)
            {
                retractSPGUI();
            }
            timer2.Start();
        }
       
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (SPex)
            {
                panel4.Width -= 30;
                if (panel4.Width <= minSP)
                {
                    SPex = false;
                    timer2.Stop();
                    this.Refresh();
                }
            }
            else
            {
                panel4.Width += 30;
                if (panel4.Width >= maxSP)
                {
                    SPex = true;
                    timer2.Stop();
                    expandSPGUI();
                    this.Refresh();
                }
            }

        }
        public void expandSPGUI()
          {
              doctor1.Text="DOCTOR";
              patient1.Text = "PATIENT";
              //vis.Text = "PRISCRIPTION";
              bill1.Text = "BILL";
              set.Text = "SETTINGS";
              //about.Text = "about";
            doctor1.Image = null;
            patient1.Image = null;
           // vis.Image = null;
            bill1.Image = null;
            set.Image = null;
            //about.Image = null;
          }
        public void retractSPGUI()
        {
            doctor1.Text = "";
            patient1.Text = "";
           // vis.Text = "";
            bill1.Text = "";
            set.Text = "";
            //about.Text = "";
            doctor1.Image =Properties.Resources.doc;
            patient1.Image = Properties.Resources.patient;
           // vis.Image = Properties.Resources.visit;
            bill1.Image = Properties.Resources.bill;
            set.Image = Properties.Resources.settings;
           // about.Image = null;
        }

        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if(SPex)
            {

            }
            timer2.Start();

        }

       

        

        private void bill_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DOCTOR_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(bill_usercontrol.Instance))
            {
                contentpanel.Controls.Add(bill_usercontrol.Instance);
                bill_usercontrol.Instance.Dock = DockStyle.Fill;
                bill_usercontrol.Instance.BringToFront();
            }
            else
            {
                 bill_usercontrol.Instance.BringToFront();
            }

        }

        private void doctor1_Click(object sender, EventArgs e)
        {
            if(! contentpanel.Controls.Contains(doctor_usercontrol.Instance))
            {
                contentpanel.Controls.Add(doctor_usercontrol.Instance);
                doctor_usercontrol.Instance.Dock = DockStyle.Fill;
                doctor_usercontrol.Instance.BringToFront();
            }
            else
            {
                doctor_usercontrol.Instance.BringToFront();
            }
        } 

        private void visit1_Click(object sender, EventArgs e)
        {

        }

       
        private void contentpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void patient1_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(patient_usercontrol.Instance))
            {
                contentpanel.Controls.Add(patient_usercontrol.Instance);
                patient_usercontrol.Instance.Dock = DockStyle.Fill;
                patient_usercontrol.Instance.BringToFront();
            }
            else
            {
                patient_usercontrol.Instance.BringToFront();
            }
        }

        private void set_Click(object sender, EventArgs e)
        {

            if (! contentpanel.Controls.Contains(settings_usercontrol.Instance))
            {
                contentpanel.Controls.Add(settings_usercontrol.Instance);
                settings_usercontrol.Instance.Dock = DockStyle.Fill;
                settings_usercontrol.Instance.BringToFront();
            }
            else
            {
                settings_usercontrol.Instance.BringToFront();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

