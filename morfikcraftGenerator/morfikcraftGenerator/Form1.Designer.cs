﻿namespace morfikcraftGenerator
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
            this.liblist = new System.Windows.Forms.CheckedListBox();
            this.to = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.from = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.libfolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toappdata = new System.Windows.Forms.FolderBrowserDialog();
            this.tosave = new System.Windows.Forms.FolderBrowserDialog();
            this.ver = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // liblist
            // 
            this.liblist.FormattingEnabled = true;
            this.liblist.HorizontalScrollbar = true;
            this.liblist.Location = new System.Drawing.Point(12, 68);
            this.liblist.Name = "liblist";
            this.liblist.Size = new System.Drawing.Size(723, 199);
            this.liblist.TabIndex = 0;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(12, 273);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(405, 20);
            this.to.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(12, 12);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(334, 20);
            this.from.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 21);
            this.button2.TabIndex = 4;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(506, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(439, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 51);
            this.button4.TabIndex = 6;
            this.button4.Text = "годота";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // libfolder
            // 
            this.libfolder.Location = new System.Drawing.Point(53, 42);
            this.libfolder.Name = "libfolder";
            this.libfolder.Size = new System.Drawing.Size(57, 20);
            this.libfolder.TabIndex = 7;
            this.libfolder.Text = "libraries";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Либы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Версия";
            // 
            // toappdata
            // 
            this.toappdata.RootFolder = System.Environment.SpecialFolder.ApplicationData;
            // 
            // ver
            // 
            this.ver.FormattingEnabled = true;
            this.ver.Location = new System.Drawing.Point(166, 42);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(180, 21);
            this.ver.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.libfolder);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.from);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.to);
            this.Controls.Add(this.liblist);
            this.Name = "Form1";
            this.Text = "LibToZip MorfikCraft";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox liblist;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox libfolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog toappdata;
        private System.Windows.Forms.FolderBrowserDialog tosave;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.ComboBox ver;
        private System.Windows.Forms.Label label3;
    }
}

