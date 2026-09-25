using lastversionoop.controller;
using lastversionoop.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lastversionoop
{
    public partial class adminpage : Form
    {
        private Controller controller;
        public adminpage(Controller c)
        {
            InitializeComponent();
            this.controller = c;
            hidepanels();
        }

        //for design purpose
        private void hidepanels()
        {
            panelA.Visible = false;
            panelR.Visible = false;
            panelU.Visible = false;
            panelS.Visible = false;
        }

        private void ShowPanel(Panel panel, int Width, int Height)
        {
            panel.Size = new Size(Width, Height);
            panel.Left = (this.ClientSize.Width - panel.Width) / 2;
            panel.Top = (this.ClientSize.Height - panel.Height) / 2;
        }

        //add eventss
        private void buttonA_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelA.Visible = true;
            ShowPanel(panelA, 600, 400);
        }

        private void btnaddevent_Click(object sender, EventArgs e)
        {
            int id = controller.Events.Count + 1;

            string name = txttitle.Text;
            string category = txtcategory.Text;
            DateTime date = dteventdate.Value;
            int price = int.Parse(txtprice.Text);
            int seats = int.Parse(txtseats.Text);

            Event ev = new Event(id, name, category, date, price, seats);

            txtid.Text = ev.EventID.ToString();
            controller.ADDEVENT(ev);

            listBox3.DataSource = null;
            listBox3.DataSource = controller.Events;
            listBox3.DisplayMember = null;
            listBox2.DataSource = null;
            listBox2.DataSource = controller.Events;
            listBox2.DisplayMember = null;

            MessageBox.Show("event added successfully and saved to file");
            foreach (Control c in panelA.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();

            }
            panelA.Visible = false;

        }

        //remove eventss
        private void buttonR_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelR.Visible = true;
            ShowPanel(panelR, 900, 400);
            listBox3.Size = new(800, 200);
            listBox3.HorizontalScrollbar = true;
            listBox3.ScrollAlwaysVisible = true;
        }

        private void removent_Click(object sender, EventArgs e)
        {
            if (listBox3.Items.Count == null) { MessageBox.Show("No event to remove"); panelR.Visible = false; return; }
            if (listBox3.SelectedItem == null) { MessageBox.Show("Please select an event"); return; }

            Event selectedevent = (Event)listBox3.SelectedItem;
            controller.REMOVEEVENT(selectedevent);

            MessageBox.Show("event removed and saved to file");

            listBox3.DataSource = null;
            listBox3.DataSource = controller.Events;
            listBox3.DisplayMember = null;

            listBox2.DataSource = null;
            listBox2.DataSource = controller.Events;
            listBox2.DisplayMember = null;
            panelR.Visible = false;
        }

        //editsss eventss
        private void updateeventseats_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelU.Visible = true;
            ShowPanel(panelU, 900, 400);
            listBox2.Size = new(800, 200);
            listBox2.HorizontalScrollbar = true;
            listBox2.ScrollAlwaysVisible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int nbseats;
            try
            {
                nbseats = int.Parse(nbseatstxt.Text);
            }
            catch
            {
                MessageBox.Show("Enter a valid number of seats"); return;
            }
            if (nbseats < 0) { MessageBox.Show("Enter a valid number of seats"); return; }
            if ( listBox2.Items.Count==0) { MessageBox.Show("No event to change seat"); panelU.Visible = false; return; }

            if (listBox2.SelectedItem == null) { MessageBox.Show("Please select an event"); return; }

            Event selectedevent = (Event)listBox2.SelectedItem;
            controller.UpdateSeats(selectedevent, nbseats);
            MessageBox.Show("seats updated.");

            listBox3.DataSource = null;
            listBox3.DataSource = controller.Events;
            listBox3.DisplayMember = null;

            listBox2.DataSource = null;
            listBox2.DataSource = controller.Events;
            listBox2.DisplayMember = null;

            foreach (Control c in panelU.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
            }
            panelU.Visible = false;
        }

        //summary
        private void buttonS_Click(object sender, EventArgs e)
        {
            hidepanels();
            panelS.Visible = true;
            ShowPanel(panelS, 990, 450);
            listBox1.Size = new(990, 370);

            listBox1.Items.Clear();

            foreach (var booking in controller.Bookings)
            {
                listBox1.Items.Add(booking.ToString());
            }

            // int totalrevenue = controller.Bookings.Sum(b => b.TotalPrice);
            // badnaaa total revenu of confirmed booking only, bala l cancelled oneee
            int totalrevenue = controller.Bookings.Where(b => b.status != "Cancelled" && b.status!="Removed").Sum(b => b.TotalPrice);

            listBox1.Items.Add("-----------------------------------");
            listBox1.Items.Add($"TotalRevenue:{totalrevenue}$");
            listBox1.Items.Add("-----------------------------------");

            foreach (var ev in controller.Events)
            {
                
                int re = controller.Bookings.Where(b => b.Event.EventID == ev.EventID && b.status != "Cancelled" && b.status!="Removed").Sum(b => b.TotalPrice);

                listBox1.Items.Add($"{ev.Title.PadRight(10)} : \t {ev.AvailableSeats}/{ev.TotalSeats} \t || {re} $");
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            controller.SaveListBoxToFile(listBox1);
            MessageBox.Show("Summary saved to summary.txt !");
            listBox1.Visible = false;
            button6.Visible = false;
        }

        //
        private void adminpage_Load(object sender, EventArgs e)
        {
            listBox3.DataSource = controller.Events;
            listBox2.DataSource = controller.Events;
            listBox2.DisplayMember = null;
            listBox3.DisplayMember = null;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            this.Close();
            main.Show();
        }


    }
}
