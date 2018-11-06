using System;

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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.hideWindowButton = new System.Windows.Forms.Button();
            this.restoreWindowButton = new System.Windows.Forms.Button();
            this.closeAppButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.boSelectionPanel = new System.Windows.Forms.Panel();
            this.customerSelectionPanel = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.boSelectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.headerPanel.Controls.Add(this.hideWindowButton);
            this.headerPanel.Controls.Add(this.restoreWindowButton);
            this.headerPanel.Controls.Add(this.closeAppButton);
            this.headerPanel.Controls.Add(this.TitleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(865, 38);
            this.headerPanel.TabIndex = 0;
            // 
            // hideWindowButton
            // 
            this.hideWindowButton.AutoSize = true;
            this.hideWindowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hideWindowButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideWindowButton.FlatAppearance.BorderSize = 0;
            this.hideWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideWindowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideWindowButton.ForeColor = System.Drawing.Color.White;
            this.hideWindowButton.Location = new System.Drawing.Point(764, 0);
            this.hideWindowButton.Margin = new System.Windows.Forms.Padding(0);
            this.hideWindowButton.Name = "hideWindowButton";
            this.hideWindowButton.Size = new System.Drawing.Size(32, 38);
            this.hideWindowButton.TabIndex = 3;
            this.hideWindowButton.Text = "_";
            this.hideWindowButton.UseVisualStyleBackColor = true;
            this.hideWindowButton.Click += new System.EventHandler(this.hideWindowButton_Click);
            // 
            // restoreWindowButton
            // 
            this.restoreWindowButton.AutoSize = true;
            this.restoreWindowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restoreWindowButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.restoreWindowButton.FlatAppearance.BorderSize = 0;
            this.restoreWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreWindowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreWindowButton.ForeColor = System.Drawing.Color.White;
            this.restoreWindowButton.Location = new System.Drawing.Point(796, 0);
            this.restoreWindowButton.Margin = new System.Windows.Forms.Padding(0);
            this.restoreWindowButton.Name = "restoreWindowButton";
            this.restoreWindowButton.Size = new System.Drawing.Size(38, 38);
            this.restoreWindowButton.TabIndex = 2;
            this.restoreWindowButton.Text = "❐";
            this.restoreWindowButton.UseVisualStyleBackColor = true;
            this.restoreWindowButton.Click += new System.EventHandler(this.restoreWindowButton_Click);
            // 
            // closeAppButton
            // 
            this.closeAppButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeAppButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeAppButton.FlatAppearance.BorderSize = 0;
            this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAppButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeAppButton.ForeColor = System.Drawing.Color.White;
            this.closeAppButton.Location = new System.Drawing.Point(834, 0);
            this.closeAppButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(31, 38);
            this.closeAppButton.TabIndex = 1;
            this.closeAppButton.Text = "x";
            this.closeAppButton.UseVisualStyleBackColor = true;
            this.closeAppButton.Click += new System.EventHandler(this.closeAppButton_Click);
            this.closeAppButton.MouseLeave += new System.EventHandler(this.closeAppButton_MouseLeave);
            this.closeAppButton.MouseHover += new System.EventHandler(this.closeAppButton_MouseHover);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(134, 22);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Montagebau";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 38);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(189, 423);
            this.sidePanel.TabIndex = 1;
            // 
            // boSelectionPanel
            // 
            this.boSelectionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.boSelectionPanel.Controls.Add(this.customerSelectionPanel);
            this.boSelectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boSelectionPanel.Location = new System.Drawing.Point(189, 38);
            this.boSelectionPanel.Name = "boSelectionPanel";
            this.boSelectionPanel.Size = new System.Drawing.Size(676, 423);
            this.boSelectionPanel.TabIndex = 2;
            // 
            // customerSelectionPanel
            // 
            this.customerSelectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerSelectionPanel.Location = new System.Drawing.Point(0, 0);
            this.customerSelectionPanel.Name = "customerSelectionPanel";
            this.customerSelectionPanel.Size = new System.Drawing.Size(676, 423);
            this.customerSelectionPanel.TabIndex = 0;
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
        private System.Windows.Forms.Button restoreWindowButton;
        private System.Windows.Forms.Button hideWindowButton;
    }
}

