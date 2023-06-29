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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(162, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(154, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(306, 168);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(243, 52);
            this.password.TabIndex = 11;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(306, 77);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(243, 52);
            this.username.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(162, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "Country:";
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(306, 261);
            this.country.Multiline = true;
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(243, 52);
            this.country.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaShell;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(269, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 54);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sign in";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(125, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "Admin Code:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(306, 351);
            this.code.Multiline = true;
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(243, 52);
            this.code.TabIndex = 17;
            this.code.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.code);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox code;
    }
}