namespace Medical_management_system
{
    partial class DOCTOR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DOCTOR));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.contentpanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.set = new System.Windows.Forms.Button();
            this.patient1 = new System.Windows.Forms.Button();
            this.bill1 = new System.Windows.Forms.Button();
            this.doctor1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // contentpanel
            // 
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentpanel.Location = new System.Drawing.Point(206, 38);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(608, 438);
            this.contentpanel.TabIndex = 2;
            this.contentpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentpanel_Paint);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Medical_management_system.Properties.Resources._19593_blue_square_background_design;
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.set);
            this.panel4.Controls.Add(this.patient1);
            this.panel4.Controls.Add(this.bill1);
            this.panel4.Controls.Add(this.doctor1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 438);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Medical_management_system.Properties.Resources._19593_blue_square_background_design;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 45);
            this.button5.TabIndex = 10;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // set
            // 
            this.set.BackgroundImage = global::Medical_management_system.Properties.Resources._19593_blue_square_background_design;
            this.set.Image = ((System.Drawing.Image)(resources.GetObject("set.Image")));
            this.set.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.set.Location = new System.Drawing.Point(1, 161);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(200, 43);
            this.set.TabIndex = 7;
            this.set.Text = "SETTINGS";
            this.set.UseVisualStyleBackColor = true;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // patient1
            // 
            this.patient1.BackgroundImage = global::Medical_management_system.Properties.Resources._19593_blue_square_background_design;
            this.patient1.Image = global::Medical_management_system.Properties.Resources.patient;
            this.patient1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patient1.Location = new System.Drawing.Point(0, 79);
            this.patient1.Name = "patient1";
            this.patient1.Size = new System.Drawing.Size(200, 43);
            this.patient1.TabIndex = 6;
            this.patient1.Text = "PATIENT";
            this.patient1.UseVisualStyleBackColor = true;
            this.patient1.Click += new System.EventHandler(this.patient1_Click);
            // 
            // bill1
            // 
            this.bill1.BackgroundImage = global::Medical_management_system.Properties.Resources._19593_blue_square_background_design;
            this.bill1.Image = global::Medical_management_system.Properties.Resources.bill;
            this.bill1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bill1.Location = new System.Drawing.Point(1, 119);
            this.bill1.Name = "bill1";
            this.bill1.Size = new System.Drawing.Size(200, 43);
            this.bill1.TabIndex = 4;
            this.bill1.Text = "BILL";
            this.bill1.UseVisualStyleBackColor = true;
            this.bill1.Click += new System.EventHandler(this.button8_Click);
            // 
            // doctor1
            // 
            this.doctor1.BackColor = System.Drawing.Color.Navy;
            this.doctor1.BackgroundImage = global::Medical_management_system.Properties.Resources._19593_blue_square_background_design;
            this.doctor1.Image = global::Medical_management_system.Properties.Resources.doc;
            this.doctor1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctor1.Location = new System.Drawing.Point(0, 40);
            this.doctor1.Name = "doctor1";
            this.doctor1.Size = new System.Drawing.Size(200, 43);
            this.doctor1.TabIndex = 1;
            this.doctor1.Text = "DOCTOR";
            this.doctor1.UseVisualStyleBackColor = false;
            this.doctor1.Click += new System.EventHandler(this.doctor1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BackgroundImage = global::Medical_management_system.Properties.Resources._19593_blue_square_background_design;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(814, 38);
            this.panel3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(707, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "||";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(741, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "---";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(774, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Medical_management_system.Properties.Resources._19593_blue_square_background_design;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 43);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // DOCTOR
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(814, 476);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DOCTOR";
            this.Load += new System.EventHandler(this.DOCTOR_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimise;
        private System.Windows.Forms.Button logoff;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button slidingPannelToggleButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button bill;
        private System.Windows.Forms.Button visit;
        private System.Windows.Forms.Button patient;
        private System.Windows.Forms.Button doc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button patient1;
        private System.Windows.Forms.Button bill1;
        private System.Windows.Forms.Button doctor1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button set;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel contentpanel;
    }
}