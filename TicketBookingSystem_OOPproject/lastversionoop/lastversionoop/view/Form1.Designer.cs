using lastversionoop.model;
namespace lastversionoop
{
    partial class Form1
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
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            picBoxAdmin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxAdmin).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.LightSkyBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(859, 364);
            button2.Name = "button2";
            button2.Size = new Size(147, 76);
            button2.TabIndex = 2;
            button2.Text = "Book Event Now";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(814, 113);
            label1.Name = "label1";
            label1.Size = new Size(181, 39);
            label1.TabIndex = 3;
            label1.Text = "WELCOME!";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(763, 205);
            label2.Name = "label2";
            label2.Size = new Size(338, 91);
            label2.TabIndex = 4;
            label2.Text = "Book Your Tickets Now\r\n        Get ready to \r\n enjoy wonderful experiences !";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.picture_oop;
            pictureBox2.Location = new Point(14, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(919, 549);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // picBoxAdmin
            // 
            picBoxAdmin.Anchor = AnchorStyles.None;
            picBoxAdmin.Image = Properties.Resources.picAdmin;
            picBoxAdmin.Location = new Point(397, 512);
            picBoxAdmin.Margin = new Padding(3, 4, 3, 4);
            picBoxAdmin.Name = "picBoxAdmin";
            picBoxAdmin.Size = new Size(163, 123);
            picBoxAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxAdmin.TabIndex = 7;
            picBoxAdmin.TabStop = false;
            picBoxAdmin.Click += picBoxAdmin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1227, 696);
            Controls.Add(picBoxAdmin);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "main form";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox picBoxAdmin;
    }
}