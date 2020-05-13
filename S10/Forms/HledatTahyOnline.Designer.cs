namespace S10.Forms
{
    partial class HledatTahyOnline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HledatTahyOnline));
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.HledatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateTime
            // 
            this.DateTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.DateTime.Location = new System.Drawing.Point(0, 0);
            this.DateTime.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(484, 44);
            this.DateTime.TabIndex = 0;
            // 
            // HledatButton
            // 
            this.HledatButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HledatButton.Location = new System.Drawing.Point(0, 44);
            this.HledatButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.HledatButton.Name = "HledatButton";
            this.HledatButton.Size = new System.Drawing.Size(484, 65);
            this.HledatButton.TabIndex = 1;
            this.HledatButton.Text = "Hledat";
            this.HledatButton.UseVisualStyleBackColor = true;
            this.HledatButton.Click += new System.EventHandler(this.HledatButton_Click);
            // 
            // HledatTahyOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 182);
            this.Controls.Add(this.HledatButton);
            this.Controls.Add(this.DateTime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MinimumSize = new System.Drawing.Size(500, 39);
            this.Name = "HledatTahyOnline";
            this.Text = "Hledání tahů online";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.Button HledatButton;
    }
}