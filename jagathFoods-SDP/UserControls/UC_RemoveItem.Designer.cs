namespace jagathFoods_SDP.UserControls
{
    partial class UC_RemoveItem
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
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            label3 = new Label();
            txtSeacrhItemDel = new Guna.UI2.WinForms.Guna2TextBox();
            dataGridView1 = new DataGridView();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            DelLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label1.ForeColor = Color.FromArgb(255, 215, 190);
            label1.Location = new Point(24, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 37);
            label1.TabIndex = 6;
            label1.Text = "Delete Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 215, 190);
            label3.Location = new Point(393, 82);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 7;
            label3.Text = "Item Name";
            // 
            // txtSeacrhItemDel
            // 
            txtSeacrhItemDel.BorderRadius = 15;
            txtSeacrhItemDel.CustomizableEdges = customizableEdges1;
            txtSeacrhItemDel.DefaultText = "";
            txtSeacrhItemDel.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSeacrhItemDel.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSeacrhItemDel.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSeacrhItemDel.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSeacrhItemDel.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSeacrhItemDel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSeacrhItemDel.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSeacrhItemDel.Location = new Point(490, 72);
            txtSeacrhItemDel.Name = "txtSeacrhItemDel";
            txtSeacrhItemDel.PasswordChar = '\0';
            txtSeacrhItemDel.PlaceholderText = "";
            txtSeacrhItemDel.SelectedText = "";
            txtSeacrhItemDel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSeacrhItemDel.Size = new Size(187, 36);
            txtSeacrhItemDel.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.FromArgb(126, 73, 172);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.GridColor = Color.FromArgb(255, 215, 190);
            dataGridView1.Location = new Point(149, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(507, 250);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 15;
            guna2Elipse2.TargetControl = dataGridView1;
            // 
            // DelLabel
            // 
            DelLabel.AutoSize = true;
            DelLabel.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            DelLabel.ForeColor = Color.FromArgb(255, 215, 190);
            DelLabel.Location = new Point(24, 446);
            DelLabel.Margin = new Padding(4, 0, 4, 0);
            DelLabel.Name = "DelLabel";
            DelLabel.Size = new Size(44, 19);
            DelLabel.TabIndex = 10;
            DelLabel.Text = "label";
            DelLabel.TextAlign = ContentAlignment.MiddleCenter;
            DelLabel.Click += DelLabel_Click;
            // 
            // UC_RemoveItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(126, 73, 172);
            Controls.Add(DelLabel);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(txtSeacrhItemDel);
            Controls.Add(label1);
            Name = "UC_RemoveItem";
            Size = new Size(720, 503);
            Load += UC_RemoveItem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSeacrhItemDel;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Label DelLabel;
    }
}
