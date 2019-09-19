namespace ProductsApp
{
    partial class Access
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Access));
            this.MasterTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTexBox = new System.Windows.Forms.TextBox();
            this.IngressButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.CloseApp = new System.Windows.Forms.Label();
            this.MasterTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MasterTableLayout
            // 
            this.MasterTableLayout.ColumnCount = 5;
            this.MasterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MasterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MasterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.MasterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MasterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MasterTableLayout.Controls.Add(this.UserLabel, 2, 3);
            this.MasterTableLayout.Controls.Add(this.UserTextBox, 2, 4);
            this.MasterTableLayout.Controls.Add(this.PasswordLabel, 2, 6);
            this.MasterTableLayout.Controls.Add(this.PasswordTexBox, 2, 7);
            this.MasterTableLayout.Controls.Add(this.IngressButton, 2, 9);
            this.MasterTableLayout.Controls.Add(this.LogoPictureBox, 1, 1);
            this.MasterTableLayout.Controls.Add(this.CloseApp, 4, 0);
            this.MasterTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MasterTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MasterTableLayout.Margin = new System.Windows.Forms.Padding(1);
            this.MasterTableLayout.Name = "MasterTableLayout";
            this.MasterTableLayout.RowCount = 11;
            this.MasterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MasterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MasterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MasterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MasterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MasterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MasterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MasterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MasterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MasterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MasterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MasterTableLayout.Size = new System.Drawing.Size(500, 350);
            this.MasterTableLayout.TabIndex = 1;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserLabel.Location = new System.Drawing.Point(128, 180);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(244, 20);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "Usuario";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserTextBox.Location = new System.Drawing.Point(128, 203);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(244, 20);
            this.UserTextBox.TabIndex = 3;
            this.UserTextBox.Text = "root";
            this.UserTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserTextBox_KeyDown);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordLabel.Location = new System.Drawing.Point(128, 240);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(244, 20);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Contraseña";
            // 
            // PasswordTexBox
            // 
            this.PasswordTexBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordTexBox.Location = new System.Drawing.Point(128, 263);
            this.PasswordTexBox.Name = "PasswordTexBox";
            this.PasswordTexBox.PasswordChar = '*';
            this.PasswordTexBox.Size = new System.Drawing.Size(244, 20);
            this.PasswordTexBox.TabIndex = 4;
            this.PasswordTexBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserTextBox_KeyDown);
            // 
            // IngressButton
            // 
            this.IngressButton.BackColor = System.Drawing.Color.Brown;
            this.IngressButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IngressButton.ForeColor = System.Drawing.Color.White;
            this.IngressButton.Location = new System.Drawing.Point(126, 301);
            this.IngressButton.Margin = new System.Windows.Forms.Padding(1);
            this.IngressButton.Name = "IngressButton";
            this.IngressButton.Size = new System.Drawing.Size(248, 28);
            this.IngressButton.TabIndex = 5;
            this.IngressButton.Text = "Ingresar";
            this.IngressButton.UseVisualStyleBackColor = false;
            this.IngressButton.Click += new System.EventHandler(this.IngressButton_Click);
            // 
            // LogoPictureBox
            // 
            this.MasterTableLayout.SetColumnSpan(this.LogoPictureBox, 3);
            this.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(33, 23);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(434, 134);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 6;
            this.LogoPictureBox.TabStop = false;
            // 
            // CloseApp
            // 
            this.CloseApp.AutoSize = true;
            this.CloseApp.BackColor = System.Drawing.Color.Brown;
            this.CloseApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseApp.ForeColor = System.Drawing.Color.White;
            this.CloseApp.Location = new System.Drawing.Point(470, 0);
            this.CloseApp.Margin = new System.Windows.Forms.Padding(0);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(30, 20);
            this.CloseApp.TabIndex = 7;
            this.CloseApp.Text = "X";
            this.CloseApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.MasterTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(800, 500);
            this.MaximumSize = new System.Drawing.Size(500, 350);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Access";
            this.MasterTableLayout.ResumeLayout(false);
            this.MasterTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MasterTableLayout;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTexBox;
        private System.Windows.Forms.Button IngressButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label CloseApp;
    }
}