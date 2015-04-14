namespace SepateSpriteSheet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.TextBox();
            this.p_width = new System.Windows.Forms.TextBox();
            this.p_height = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height:";
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(50, 24);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(259, 20);
            this.path.TabIndex = 3;
            // 
            // p_width
            // 
            this.p_width.Location = new System.Drawing.Point(227, 63);
            this.p_width.Name = "p_width";
            this.p_width.Size = new System.Drawing.Size(82, 20);
            this.p_width.TabIndex = 4;
            this.p_width.Text = "256";
            // 
            // p_height
            // 
            this.p_height.Location = new System.Drawing.Point(227, 91);
            this.p_height.Name = "p_height";
            this.p_height.Size = new System.Drawing.Size(82, 20);
            this.p_height.TabIndex = 5;
            this.p_height.Text = "256";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(15, 87);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(82, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number Of Sprite";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "CUT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Click_CUT);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 201);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p_height);
            this.Controls.Add(this.p_width);
            this.Controls.Add(this.path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Separate Sprite Sheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.TextBox p_width;
        private System.Windows.Forms.TextBox p_height;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}

