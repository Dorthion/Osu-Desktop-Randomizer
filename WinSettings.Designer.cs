﻿namespace OsuDesktop
{
    partial class WinSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.LanguageList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RadioBtnClassic = new System.Windows.Forms.RadioButton();
            this.RadioBtnModern = new System.Windows.Forms.RadioButton();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Language";
            // 
            // LanguageList
            // 
            this.LanguageList.FormattingEnabled = true;
            this.LanguageList.Items.AddRange(new object[] {
            "English",
            "Polski"});
            this.LanguageList.Location = new System.Drawing.Point(12, 82);
            this.LanguageList.Name = "LanguageList";
            this.LanguageList.Size = new System.Drawing.Size(240, 24);
            this.LanguageList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Style";
            // 
            // RadioBtnClassic
            // 
            this.RadioBtnClassic.AutoSize = true;
            this.RadioBtnClassic.Location = new System.Drawing.Point(12, 29);
            this.RadioBtnClassic.Name = "RadioBtnClassic";
            this.RadioBtnClassic.Size = new System.Drawing.Size(108, 21);
            this.RadioBtnClassic.TabIndex = 3;
            this.RadioBtnClassic.Text = "Classic Style";
            this.RadioBtnClassic.UseVisualStyleBackColor = true;
            this.RadioBtnClassic.CheckedChanged += new System.EventHandler(this.RadioBtnClassic_CheckedChanged);
            // 
            // RadioBtnModern
            // 
            this.RadioBtnModern.AutoSize = true;
            this.RadioBtnModern.Location = new System.Drawing.Point(140, 29);
            this.RadioBtnModern.Name = "RadioBtnModern";
            this.RadioBtnModern.Size = new System.Drawing.Size(112, 21);
            this.RadioBtnModern.TabIndex = 4;
            this.RadioBtnModern.Text = "Modern Style";
            this.RadioBtnModern.UseVisualStyleBackColor = true;
            this.RadioBtnModern.CheckedChanged += new System.EventHandler(this.RadioBtnModern_CheckedChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(77, 297);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(105, 44);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Beatmap Types";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 142);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Ranked";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(13, 169);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 21);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Love State";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 196);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(86, 21);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Qualified";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(12, 223);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(82, 21);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "Pending";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(13, 251);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(97, 21);
            this.checkBox5.TabIndex = 11;
            this.checkBox5.Text = "Graveyard";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // WinSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 353);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.RadioBtnModern);
            this.Controls.Add(this.RadioBtnClassic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LanguageList);
            this.Controls.Add(this.label1);
            this.Name = "WinSettings";
            this.Text = "ODR Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WinSettings_FormClosed);
            this.Load += new System.EventHandler(this.WinSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LanguageList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RadioBtnClassic;
        private System.Windows.Forms.RadioButton RadioBtnModern;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}