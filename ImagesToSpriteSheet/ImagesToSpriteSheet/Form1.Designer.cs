﻿namespace ImagesToSpriteSheet
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
            this.input = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(52, 30);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(339, 136);
            this.input.TabIndex = 1;
            this.input.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Click_Export);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Images To SrpiteSheet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.Button button1;
    }
}

