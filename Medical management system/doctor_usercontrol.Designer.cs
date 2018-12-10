namespace Medical_management_system
{
    partial class doctor_usercontrol
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.d_name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.d_address = new System.Windows.Forms.TextBox();
            this.d_ssn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(508, 126);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Aqua;
            this.add.Location = new System.Drawing.Point(3, 135);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(145, 37);
            this.add.TabIndex = 4;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Aqua;
            this.delete.Location = new System.Drawing.Point(154, 135);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(132, 37);
            this.delete.TabIndex = 6;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.button4_Click);
            // 
            // d_name
            // 
            this.d_name.Location = new System.Drawing.Point(62, 200);
            this.d_name.Name = "d_name";
            this.d_name.Size = new System.Drawing.Size(132, 22);
            this.d_name.TabIndex = 8;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(62, 244);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(132, 22);
            this.phone.TabIndex = 9;
            // 
            // d_address
            // 
            this.d_address.Location = new System.Drawing.Point(271, 241);
            this.d_address.Name = "d_address";
            this.d_address.Size = new System.Drawing.Size(132, 22);
            this.d_address.TabIndex = 10;
            // 
            // d_ssn
            // 
            this.d_ssn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.d_ssn.Location = new System.Drawing.Point(271, 200);
            this.d_ssn.Name = "d_ssn";
            this.d_ssn.Size = new System.Drawing.Size(132, 22);
            this.d_ssn.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "D_SSN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Address:";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Aqua;
            this.clear.Location = new System.Drawing.Point(292, 135);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(132, 37);
            this.clear.TabIndex = 19;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // doctor_usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.d_ssn);
            this.Controls.Add(this.d_address);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.d_name);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "doctor_usercontrol";
            this.Size = new System.Drawing.Size(608, 438);
            this.Load += new System.EventHandler(this.doctor_usercontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox d_name;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox d_address;
        private System.Windows.Forms.TextBox d_ssn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clear;
    }
}
