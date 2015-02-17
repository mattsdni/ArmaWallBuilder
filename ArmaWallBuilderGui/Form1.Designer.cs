namespace ArmaWallBuilderGui
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.preview_text = new System.Windows.Forms.TextBox();
            this.posX_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.posZ_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.azimut_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.incX_text = new System.Windows.Forms.TextBox();
            this.incZ_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.posY_text = new System.Windows.Forms.TextBox();
            this.incY_text = new System.Windows.Forms.TextBox();
            this.azInc_text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numBlocks_text = new System.Windows.Forms.TextBox();
            this.itemName_text = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fileName_text = new System.Windows.Forms.TextBox();
            this.normal_r = new System.Windows.Forms.RadioButton();
            this.snowflake_r = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addTo_box = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(320, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Position";
            // 
            // preview_text
            // 
            this.preview_text.AllowDrop = true;
            this.preview_text.Location = new System.Drawing.Point(249, 30);
            this.preview_text.Multiline = true;
            this.preview_text.Name = "preview_text";
            this.preview_text.Size = new System.Drawing.Size(198, 208);
            this.preview_text.TabIndex = 4;
            this.preview_text.TabStop = false;
            // 
            // posX_text
            // 
            this.posX_text.Location = new System.Drawing.Point(12, 73);
            this.posX_text.Name = "posX_text";
            this.posX_text.Size = new System.Drawing.Size(78, 20);
            this.posX_text.TabIndex = 2;
            this.posX_text.TextChanged += new System.EventHandler(this.posX_text_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            // 
            // posZ_text
            // 
            this.posZ_text.Location = new System.Drawing.Point(12, 99);
            this.posZ_text.Name = "posZ_text";
            this.posZ_text.Size = new System.Drawing.Size(78, 20);
            this.posZ_text.TabIndex = 4;
            this.posZ_text.TextChanged += new System.EventHandler(this.itemName_text_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Preview";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Azimut";
            // 
            // azimut_text
            // 
            this.azimut_text.Location = new System.Drawing.Point(12, 170);
            this.azimut_text.Name = "azimut_text";
            this.azimut_text.Size = new System.Drawing.Size(100, 20);
            this.azimut_text.TabIndex = 8;
            this.azimut_text.TextChanged += new System.EventHandler(this.itemName_text_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Increment by";
            // 
            // incX_text
            // 
            this.incX_text.Location = new System.Drawing.Point(129, 73);
            this.incX_text.Name = "incX_text";
            this.incX_text.Size = new System.Drawing.Size(78, 20);
            this.incX_text.TabIndex = 3;
            this.incX_text.TextChanged += new System.EventHandler(this.itemName_text_TextChanged);
            // 
            // incZ_text
            // 
            this.incZ_text.Location = new System.Drawing.Point(129, 99);
            this.incZ_text.Name = "incZ_text";
            this.incZ_text.Size = new System.Drawing.Size(78, 20);
            this.incZ_text.TabIndex = 5;
            this.incZ_text.TextChanged += new System.EventHandler(this.itemName_text_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Y";
            // 
            // posY_text
            // 
            this.posY_text.Location = new System.Drawing.Point(12, 125);
            this.posY_text.Name = "posY_text";
            this.posY_text.Size = new System.Drawing.Size(75, 20);
            this.posY_text.TabIndex = 6;
            this.posY_text.TextChanged += new System.EventHandler(this.itemName_text_TextChanged);
            // 
            // incY_text
            // 
            this.incY_text.Location = new System.Drawing.Point(129, 125);
            this.incY_text.Name = "incY_text";
            this.incY_text.Size = new System.Drawing.Size(78, 20);
            this.incY_text.TabIndex = 7;
            this.incY_text.TextChanged += new System.EventHandler(this.itemName_text_TextChanged);
            // 
            // azInc_text
            // 
            this.azInc_text.Location = new System.Drawing.Point(129, 170);
            this.azInc_text.Name = "azInc_text";
            this.azInc_text.Size = new System.Drawing.Size(78, 20);
            this.azInc_text.TabIndex = 9;
            this.azInc_text.TextChanged += new System.EventHandler(this.itemName_text_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Number of Blocks";
            // 
            // numBlocks_text
            // 
            this.numBlocks_text.Location = new System.Drawing.Point(12, 209);
            this.numBlocks_text.Name = "numBlocks_text";
            this.numBlocks_text.Size = new System.Drawing.Size(100, 20);
            this.numBlocks_text.TabIndex = 10;
            this.numBlocks_text.TextChanged += new System.EventHandler(this.itemName_text_TextChanged);
            // 
            // itemName_text
            // 
            this.itemName_text.FormattingEnabled = true;
            this.itemName_text.Location = new System.Drawing.Point(12, 30);
            this.itemName_text.Name = "itemName_text";
            this.itemName_text.Size = new System.Drawing.Size(195, 21);
            this.itemName_text.TabIndex = 1;
            this.itemName_text.TextChanged += new System.EventHandler(this.itemName_text_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "File Name";
            // 
            // fileName_text
            // 
            this.fileName_text.Location = new System.Drawing.Point(12, 253);
            this.fileName_text.Name = "fileName_text";
            this.fileName_text.Size = new System.Drawing.Size(195, 20);
            this.fileName_text.TabIndex = 11;
            this.fileName_text.TextChanged += new System.EventHandler(this.itemName_text_TextChanged);
            // 
            // normal_r
            // 
            this.normal_r.AutoSize = true;
            this.normal_r.Location = new System.Drawing.Point(6, 20);
            this.normal_r.Name = "normal_r";
            this.normal_r.Size = new System.Drawing.Size(76, 17);
            this.normal_r.TabIndex = 29;
            this.normal_r.TabStop = true;
            this.normal_r.Text = "Wall Mode";
            this.normal_r.UseVisualStyleBackColor = true;
            this.normal_r.CheckedChanged += new System.EventHandler(this.normal_r_CheckedChanged);
            // 
            // snowflake_r
            // 
            this.snowflake_r.AutoSize = true;
            this.snowflake_r.Location = new System.Drawing.Point(6, 43);
            this.snowflake_r.Name = "snowflake_r";
            this.snowflake_r.Size = new System.Drawing.Size(105, 17);
            this.snowflake_r.TabIndex = 30;
            this.snowflake_r.TabStop = true;
            this.snowflake_r.Text = "Snowflake Mode";
            this.snowflake_r.UseVisualStyleBackColor = true;
            this.snowflake_r.CheckedChanged += new System.EventHandler(this.snowflake_r_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.normal_r);
            this.groupBox1.Controls.Add(this.snowflake_r);
            this.groupBox1.Location = new System.Drawing.Point(15, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 72);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generation Mode";
            // 
            // addTo_box
            // 
            this.addTo_box.AutoSize = true;
            this.addTo_box.Location = new System.Drawing.Point(15, 357);
            this.addTo_box.Name = "addTo_box";
            this.addTo_box.Size = new System.Drawing.Size(128, 17);
            this.addTo_box.TabIndex = 32;
            this.addTo_box.Text = "Add to current misson";
            this.addTo_box.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Browse...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 380);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 34;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(470, 412);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addTo_box);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fileName_text);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.itemName_text);
            this.Controls.Add(this.numBlocks_text);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.azInc_text);
            this.Controls.Add(this.incY_text);
            this.Controls.Add(this.posY_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.incZ_text);
            this.Controls.Add(this.incX_text);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.azimut_text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.posZ_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.posX_text);
            this.Controls.Add(this.preview_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Arma Wall Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox preview_text;
        private System.Windows.Forms.TextBox posX_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox posZ_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox azimut_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox incX_text;
        private System.Windows.Forms.TextBox incZ_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox posY_text;
        private System.Windows.Forms.TextBox incY_text;
        private System.Windows.Forms.TextBox azInc_text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox numBlocks_text;
        private System.Windows.Forms.ComboBox itemName_text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fileName_text;
        private System.Windows.Forms.RadioButton normal_r;
        private System.Windows.Forms.RadioButton snowflake_r;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox addTo_box;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

