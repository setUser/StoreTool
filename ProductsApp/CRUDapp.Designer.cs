namespace ProductsApp
{
    partial class CRUDapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDapp));
            this.MasterTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.IdListBox = new System.Windows.Forms.ListBox();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.PriceListBox = new System.Windows.Forms.ListBox();
            this.LastModifiedListBox = new System.Windows.Forms.ListBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.LastModifiedLabel = new System.Windows.Forms.Label();
            this.NameListBox = new System.Windows.Forms.ListBox();
            this.ControlTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Update = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel2 = new System.Windows.Forms.Label();
            this.CategoryLabel2 = new System.Windows.Forms.Label();
            this.NameLabel2 = new System.Windows.Forms.Label();
            this.PriceLabel2 = new System.Windows.Forms.Label();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.MasterTableLayout.SuspendLayout();
            this.ControlTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MasterTableLayout
            // 
            this.MasterTableLayout.BackColor = System.Drawing.Color.White;
            this.MasterTableLayout.ColumnCount = 6;
            this.MasterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MasterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MasterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MasterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MasterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.MasterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.MasterTableLayout.Controls.Add(this.IdListBox, 0, 1);
            this.MasterTableLayout.Controls.Add(this.CategoryListBox, 1, 1);
            this.MasterTableLayout.Controls.Add(this.PriceListBox, 3, 1);
            this.MasterTableLayout.Controls.Add(this.LastModifiedListBox, 4, 1);
            this.MasterTableLayout.Controls.Add(this.IdLabel, 0, 0);
            this.MasterTableLayout.Controls.Add(this.CategoryLabel, 1, 0);
            this.MasterTableLayout.Controls.Add(this.NameLabel, 2, 0);
            this.MasterTableLayout.Controls.Add(this.PriceLabel, 3, 0);
            this.MasterTableLayout.Controls.Add(this.LastModifiedLabel, 4, 0);
            this.MasterTableLayout.Controls.Add(this.NameListBox, 2, 1);
            this.MasterTableLayout.Controls.Add(this.ControlTableLayout, 4, 2);
            this.MasterTableLayout.Controls.Add(this.IdTextBox, 0, 3);
            this.MasterTableLayout.Controls.Add(this.CategoryTextBox, 1, 3);
            this.MasterTableLayout.Controls.Add(this.NameTextBox, 2, 3);
            this.MasterTableLayout.Controls.Add(this.PriceTextBox, 3, 3);
            this.MasterTableLayout.Controls.Add(this.IdLabel2, 0, 2);
            this.MasterTableLayout.Controls.Add(this.CategoryLabel2, 1, 2);
            this.MasterTableLayout.Controls.Add(this.NameLabel2, 2, 2);
            this.MasterTableLayout.Controls.Add(this.PriceLabel2, 3, 2);
            this.MasterTableLayout.Controls.Add(this.vScrollBar, 5, 1);
            this.MasterTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MasterTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MasterTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MasterTableLayout.Name = "MasterTableLayout";
            this.MasterTableLayout.RowCount = 4;
            this.MasterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MasterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MasterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MasterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MasterTableLayout.Size = new System.Drawing.Size(784, 666);
            this.MasterTableLayout.TabIndex = 3;
            // 
            // IdListBox
            // 
            this.IdListBox.BackColor = System.Drawing.Color.DarkCyan;
            this.IdListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdListBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdListBox.FormattingEnabled = true;
            this.IdListBox.ItemHeight = 16;
            this.IdListBox.Location = new System.Drawing.Point(1, 21);
            this.IdListBox.Margin = new System.Windows.Forms.Padding(1);
            this.IdListBox.Name = "IdListBox";
            this.IdListBox.Size = new System.Drawing.Size(48, 594);
            this.IdListBox.TabIndex = 10;
            this.IdListBox.SelectedIndexChanged += new System.EventHandler(this.IdListBox_SelectedIndexChanged);
            this.IdListBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListBoxes_KeyDown);
            this.IdListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IdListBox_MouseDown);
            this.IdListBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.MouseWheel_Event);
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryListBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.ItemHeight = 16;
            this.CategoryListBox.Location = new System.Drawing.Point(51, 21);
            this.CategoryListBox.Margin = new System.Windows.Forms.Padding(1);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(210, 594);
            this.CategoryListBox.TabIndex = 11;
            this.CategoryListBox.SelectedIndexChanged += new System.EventHandler(this.CategoryListBox_SelectedIndexChanged);
            this.CategoryListBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListBoxes_KeyDown);
            this.CategoryListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CategoryListBox_MouseDown);
            this.CategoryListBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.MouseWheel_Event);
            // 
            // PriceListBox
            // 
            this.PriceListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceListBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceListBox.FormattingEnabled = true;
            this.PriceListBox.ItemHeight = 16;
            this.PriceListBox.Location = new System.Drawing.Point(475, 21);
            this.PriceListBox.Margin = new System.Windows.Forms.Padding(1);
            this.PriceListBox.Name = "PriceListBox";
            this.PriceListBox.Size = new System.Drawing.Size(104, 594);
            this.PriceListBox.TabIndex = 13;
            this.PriceListBox.SelectedIndexChanged += new System.EventHandler(this.PriceListBox_SelectedIndexChanged);
            this.PriceListBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListBoxes_KeyDown);
            this.PriceListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PriceListBox_MouseDown);
            this.PriceListBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.MouseWheel_Event);
            // 
            // LastModifiedListBox
            // 
            this.LastModifiedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastModifiedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastModifiedListBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastModifiedListBox.FormattingEnabled = true;
            this.LastModifiedListBox.ItemHeight = 16;
            this.LastModifiedListBox.Location = new System.Drawing.Point(581, 21);
            this.LastModifiedListBox.Margin = new System.Windows.Forms.Padding(1);
            this.LastModifiedListBox.Name = "LastModifiedListBox";
            this.LastModifiedListBox.Size = new System.Drawing.Size(178, 594);
            this.LastModifiedListBox.TabIndex = 14;
            this.LastModifiedListBox.SelectedIndexChanged += new System.EventHandler(this.LastModifiedListBox_SelectedIndexChanged);
            this.LastModifiedListBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListBoxes_KeyDown);
            this.LastModifiedListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LastModifiedListBox_MouseDown);
            this.LastModifiedListBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.MouseWheel_Event);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.BackColor = System.Drawing.Color.MediumPurple;
            this.IdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdLabel.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.Color.White;
            this.IdLabel.Location = new System.Drawing.Point(1, 1);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(1);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(48, 18);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "Codigo";
            this.IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.BackColor = System.Drawing.Color.MediumPurple;
            this.CategoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryLabel.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.ForeColor = System.Drawing.Color.White;
            this.CategoryLabel.Location = new System.Drawing.Point(51, 1);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(1);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(210, 18);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Categoria";
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.MediumPurple;
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(263, 1);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(1);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(210, 18);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Nombre";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.Color.MediumPurple;
            this.PriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceLabel.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.White;
            this.PriceLabel.Location = new System.Drawing.Point(475, 1);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(1);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(104, 18);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Precio";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastModifiedLabel
            // 
            this.LastModifiedLabel.AutoSize = true;
            this.LastModifiedLabel.BackColor = System.Drawing.Color.MediumPurple;
            this.MasterTableLayout.SetColumnSpan(this.LastModifiedLabel, 2);
            this.LastModifiedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastModifiedLabel.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastModifiedLabel.ForeColor = System.Drawing.Color.White;
            this.LastModifiedLabel.Location = new System.Drawing.Point(581, 1);
            this.LastModifiedLabel.Margin = new System.Windows.Forms.Padding(1);
            this.LastModifiedLabel.Name = "LastModifiedLabel";
            this.LastModifiedLabel.Size = new System.Drawing.Size(202, 18);
            this.LastModifiedLabel.TabIndex = 4;
            this.LastModifiedLabel.Text = "Ultima Modificación";
            this.LastModifiedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameListBox
            // 
            this.NameListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameListBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameListBox.FormattingEnabled = true;
            this.NameListBox.ItemHeight = 16;
            this.NameListBox.Location = new System.Drawing.Point(263, 21);
            this.NameListBox.Margin = new System.Windows.Forms.Padding(1);
            this.NameListBox.Name = "NameListBox";
            this.NameListBox.Size = new System.Drawing.Size(210, 594);
            this.NameListBox.TabIndex = 12;
            this.NameListBox.SelectedIndexChanged += new System.EventHandler(this.NameListBox_SelectedIndexChanged);
            this.NameListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBoxes_KeyDown);
            this.NameListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NameListBox_MouseDown);
            this.NameListBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.MouseWheel_Event);
            // 
            // ControlTableLayout
            // 
            this.ControlTableLayout.ColumnCount = 3;
            this.MasterTableLayout.SetColumnSpan(this.ControlTableLayout, 2);
            this.ControlTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ControlTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ControlTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ControlTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ControlTableLayout.Controls.Add(this.Update, 0, 0);
            this.ControlTableLayout.Controls.Add(this.Add, 1, 0);
            this.ControlTableLayout.Controls.Add(this.Remove, 2, 0);
            this.ControlTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlTableLayout.Location = new System.Drawing.Point(580, 616);
            this.ControlTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.ControlTableLayout.Name = "ControlTableLayout";
            this.ControlTableLayout.RowCount = 1;
            this.MasterTableLayout.SetRowSpan(this.ControlTableLayout, 2);
            this.ControlTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlTableLayout.Size = new System.Drawing.Size(204, 50);
            this.ControlTableLayout.TabIndex = 15;
            // 
            // Update
            // 
            this.Update.AutoSize = true;
            this.Update.BackColor = System.Drawing.Color.BurlyWood;
            this.Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Update.Location = new System.Drawing.Point(1, 1);
            this.Update.Margin = new System.Windows.Forms.Padding(1);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(79, 48);
            this.Update.TabIndex = 0;
            this.Update.Text = "Update";
            this.Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Update.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.BackColor = System.Drawing.Color.BurlyWood;
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Location = new System.Drawing.Point(82, 1);
            this.Add.Margin = new System.Windows.Forms.Padding(1);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(59, 48);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Add.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // Remove
            // 
            this.Remove.AutoSize = true;
            this.Remove.BackColor = System.Drawing.Color.BurlyWood;
            this.Remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Remove.Location = new System.Drawing.Point(143, 1);
            this.Remove.Margin = new System.Windows.Forms.Padding(1);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(60, 48);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "Remove";
            this.Remove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Remove.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdTextBox.Location = new System.Drawing.Point(3, 644);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(44, 20);
            this.IdTextBox.TabIndex = 5;
            this.IdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxes_KeyDown);
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryTextBox.Location = new System.Drawing.Point(53, 644);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(206, 20);
            this.CategoryTextBox.TabIndex = 6;
            this.CategoryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxes_KeyDown);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTextBox.Location = new System.Drawing.Point(265, 644);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(206, 20);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxes_KeyDown);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceTextBox.Location = new System.Drawing.Point(477, 644);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 8;
            this.PriceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxes_KeyDown);
            // 
            // IdLabel2
            // 
            this.IdLabel2.AutoSize = true;
            this.IdLabel2.BackColor = System.Drawing.Color.BurlyWood;
            this.IdLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdLabel2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel2.Location = new System.Drawing.Point(1, 617);
            this.IdLabel2.Margin = new System.Windows.Forms.Padding(1);
            this.IdLabel2.Name = "IdLabel2";
            this.IdLabel2.Size = new System.Drawing.Size(48, 23);
            this.IdLabel2.TabIndex = 16;
            this.IdLabel2.Text = "Codigo";
            this.IdLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CategoryLabel2
            // 
            this.CategoryLabel2.AutoSize = true;
            this.CategoryLabel2.BackColor = System.Drawing.Color.BurlyWood;
            this.CategoryLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryLabel2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel2.Location = new System.Drawing.Point(51, 617);
            this.CategoryLabel2.Margin = new System.Windows.Forms.Padding(1);
            this.CategoryLabel2.Name = "CategoryLabel2";
            this.CategoryLabel2.Size = new System.Drawing.Size(210, 23);
            this.CategoryLabel2.TabIndex = 17;
            this.CategoryLabel2.Text = "Categoria";
            this.CategoryLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameLabel2
            // 
            this.NameLabel2.AutoSize = true;
            this.NameLabel2.BackColor = System.Drawing.Color.BurlyWood;
            this.NameLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel2.Location = new System.Drawing.Point(263, 617);
            this.NameLabel2.Margin = new System.Windows.Forms.Padding(1);
            this.NameLabel2.Name = "NameLabel2";
            this.NameLabel2.Size = new System.Drawing.Size(210, 23);
            this.NameLabel2.TabIndex = 18;
            this.NameLabel2.Text = "Nombre";
            this.NameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceLabel2
            // 
            this.PriceLabel2.AutoSize = true;
            this.PriceLabel2.BackColor = System.Drawing.Color.BurlyWood;
            this.PriceLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceLabel2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel2.Location = new System.Drawing.Point(475, 617);
            this.PriceLabel2.Margin = new System.Windows.Forms.Padding(1);
            this.PriceLabel2.Name = "PriceLabel2";
            this.PriceLabel2.Size = new System.Drawing.Size(104, 23);
            this.PriceLabel2.TabIndex = 19;
            this.PriceLabel2.Text = "Precio";
            this.PriceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBar.Location = new System.Drawing.Point(760, 20);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(24, 596);
            this.vScrollBar.TabIndex = 20;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar_Scroll);
            // 
            // CRUDapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 666);
            this.Controls.Add(this.MasterTableLayout);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 705);
            this.Name = "CRUDapp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Productos El Pancito";
            this.MasterTableLayout.ResumeLayout(false);
            this.MasterTableLayout.PerformLayout();
            this.ControlTableLayout.ResumeLayout(false);
            this.ControlTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel MasterTableLayout;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label LastModifiedLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.ListBox IdListBox;
        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.ListBox NameListBox;
        private System.Windows.Forms.ListBox PriceListBox;
        private System.Windows.Forms.ListBox LastModifiedListBox;
        private System.Windows.Forms.TableLayoutPanel ControlTableLayout;
        private System.Windows.Forms.Label IdLabel2;
        private System.Windows.Forms.Label CategoryLabel2;
        private System.Windows.Forms.Label NameLabel2;
        private System.Windows.Forms.Label PriceLabel2;
        private System.Windows.Forms.Label Update;
        private System.Windows.Forms.Label Add;
        private System.Windows.Forms.Label Remove;
        private System.Windows.Forms.VScrollBar vScrollBar;
    }
}

