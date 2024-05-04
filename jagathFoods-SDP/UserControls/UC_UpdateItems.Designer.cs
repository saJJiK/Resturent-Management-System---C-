namespace jagathFoods_SDP.UserControls
{
    partial class UC_UpdateItems
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            txtSeacrhItemUpd = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            label2 = new Label();
            label4 = new Label();
            txtNameUpd = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            txtPriceUpd = new Guna.UI2.WinForms.Guna2TextBox();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            txtItemCategoryUpd = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 37);
            label1.TabIndex = 5;
            label1.Text = "Update Item";
            // 
            // txtSeacrhItemUpd
            // 
            txtSeacrhItemUpd.BorderRadius = 15;
            txtSeacrhItemUpd.CustomizableEdges = customizableEdges9;
            txtSeacrhItemUpd.DefaultText = "";
            txtSeacrhItemUpd.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSeacrhItemUpd.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSeacrhItemUpd.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSeacrhItemUpd.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSeacrhItemUpd.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSeacrhItemUpd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSeacrhItemUpd.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSeacrhItemUpd.Location = new Point(483, 39);
            txtSeacrhItemUpd.Name = "txtSeacrhItemUpd";
            txtSeacrhItemUpd.PasswordChar = '\0';
            txtSeacrhItemUpd.PlaceholderText = "";
            txtSeacrhItemUpd.SelectedText = "";
            txtSeacrhItemUpd.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSeacrhItemUpd.Size = new Size(187, 36);
            txtSeacrhItemUpd.TabIndex = 5;
            txtSeacrhItemUpd.TextChanged += txtSeacrhItemUpd_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(159, 230, 220);
            label3.Location = new Point(386, 49);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 2;
            label3.Text = "Item Name";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(36, 92);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowTemplate.Height = 25;
            guna2DataGridView1.Size = new Size(634, 243);
            guna2DataGridView1.TabIndex = 6;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellClick += guna2DataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(159, 230, 220);
            label2.Location = new Point(35, 364);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 7;
            label2.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(159, 230, 220);
            label4.Location = new Point(35, 421);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 19);
            label4.TabIndex = 9;
            label4.Text = "Item Name";
            // 
            // txtNameUpd
            // 
            txtNameUpd.BorderRadius = 15;
            txtNameUpd.CustomizableEdges = customizableEdges7;
            txtNameUpd.DefaultText = "";
            txtNameUpd.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNameUpd.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNameUpd.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNameUpd.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNameUpd.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNameUpd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameUpd.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNameUpd.Location = new Point(141, 412);
            txtNameUpd.Name = "txtNameUpd";
            txtNameUpd.PasswordChar = '\0';
            txtNameUpd.PlaceholderText = "";
            txtNameUpd.SelectedText = "";
            txtNameUpd.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtNameUpd.Size = new Size(184, 36);
            txtNameUpd.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(159, 230, 220);
            label5.Location = new Point(416, 362);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 19);
            label5.TabIndex = 11;
            label5.Text = "Price";
            // 
            // txtPriceUpd
            // 
            txtPriceUpd.BorderRadius = 15;
            txtPriceUpd.CustomizableEdges = customizableEdges5;
            txtPriceUpd.DefaultText = "";
            txtPriceUpd.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPriceUpd.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPriceUpd.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPriceUpd.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPriceUpd.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPriceUpd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPriceUpd.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPriceUpd.Location = new Point(466, 355);
            txtPriceUpd.Name = "txtPriceUpd";
            txtPriceUpd.PasswordChar = '\0';
            txtPriceUpd.PlaceholderText = "";
            txtPriceUpd.SelectedText = "";
            txtPriceUpd.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPriceUpd.Size = new Size(184, 36);
            txtPriceUpd.TabIndex = 12;
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 25;
            btnUpdate.CustomizableEdges = customizableEdges3;
            btnUpdate.DisabledState.BorderColor = Color.DarkGray;
            btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdate.FillColor = Color.FromArgb(159, 230, 220);
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.FromArgb(48, 77, 78);
            btnUpdate.Location = new Point(482, 409);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnUpdate.Size = new Size(142, 47);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtItemCategoryUpd
            // 
            txtItemCategoryUpd.BackColor = Color.Transparent;
            txtItemCategoryUpd.BorderRadius = 15;
            txtItemCategoryUpd.CustomizableEdges = customizableEdges1;
            txtItemCategoryUpd.DrawMode = DrawMode.OwnerDrawFixed;
            txtItemCategoryUpd.DropDownStyle = ComboBoxStyle.DropDownList;
            txtItemCategoryUpd.FocusedColor = Color.FromArgb(94, 148, 255);
            txtItemCategoryUpd.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtItemCategoryUpd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemCategoryUpd.ForeColor = Color.FromArgb(68, 88, 112);
            txtItemCategoryUpd.ItemHeight = 30;
            txtItemCategoryUpd.Items.AddRange(new object[] { "Cakes and Bakery", "Beverages", "Desserts & Sweets", "Main Meals " });
            txtItemCategoryUpd.Location = new Point(141, 355);
            txtItemCategoryUpd.Margin = new Padding(4);
            txtItemCategoryUpd.Name = "txtItemCategoryUpd";
            txtItemCategoryUpd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtItemCategoryUpd.Size = new Size(184, 36);
            txtItemCategoryUpd.TabIndex = 14;
            // 
            // UC_UpdateItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 110, 110);
            Controls.Add(txtItemCategoryUpd);
            Controls.Add(btnUpdate);
            Controls.Add(label5);
            Controls.Add(txtPriceUpd);
            Controls.Add(label4);
            Controls.Add(txtNameUpd);
            Controls.Add(label2);
            Controls.Add(guna2DataGridView1);
            Controls.Add(label3);
            Controls.Add(txtSeacrhItemUpd);
            Controls.Add(label1);
            Name = "UC_UpdateItems";
            Size = new Size(720, 503);
            Load += UC_UpdateItems_Load;
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSeacrhItemUpd;
        private Label label3;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtPriceUpd;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtNameUpd;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2ComboBox txtItemCategoryUpd;
    }
}
