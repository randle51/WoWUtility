namespace WoWUtility
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblWP1 = new System.Windows.Forms.Label();
            this.lblWP2 = new System.Windows.Forms.Label();
            this.btnDurchsuchen1 = new System.Windows.Forms.Button();
            this.btnDurchsuchen2 = new System.Windows.Forms.Button();
            this.clbAddons = new System.Windows.Forms.CheckedListBox();
            this.clbWTF = new System.Windows.Forms.CheckedListBox();
            this.lblAddons = new System.Windows.Forms.Label();
            this.lblWTF = new System.Windows.Forms.Label();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnMacro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPath1
            // 
            this.txtPath1.Location = new System.Drawing.Point(166, 58);
            this.txtPath1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(522, 26);
            this.txtPath1.TabIndex = 0;
            this.txtPath1.Text = "C:\\Program Files (x86)\\World of Warcraft";
            // 
            // txtPath2
            // 
            this.txtPath2.Location = new System.Drawing.Point(166, 98);
            this.txtPath2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(522, 26);
            this.txtPath2.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(166, 138);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(150, 35);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblWP1
            // 
            this.lblWP1.AutoSize = true;
            this.lblWP1.Location = new System.Drawing.Point(54, 58);
            this.lblWP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWP1.Name = "lblWP1";
            this.lblWP1.Size = new System.Drawing.Size(98, 20);
            this.lblWP1.TabIndex = 3;
            this.lblWP1.Text = "WoW Path 1";
            // 
            // lblWP2
            // 
            this.lblWP2.AutoSize = true;
            this.lblWP2.Location = new System.Drawing.Point(54, 98);
            this.lblWP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWP2.Name = "lblWP2";
            this.lblWP2.Size = new System.Drawing.Size(98, 20);
            this.lblWP2.TabIndex = 4;
            this.lblWP2.Text = "WoW Path 2";
            // 
            // btnDurchsuchen1
            // 
            this.btnDurchsuchen1.Location = new System.Drawing.Point(699, 55);
            this.btnDurchsuchen1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDurchsuchen1.Name = "btnDurchsuchen1";
            this.btnDurchsuchen1.Size = new System.Drawing.Size(150, 35);
            this.btnDurchsuchen1.TabIndex = 5;
            this.btnDurchsuchen1.Text = "...";
            this.btnDurchsuchen1.UseVisualStyleBackColor = true;
            this.btnDurchsuchen1.Click += new System.EventHandler(this.btnDurchsuchen1_Click);
            // 
            // btnDurchsuchen2
            // 
            this.btnDurchsuchen2.Location = new System.Drawing.Point(699, 95);
            this.btnDurchsuchen2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDurchsuchen2.Name = "btnDurchsuchen2";
            this.btnDurchsuchen2.Size = new System.Drawing.Size(150, 35);
            this.btnDurchsuchen2.TabIndex = 6;
            this.btnDurchsuchen2.Text = "...";
            this.btnDurchsuchen2.UseVisualStyleBackColor = true;
            this.btnDurchsuchen2.Click += new System.EventHandler(this.btnDurchsuchen2_Click_1);
            // 
            // clbAddons
            // 
            this.clbAddons.FormattingEnabled = true;
            this.clbAddons.Location = new System.Drawing.Point(166, 248);
            this.clbAddons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clbAddons.Name = "clbAddons";
            this.clbAddons.Size = new System.Drawing.Size(330, 592);
            this.clbAddons.TabIndex = 7;
            // 
            // clbWTF
            // 
            this.clbWTF.FormattingEnabled = true;
            this.clbWTF.Location = new System.Drawing.Point(507, 248);
            this.clbWTF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clbWTF.Name = "clbWTF";
            this.clbWTF.Size = new System.Drawing.Size(340, 592);
            this.clbWTF.TabIndex = 8;
            // 
            // lblAddons
            // 
            this.lblAddons.AutoSize = true;
            this.lblAddons.Location = new System.Drawing.Point(162, 223);
            this.lblAddons.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddons.Name = "lblAddons";
            this.lblAddons.Size = new System.Drawing.Size(68, 20);
            this.lblAddons.TabIndex = 9;
            this.lblAddons.Text = "Addons:";
            // 
            // lblWTF
            // 
            this.lblWTF.AutoSize = true;
            this.lblWTF.Location = new System.Drawing.Point(502, 223);
            this.lblWTF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWTF.Name = "lblWTF";
            this.lblWTF.Size = new System.Drawing.Size(47, 20);
            this.lblWTF.TabIndex = 10;
            this.lblWTF.Text = "WTF:";
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(166, 892);
            this.btnSync.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(150, 35);
            this.btnSync.TabIndex = 11;
            this.btnSync.Text = "Synchronize";
            this.btnSync.UseVisualStyleBackColor = true;
            // 
            // btnMacro
            // 
            this.btnMacro.Location = new System.Drawing.Point(979, 58);
            this.btnMacro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMacro.Name = "btnMacro";
            this.btnMacro.Size = new System.Drawing.Size(317, 220);
            this.btnMacro.TabIndex = 12;
            this.btnMacro.Text = "Translate Macros";
            this.btnMacro.UseVisualStyleBackColor = true;
            this.btnMacro.Click += new System.EventHandler(this.btnMacro_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 946);
            this.Controls.Add(this.btnMacro);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.lblWTF);
            this.Controls.Add(this.lblAddons);
            this.Controls.Add(this.clbWTF);
            this.Controls.Add(this.clbAddons);
            this.Controls.Add(this.btnDurchsuchen2);
            this.Controls.Add(this.btnDurchsuchen1);
            this.Controls.Add(this.lblWP2);
            this.Controls.Add(this.lblWP1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtPath2);
            this.Controls.Add(this.txtPath1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "WoW Addon Synchronizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblWP1;
        private System.Windows.Forms.Label lblWP2;
        private System.Windows.Forms.Button btnDurchsuchen1;
        private System.Windows.Forms.Button btnDurchsuchen2;
        private System.Windows.Forms.CheckedListBox clbAddons;
        private System.Windows.Forms.CheckedListBox clbWTF;
        private System.Windows.Forms.Label lblAddons;
        private System.Windows.Forms.Label lblWTF;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnMacro;
    }
}

