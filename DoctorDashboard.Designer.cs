
namespace WindowsFormsApp4
{
    partial class DoctorDashboard
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbar = new CircularProgressBar.CircularProgressBar();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.EarningBtn = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.PatNumBtn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Patients";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(344, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "patients";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(347, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 27);
            this.label1.TabIndex = 60;
            this.label1.Text = "Num";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbar
            // 
            this.pbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbar.AnimationSpeed = 500;
            this.pbar.BackColor = System.Drawing.Color.Transparent;
            this.pbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.pbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbar.InnerColor = System.Drawing.SystemColors.InactiveCaption;
            this.pbar.InnerMargin = 2;
            this.pbar.InnerWidth = -1;
            this.pbar.Location = new System.Drawing.Point(307, 161);
            this.pbar.MarqueeAnimationSpeed = 2000;
            this.pbar.Name = "pbar";
            this.pbar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))));
            this.pbar.OuterMargin = -25;
            this.pbar.OuterWidth = 25;
            this.pbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pbar.ProgressWidth = 17;
            this.pbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pbar.Size = new System.Drawing.Size(146, 133);
            this.pbar.StartAngle = 270;
            this.pbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbar.SubscriptText = "";
            this.pbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbar.SuperscriptText = "";
            this.pbar.TabIndex = 50;
            this.pbar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbar.Value = 40;
            this.pbar.Click += new System.EventHandler(this.pbar_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.EarningBtn);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(529, 482);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(289, 133);
            this.panel6.TabIndex = 58;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.icons8_money_bag_64;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(187, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(89, 84);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // EarningBtn
            // 
            this.EarningBtn.AutoSize = true;
            this.EarningBtn.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EarningBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))));
            this.EarningBtn.Location = new System.Drawing.Point(59, 64);
            this.EarningBtn.Name = "EarningBtn";
            this.EarningBtn.Size = new System.Drawing.Size(86, 38);
            this.EarningBtn.TabIndex = 1;
            this.EarningBtn.Text = "Num";
            this.EarningBtn.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(13, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Earnings";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(343, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 27);
            this.label8.TabIndex = 57;
            this.label8.Text = "Num";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(341, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = "patients";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel8.Controls.Add(this.pictureBox4);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Controls.Add(this.label18);
            this.panel8.Location = new System.Drawing.Point(529, 326);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(598, 133);
            this.panel8.TabIndex = 54;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.icons8_appointment_67;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(496, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 84);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))));
            this.label17.Location = new System.Drawing.Point(258, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 38);
            this.label17.TabIndex = 2;
            this.label17.Text = "Num";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(13, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(118, 19);
            this.label18.TabIndex = 1;
            this.label18.Text = "Appointments";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(222, 408);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 59;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel12.Controls.Add(this.pictureBox11);
            this.panel12.Controls.Add(this.label23);
            this.panel12.Controls.Add(this.label24);
            this.panel12.Location = new System.Drawing.Point(838, 482);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(289, 133);
            this.panel12.TabIndex = 53;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.icons8_doctors_64;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox11.Location = new System.Drawing.Point(187, 19);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(89, 84);
            this.pictureBox11.TabIndex = 5;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))));
            this.label23.Location = new System.Drawing.Point(59, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 38);
            this.label23.TabIndex = 1;
            this.label23.Text = "Num";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(13, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 19);
            this.label24.TabIndex = 0;
            this.label24.Text = "Doctors";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // PatNumBtn
            // 
            this.PatNumBtn.AutoSize = true;
            this.PatNumBtn.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatNumBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))));
            this.PatNumBtn.Location = new System.Drawing.Point(258, 64);
            this.PatNumBtn.Name = "PatNumBtn";
            this.PatNumBtn.Size = new System.Drawing.Size(86, 38);
            this.PatNumBtn.TabIndex = 1;
            this.PatNumBtn.Text = "Num";
            this.PatNumBtn.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.guna2Button6);
            this.panel1.Controls.Add(this.guna2Button5);
            this.panel1.Controls.Add(this.guna2Button4);
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.pictureBox12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 732);
            this.panel1.TabIndex = 48;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2Button6
            // 
            this.guna2Button6.AutoRoundedCorners = true;
            this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button6.BorderRadius = 21;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Image = global::WindowsFormsApp4.Properties.Resources.icons8_health_book_50;
            this.guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button6.Location = new System.Drawing.Point(5, 372);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.ShadowDecoration.BorderRadius = 26;
            this.guna2Button6.ShadowDecoration.Enabled = true;
            this.guna2Button6.Size = new System.Drawing.Size(180, 45);
            this.guna2Button6.TabIndex = 72;
            this.guna2Button6.Text = "Medical Record";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.AutoRoundedCorners = true;
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderRadius = 21;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Image = global::WindowsFormsApp4.Properties.Resources.icons8_customer_501;
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.Location = new System.Drawing.Point(5, 245);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.BorderRadius = 26;
            this.guna2Button5.ShadowDecoration.Enabled = true;
            this.guna2Button5.Size = new System.Drawing.Size(180, 45);
            this.guna2Button5.TabIndex = 71;
            this.guna2Button5.Text = "Patient";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.AutoRoundedCorners = true;
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 21;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = global::WindowsFormsApp4.Properties.Resources.icons8_dashboard_layout_48;
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.Location = new System.Drawing.Point(5, 173);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.BorderRadius = 26;
            this.guna2Button4.ShadowDecoration.Enabled = true;
            this.guna2Button4.Size = new System.Drawing.Size(180, 45);
            this.guna2Button4.TabIndex = 70;
            this.guna2Button4.Text = "Dashboard";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 21;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = global::WindowsFormsApp4.Properties.Resources.icons8_appointment_64__1_;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Location = new System.Drawing.Point(5, 307);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.BorderRadius = 26;
            this.guna2Button3.ShadowDecoration.Enabled = true;
            this.guna2Button3.Size = new System.Drawing.Size(180, 45);
            this.guna2Button3.TabIndex = 69;
            this.guna2Button3.Text = "Appointments";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::WindowsFormsApp4.Properties.Resources.icons8_logout_rounded_up_30;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(5, 682);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.BorderRadius = 26;
            this.guna2Button1.ShadowDecoration.Color = System.Drawing.Color.Navy;
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 67;
            this.guna2Button1.Text = "Log out";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 21;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::WindowsFormsApp4.Properties.Resources.icons8_therapy_50;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Location = new System.Drawing.Point(5, 436);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.BorderRadius = 26;
            this.guna2Button2.ShadowDecoration.Enabled = true;
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 68;
            this.guna2Button2.Text = "Therapy";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(65, 69);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 19);
            this.label21.TabIndex = 2;
            this.label21.Text = "Doctor";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.external_User_it_icematte_lafs;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox12.Location = new System.Drawing.Point(53, 12);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(82, 54);
            this.pictureBox12.TabIndex = 1;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.pictureBox7);
            this.panel3.Controls.Add(this.PatNumBtn);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(529, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(598, 133);
            this.panel3.TabIndex = 52;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.icons8_fever_64;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(496, 27);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(89, 84);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(188, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 55);
            this.panel2.TabIndex = 62;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.icons8_close_50;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(990, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 34);
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))));
            this.label22.Location = new System.Drawing.Point(6, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(187, 38);
            this.label22.TabIndex = 1;
            this.label22.Text = "Dashboard";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(41, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Woman";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(41, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Man";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))));
            this.label11.Location = new System.Drawing.Point(79, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "Num";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))));
            this.label12.Location = new System.Drawing.Point(110, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Num";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(228, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 103);
            this.panel5.TabIndex = 56;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // DoctorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1228, 732);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorDashboard";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar pbar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label EarningBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label PatNumBtn;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
    }
}