using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBikeFactoryClientLayer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (this.textBoxUser.Text == "user1" && this.textBoxPassword.Text == "123")
            {
                Form1 myMainForm = new Form1();
                this.Hide();

                myMainForm.ShowDialog();

                this.Dispose();

            }
            else
            {

                MessageBox.Show("invalid input");
                this.textBoxUser.Clear(); this.textBoxPassword.Clear();
                this.textBoxUser.Focus();

            }
        }
    }
}
