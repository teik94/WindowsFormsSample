
namespace WindowsFormsApp2
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbPType = new System.Windows.Forms.ComboBox();
            this.cbPromotion = new System.Windows.Forms.CheckBox();
            this.nmrQuantity = new System.Windows.Forms.NumericUpDown();
            this.nmrPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.btnMassUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchPriceFrom = new System.Windows.Forms.TextBox();
            this.cbbSearchPromo = new System.Windows.Forms.ComboBox();
            this.txtSearchPriceTo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 249);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(614, 500);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Code";
            // 
            // txtPCode
            // 
            this.txtPCode.Location = new System.Drawing.Point(95, 26);
            this.txtPCode.Name = "txtPCode";
            this.txtPCode.Size = new System.Drawing.Size(381, 20);
            this.txtPCode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(95, 50);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(395, 20);
            this.txtPName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(95, 128);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(395, 20);
            this.txtNote.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbPType);
            this.groupBox1.Controls.Add(this.cbPromotion);
            this.groupBox1.Controls.Add(this.nmrQuantity);
            this.groupBox1.Controls.Add(this.nmrPrice);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.txtPCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 168);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Type";
            // 
            // cbbPType
            // 
            this.cbbPType.FormattingEnabled = true;
            this.cbbPType.Items.AddRange(new object[] {
            "Quần",
            "Áo",
            "Vớ",
            "Giày"});
            this.cbbPType.Location = new System.Drawing.Point(282, 102);
            this.cbbPType.Name = "cbbPType";
            this.cbbPType.Size = new System.Drawing.Size(121, 21);
            this.cbbPType.TabIndex = 6;
            // 
            // cbPromotion
            // 
            this.cbPromotion.AutoSize = true;
            this.cbPromotion.Location = new System.Drawing.Point(245, 78);
            this.cbPromotion.Name = "cbPromotion";
            this.cbPromotion.Size = new System.Drawing.Size(73, 17);
            this.cbPromotion.TabIndex = 5;
            this.cbPromotion.Text = "Promotion";
            this.cbPromotion.UseVisualStyleBackColor = true;
            // 
            // nmrQuantity
            // 
            this.nmrQuantity.Location = new System.Drawing.Point(95, 103);
            this.nmrQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrQuantity.Name = "nmrQuantity";
            this.nmrQuantity.Size = new System.Drawing.Size(120, 20);
            this.nmrQuantity.TabIndex = 3;
            // 
            // nmrPrice
            // 
            this.nmrPrice.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrPrice.Location = new System.Drawing.Point(95, 77);
            this.nmrPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmrPrice.Name = "nmrPrice";
            this.nmrPrice.Size = new System.Drawing.Size(120, 20);
            this.nmrPrice.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(551, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(551, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.Location = new System.Drawing.Point(551, 70);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(75, 23);
            this.btnDelete2.TabIndex = 5;
            this.btnDelete2.Text = "Delete";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Product Code";
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.Location = new System.Drawing.Point(93, 197);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(78, 20);
            this.txtSearchCode.TabIndex = 2;
            this.txtSearchCode.TextChanged += new System.EventHandler(this.txtSearchAll_TextChanged);
            // 
            // btnMassUpdate
            // 
            this.btnMassUpdate.Location = new System.Drawing.Point(551, 99);
            this.btnMassUpdate.Name = "btnMassUpdate";
            this.btnMassUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnMassUpdate.TabIndex = 6;
            this.btnMassUpdate.Text = "Mass Update";
            this.btnMassUpdate.UseVisualStyleBackColor = true;
            this.btnMassUpdate.Click += new System.EventHandler(this.btnMassUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Product Name";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(270, 197);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(121, 20);
            this.txtSearchName.TabIndex = 8;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchAll_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Price";
            // 
            // txtSearchPriceFrom
            // 
            this.txtSearchPriceFrom.Location = new System.Drawing.Point(48, 223);
            this.txtSearchPriceFrom.Name = "txtSearchPriceFrom";
            this.txtSearchPriceFrom.Size = new System.Drawing.Size(107, 20);
            this.txtSearchPriceFrom.TabIndex = 8;
            this.txtSearchPriceFrom.TextChanged += new System.EventHandler(this.txtSearchAll_TextChanged);
            // 
            // cbbSearchPromo
            // 
            this.cbbSearchPromo.FormattingEnabled = true;
            this.cbbSearchPromo.Items.AddRange(new object[] {
            "All",
            "True",
            "False"});
            this.cbbSearchPromo.Location = new System.Drawing.Point(424, 197);
            this.cbbSearchPromo.Name = "cbbSearchPromo";
            this.cbbSearchPromo.Size = new System.Drawing.Size(121, 21);
            this.cbbSearchPromo.TabIndex = 10;
            this.cbbSearchPromo.SelectedIndexChanged += new System.EventHandler(this.txtSearchAll_TextChanged);
            // 
            // txtSearchPriceTo
            // 
            this.txtSearchPriceTo.Location = new System.Drawing.Point(181, 223);
            this.txtSearchPriceTo.Name = "txtSearchPriceTo";
            this.txtSearchPriceTo.Size = new System.Drawing.Size(107, 20);
            this.txtSearchPriceTo.TabIndex = 8;
            this.txtSearchPriceTo.TextChanged += new System.EventHandler(this.txtSearchAll_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "~";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 761);
            this.Controls.Add(this.cbbSearchPromo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSearchPriceTo);
            this.Controls.Add(this.txtSearchPriceFrom);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.btnMassUpdate);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearchCode);
            this.Controls.Add(this.label7);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbPromotion;
        private System.Windows.Forms.NumericUpDown nmrQuantity;
        private System.Windows.Forms.NumericUpDown nmrPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbPType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchCode;
        private System.Windows.Forms.Button btnMassUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchPriceFrom;
        private System.Windows.Forms.ComboBox cbbSearchPromo;
        private System.Windows.Forms.TextBox txtSearchPriceTo;
        private System.Windows.Forms.Label label10;
    }
}