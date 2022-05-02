namespace Library_Management_System
{
    partial class Form2
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
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.TransactionButton = new System.Windows.Forms.Button();
            this.BooksButton = new System.Windows.Forms.Button();
            this.BorrowerButton = new System.Windows.Forms.Button();
            this.slidingpanel_toggle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SlidingPanel.Controls.Add(this.AboutButton);
            this.SlidingPanel.Controls.Add(this.SettingsButton);
            this.SlidingPanel.Controls.Add(this.TransactionButton);
            this.SlidingPanel.Controls.Add(this.BooksButton);
            this.SlidingPanel.Controls.Add(this.BorrowerButton);
            this.SlidingPanel.Controls.Add(this.slidingpanel_toggle);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(231, 606);
            this.SlidingPanel.TabIndex = 0;
            this.SlidingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SlidingPanel_Paint);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.Location = new System.Drawing.Point(0, 317);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(231, 67);
            this.AboutButton.TabIndex = 6;
            this.AboutButton.Text = "ABOUT";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(0, 253);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(231, 67);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.Text = "SETTINGS";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // TransactionButton
            // 
            this.TransactionButton.BackColor = System.Drawing.Color.Transparent;
            this.TransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionButton.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransactionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionButton.Location = new System.Drawing.Point(0, 189);
            this.TransactionButton.Name = "TransactionButton";
            this.TransactionButton.Size = new System.Drawing.Size(231, 67);
            this.TransactionButton.TabIndex = 4;
            this.TransactionButton.Text = "TRANSACTIONS";
            this.TransactionButton.UseVisualStyleBackColor = false;
            this.TransactionButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // BooksButton
            // 
            this.BooksButton.BackColor = System.Drawing.Color.Transparent;
            this.BooksButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BooksButton.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BooksButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BooksButton.Location = new System.Drawing.Point(0, 63);
            this.BooksButton.Name = "BooksButton";
            this.BooksButton.Size = new System.Drawing.Size(231, 67);
            this.BooksButton.TabIndex = 3;
            this.BooksButton.Text = "BOOKS";
            this.BooksButton.UseVisualStyleBackColor = false;
            this.BooksButton.Click += new System.EventHandler(this.BooksButton_Click);
            // 
            // BorrowerButton
            // 
            this.BorrowerButton.BackColor = System.Drawing.Color.Transparent;
            this.BorrowerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowerButton.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BorrowerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrowerButton.Location = new System.Drawing.Point(0, 126);
            this.BorrowerButton.Name = "BorrowerButton";
            this.BorrowerButton.Size = new System.Drawing.Size(231, 67);
            this.BorrowerButton.TabIndex = 2;
            this.BorrowerButton.Text = "BORROWERS";
            this.BorrowerButton.UseVisualStyleBackColor = false;
            this.BorrowerButton.Click += new System.EventHandler(this.BorrowerButton_Click);
            // 
            // slidingpanel_toggle
            // 
            this.slidingpanel_toggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.slidingpanel_toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slidingpanel_toggle.Location = new System.Drawing.Point(0, 0);
            this.slidingpanel_toggle.Name = "slidingpanel_toggle";
            this.slidingpanel_toggle.Size = new System.Drawing.Size(231, 67);
            this.slidingpanel_toggle.TabIndex = 1;
            this.slidingpanel_toggle.UseVisualStyleBackColor = true;
            this.slidingpanel_toggle.Click += new System.EventHandler(this.slidingpanel_toggle_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 606);
            this.Controls.Add(this.SlidingPanel);
            this.Name = "Form2";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SlidingPanel;
        private Button slidingpanel_toggle;
        private System.Windows.Forms.Timer timer1;
        private Button AboutButton;
        private Button SettingsButton;
        private Button TransactionButton;
        private Button BooksButton;
        private Button BorrowerButton;
    }
}