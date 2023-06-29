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
    public partial class Form3 : Form
    {
        bool isAdmin = false;
        public Form3()
        {
            InitializeComponent();
            try
            {
                DB.EstablishConnection(); // Corrected method name
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database not connected");

            };
        }

        private void button2_Click(object sender, EventArgs e)

        {
            if(code.Text == "1212")
            {
                isAdmin = true;
            }
            try{
                DB.CreateTableUsers();
                DB.InsertDataUsers(username.Text, password.Text, isAdmin, country.Text);
                Form2 form2 = new Form2();

                form2.Show(); // Show Form1
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data not inserted");

            };

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
