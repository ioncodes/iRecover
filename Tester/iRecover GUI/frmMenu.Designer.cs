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
            this.pbFF = new Reflection.rProgressBar();
            this.btnRecoverFFPass = new Reflection.rButton();
            this.rBoxLabel1 = new Reflection.rBoxLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRecoverFFCookies = new Reflection.rButton();
            this.rBoxLabel2 = new Reflection.rBoxLabel();
            this.abResult = new Reflection.rAlertBox();
            this.rTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.rGroupBox1.SuspendLayout();
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
            this.rTabControl1.Size = new System.Drawing.Size(473, 202);
            this.rTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.rTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rGroupBox1);
            this.tabPage1.Location = new System.Drawing.Point(174, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(295, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Browsers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rGroupBox1
            // 
            this.rGroupBox1.BackColor = System.Drawing.Color.White;
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
            this.rGroupBox1.Size = new System.Drawing.Size(289, 188);
            this.rGroupBox1.TabIndex = 2;
            this.rGroupBox1.TabStop = false;
            this.rGroupBox1.Text = "rGroupBox1";
            // 
            // pbFF
            // 
            this.pbFF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pbFF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pbFF.Location = new System.Drawing.Point(6, 159);
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
            this.tabPage2.Location = new System.Drawing.Point(174, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(462, 120);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tools";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // abResult
            // 
            this.abResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.abResult.Location = new System.Drawing.Point(6, 120);
            this.abResult.Name = "abResult";
            this.abResult.Size = new System.Drawing.Size(277, 33);
            this.abResult.Style = Reflection.rAlertBox.Styles.Blue;
            this.abResult.TabIndex = 5;
            this.abResult.Text = "Running";
            this.abResult.Visible = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 202);
            this.Controls.Add(this.rTabControl1);
            this.Name = "frmMenu";
            this.Text = "iRecover GUI by ion";
            this.rTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.rGroupBox1.ResumeLayout(false);
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
    }
}

