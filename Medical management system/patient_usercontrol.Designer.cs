namespace Medical_management_system
{
    partial class patient_usercontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.p_ssn = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.p_address = new System.Windows.Forms.TextBox();
            this.p_name = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(508, 126);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Aqua;
            this.add.Location = new System.Drawing.Point(3, 135);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(145, 37);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Aqua;
            this.clear.Location = new System.Drawing.Point(305, 135);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(145, 37);
            this.clear.TabIndex = 6;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Aqua;
            this.delete.Location = new System.Drawing.Point(154, 135);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(145, 37);
            this.delete.TabIndex = 7;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "p_ssn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "p_name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "p_address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "DOB:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // p_ssn
            // 
            this.p_ssn.Location = new System.Drawing.Point(48, 185);
            this.p_ssn.Name = "p_ssn";
            this.p_ssn.Size = new System.Drawing.Size(112, 22);
            this.p_ssn.TabIndex = 13;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(261, 261);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(136, 22);
            this.phone.TabIndex = 14;
            // 
            // p_address
            // 
            this.p_address.Location = new System.Drawing.Point(88, 224);
            this.p_address.Name = "p_address";
            this.p_address.Size = new System.Drawing.Size(129, 22);
            this.p_address.TabIndex = 15;
            // 
            // p_name
            // 
            this.p_name.Location = new System.Drawing.Point(232, 183);
            this.p_name.Name = "p_name";
            this.p_name.Size = new System.Drawing.Size(100, 22);
            this.p_name.TabIndex = 16;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(48, 264);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(112, 22);
            this.dob.TabIndex = 17;
            // 
            // patient_usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.Controls.Add(this.dob);
            this.Controls.Add(this.p_name);
            this.Controls.Add(this.p_address);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.p_ssn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "patient_usercontrol";
            this.Size = new System.Drawing.Size(603, 433);
            this.Load += new System.EventHandler(this.patient_usercontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox p_ssn;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox p_address;
        private System.Windows.Forms.TextBox p_name;
        private System.Windows.Forms.TextBox dob;
    }
}
