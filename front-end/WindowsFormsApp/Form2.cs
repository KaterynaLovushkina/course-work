using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Helper;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                DB.EstablishConnection();
                bool isValidCredentials = DB.CheckCredentials(username.Text, password.Text);
                if (isValidCredentials)
                {
                 
                    Form1 form1 = new Form1(username.Text, password.Text);

                    form1.Show(); // Show Form1
                    this.Hide();
                }
                else{
                    error.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show(); // Show Form1
            this.Hide();
        }
    }
}
