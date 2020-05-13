namespace S10.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.KonecButton = new System.Windows.Forms.Button();
            this.VysledekBox = new System.Windows.Forms.TextBox();
            this.NastaveniButton = new System.Windows.Forms.Button();
            this.TahyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.DisplayPanel.SuspendLayout();
            this.ControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // KonecButton
            // 
            this.KonecButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.KonecButton.Location = new System.Drawing.Point(0, 180);
            this.KonecButton.Name = "KonecButton";
            this.KonecButton.Size = new System.Drawing.Size(637, 90);
            this.KonecButton.TabIndex = 3;
            this.KonecButton.Text = "Konec";
            this.KonecButton.UseVisualStyleBackColor = true;
            this.KonecButton.Click += new System.EventHandler(this.KonecButton_Click);
            // 
            // VysledekBox
            // 
            this.VysledekBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VysledekBox.Enabled = false;
            this.VysledekBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.VysledekBox.Location = new System.Drawing.Point(94, 0);
            this.VysledekBox.Name = "VysledekBox";
            this.VysledekBox.ReadOnly = true;
            this.VysledekBox.Size = new System.Drawing.Size(543, 44);
            this.VysledekBox.TabIndex = 1;
            this.VysledekBox.TabStop = false;
            this.VysledekBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NastaveniButton
            // 
            this.NastaveniButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NastaveniButton.Enabled = false;
            this.NastaveniButton.Location = new System.Drawing.Point(0, 90);
            this.NastaveniButton.Name = "NastaveniButton";
            this.NastaveniButton.Size = new System.Drawing.Size(637, 90);
            this.NastaveniButton.TabIndex = 1;
            this.NastaveniButton.Text = "Nastavení";
            this.NastaveniButton.UseVisualStyleBackColor = true;
            this.NastaveniButton.Click += new System.EventHandler(this.NastaveniButton_Click);
            // 
            // TahyButton
            // 
            this.TahyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TahyButton.Location = new System.Drawing.Point(0, 0);
            this.TahyButton.Name = "TahyButton";
            this.TahyButton.Size = new System.Drawing.Size(637, 90);
            this.TahyButton.TabIndex = 0;
            this.TahyButton.Text = "Tahy";
            this.TahyButton.UseVisualStyleBackColor = true;
            this.TahyButton.Click += new System.EventHandler(this.TahyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahy";
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.AutoSize = true;
            this.DisplayPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DisplayPanel.Controls.Add(this.label1);
            this.DisplayPanel.Controls.Add(this.VysledekBox);
            this.DisplayPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DisplayPanel.Location = new System.Drawing.Point(0, 0);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(637, 47);
            this.DisplayPanel.TabIndex = 4;
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.AutoSize = true;
            this.ControlsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ControlsPanel.Controls.Add(this.KonecButton);
            this.ControlsPanel.Controls.Add(this.NastaveniButton);
            this.ControlsPanel.Controls.Add(this.TahyButton);
            this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlsPanel.Location = new System.Drawing.Point(0, 262);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(637, 270);
            this.ControlsPanel.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(637, 532);
            this.Controls.Add(this.ControlsPanel);
            this.Controls.Add(this.DisplayPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MinimumSize = new System.Drawing.Size(600, 39);
            this.Name = "Main";
            this.Text = "Šťastných 10";
            this.Load += new System.EventHandler(this.Main_Load);
            this.DisplayPanel.ResumeLayout(false);
            this.DisplayPanel.PerformLayout();
            this.ControlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KonecButton;
        private System.Windows.Forms.TextBox VysledekBox;
        private System.Windows.Forms.Button NastaveniButton;
        private System.Windows.Forms.Button TahyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.Panel ControlsPanel;
    }
}