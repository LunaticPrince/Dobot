namespace Dobot
{
    partial class DobotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DobotForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGestion = new System.Windows.Forms.Button();
            this.PnlSide = new System.Windows.Forms.Panel();
            this.BtnPersonnages = new System.Windows.Forms.Button();
            this.BtnModeAutomatique = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEquipes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.gestionControl1 = new Dobot.GestionControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.BtnGestion);
            this.panel1.Controls.Add(this.PnlSide);
            this.panel1.Controls.Add(this.BtnPersonnages);
            this.panel1.Controls.Add(this.BtnModeAutomatique);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.BtnEquipes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 611);
            this.panel1.TabIndex = 0;
            // 
            // BtnGestion
            // 
            this.BtnGestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGestion.FlatAppearance.BorderSize = 0;
            this.BtnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestion.ForeColor = System.Drawing.Color.White;
            this.BtnGestion.Image = ((System.Drawing.Image)(resources.GetObject("BtnGestion.Image")));
            this.BtnGestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGestion.Location = new System.Drawing.Point(9, 56);
            this.BtnGestion.Margin = new System.Windows.Forms.Padding(0);
            this.BtnGestion.Name = "BtnGestion";
            this.BtnGestion.Size = new System.Drawing.Size(210, 75);
            this.BtnGestion.TabIndex = 0;
            this.BtnGestion.TabStop = false;
            this.BtnGestion.Text = "   Gestion";
            this.BtnGestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGestion.UseVisualStyleBackColor = false;
            this.BtnGestion.Click += new System.EventHandler(this.button1_Click);
            // 
            // PnlSide
            // 
            this.PnlSide.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.PnlSide.Location = new System.Drawing.Point(0, 56);
            this.PnlSide.Name = "PnlSide";
            this.PnlSide.Size = new System.Drawing.Size(8, 75);
            this.PnlSide.TabIndex = 2;
            // 
            // BtnPersonnages
            // 
            this.BtnPersonnages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPersonnages.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPersonnages.BackgroundImage")));
            this.BtnPersonnages.FlatAppearance.BorderSize = 0;
            this.BtnPersonnages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonnages.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPersonnages.ForeColor = System.Drawing.Color.White;
            this.BtnPersonnages.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonnages.Image")));
            this.BtnPersonnages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPersonnages.Location = new System.Drawing.Point(9, 131);
            this.BtnPersonnages.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPersonnages.Name = "BtnPersonnages";
            this.BtnPersonnages.Size = new System.Drawing.Size(210, 75);
            this.BtnPersonnages.TabIndex = 1;
            this.BtnPersonnages.TabStop = false;
            this.BtnPersonnages.Text = "   Personnages";
            this.BtnPersonnages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPersonnages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPersonnages.UseVisualStyleBackColor = false;
            this.BtnPersonnages.Click += new System.EventHandler(this.BtnPersonnages_Click);
            // 
            // BtnModeAutomatique
            // 
            this.BtnModeAutomatique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnModeAutomatique.FlatAppearance.BorderSize = 0;
            this.BtnModeAutomatique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModeAutomatique.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModeAutomatique.ForeColor = System.Drawing.Color.White;
            this.BtnModeAutomatique.Image = ((System.Drawing.Image)(resources.GetObject("BtnModeAutomatique.Image")));
            this.BtnModeAutomatique.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModeAutomatique.Location = new System.Drawing.Point(9, 281);
            this.BtnModeAutomatique.Margin = new System.Windows.Forms.Padding(0);
            this.BtnModeAutomatique.Name = "BtnModeAutomatique";
            this.BtnModeAutomatique.Size = new System.Drawing.Size(210, 75);
            this.BtnModeAutomatique.TabIndex = 3;
            this.BtnModeAutomatique.TabStop = false;
            this.BtnModeAutomatique.Text = "   Mode Automatique";
            this.BtnModeAutomatique.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModeAutomatique.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModeAutomatique.UseVisualStyleBackColor = false;
            this.BtnModeAutomatique.Click += new System.EventHandler(this.BtnModeAutomatique_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel3.Controls.Add(this.label1);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 56);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(9, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 56);
            this.label1.TabIndex = 8;
            this.label1.Text = "DOBOT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnEquipes
            // 
            this.BtnEquipes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEquipes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEquipes.BackgroundImage")));
            this.BtnEquipes.FlatAppearance.BorderSize = 0;
            this.BtnEquipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquipes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquipes.ForeColor = System.Drawing.Color.White;
            this.BtnEquipes.Image = ((System.Drawing.Image)(resources.GetObject("BtnEquipes.Image")));
            this.BtnEquipes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEquipes.Location = new System.Drawing.Point(9, 206);
            this.BtnEquipes.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEquipes.Name = "BtnEquipes";
            this.BtnEquipes.Size = new System.Drawing.Size(210, 75);
            this.BtnEquipes.TabIndex = 2;
            this.BtnEquipes.TabStop = false;
            this.BtnEquipes.Text = "   Équipes";
            this.BtnEquipes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEquipes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEquipes.UseVisualStyleBackColor = false;
            this.BtnEquipes.Click += new System.EventHandler(this.BtnEquipes_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel2.Controls.Add(this.BtnQuit);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.BtnSettings);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(219, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 56);
            this.panel2.TabIndex = 1;
            // 
            // BtnQuit
            // 
            this.BtnQuit.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnQuit.BackgroundImage")));
            this.BtnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnQuit.FlatAppearance.BorderSize = 0;
            this.BtnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuit.ForeColor = System.Drawing.Color.White;
            this.BtnQuit.Location = new System.Drawing.Point(872, 0);
            this.BtnQuit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(58, 56);
            this.BtnQuit.TabIndex = 1;
            this.BtnQuit.TabStop = false;
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(814, -2);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 58);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSettings.BackgroundImage")));
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.Color.White;
            this.BtnSettings.Location = new System.Drawing.Point(756, 0);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(58, 56);
            this.BtnSettings.TabIndex = 2;
            this.BtnSettings.TabStop = false;
            this.BtnSettings.UseVisualStyleBackColor = false;
            // 
            // gestionControl1
            // 
            this.gestionControl1.Location = new System.Drawing.Point(219, 56);
            this.gestionControl1.Name = "gestionControl1";
            this.gestionControl1.Size = new System.Drawing.Size(930, 555);
            this.gestionControl1.TabIndex = 2;
            // 
            // DobotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1149, 611);
            this.Controls.Add(this.gestionControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DobotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dobot";
            this.Load += new System.EventHandler(this.Dobot_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGestion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnModeAutomatique;
        private System.Windows.Forms.Button BtnEquipes;
        private System.Windows.Forms.Button BtnPersonnages;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlSide;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Button button1;
        private GestionControl gestionControl1;
    }
}

