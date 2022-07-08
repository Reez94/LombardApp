using LombardApp.Interface;
using LombardApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LombardApp
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();

            txtPassword.PasswordChar = '*';
        }
        /// <summary>
        /// Logowanie
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using DataBaseContext context = new DataBaseContext();

            IFormFunctions functions = new MockFormFunctions(context);

            User loginUser = new()
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };

            if (functions.LogIn(loginUser))
            {
                new frmAdminPanel().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane", "Logwanie nieudane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
