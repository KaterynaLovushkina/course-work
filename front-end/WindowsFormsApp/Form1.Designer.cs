namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(556, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.textBox1.Location = new System.Drawing.Point(100, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 267);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "GET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 57);
            this.button2.TabIndex = 4;
            this.button2.Text = "SEND";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.LightGray;
            this.Connect.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.ForeColor = System.Drawing.Color.ForestGreen;
            this.Connect.Location = new System.Drawing.Point(789, 21);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(144, 74);
            this.Connect.TabIndex = 5;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Olive;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(556, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 86);
            this.button3.TabIndex = 6;
            this.button3.Text = "🌱 Polish plants!";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("Nirmala UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.admin.Location = new System.Drawing.Point(551, 266);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(231, 30);
            this.admin.TabIndex = 7;
            this.admin.Text = "You are not an admin!";
            this.admin.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 61);
            this.button4.TabIndex = 8;
            this.button4.Text = "↩️";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 574);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Connect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label admin;
        private System.Windows.Forms.Button button4;
    }
}

