namespace RS_07_02_2023_saldumuaprekinasana
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
            this.label2 = new System.Windows.Forms.Label();
            this.naudas_daudzums_tbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.serenade = new System.Windows.Forms.CheckBox();
            this.selga = new System.Windows.Forms.CheckBox();
            this.jurakonfekte = new System.Windows.Forms.CheckBox();
            this.kg_daudzums_tbox = new System.Windows.Forms.TextBox();
            this.varda_tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ievadiet naudas daudzumu (eur):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // naudas_daudzums_tbox
            // 
            this.naudas_daudzums_tbox.BackColor = System.Drawing.Color.White;
            this.naudas_daudzums_tbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.naudas_daudzums_tbox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.naudas_daudzums_tbox.Location = new System.Drawing.Point(206, 163);
            this.naudas_daudzums_tbox.Name = "naudas_daudzums_tbox";
            this.naudas_daudzums_tbox.Size = new System.Drawing.Size(100, 20);
            this.naudas_daudzums_tbox.TabIndex = 2;
            this.naudas_daudzums_tbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(166, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "APREKINAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(125, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Konfeksu daudzums (kg):";
            // 
            // serenade
            // 
            this.serenade.AutoSize = true;
            this.serenade.BackColor = System.Drawing.Color.White;
            this.serenade.ForeColor = System.Drawing.SystemColors.MenuText;
            this.serenade.Location = new System.Drawing.Point(56, 57);
            this.serenade.Name = "serenade";
            this.serenade.Size = new System.Drawing.Size(113, 17);
            this.serenade.TabIndex = 6;
            this.serenade.Text = "Serenade 6.55/kg";
            this.serenade.UseVisualStyleBackColor = false;
            this.serenade.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // selga
            // 
            this.selga.AutoSize = true;
            this.selga.BackColor = System.Drawing.Color.White;
            this.selga.Cursor = System.Windows.Forms.Cursors.Default;
            this.selga.ForeColor = System.Drawing.SystemColors.MenuText;
            this.selga.Location = new System.Drawing.Point(56, 34);
            this.selga.Name = "selga";
            this.selga.Size = new System.Drawing.Size(94, 17);
            this.selga.TabIndex = 8;
            this.selga.Text = "Selga 7.64/kg";
            this.selga.UseVisualStyleBackColor = false;
            this.selga.CheckedChanged += new System.EventHandler(this.selga_CheckedChanged);
            // 
            // jurakonfekte
            // 
            this.jurakonfekte.AutoSize = true;
            this.jurakonfekte.BackColor = System.Drawing.Color.White;
            this.jurakonfekte.ForeColor = System.Drawing.SystemColors.MenuText;
            this.jurakonfekte.Location = new System.Drawing.Point(56, 80);
            this.jurakonfekte.Name = "jurakonfekte";
            this.jurakonfekte.Size = new System.Drawing.Size(130, 17);
            this.jurakonfekte.TabIndex = 9;
            this.jurakonfekte.Text = "JuraKonfekte 3.23/kg";
            this.jurakonfekte.UseVisualStyleBackColor = false;
            this.jurakonfekte.CheckedChanged += new System.EventHandler(this.jurakonfekte_CheckedChanged);
            // 
            // kg_daudzums_tbox
            // 
            this.kg_daudzums_tbox.Location = new System.Drawing.Point(258, 282);
            this.kg_daudzums_tbox.Name = "kg_daudzums_tbox";
            this.kg_daudzums_tbox.Size = new System.Drawing.Size(100, 20);
            this.kg_daudzums_tbox.TabIndex = 10;
            // 
            // varda_tbox
            // 
            this.varda_tbox.Location = new System.Drawing.Point(206, 189);
            this.varda_tbox.Name = "varda_tbox";
            this.varda_tbox.Size = new System.Drawing.Size(100, 20);
            this.varda_tbox.TabIndex = 11;
            this.varda_tbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(99, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ievadiet jusu vardu:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RS_07_02_2023_saldumuaprekinasana.Properties.Resources.Screenshot_1;
            this.ClientSize = new System.Drawing.Size(577, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.varda_tbox);
            this.Controls.Add(this.kg_daudzums_tbox);
            this.Controls.Add(this.jurakonfekte);
            this.Controls.Add(this.selga);
            this.Controls.Add(this.serenade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.naudas_daudzums_tbox);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Saldumu_aprekins";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox naudas_daudzums_tbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox serenade;
        private System.Windows.Forms.CheckBox selga;
        private System.Windows.Forms.CheckBox jurakonfekte;
        private System.Windows.Forms.TextBox kg_daudzums_tbox;
        private System.Windows.Forms.TextBox varda_tbox;
        private System.Windows.Forms.Label label1;
    }
}

