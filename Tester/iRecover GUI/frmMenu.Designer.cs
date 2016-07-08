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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rBoxLabel1 = new Reflection.rBoxLabel();
            this.rGroupBox1 = new Reflection.rGroupBox();
            this.btnRecoverFF = new Reflection.rButton();
            this.pbFF = new Reflection.rProgressBar();
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
            this.rTabControl1.Size = new System.Drawing.Size(573, 128);
            this.rTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.rTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rGroupBox1);
            this.tabPage1.Location = new System.Drawing.Point(174, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(395, 120);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Browsers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(174, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(395, 120);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tools";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rBoxLabel1
            // 
            this.rBoxLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rBoxLabel1.Location = new System.Drawing.Point(6, 5);
            this.rBoxLabel1.Name = "rBoxLabel1";
            this.rBoxLabel1.Size = new System.Drawing.Size(88, 33);
            this.rBoxLabel1.TabIndex = 0;
            this.rBoxLabel1.Text = "Firefox:";
            // 
            // rGroupBox1
            // 
            this.rGroupBox1.BackColor = System.Drawing.Color.White;
            this.rGroupBox1.Controls.Add(this.pbFF);
            this.rGroupBox1.Controls.Add(this.btnRecoverFF);
            this.rGroupBox1.Controls.Add(this.rBoxLabel1);
            this.rGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(94)))), ((int)(((byte)(100)))));
            this.rGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.rGroupBox1.Name = "rGroupBox1";
            this.rGroupBox1.Size = new System.Drawing.Size(389, 114);
            this.rGroupBox1.TabIndex = 2;
            this.rGroupBox1.TabStop = false;
            this.rGroupBox1.Text = "rGroupBox1";
            // 
            // btnRecoverFF
            // 
            this.btnRecoverFF.Blue = true;
            this.btnRecoverFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecoverFF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecoverFF.Location = new System.Drawing.Point(100, 5);
            this.btnRecoverFF.Name = "btnRecoverFF";
            this.btnRecoverFF.Size = new System.Drawing.Size(96, 33);
            this.btnRecoverFF.TabIndex = 1;
            this.btnRecoverFF.Text = "Recover!";
            this.btnRecoverFF.UseVisualStyleBackColor = true;
            this.btnRecoverFF.Click += new System.EventHandler(this.btnRecoverFF_Click);
            // 
            // pbFF
            // 
            this.pbFF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pbFF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pbFF.Location = new System.Drawing.Point(202, 11);
            this.pbFF.Name = "pbFF";
            this.pbFF.Size = new System.Drawing.Size(181, 23);
            this.pbFF.TabIndex = 2;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 128);
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
        private Reflection.rButton btnRecoverFF;
    }
}

