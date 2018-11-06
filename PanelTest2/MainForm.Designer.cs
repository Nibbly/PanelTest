namespace PanelTest2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.boSelectionPanel = new System.Windows.Forms.Panel();
            this.customerSelectionPanel = new System.Windows.Forms.Panel();
            this.closeAppButton = new System.Windows.Forms.Button();
            this.newFileButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.boSelectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.headerPanel.Controls.Add(this.closeAppButton);
            this.headerPanel.Controls.Add(this.TitleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(865, 54);
            this.headerPanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(12, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(275, 30);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Montagebau Haendly";
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.sidePanel.Controls.Add(this.newFileButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 54);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(190, 407);
            this.sidePanel.TabIndex = 1;
            // 
            // boSelectionPanel
            // 
            this.boSelectionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.boSelectionPanel.Controls.Add(this.customerSelectionPanel);
            this.boSelectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boSelectionPanel.Location = new System.Drawing.Point(190, 54);
            this.boSelectionPanel.Name = "boSelectionPanel";
            this.boSelectionPanel.Size = new System.Drawing.Size(675, 407);
            this.boSelectionPanel.TabIndex = 2;
            // 
            // customerSelectionPanel
            // 
            this.customerSelectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerSelectionPanel.Location = new System.Drawing.Point(0, 0);
            this.customerSelectionPanel.Name = "customerSelectionPanel";
            this.customerSelectionPanel.Size = new System.Drawing.Size(675, 407);
            this.customerSelectionPanel.TabIndex = 0;
            // 
            // closeAppButton
            // 
            this.closeAppButton.FlatAppearance.BorderSize = 0;
            this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAppButton.ForeColor = System.Drawing.Color.White;
            this.closeAppButton.Image = ((System.Drawing.Image)(resources.GetObject("closeAppButton.Image")));
            this.closeAppButton.Location = new System.Drawing.Point(818, 3);
            this.closeAppButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(47, 51);
            this.closeAppButton.TabIndex = 1;
            this.closeAppButton.UseVisualStyleBackColor = true;
            this.closeAppButton.Click += new System.EventHandler(this.closeAppButton_Click);
            // 
            // newFileButton
            // 
            this.newFileButton.FlatAppearance.BorderSize = 0;
            this.newFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newFileButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFileButton.ForeColor = System.Drawing.Color.White;
            this.newFileButton.Image = ((System.Drawing.Image)(resources.GetObject("newFileButton.Image")));
            this.newFileButton.Location = new System.Drawing.Point(0, 35);
            this.newFileButton.Name = "newFileButton";
            this.newFileButton.Size = new System.Drawing.Size(190, 61);
            this.newFileButton.TabIndex = 0;
            this.newFileButton.Text = "      Neu";
            this.newFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newFileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newFileButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 461);
            this.Controls.Add(this.boSelectionPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.boSelectionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel boSelectionPanel;
        private System.Windows.Forms.Panel customerSelectionPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button closeAppButton;
        private System.Windows.Forms.Button newFileButton;
    }
}

