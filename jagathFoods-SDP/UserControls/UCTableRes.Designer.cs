namespace jagathFoods_SDP.UserControls
{
    partial class UCTableRes
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            tblContainerMain = new Guna.UI2.WinForms.Guna2ContainerControl();
            tblSea = new Guna.UI2.WinForms.Guna2Button();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            uC_TableSearch1 = new UC_TableSearch();
            uc_AddRes1 = new Uc_AddRes();
            tblres = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            tblContainerMain.SuspendLayout();
            guna2ContainerControl1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(267, 37);
            label1.TabIndex = 1;
            label1.Text = "Table Reservation";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // tblContainerMain
            // 
            tblContainerMain.Controls.Add(tblSea);
            tblContainerMain.Controls.Add(guna2ContainerControl1);
            tblContainerMain.Controls.Add(tblres);
            tblContainerMain.CustomizableEdges = customizableEdges7;
            tblContainerMain.FillColor = Color.FromArgb(54, 41, 153);
            tblContainerMain.Location = new Point(15, 49);
            tblContainerMain.Name = "tblContainerMain";
            tblContainerMain.ShadowDecoration.CustomizableEdges = customizableEdges8;
            tblContainerMain.Size = new Size(682, 413);
            tblContainerMain.TabIndex = 3;
            tblContainerMain.Text = "guna2ContainerControl1";
            // 
            // tblSea
            // 
            tblSea.CustomizableEdges = customizableEdges1;
            tblSea.DisabledState.BorderColor = Color.DarkGray;
            tblSea.DisabledState.CustomBorderColor = Color.DarkGray;
            tblSea.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            tblSea.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            tblSea.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tblSea.ForeColor = Color.White;
            tblSea.Location = new Point(172, 17);
            tblSea.Name = "tblSea";
            tblSea.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tblSea.Size = new Size(145, 34);
            tblSea.TabIndex = 1;
            tblSea.Text = "Search Reservation";
            tblSea.Click += tblSea_Click;
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.Controls.Add(uC_TableSearch1);
            guna2ContainerControl1.Controls.Add(uc_AddRes1);
            guna2ContainerControl1.CustomizableEdges = customizableEdges3;
            guna2ContainerControl1.Location = new Point(16, 50);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ContainerControl1.Size = new Size(644, 353);
            guna2ContainerControl1.TabIndex = 1;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // uC_TableSearch1
            // 
            uC_TableSearch1.BackColor = Color.FromArgb(201, 214, 223);
            uC_TableSearch1.Location = new Point(0, 3);
            uC_TableSearch1.Name = "uC_TableSearch1";
            uC_TableSearch1.Size = new Size(644, 353);
            uC_TableSearch1.TabIndex = 1;
            // 
            // uc_AddRes1
            // 
            uc_AddRes1.BackColor = Color.FromArgb(201, 214, 223);
            uc_AddRes1.Location = new Point(3, -3);
            uc_AddRes1.Name = "uc_AddRes1";
            uc_AddRes1.Size = new Size(644, 356);
            uc_AddRes1.TabIndex = 0;
            // 
            // tblres
            // 
            tblres.CustomizableEdges = customizableEdges5;
            tblres.DisabledState.BorderColor = Color.DarkGray;
            tblres.DisabledState.CustomBorderColor = Color.DarkGray;
            tblres.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            tblres.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            tblres.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tblres.ForeColor = Color.White;
            tblres.Location = new Point(16, 17);
            tblres.Name = "tblres";
            tblres.ShadowDecoration.CustomizableEdges = customizableEdges6;
            tblres.Size = new Size(145, 34);
            tblres.TabIndex = 0;
            tblres.Text = "Add Reservation";
            tblres.Click += tblres_Click;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 20;
            guna2Elipse2.TargetControl = tblContainerMain;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 20;
            guna2Elipse3.TargetControl = uc_AddRes1;
            // 
            // UCTableRes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 121, 155);
            Controls.Add(tblContainerMain);
            Controls.Add(label1);
            Name = "UCTableRes";
            Size = new Size(719, 480);
            Load += UCTableRes_Load;
            tblContainerMain.ResumeLayout(false);
            guna2ContainerControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ContainerControl tblContainerMain;
        private Guna.UI2.WinForms.Guna2Button tblres;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Uc_AddRes uc_AddRes1;
        private Guna.UI2.WinForms.Guna2Button tblSea;
        private UC_TableSearch uC_TableSearch1;
    }
}
