namespace iRecover_GUI
{
    partial class frmMenu
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
            this.rTabControl1 = new Reflection.rTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rGroupBox1 = new Reflection.rGroupBox();
            this.btnRecoverChrome = new Reflection.rButton();
            this.rBoxLabel3 = new Reflection.rBoxLabel();
            this.abResult = new Reflection.rAlertBox();
            this.btnRecoverFFCookies = new Reflection.rButton();
            this.rBoxLabel2 = new Reflection.rBoxLabel();
            this.pbFF = new Reflection.rProgressBar();
            this.btnRecoverFFPass = new Reflection.rButton();
            this.rBoxLabel1 = new Reflection.rBoxLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rGroupBox2 = new Reflection.rGroupBox();
            this.abStatusTools = new Reflection.rAlertBox();
            this.pbProgressTools = new Reflection.rProgressBar();
            this.btnRecoverFZHosts = new Reflection.rButton();
            this.rBoxLabel6 = new Reflection.rBoxLabel();
            this.rTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.rGroupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.rGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTabControl1
            // 
            this.rTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.rTabControl1.Controls.Add(this.tabPage1);
            this.rTabControl1.Controls.Add(this.tabPage2);
            this.rTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rTabControl1.ItemSize = new System.Drawing.Size(40, 170);
            this.rTabControl1.Location = new System.Drawing.Point(0, 0);
            this.rTabControl1.Multiline = true;
            this.rTabControl1.Name = "rTabControl1";
            this.rTabControl1.SelectedIndex = 0;
            this.rTabControl1.Size = new System.Drawing.Size(473, 230);
            this.rTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.rTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rGroupBox1);
            this.tabPage1.Location = new System.Drawing.Point(174, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(295, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Browsers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rGroupBox1
            // 
            this.rGroupBox1.BackColor = System.Drawing.Color.White;
            this.rGroupBox1.Controls.Add(this.btnRecoverChrome);
            this.rGroupBox1.Controls.Add(this.rBoxLabel3);
            this.rGroupBox1.Controls.Add(this.abResult);
            this.rGroupBox1.Controls.Add(this.btnRecoverFFCookies);
            this.rGroupBox1.Controls.Add(this.rBoxLabel2);
            this.rGroupBox1.Controls.Add(this.pbFF);
            this.rGroupBox1.Controls.Add(this.btnRecoverFFPass);
            this.rGroupBox1.Controls.Add(this.rBoxLabel1);
            this.rGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(94)))), ((int)(((byte)(100)))));
            this.rGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.rGroupBox1.Name = "rGroupBox1";
            this.rGroupBox1.Size = new System.Drawing.Size(289, 216);
            this.rGroupBox1.TabIndex = 2;
            this.rGroupBox1.TabStop = false;
            this.rGroupBox1.Text = "rGroupBox1";
            // 
            // btnRecoverChrome
            // 
            this.btnRecoverChrome.Blue = true;
            this.btnRecoverChrome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecoverChrome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecoverChrome.Location = new System.Drawing.Point(147, 83);
            this.btnRecoverChrome.Name = "btnRecoverChrome";
            this.btnRecoverChrome.Size = new System.Drawing.Size(136, 33);
            this.btnRecoverChrome.TabIndex = 7;
            this.btnRecoverChrome.Text = "Recover!";
            this.btnRecoverChrome.UseVisualStyleBackColor = true;
            this.btnRecoverChrome.Click += new System.EventHandler(this.btnRecoverChrome_Click);
            // 
            // rBoxLabel3
            // 
            this.rBoxLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rBoxLabel3.Location = new System.Drawing.Point(6, 83);
            this.rBoxLabel3.Name = "rBoxLabel3";
            this.rBoxLabel3.Size = new System.Drawing.Size(135, 33);
            this.rBoxLabel3.TabIndex = 6;
            this.rBoxLabel3.Text = "Chrome Passwords:";
            // 
            // abResult
            // 
            this.abResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.abResult.Location = new System.Drawing.Point(6, 148);
            this.abResult.Name = "abResult";
            this.abResult.Size = new System.Drawing.Size(277, 33);
            this.abResult.Style = Reflection.rAlertBox.Styles.Blue;
            this.abResult.TabIndex = 5;
            this.abResult.Text = "Running";
            this.abResult.Visible = false;
            // 
            // btnRecoverFFCookies
            // 
            this.btnRecoverFFCookies.Blue = true;
            this.btnRecoverFFCookies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecoverFFCookies.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecoverFFCookies.Location = new System.Drawing.Point(147, 44);
            this.btnRecoverFFCookies.Name = "btnRecoverFFCookies";
            this.btnRecoverFFCookies.Size = new System.Drawing.Size(136, 33);
            this.btnRecoverFFCookies.TabIndex = 4;
            this.btnRecoverFFCookies.Text = "Recover!";
            this.btnRecoverFFCookies.UseVisualStyleBackColor = true;
            this.btnRecoverFFCookies.Click += new System.EventHandler(this.btnRecoverFFCookies_Click);
            // 
            // rBoxLabel2
            // 
            this.rBoxLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rBoxLabel2.Location = new System.Drawing.Point(6, 44);
            this.rBoxLabel2.Name = "rBoxLabel2";
            this.rBoxLabel2.Size = new System.Drawing.Size(135, 33);
            this.rBoxLabel2.TabIndex = 3;
            this.rBoxLabel2.Text = "Firefox Cookies:";
            // 
            // pbFF
            // 
            this.pbFF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pbFF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pbFF.Location = new System.Drawing.Point(6, 187);
            this.pbFF.Name = "pbFF";
            this.pbFF.Size = new System.Drawing.Size(277, 23);
            this.pbFF.TabIndex = 2;
            // 
            // btnRecoverFFPass
            // 
            this.btnRecoverFFPass.Blue = true;
            this.btnRecoverFFPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecoverFFPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecoverFFPass.Location = new System.Drawing.Point(147, 5);
            this.btnRecoverFFPass.Name = "btnRecoverFFPass";
            this.btnRecoverFFPass.Size = new System.Drawing.Size(136, 33);
            this.btnRecoverFFPass.TabIndex = 1;
            this.btnRecoverFFPass.Text = "Recover!";
            this.btnRecoverFFPass.UseVisualStyleBackColor = true;
            this.btnRecoverFFPass.Click += new System.EventHandler(this.btnRecoverFFPass_Click);
            // 
            // rBoxLabel1
            // 
            this.rBoxLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rBoxLabel1.Location = new System.Drawing.Point(6, 5);
            this.rBoxLabel1.Name = "rBoxLabel1";
            this.rBoxLabel1.Size = new System.Drawing.Size(135, 33);
            this.rBoxLabel1.TabIndex = 0;
            this.rBoxLabel1.Text = "Firefox Passwords:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rGroupBox2);
            this.tabPage2.Location = new System.Drawing.Point(174, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(295, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tools";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rGroupBox2
            // 
            this.rGroupBox2.BackColor = System.Drawing.Color.White;
            this.rGroupBox2.Controls.Add(this.abStatusTools);
            this.rGroupBox2.Controls.Add(this.pbProgressTools);
            this.rGroupBox2.Controls.Add(this.btnRecoverFZHosts);
            this.rGroupBox2.Controls.Add(this.rBoxLabel6);
            this.rGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(94)))), ((int)(((byte)(100)))));
            this.rGroupBox2.Location = new System.Drawing.Point(3, 3);
            this.rGroupBox2.Name = "rGroupBox2";
            this.rGroupBox2.Size = new System.Drawing.Size(289, 216);
            this.rGroupBox2.TabIndex = 3;
            this.rGroupBox2.TabStop = false;
            this.rGroupBox2.Text = "rGroupBox2";
            // 
            // abStatusTools
            // 
            this.abStatusTools.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.abStatusTools.Location = new System.Drawing.Point(6, 148);
            this.abStatusTools.Name = "abStatusTools";
            this.abStatusTools.Size = new System.Drawing.Size(277, 33);
            this.abStatusTools.Style = Reflection.rAlertBox.Styles.Blue;
            this.abStatusTools.TabIndex = 5;
            this.abStatusTools.Text = "Running";
            this.abStatusTools.Visible = false;
            // 
            // pbProgressTools
            // 
            this.pbProgressTools.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pbProgressTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pbProgressTools.Location = new System.Drawing.Point(6, 187);
            this.pbProgressTools.Name = "pbProgressTools";
            this.pbProgressTools.Size = new System.Drawing.Size(277, 23);
            this.pbProgressTools.TabIndex = 2;
            // 
            // btnRecoverFZHosts
            // 
            this.btnRecoverFZHosts.Blue = true;
            this.btnRecoverFZHosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecoverFZHosts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecoverFZHosts.Location = new System.Drawing.Point(147, 5);
            this.btnRecoverFZHosts.Name = "btnRecoverFZHosts";
            this.btnRecoverFZHosts.Size = new System.Drawing.Size(136, 33);
            this.btnRecoverFZHosts.TabIndex = 1;
            this.btnRecoverFZHosts.Text = "Recover!";
            this.btnRecoverFZHosts.UseVisualStyleBackColor = true;
            this.btnRecoverFZHosts.Click += new System.EventHandler(this.btnRecoverFZHosts_Click);
            // 
            // rBoxLabel6
            // 
            this.rBoxLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rBoxLabel6.Location = new System.Drawing.Point(6, 5);
            this.rBoxLabel6.Name = "rBoxLabel6";
            this.rBoxLabel6.Size = new System.Drawing.Size(135, 33);
            this.rBoxLabel6.TabIndex = 0;
            this.rBoxLabel6.Text = "FileZilla Hosts:";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 230);
            this.Controls.Add(this.rTabControl1);
            this.Name = "frmMenu";
            this.Text = "iRecover GUI by ion";
            this.rTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.rGroupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.rGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Reflection.rTabControl rTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Reflection.rBoxLabel rBoxLabel1;
        private Reflection.rGroupBox rGroupBox1;
        private Reflection.rProgressBar pbFF;
        private Reflection.rButton btnRecoverFFPass;
        private Reflection.rButton btnRecoverFFCookies;
        private Reflection.rBoxLabel rBoxLabel2;
        private Reflection.rAlertBox abResult;
        private Reflection.rButton btnRecoverChrome;
        private Reflection.rBoxLabel rBoxLabel3;
        private Reflection.rGroupBox rGroupBox2;
        private Reflection.rAlertBox abStatusTools;
        private Reflection.rProgressBar pbProgressTools;
        private Reflection.rButton btnRecoverFZHosts;
        private Reflection.rBoxLabel rBoxLabel6;
    }
}

