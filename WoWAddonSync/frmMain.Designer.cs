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
            this.btnMacro2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAS = new System.Windows.Forms.TabPage();
            this.tpMT = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tpAS.SuspendLayout();
            this.tpMT.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath1
            // 
            this.txtPath1.Location = new System.Drawing.Point(133, 17);
            this.txtPath1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(522, 26);
            this.txtPath1.TabIndex = 0;
            this.txtPath1.Text = "C:\\Program Files (x86)\\World of Warcraft";
            // 
            // txtPath2
            // 
            this.txtPath2.Location = new System.Drawing.Point(132, 794);
            this.txtPath2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(522, 26);
            this.txtPath2.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(134, 39);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(681, 120);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "List AddOns";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblWP1
            // 
            this.lblWP1.AutoSize = true;
            this.lblWP1.Location = new System.Drawing.Point(21, 17);
            this.lblWP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWP1.Name = "lblWP1";
            this.lblWP1.Size = new System.Drawing.Size(98, 20);
            this.lblWP1.TabIndex = 3;
            this.lblWP1.Text = "WoW Path 1";
            // 
            // lblWP2
            // 
            this.lblWP2.AutoSize = true;
            this.lblWP2.Location = new System.Drawing.Point(20, 794);
            this.lblWP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWP2.Name = "lblWP2";
            this.lblWP2.Size = new System.Drawing.Size(98, 20);
            this.lblWP2.TabIndex = 4;
            this.lblWP2.Text = "WoW Path 2";
            // 
            // btnDurchsuchen1
            // 
            this.btnDurchsuchen1.Location = new System.Drawing.Point(666, 14);
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
            this.btnDurchsuchen2.Location = new System.Drawing.Point(665, 791);
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
            this.clbAddons.Location = new System.Drawing.Point(134, 189);
            this.clbAddons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clbAddons.Name = "clbAddons";
            this.clbAddons.Size = new System.Drawing.Size(330, 592);
            this.clbAddons.TabIndex = 7;
            // 
            // clbWTF
            // 
            this.clbWTF.FormattingEnabled = true;
            this.clbWTF.Location = new System.Drawing.Point(475, 189);
            this.clbWTF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clbWTF.Name = "clbWTF";
            this.clbWTF.Size = new System.Drawing.Size(340, 592);
            this.clbWTF.TabIndex = 8;
            // 
            // lblAddons
            // 
            this.lblAddons.AutoSize = true;
            this.lblAddons.Location = new System.Drawing.Point(130, 164);
            this.lblAddons.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddons.Name = "lblAddons";
            this.lblAddons.Size = new System.Drawing.Size(68, 20);
            this.lblAddons.TabIndex = 9;
            this.lblAddons.Text = "Addons:";
            // 
            // lblWTF
            // 
            this.lblWTF.AutoSize = true;
            this.lblWTF.Location = new System.Drawing.Point(470, 164);
            this.lblWTF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWTF.Name = "lblWTF";
            this.lblWTF.Size = new System.Drawing.Size(47, 20);
            this.lblWTF.TabIndex = 10;
            this.lblWTF.Text = "WTF:";
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(132, 830);
            this.btnSync.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(150, 35);
            this.btnSync.TabIndex = 11;
            this.btnSync.Text = "Synchronize";
            this.btnSync.UseVisualStyleBackColor = true;
            // 
            // btnMacro
            // 
            this.btnMacro.Location = new System.Drawing.Point(50, 57);
            this.btnMacro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMacro.Name = "btnMacro";
            this.btnMacro.Size = new System.Drawing.Size(779, 220);
            this.btnMacro.TabIndex = 12;
            this.btnMacro.Text = "Translate Ger -> Eng";
            this.btnMacro.UseVisualStyleBackColor = true;
            this.btnMacro.Click += new System.EventHandler(this.btnMacro_Click);
            // 
            // btnMacro2
            // 
            this.btnMacro2.Location = new System.Drawing.Point(50, 623);
            this.btnMacro2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMacro2.Name = "btnMacro2";
            this.btnMacro2.Size = new System.Drawing.Size(779, 220);
            this.btnMacro2.TabIndex = 13;
            this.btnMacro2.Text = "Translate Eng -> Ger";
            this.btnMacro2.UseVisualStyleBackColor = true;
            this.btnMacro2.Click += new System.EventHandler(this.btnMacro2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAS);
            this.tabControl1.Controls.Add(this.tpMT);
            this.tabControl1.Location = new System.Drawing.Point(25, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(885, 929);
            this.tabControl1.TabIndex = 14;
            // 
            // tpAS
            // 
            this.tpAS.Controls.Add(this.clbWTF);
            this.tpAS.Controls.Add(this.txtPath2);
            this.tpAS.Controls.Add(this.btnSync);
            this.tpAS.Controls.Add(this.btnGo);
            this.tpAS.Controls.Add(this.lblWTF);
            this.tpAS.Controls.Add(this.lblAddons);
            this.tpAS.Controls.Add(this.lblWP2);
            this.tpAS.Controls.Add(this.clbAddons);
            this.tpAS.Controls.Add(this.btnDurchsuchen2);
            this.tpAS.Location = new System.Drawing.Point(4, 29);
            this.tpAS.Name = "tpAS";
            this.tpAS.Padding = new System.Windows.Forms.Padding(3);
            this.tpAS.Size = new System.Drawing.Size(877, 896);
            this.tpAS.TabIndex = 0;
            this.tpAS.Text = "Addon Sync";
            this.tpAS.UseVisualStyleBackColor = true;
            // 
            // tpMT
            // 
            this.tpMT.Controls.Add(this.btnMacro);
            this.tpMT.Controls.Add(this.btnMacro2);
            this.tpMT.Location = new System.Drawing.Point(4, 29);
            this.tpMT.Name = "tpMT";
            this.tpMT.Padding = new System.Windows.Forms.Padding(3);
            this.tpMT.Size = new System.Drawing.Size(877, 896);
            this.tpMT.TabIndex = 1;
            this.tpMT.Text = "Macro Translator";
            this.tpMT.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 995);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtPath1);
            this.Controls.Add(this.btnDurchsuchen1);
            this.Controls.Add(this.lblWP1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "WoW Utility";
            this.tabControl1.ResumeLayout(false);
            this.tpAS.ResumeLayout(false);
            this.tpAS.PerformLayout();
            this.tpMT.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnMacro2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAS;
        private System.Windows.Forms.TabPage tpMT;
    }
}

