
namespace WindowsFormsApp2
{
    partial class Form2
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHpPerLvl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxHp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAtk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAtkPerLvl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaxAtk = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCurrentExp = new System.Windows.Forms.TextBox();
            this.txtDef = new System.Windows.Forms.TextBox();
            this.txtDefPerLvl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtExpValue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRarity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMaxLvl = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtElement = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMaxDef = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnImageBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(288, 569);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 53);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(116, 33);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(318, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(318, 20);
            this.txtName.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(40, 36);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 2;
            this.Id.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(116, 86);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(232, 20);
            this.txtImage.TabIndex = 1;
            this.txtImage.TextChanged += new System.EventHandler(this.txtImage_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Image";
            // 
            // txtHp
            // 
            this.txtHp.Location = new System.Drawing.Point(116, 112);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(318, 20);
            this.txtHp.TabIndex = 1;
            this.txtHp.TextChanged += new System.EventHandler(this.txtHp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hp";
            // 
            // txtHpPerLvl
            // 
            this.txtHpPerLvl.Location = new System.Drawing.Point(116, 138);
            this.txtHpPerLvl.Name = "txtHpPerLvl";
            this.txtHpPerLvl.Size = new System.Drawing.Size(318, 20);
            this.txtHpPerLvl.TabIndex = 1;
            this.txtHpPerLvl.TextChanged += new System.EventHandler(this.txtHp_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hp Per Level";
            // 
            // txtMaxHp
            // 
            this.txtMaxHp.Location = new System.Drawing.Point(116, 164);
            this.txtMaxHp.Name = "txtMaxHp";
            this.txtMaxHp.Size = new System.Drawing.Size(318, 20);
            this.txtMaxHp.TabIndex = 1;
            this.txtMaxHp.TextChanged += new System.EventHandler(this.txtHp_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Max HP";
            // 
            // txtAtk
            // 
            this.txtAtk.Location = new System.Drawing.Point(116, 190);
            this.txtAtk.Name = "txtAtk";
            this.txtAtk.Size = new System.Drawing.Size(318, 20);
            this.txtAtk.TabIndex = 1;
            this.txtAtk.TextChanged += new System.EventHandler(this.txtHp_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Atk";
            // 
            // txtAtkPerLvl
            // 
            this.txtAtkPerLvl.Location = new System.Drawing.Point(116, 216);
            this.txtAtkPerLvl.Name = "txtAtkPerLvl";
            this.txtAtkPerLvl.Size = new System.Drawing.Size(318, 20);
            this.txtAtkPerLvl.TabIndex = 1;
            this.txtAtkPerLvl.TextChanged += new System.EventHandler(this.txtHp_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Atk Per Level";
            // 
            // txtMaxAtk
            // 
            this.txtMaxAtk.Location = new System.Drawing.Point(116, 242);
            this.txtMaxAtk.Name = "txtMaxAtk";
            this.txtMaxAtk.Size = new System.Drawing.Size(318, 20);
            this.txtMaxAtk.TabIndex = 1;
            this.txtMaxAtk.TextChanged += new System.EventHandler(this.txtHp_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Max Atk";
            // 
            // txtCurrentExp
            // 
            this.txtCurrentExp.Location = new System.Drawing.Point(116, 343);
            this.txtCurrentExp.Name = "txtCurrentExp";
            this.txtCurrentExp.Size = new System.Drawing.Size(318, 20);
            this.txtCurrentExp.TabIndex = 1;
            this.txtCurrentExp.TextChanged += new System.EventHandler(this.txtHp_TextChanged);
            // 
            // txtDef
            // 
            this.txtDef.Location = new System.Drawing.Point(116, 267);
            this.txtDef.Name = "txtDef";
            this.txtDef.Size = new System.Drawing.Size(318, 20);
            this.txtDef.TabIndex = 1;
            this.txtDef.TextChanged += new System.EventHandler(this.txtHp_TextChanged);
            this.txtDef.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDef_KeyDown);
            // 
            // txtDefPerLvl
            // 
            this.txtDefPerLvl.Location = new System.Drawing.Point(116, 293);
            this.txtDefPerLvl.Name = "txtDefPerLvl";
            this.txtDefPerLvl.Size = new System.Drawing.Size(318, 20);
            this.txtDefPerLvl.TabIndex = 1;
            this.txtDefPerLvl.TextChanged += new System.EventHandler(this.txtHp_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Current Exp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Def";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Def Per Level";
            // 
            // txtExpValue
            // 
            this.txtExpValue.Location = new System.Drawing.Point(116, 369);
            this.txtExpValue.Name = "txtExpValue";
            this.txtExpValue.Size = new System.Drawing.Size(318, 20);
            this.txtExpValue.TabIndex = 1;
            this.txtExpValue.TextChanged += new System.EventHandler(this.txtHp_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Exp Value";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(116, 395);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(318, 20);
            this.txtCost.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 398);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Cost";
            // 
            // txtRarity
            // 
            this.txtRarity.Location = new System.Drawing.Point(116, 421);
            this.txtRarity.Name = "txtRarity";
            this.txtRarity.Size = new System.Drawing.Size(318, 20);
            this.txtRarity.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 424);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Rarity";
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(116, 447);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(318, 20);
            this.txtLevel.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 450);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Level";
            // 
            // txtMaxLvl
            // 
            this.txtMaxLvl.Location = new System.Drawing.Point(116, 473);
            this.txtMaxLvl.Name = "txtMaxLvl";
            this.txtMaxLvl.Size = new System.Drawing.Size(318, 20);
            this.txtMaxLvl.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 476);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "MaxLevel";
            // 
            // txtElement
            // 
            this.txtElement.AutoCompleteCustomSource.AddRange(new string[] {
            "Fire",
            "Earth",
            "Water",
            "Wind"});
            this.txtElement.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtElement.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtElement.Location = new System.Drawing.Point(116, 499);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(318, 20);
            this.txtElement.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(40, 502);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Element";
            // 
            // txtMaxDef
            // 
            this.txtMaxDef.Location = new System.Drawing.Point(116, 317);
            this.txtMaxDef.Name = "txtMaxDef";
            this.txtMaxDef.Size = new System.Drawing.Size(318, 20);
            this.txtMaxDef.TabIndex = 1;
            this.txtMaxDef.TextChanged += new System.EventHandler(this.txtHp_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(40, 320);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Max Def";
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(440, 569);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(146, 53);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnImageBrowse
            // 
            this.btnImageBrowse.Location = new System.Drawing.Point(354, 84);
            this.btnImageBrowse.Name = "btnImageBrowse";
            this.btnImageBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnImageBrowse.TabIndex = 3;
            this.btnImageBrowse.Text = "Browse";
            this.btnImageBrowse.UseVisualStyleBackColor = true;
            this.btnImageBrowse.Click += new System.EventHandler(this.btnImageBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(455, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 482);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 646);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnImageBrowse);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.txtDefPerLvl);
            this.Controls.Add(this.txtAtkPerLvl);
            this.Controls.Add(this.txtDef);
            this.Controls.Add(this.txtAtk);
            this.Controls.Add(this.txtMaxDef);
            this.Controls.Add(this.txtElement);
            this.Controls.Add(this.txtMaxLvl);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtRarity);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtExpValue);
            this.Controls.Add(this.txtCurrentExp);
            this.Controls.Add(this.txtMaxAtk);
            this.Controls.Add(this.txtMaxHp);
            this.Controls.Add(this.txtHpPerLvl);
            this.Controls.Add(this.txtHp);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHpPerLvl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxHp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAtk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAtkPerLvl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaxAtk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCurrentExp;
        private System.Windows.Forms.TextBox txtDef;
        private System.Windows.Forms.TextBox txtDefPerLvl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtExpValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRarity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMaxLvl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMaxDef;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnImageBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}