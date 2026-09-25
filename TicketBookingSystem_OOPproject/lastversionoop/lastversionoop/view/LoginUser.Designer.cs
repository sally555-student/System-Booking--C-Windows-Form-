namespace lastversionoop
{
    partial class LoginUser
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
            panel1 = new Panel();
            label5 = new Label();
            txtseatnb = new TextBox();
            btnbooking = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtbookedevent = new TextBox();
            txtcontact = new TextBox();
            txtid = new TextBox();
            txtname = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtseatnb);
            panel1.Controls.Add(btnbooking);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtbookedevent);
            panel1.Controls.Add(txtcontact);
            panel1.Controls.Add(txtid);
            panel1.Controls.Add(txtname);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-62, -24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1117, 621);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 227);
            label5.Name = "label5";
            label5.Size = new Size(136, 40);
            label5.TabIndex = 21;
            label5.Text = "    enter number \r\nof seats to reserve :";
            // 
            // txtseatnb
            // 
            txtseatnb.Location = new Point(254, 236);
            txtseatnb.Name = "txtseatnb";
            txtseatnb.Size = new Size(125, 27);
            txtseatnb.TabIndex = 20;
            txtseatnb.Leave += txtseatnb_Leave;
            // 
            // btnbooking
            // 
            btnbooking.BackColor = SystemColors.ControlDark;
            btnbooking.Cursor = Cursors.Hand;
            btnbooking.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnbooking.Location = new Point(630, 151);
            btnbooking.Name = "btnbooking";
            btnbooking.Size = new Size(159, 97);
            btnbooking.TabIndex = 19;
            btnbooking.Text = "Confirm Booking";
            btnbooking.UseVisualStyleBackColor = false;
            btnbooking.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(104, 404);
            label4.Name = "label4";
            label4.Size = new Size(113, 22);
            label4.TabIndex = 18;
            label4.Text = "Booked Event";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 123);
            label3.Name = "label3";
            label3.Size = new Size(129, 22);
            label3.TabIndex = 17;
            label3.Text = "Contact [Email]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(142, 333);
            label2.Name = "label2";
            label2.Size = new Size(30, 22);
            label2.TabIndex = 16;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 80);
            label1.Name = "label1";
            label1.Size = new Size(61, 22);
            label1.TabIndex = 15;
            label1.Text = "Name :";
            // 
            // txtbookedevent
            // 
            txtbookedevent.Location = new Point(254, 396);
            txtbookedevent.Name = "txtbookedevent";
            txtbookedevent.ReadOnly = true;
            txtbookedevent.Size = new Size(125, 27);
            txtbookedevent.TabIndex = 14;
            // 
            // txtcontact
            // 
            txtcontact.Location = new Point(193, 120);
            txtcontact.Name = "txtcontact";
            txtcontact.Size = new Size(273, 27);
            txtcontact.TabIndex = 13;
            txtcontact.Leave += txtcontact_Leave;
            // 
            // txtid
            // 
            txtid.Location = new Point(254, 331);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(125, 27);
            txtid.TabIndex = 12;
            // 
            // txtname
            // 
            txtname.Location = new Point(205, 80);
            txtname.Name = "txtname";
            txtname.Size = new Size(215, 27);
            txtname.TabIndex = 11;
            txtname.Text = "\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.piclogin;
            pictureBox1.Location = new Point(472, 30);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(626, 571);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // LoginUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1050, 612);
            Controls.Add(panel1);
            Name = "LoginUser";
            Text = "LoginUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private TextBox txtseatnb;
        private Button btnbooking;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtbookedevent;
        private TextBox txtcontact;
        private TextBox txtid;
        private TextBox txtname;
        private PictureBox pictureBox1;
    }
}