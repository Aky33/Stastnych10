namespace S10.Forms
{
    partial class Tahy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tahy));
            this.CislaGrid = new System.Windows.Forms.DataGridView();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.HledatTahyOnlineButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CislaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CislaGrid
            // 
            this.CislaGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CislaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CislaGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CislaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CislaGrid.Location = new System.Drawing.Point(0, 0);
            this.CislaGrid.Name = "CislaGrid";
            this.CislaGrid.Size = new System.Drawing.Size(1784, 512);
            this.CislaGrid.TabIndex = 0;
            this.CislaGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CislaGrid_CellEndEdit);
            this.CislaGrid.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.CislaGrid_ColumnRemoved);
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.AutoSize = true;
            this.ControlsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlsPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(1784, 0);
            this.ControlsPanel.TabIndex = 1;
            // 
            // HledatTahyOnlineButton
            // 
            this.HledatTahyOnlineButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HledatTahyOnlineButton.Location = new System.Drawing.Point(0, 518);
            this.HledatTahyOnlineButton.Name = "HledatTahyOnlineButton";
            this.HledatTahyOnlineButton.Size = new System.Drawing.Size(1784, 80);
            this.HledatTahyOnlineButton.TabIndex = 0;
            this.HledatTahyOnlineButton.Text = "Hledat tahy online";
            this.HledatTahyOnlineButton.UseVisualStyleBackColor = true;
            this.HledatTahyOnlineButton.Click += new System.EventHandler(this.HledatTahyOnlineButton_Click);
            // 
            // Tahy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1784, 598);
            this.Controls.Add(this.HledatTahyOnlineButton);
            this.Controls.Add(this.ControlsPanel);
            this.Controls.Add(this.CislaGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Tahy";
            this.Text = "Čísla";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tahy_FormClosing);
            this.Load += new System.EventHandler(this.Tahy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CislaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CislaGrid;
        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.Button HledatTahyOnlineButton;
    }
}