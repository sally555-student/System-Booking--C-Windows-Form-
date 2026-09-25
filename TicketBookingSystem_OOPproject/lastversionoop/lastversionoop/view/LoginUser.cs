using lastversionoop.controller;
using lastversionoop.model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace lastversionoop
{
    public partial class LoginUser : Form
    {
        private Controller controller;
        private Event selectedevent;
        private model.User currentuser;
        public LoginUser(Controller c, Event e)
        {
            InitializeComponent();
            this.controller = c;
            selectedevent = e;
            txtbookedevent.Text = selectedevent.Title;
            controller.OnCreatedBooking += Controller_createdbooking;
        }
        private void Controller_createdbooking(Booking booking)
        {
            {
                //MessageBox.Show($"Booking confirmed for {booking.seatnumber} in {booking.Event.Title} ");
                controller.SaveData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = txtname.Text.Trim();
            string email = txtcontact.Text.Trim();

            int seatnumber = int.Parse(txtseatnb.Text.Trim());


            if (currentuser == null)
            {
                MessageBox.Show("Please enter valid user information first.");
                return;
            }

            Booking booking = controller.ConfirmBooking(currentuser, selectedevent, seatnumber);

            if (booking != null)
            {
                controller.PriceEvent += booking.TotalPrice;
                MessageBox.Show($" Thank you for booking!\n Booking confirmed for:\n" +
                    $" {booking.seatnumber} in {booking.Event.Title} \n Total Price={booking.TotalPrice} $ \n date:{booking.Event.Date}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to book. No available seats.");
            }
        }
        private void txtcontact_Leave(object sender, EventArgs e)
        {

            string username = txtname.Text.Trim();
            string email = txtcontact.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter both username and email.");
                return;
            }

            if (email.IndexOf('@') <= 0)
            {
                MessageBox.Show("Email should be like :something@gmail.com");
                txtcontact.Clear();
                return;
            }
            model.User a = null;
            foreach (model.User u in controller.Users)
            {
                if (u.Name == txtname.Text && u.contact == txtcontact.Text)
                {
                    a = u;

                    break;
                }
            }
            if (a == null)
            {
                a = new model.User(txtname.Text, txtcontact.Text);
                a.userID = controller.Users.Count + 1;
                controller.Users.Add(a);

            }
            txtid.Text = a.userID.ToString();
            currentuser = a;
        }

        private void txtseatnb_Leave(object sender, EventArgs e)
        {
            int seatnumber = 0;
            try
            {
                seatnumber = int.Parse(txtseatnb.Text.Trim());
            }
            catch
            {
                MessageBox.Show("the seat number should be an integer");
                txtseatnb.Clear();
                return;
            }
            if (seatnumber < 0) MessageBox.Show("the seat number should be an positive integer");
        }


    }
}

