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

namespace lastversionoop
{
    public partial class searchpage : Form
    {
        private Controller controller;
        private Form mainform;
        public searchpage(Controller c, Form f)
        {
            InitializeComponent();

            this.controller = c;
            this.mainform = f;

            hidepanels();
            LoadCategories();
            controller.OnCancelledBooking += controllerOnCancelledBooking;
            controller.OnUpdatebooking += controlleronupdatebooking;
        }

             private void controllerOnCancelledBooking  (Booking b) 
              {
                  controller.SaveData();
                  MessageBox.Show($"Booking for {b.Event.Title} cancelled successfully!");
              }
        private void controlleronupdatebooking(Booking b)
        {
            controller.SaveData();
            MessageBox.Show($"Booking for {b.Event.Title} updated successfully!");
        }


        private void LoadCategories()
        {
            cbCategory.Items.Clear();

            var categories = controller.Events.Select(e => e.Category).Distinct().ToList();

            foreach (var c in categories)
                cbCategory.Items.Add(c);

            if (cbCategory.Items.Count > 0)
                cbCategory.SelectedIndex = 0;
        }

        private void searchpage_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox1_SelectedIndexChanged(null, null);
        }

        private void hidepanels()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panelresult.Visible = false;
            dateTimePicker1.Visible = false;

            panelC.Visible = false;
            panelID.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void ShowPanel(Panel panel, int Width, int Height)
        {
            panel.Size = new Size(Width, Height);
            panel.Left = (this.ClientSize.Width - panel.Width) / 2;
            panel.Top = (this.ClientSize.Height - panel.Height) / 2;
        }

        //reservation
        private void reservebtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            panel1.Visible = true;
            ShowPanel(panel1, 900, 400);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.Visible = panel3.Visible = dateTimePicker1.Visible = false;

            if (comboBox1.SelectedItem == null)
                return;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Date":
                    dateTimePicker1.Visible = true;
                    break;
                case "Category":
                    panel2.Visible = true;
                    panel2.Location=dateTimePicker1.Location;
                    break;
                case "Price":
                    panel3.Visible = true;
                    panel3.Location=dateTimePicker1.Location;
                    break;
            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select search type first");
                return;
            }

            List<Event> events = new List<Event>();
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Date":
                    {
                        panelresult.Visible = true;
                        panelresult.Size = new Size(900, 300);
                        lstsearchresults.Size = new Size(800, 150);
                        lstsearchresults.HorizontalScrollbar = true;
                        lstsearchresults.ScrollAlwaysVisible = true;
                        panelresult.Location = new Point(50, 150);
                        //point(x,y)
                        events = controller.SearchByDate(dateTimePicker1.Value);

                        break;
                    }

                case "Category":
                    {
                        if (cbCategory.SelectedItem == null)
                        {
                            MessageBox.Show("Please select a category first");
                            return;
                        }

                        panelresult.Visible = true;
                        panelresult.Size = new Size(900, 300);
                        lstsearchresults.Size = new Size(800, 150);

                        lstsearchresults.HorizontalScrollbar = true;
                        lstsearchresults.ScrollAlwaysVisible = true;
                        panelresult.Location = new Point(50, 150);

                        string category = cbCategory.SelectedItem.ToString();
                        events = controller.SearchByCategory(category);

                        break;
                    }

                case "Price":
                    {
                        if (int.TryParse(txtmin.Text, out int min) && int.TryParse(txtmax.Text, out int max))
                        {
                            //panel3.Visible = false;
                            panelresult.Visible = true;
                            panelresult.Size = new Size(900, 300);
                            lstsearchresults.Size = new Size(800, 150);
                            lstsearchresults.HorizontalScrollbar = true;
                            lstsearchresults.ScrollAlwaysVisible = true;
                            panelresult.Location = new Point(50, 150);
                            events = controller.SearchByPriceRange(min, max);
                        }
                        else
                        {
                            MessageBox.Show("Invalid price range!");
                            return;
                        }
                        break;
                    }

            }

            if (events.Count == 0)
            {
                
                lstsearchresults.DataSource=new List<string> { "No events found." };
                return;
            }

            lstsearchresults.DataSource = null;
            lstsearchresults.DataSource = events;
            lstsearchresults.DisplayMember = null;
        }


        private void bookbtn_Click(object sender, EventArgs e)
        {
            //  Check if event selected or exits
            if (lstsearchresults.DataSource == null)
            {
                MessageBox.Show("No events to booking");
                return;
            }
            if (lstsearchresults.SelectedItem == null)
            {
                MessageBox.Show("Please select an event first.");
                return;
            }

            Event selectedEvent = (Event)lstsearchresults.SelectedItem;

            // Check seat availability
            if (selectedEvent.AvailableSeats <= 0)
            {
                MessageBox.Show("No seats left for this event!");
                this.Close(); return;
            }

            //open the login user infos
            LoginUser us = new LoginUser(controller, selectedEvent);
            us.Show();
        }

        //
        private string lastaction;
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            hidepanels();
            lastaction = "Cancel";

            panelC.Visible = true; listBox1.Visible = false;
            ShowPanel(panelC, 900, 400);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelID.Visible = true;
            ShowPanel(panelC, 900, 400);
            listBox1.Visible = false;
            panel4.Visible = false;
        }

        private void GetID_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string contact = tbEmail.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Please enter both name and email.");
                return;
            }

            var user = controller.Users.FirstOrDefault
                (u => u.Name.Trim().Equals(name, StringComparison.OrdinalIgnoreCase)
                                 && u.contact.Trim().Equals(contact, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                MessageBox.Show("User not found. Please check your info.");
                return;
            }
            else
            {
                // Fill the ID textbox in cancel panel
                txtidtocancel.Text = user.userID.ToString();

                MessageBox.Show("Your ID has been found!");
                // Close panelID
                panelID.Visible = false;
            }

        }

        private void view_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtidtocancel.Text, out int userid))
            {
                MessageBox.Show("Invalid User ID");
                return;
            }


            listBox1.Visible = true;
            listBox1.Location = panelID.Location;
            listBox1.HorizontalScrollbar = true;
            listBox1.ScrollAlwaysVisible = true;
            panelID.Visible = false;

            userid = int.Parse(txtidtocancel.Text);
            var user = controller.Users.FirstOrDefault(u => u.userID == userid);

            if (user == null)
            {
                MessageBox.Show("User not found");
                panelC.Visible = false;
                return;
            }
            listBox1.DataSource = null;
            listBox1.DataSource = user.BookedEvents;
            listBox1.DisplayMember = null;

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("no events booking by you,sorry");
                panelC.Visible = false;
                return;
            }
            listBox1.Visible = true;
            if (lastaction == "Cancel")
                panel4.Visible = true;
            if (lastaction == "Update")
                panel5.Visible = true;

            listBox1.Size = new(860, 200);
        }


        private void cnclbtn_Click(object sender, EventArgs e)
        {
            //  Check that the User ID is valid
            if (!int.TryParse(txtidtocancel.Text, out int userid))
            {
                MessageBox.Show("Invalid User ID");
                return;
            }

            // Find the user in the controller
            var user = controller.Users.FirstOrDefault(u => u.userID == userid);
            if (user == null)
            {
                MessageBox.Show("User not found");
                return;
            }

            // Check if a booking is selected in the listbox
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a booking first.");
                return;
            }

            // Get the selected booking
            Booking selectedBooking = (Booking)listBox1.SelectedItem;

            // Cancel the booking (update status and restore seats)
            if (selectedBooking.status == "Cancelled" || selectedBooking.status=="Removed")
            { MessageBox.Show("Please select an event not cancelled or removed "); }
            
                controller.CancelBooking(user, selectedBooking);

                // Refresh the listbox to show updated bookings
                listBox1.DataSource = null;
                listBox1.DataSource = user.BookedEvents;
                listBox1.DisplayMember = null;
            
        }

        private void button1_Click(object sender, EventArgs e)  //back to main button
        {
            Form1 main = new Form1();
            this.Close();
            main.Show();
        }

        private void btnseatreserved_Click(object sender, EventArgs e)
        {
            hidepanels();
            lastaction = "Update";

            panelC.Visible = true; listBox1.Visible = false;
            ShowPanel(panelC, 900, 400);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int userid = int.Parse(txtidtocancel.Text);
            var user = controller.Users.FirstOrDefault(u => u.userID == userid);
            if (user == null)
            {
                MessageBox.Show("User not found");
                return;
            }

            // Check if a booking is selected in the listbox
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a booking first.");
                return;
            }
            int seatnumber = 0;
            try
            {
                seatnumber = int.Parse(txtupdateseats.Text.Trim());
            }
            catch
            {
                MessageBox.Show("the seat number should be an integer");
                txtupdateseats.Clear();
                return;
            }
            if (seatnumber < 0) { MessageBox.Show("Enter a valid number of seats"); return; }
            // Get the selected booking
            Booking selectedBooking = (Booking)listBox1.SelectedItem;

            // update seat number
            if (selectedBooking.status == "Cancelled" || selectedBooking.status=="Removed")
            { MessageBox.Show("Please select an event not cancelled or removed"); }
            controller.updatebooking(selectedBooking, int.Parse(txtupdateseats.Text));
            // Refresh the listbox to show updated bookings
            listBox1.DataSource = null;
            listBox1.DataSource = user.BookedEvents;
            listBox1.DisplayMember = null;
           
        }
    }
}
