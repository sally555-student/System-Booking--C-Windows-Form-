namespace lastversionoop
{
    partial class searchpage
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
            reservebtn = new Button();
            cancelbtn = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            txtmax = new TextBox();
            txtmin = new TextBox();
            panelresult = new Panel();
            bookbtn = new Button();
            lstsearchresults = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            cbCategory = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btnsearch = new Button();
            comboBox1 = new ComboBox();
            panel5 = new Panel();
            label8 = new Label();
            txtupdateseats = new TextBox();
            button2 = new Button();
            panelC = new Panel();
            panel4 = new Panel();
            cnclbtn = new Button();
            listBox1 = new ListBox();
            panelID = new Panel();
            GetID = new Button();
            tbEmail = new TextBox();
            tbName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            view = new Button();
            txtidtocancel = new TextBox();
            label3 = new Label();
            button1 = new Button();
            btnseatreserved = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panelresult.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panelC.SuspendLayout();
            panel4.SuspendLayout();
            panelID.SuspendLayout();
            SuspendLayout();
            // 
            // reservebtn
            // 
            reservebtn.Anchor = AnchorStyles.None;
            reservebtn.BackColor = Color.PaleGoldenrod;
            reservebtn.FlatStyle = FlatStyle.Popup;
            reservebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reservebtn.Location = new Point(65, 12);
            reservebtn.Name = "reservebtn";
            reservebtn.Size = new Size(138, 29);
            reservebtn.TabIndex = 0;
            reservebtn.Text = "Reservation";
            reservebtn.UseVisualStyleBackColor = false;
            reservebtn.Click += reservebtn_Click;
            // 
            // cancelbtn
            // 
            cancelbtn.Anchor = AnchorStyles.None;
            cancelbtn.BackColor = Color.PaleGoldenrod;
            cancelbtn.FlatStyle = FlatStyle.Popup;
            cancelbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelbtn.Location = new Point(649, 12);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(278, 29);
            cancelbtn.TabIndex = 1;
            cancelbtn.Text = "Cancellation of all seats of an event";
            cancelbtn.UseVisualStyleBackColor = false;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panelresult);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnsearch);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(7, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(571, 429);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtmax);
            panel3.Controls.Add(txtmin);
            panel3.Location = new Point(182, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(256, 65);
            panel3.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 39);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 11;
            label5.Text = "price max";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 7);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 10;
            label4.Text = "price min";
            // 
            // txtmax
            // 
            txtmax.Location = new Point(83, 36);
            txtmax.Name = "txtmax";
            txtmax.Size = new Size(125, 27);
            txtmax.TabIndex = 9;
            // 
            // txtmin
            // 
            txtmin.Location = new Point(83, 3);
            txtmin.Name = "txtmin";
            txtmin.Size = new Size(125, 27);
            txtmin.TabIndex = 8;
            // 
            // panelresult
            // 
            panelresult.Anchor = AnchorStyles.None;
            panelresult.Controls.Add(bookbtn);
            panelresult.Controls.Add(lstsearchresults);
            panelresult.Location = new Point(5, 275);
            panelresult.Name = "panelresult";
            panelresult.Size = new Size(563, 147);
            panelresult.TabIndex = 5;
            // 
            // bookbtn
            // 
            bookbtn.Anchor = AnchorStyles.None;
            bookbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookbtn.Location = new Point(472, 104);
            bookbtn.Name = "bookbtn";
            bookbtn.Size = new Size(94, 43);
            bookbtn.TabIndex = 3;
            bookbtn.Text = "Booking";
            bookbtn.UseVisualStyleBackColor = true;
            bookbtn.Click += bookbtn_Click;
            // 
            // lstsearchresults
            // 
            lstsearchresults.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstsearchresults.FormattingEnabled = true;
            lstsearchresults.Location = new Point(66, 33);
            lstsearchresults.Name = "lstsearchresults";
            lstsearchresults.Size = new Size(221, 64);
            lstsearchresults.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(182, 86);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbCategory);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(182, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 43);
            panel2.TabIndex = 6;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(95, 4);
            cbCategory.Margin = new Padding(3, 4, 3, 4);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(138, 28);
            cbCategory.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 7);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 6;
            label2.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 20);
            label1.Name = "label1";
            label1.Size = new Size(291, 20);
            label1.TabIndex = 4;
            label1.Text = "choose how do you want filter events";
            // 
            // btnsearch
            // 
            btnsearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnsearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsearch.Location = new Point(230, 48);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(94, 32);
            btnsearch.TabIndex = 2;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Date", "Category", "Price" });
            comboBox1.Location = new Point(330, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(label8);
            panel5.Controls.Add(txtupdateseats);
            panel5.Controls.Add(button2);
            panel5.Location = new Point(444, 484);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 178);
            panel5.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(49, 9);
            label8.Name = "label8";
            label8.Size = new Size(161, 40);
            label8.TabIndex = 14;
            label8.Text = "Enter the new number\r\n         of seats";
            // 
            // txtupdateseats
            // 
            txtupdateseats.Location = new Point(63, 52);
            txtupdateseats.Name = "txtupdateseats";
            txtupdateseats.Size = new Size(115, 27);
            txtupdateseats.TabIndex = 13;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(42, 99);
            button2.Name = "button2";
            button2.Size = new Size(168, 61);
            button2.TabIndex = 12;
            button2.Text = "Update my booking\r\n    seats number\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panelC
            // 
            panelC.Anchor = AnchorStyles.None;
            panelC.Controls.Add(panel4);
            panelC.Controls.Add(listBox1);
            panelC.Controls.Add(panelID);
            panelC.Controls.Add(linkLabel1);
            panelC.Controls.Add(view);
            panelC.Controls.Add(txtidtocancel);
            panelC.Controls.Add(label3);
            panelC.Location = new Point(635, 51);
            panelC.Name = "panelC";
            panelC.Size = new Size(520, 427);
            panelC.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(cnclbtn);
            panel4.Location = new Point(59, 355);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(379, 60);
            panel4.TabIndex = 7;
            // 
            // cnclbtn
            // 
            cnclbtn.Location = new Point(120, 4);
            cnclbtn.Name = "cnclbtn";
            cnclbtn.Size = new Size(155, 43);
            cnclbtn.TabIndex = 3;
            cnclbtn.Text = "Cancel my Booking";
            cnclbtn.UseVisualStyleBackColor = true;
            cnclbtn.Click += cnclbtn_Click;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(27, 306);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(446, 27);
            listBox1.TabIndex = 2;
            // 
            // panelID
            // 
            panelID.Controls.Add(GetID);
            panelID.Controls.Add(tbEmail);
            panelID.Controls.Add(tbName);
            panelID.Controls.Add(label7);
            panelID.Controls.Add(label6);
            panelID.Location = new Point(27, 115);
            panelID.Margin = new Padding(3, 4, 3, 4);
            panelID.Name = "panelID";
            panelID.Size = new Size(445, 173);
            panelID.TabIndex = 6;
            // 
            // GetID
            // 
            GetID.Location = new Point(158, 132);
            GetID.Margin = new Padding(3, 4, 3, 4);
            GetID.Name = "GetID";
            GetID.Size = new Size(83, 33);
            GetID.TabIndex = 4;
            GetID.Text = "Get ID";
            GetID.UseVisualStyleBackColor = true;
            GetID.Click += GetID_Click;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(193, 73);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(236, 27);
            tbEmail.TabIndex = 3;
            // 
            // tbName
            // 
            tbName.Location = new Point(193, 27);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(114, 27);
            tbName.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 73);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 1;
            label7.Text = "enter your email :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 31);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 0;
            label6.Text = "enter your name :";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.FromArgb(192, 0, 192);
            linkLabel1.Location = new Point(119, 69);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(145, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "don't know your ID ?";
            linkLabel1.VisitedLinkColor = Color.FromArgb(255, 128, 255);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // view
            // 
            view.Location = new Point(283, 24);
            view.Name = "view";
            view.Size = new Size(155, 49);
            view.TabIndex = 4;
            view.Text = "View my bookings";
            view.UseVisualStyleBackColor = true;
            view.Click += view_Click;
            // 
            // txtidtocancel
            // 
            txtidtocancel.Location = new Point(126, 24);
            txtidtocancel.Name = "txtidtocancel";
            txtidtocancel.Size = new Size(125, 27);
            txtidtocancel.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 27);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 0;
            label3.Text = "enter your ID :";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.PaleGoldenrod;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1017, 15);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 4;
            button1.Text = "back to mainpage";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnseatreserved
            // 
            btnseatreserved.Anchor = AnchorStyles.None;
            btnseatreserved.BackColor = Color.PaleGoldenrod;
            btnseatreserved.FlatStyle = FlatStyle.Popup;
            btnseatreserved.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnseatreserved.Location = new Point(337, 12);
            btnseatreserved.Name = "btnseatreserved";
            btnseatreserved.Size = new Size(191, 29);
            btnseatreserved.TabIndex = 5;
            btnseatreserved.Text = "Update seats reserved";
            btnseatreserved.UseVisualStyleBackColor = false;
            btnseatreserved.Click += btnseatreserved_Click;
            // 
            // searchpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1215, 711);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(btnseatreserved);
            Controls.Add(panelC);
            Controls.Add(button1);
            Controls.Add(cancelbtn);
            Controls.Add(reservebtn);
            Name = "searchpage";
            Text = "searchpage";
            Load += searchpage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelresult.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panelC.ResumeLayout(false);
            panelC.PerformLayout();
            panel4.ResumeLayout(false);
            panelID.ResumeLayout(false);
            panelID.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button reservebtn;
        private Button cancelbtn;
        private Panel panel1;
        private ComboBox comboBox1;
        
        private Label label1;
        private Button bookbtn;
        private Button btnsearch;
        private Panel panel2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox txtmax;
        private TextBox txtmin;
        private Panel panelC;
        private TextBox txtidtocancel;
        private Label label3;
        private Button cnclbtn;
        private ListBox listBox1;
        private Button view;
        private Button button1;
        private Label label5;
        private Panel panel3;
        private Label label4;
        private Panel panelresult;
        private LinkLabel linkLabel1;
        private Panel panelID;
        private Button GetID;
        private TextBox tbEmail;
        private TextBox tbName;
        private Label label7;
        private Label label6;
        private Panel panel4;
        private ComboBox cbCategory;
        private Panel panel5;
        private Button btnseatreserved;
       
        private ListBox lstsearchresults;
        private TextBox txtupdateseats;
        private Button button2;
        private Label label8;
    }
}