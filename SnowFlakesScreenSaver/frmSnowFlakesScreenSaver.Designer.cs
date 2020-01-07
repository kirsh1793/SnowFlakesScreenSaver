namespace SnowFlakesScreenSaver
{
    partial class SnowFlakesScreenSaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnowFlakesScreenSaver));
            this.btnLetItSnow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLetItSnow
            // 
            this.btnLetItSnow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLetItSnow.FlatAppearance.BorderSize = 0;
            this.btnLetItSnow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetItSnow.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnLetItSnow.Location = new System.Drawing.Point(360, 238);
            this.btnLetItSnow.Name = "btnLetItSnow";
            this.btnLetItSnow.Size = new System.Drawing.Size(75, 23);
            this.btnLetItSnow.TabIndex = 1;
            this.btnLetItSnow.Text = "Let it snow!";
            this.btnLetItSnow.UseVisualStyleBackColor = true;
            this.btnLetItSnow.Click += new System.EventHandler(this.btnLetItSnow_Click);
            // 
            // SnowFlakesScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLetItSnow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SnowFlakesScreenSaver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Let it snow!";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLetItSnow;
    }
}

