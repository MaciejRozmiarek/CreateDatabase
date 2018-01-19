using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Connection string to database
            string connectionString = String.Format("SERVER={0};UID={1};PASSWORD={2};", ipBazyDanychTextBox.Text, loginTextBox.Text, hasłoTextBox.Text);
            //listBox1.Items.Add(connectionString);

            // Database connection
            MySqlDatabase dbConnection = new MySqlDatabase();
            bool status = dbConnection.OpenConnection(connectionString);
            if (status == true)
            {
                bool check = dbConnection.insertToDB(insertToDatabaseTextBox.Text);
                if (check==true)
                {
                    MessageBox.Show("Wykonałem");
                }
                else
                {

                }
                
            }
            else
            {
                MessageBox.Show("Nie połączyłem się");
            }


        }
    }
}
