
namespace explore
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.txtBirthday = new System.Windows.Forms.MaskedTextBox();
            this.txtCMND = new System.Windows.Forms.MaskedTextBox();
            this.txtCreateDate = new System.Windows.Forms.MaskedTextBox();
            this.txtExpire = new System.Windows.Forms.MaskedTextBox();
            this.txtBalance = new System.Windows.Forms.MaskedTextBox();
            this.txtPIN = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btSAVE = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1018, 401);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(138, 438);
            this.txtID.Mask = "0000000000";
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(336, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(138, 512);
            this.txtBirthday.Mask = "00/00/0000";
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(336, 20);
            this.txtBirthday.TabIndex = 3;
            this.txtBirthday.ValidatingType = typeof(System.DateTime);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(138, 549);
            this.txtCMND.Mask = "000000000";
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(336, 20);
            this.txtCMND.TabIndex = 4;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Location = new System.Drawing.Point(138, 586);
            this.txtCreateDate.Mask = "00/00/0000";
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(336, 20);
            this.txtCreateDate.TabIndex = 5;
            this.txtCreateDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtExpire
            // 
            this.txtExpire.Location = new System.Drawing.Point(138, 623);
            this.txtExpire.Mask = "00";
            this.txtExpire.Name = "txtExpire";
            this.txtExpire.Size = new System.Drawing.Size(336, 20);
            this.txtExpire.TabIndex = 6;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(138, 660);
            this.txtBalance.Mask = "000000000000";
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(336, 20);
            this.txtBalance.TabIndex = 7;
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(138, 697);
            this.txtPIN.Mask = "000000";
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(336, 20);
            this.txtPIN.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "So TK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ten chu the";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngay sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "So CMND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 590);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ngay mo the";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Han su dung (thang)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 664);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "So du";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 701);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ma pin";
            // 
            // btSAVE
            // 
            this.btSAVE.Location = new System.Drawing.Point(138, 723);
            this.btSAVE.Name = "btSAVE";
            this.btSAVE.Size = new System.Drawing.Size(75, 23);
            this.btSAVE.TabIndex = 17;
            this.btSAVE.Text = "SAVE";
            this.btSAVE.UseVisualStyleBackColor = true;
            this.btSAVE.Click += new System.EventHandler(this.btSAVE_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 472);
            this.txtName.Mask = "aaaaa";
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(336, 20);
            this.txtName.TabIndex = 18;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 774);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btSAVE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtExpire);
            this.Controls.Add(this.txtCreateDate);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.MaskedTextBox txtBirthday;
        private System.Windows.Forms.MaskedTextBox txtCMND;
        private System.Windows.Forms.MaskedTextBox txtCreateDate;
        private System.Windows.Forms.MaskedTextBox txtExpire;
        private System.Windows.Forms.MaskedTextBox txtBalance;
        private System.Windows.Forms.MaskedTextBox txtPIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btSAVE;
        private System.Windows.Forms.MaskedTextBox txtName;
    }
}