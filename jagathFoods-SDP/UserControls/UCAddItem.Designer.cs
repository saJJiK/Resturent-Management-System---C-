namespace jagathFoods_SDP.UserControls
{
    partial class UCAddItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtItemCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            txtItemName = new Guna.UI2.WinForms.Guna2TextBox();
            TxtItemPrice = new Guna.UI2.WinForms.Guna2TextBox();
            btnAddItem = new Guna.UI2.WinForms.Guna2Button();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            guna2ContainerControl2 = new Guna.UI2.WinForms.Guna2ContainerControl();
            pictureBox1 = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2ContainerControl1.SuspendLayout();
            guna2ContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 0;
            label1.Text = "Add Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(56, 46);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(56, 130);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 2;
            label3.Text = "Item Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(66, 209);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 19);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // txtItemCategory
            // 
            txtItemCategory.BackColor = Color.Transparent;
            txtItemCategory.BorderRadius = 15;
            txtItemCategory.CustomizableEdges = customizableEdges1;
            txtItemCategory.DrawMode = DrawMode.OwnerDrawFixed;
            txtItemCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            txtItemCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            txtItemCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtItemCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemCategory.ForeColor = Color.FromArgb(68, 88, 112);
            txtItemCategory.ItemHeight = 30;
            txtItemCategory.Items.AddRange(new object[] { "Cakes and Bakery", "Beverages", "Desserts & Sweets", "Main Meals " });
            txtItemCategory.Location = new Point(42, 29);
            txtItemCategory.Margin = new Padding(4);
            txtItemCategory.Name = "txtItemCategory";
            txtItemCategory.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtItemCategory.Size = new Size(146, 36);
            txtItemCategory.TabIndex = 4;
            // 
            // txtItemName
            // 
            txtItemName.BorderRadius = 15;
            txtItemName.CustomizableEdges = customizableEdges3;
            txtItemName.DefaultText = "";
            txtItemName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtItemName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtItemName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtItemName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtItemName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtItemName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtItemName.Location = new Point(42, 104);
            txtItemName.Name = "txtItemName";
            txtItemName.PasswordChar = '\0';
            txtItemName.PlaceholderText = "";
            txtItemName.SelectedText = "";
            txtItemName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtItemName.Size = new Size(247, 36);
            txtItemName.TabIndex = 5;
            // 
            // TxtItemPrice
            // 
            TxtItemPrice.BorderRadius = 15;
            TxtItemPrice.CustomizableEdges = customizableEdges5;
            TxtItemPrice.DefaultText = "";
            TxtItemPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxtItemPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxtItemPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxtItemPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxtItemPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtItemPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtItemPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtItemPrice.Location = new Point(42, 179);
            TxtItemPrice.Name = "TxtItemPrice";
            TxtItemPrice.PasswordChar = '\0';
            TxtItemPrice.PlaceholderText = "";
            TxtItemPrice.SelectedText = "";
            TxtItemPrice.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TxtItemPrice.Size = new Size(247, 36);
            TxtItemPrice.TabIndex = 6;
            // 
            // btnAddItem
            // 
            btnAddItem.BorderRadius = 25;
            btnAddItem.CustomizableEdges = customizableEdges7;
            btnAddItem.DisabledState.BorderColor = Color.DarkGray;
            btnAddItem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddItem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddItem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddItem.FillColor = Color.FromArgb(0, 118, 221);
            btnAddItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(287, 402);
            btnAddItem.Margin = new Padding(4);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAddItem.Size = new Size(142, 47);
            btnAddItem.TabIndex = 7;
            btnAddItem.Text = "Add Items";
            btnAddItem.Click += btnAddItem_Click;
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.BackColor = Color.Transparent;
            guna2ContainerControl1.BorderRadius = 20;
            guna2ContainerControl1.Controls.Add(txtItemCategory);
            guna2ContainerControl1.Controls.Add(txtItemName);
            guna2ContainerControl1.Controls.Add(TxtItemPrice);
            guna2ContainerControl1.CustomizableEdges = customizableEdges9;
            guna2ContainerControl1.FillColor = Color.FromArgb(101, 121, 155);
            guna2ContainerControl1.Location = new Point(175, 14);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2ContainerControl1.Size = new Size(366, 268);
            guna2ContainerControl1.TabIndex = 8;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // guna2ContainerControl2
            // 
            guna2ContainerControl2.BackColor = Color.Transparent;
            guna2ContainerControl2.BorderRadius = 20;
            guna2ContainerControl2.Controls.Add(guna2ContainerControl1);
            guna2ContainerControl2.Controls.Add(label3);
            guna2ContainerControl2.Controls.Add(label4);
            guna2ContainerControl2.Controls.Add(label2);
            guna2ContainerControl2.CustomizableEdges = customizableEdges11;
            guna2ContainerControl2.FillColor = Color.FromArgb(182, 213, 225);
            guna2ContainerControl2.Location = new Point(82, 75);
            guna2ContainerControl2.Name = "guna2ContainerControl2";
            guna2ContainerControl2.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2ContainerControl2.Size = new Size(574, 303);
            guna2ContainerControl2.TabIndex = 9;
            guna2ContainerControl2.Text = "guna2ContainerControl2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.additemAnim;
            pictureBox1.Location = new Point(523, 354);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // UCAddItem
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(85, 82, 115);
            Controls.Add(guna2ContainerControl2);
            Controls.Add(btnAddItem);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UCAddItem";
            Size = new Size(720, 503);
            Leave += UCAddItem_Leave;
            guna2ContainerControl1.ResumeLayout(false);
            guna2ContainerControl2.ResumeLayout(false);
            guna2ContainerControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox txtItemCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtItemName;
        private Guna.UI2.WinForms.Guna2TextBox TxtItemPrice;
        private Guna.UI2.WinForms.Guna2Button btnAddItem;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
