using lastversionoop.controller;
using lastversionoop.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace lastversionoop
{
    public partial class Form1 : Form
    {
        private Controller controller;
        private string adminSecret = "1";
        public Form1()
        {
            InitializeComponent();
            this.controller = new Controller();
          

        }

        private void picBoxAdmin_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
              "Enter secret admin password:",
              "Admin Login",
              ""); // default empty

            if (input == adminSecret)
            {
                //MessageBox.Show("welcome admin. Admin Page will open.");
                // or, open AdminForm:
                adminpage adminForm = new adminpage(controller);
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Secret password is wrong!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchpage UF = new searchpage(controller, this); //define object UF using constructor
            UF.Show();
            this.Hide();

        }

    }
}
