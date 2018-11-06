using PanelTest2.UserControls;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.PanelBODataInput = new PanelTest2.UserControls.CustomButton();
            this.customerSelectionButton = new PanelTest2.UserControls.CustomButton();
            this.newFileButton = new PanelTest2.UserControls.CustomButton();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.hideWindowButton = new System.Windows.Forms.Button();
            this.restoreWindowButton = new System.Windows.Forms.Button();
            this.closeAppButton = new System.Windows.Forms.Button();
            this.newBOPanel = new System.Windows.Forms.Panel();
            this.panelCustomerSelection = new System.Windows.Forms.Panel();
            this.panelInputBOData = new System.Windows.Forms.Panel();
            this.panelStandard = new System.Windows.Forms.Panel();
            this.bbLogo = new System.Windows.Forms.PictureBox();
            this.sidePanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.newBOPanel.SuspendLayout();
            this.panelCustomerSelection.SuspendLayout();
            this.panelInputBOData.SuspendLayout();
            this.panelStandard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.sidePanel.Controls.Add(this.PanelBODataInput);
            this.sidePanel.Controls.Add(this.customerSelectionButton);
            this.sidePanel.Controls.Add(this.newFileButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 38);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(189, 423);
            this.sidePanel.TabIndex = 1;
            // 
            // PanelBODataInput
            // 
            this.PanelBODataInput.ActionImage = ((System.Drawing.Image)(resources.GetObject("PanelBODataInput.ActionImage")));
            this.PanelBODataInput.ActionName = "Dateneingabe";
            this.PanelBODataInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PanelBODataInput.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelBODataInput.Location = new System.Drawing.Point(-1, 125);
            this.PanelBODataInput.Margin = new System.Windows.Forms.Padding(4);
            this.PanelBODataInput.Name = "PanelBODataInput";
            this.PanelBODataInput.Size = new System.Drawing.Size(190, 40);
            this.PanelBODataInput.TabIndex = 2;
            // 
            // customerSelectionButton
            // 
            this.customerSelectionButton.ActionImage = ((System.Drawing.Image)(resources.GetObject("customerSelectionButton.ActionImage")));
            this.customerSelectionButton.ActionName = "Kundenauswahl";
            this.customerSelectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.customerSelectionButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSelectionButton.Location = new System.Drawing.Point(-1, 84);
            this.customerSelectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.customerSelectionButton.Name = "customerSelectionButton";
            this.customerSelectionButton.Size = new System.Drawing.Size(190, 40);
            this.customerSelectionButton.TabIndex = 1;
            // 
            // newFileButton
            // 
            this.newFileButton.ActionImage = ((System.Drawing.Image)(resources.GetObject("newFileButton.ActionImage")));
            this.newFileButton.ActionName = "Neu";
            this.newFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.newFileButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFileButton.Location = new System.Drawing.Point(-1, 42);
            this.newFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.newFileButton.Name = "newFileButton";
            this.newFileButton.Size = new System.Drawing.Size(190, 40);
            this.newFileButton.TabIndex = 0;
            this.newFileButton.Load += new System.EventHandler(this.newFileButton_Load);
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
            this.hideWindowButton.Location = new System.Drawing.Point(745, 0);
            this.hideWindowButton.Margin = new System.Windows.Forms.Padding(0);
            this.hideWindowButton.Name = "hideWindowButton";
            this.hideWindowButton.Size = new System.Drawing.Size(40, 38);
            this.hideWindowButton.TabIndex = 3;
            this.hideWindowButton.Text = "_";
            this.hideWindowButton.UseVisualStyleBackColor = true;
            this.hideWindowButton.Click += new System.EventHandler(this.hideWindowButton_Click);
            // 
            // restoreWindowButton
            // 
            this.restoreWindowButton.AutoSize = true;
            this.restoreWindowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.restoreWindowButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.restoreWindowButton.FlatAppearance.BorderSize = 0;
            this.restoreWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreWindowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreWindowButton.ForeColor = System.Drawing.Color.White;
            this.restoreWindowButton.Location = new System.Drawing.Point(785, 0);
            this.restoreWindowButton.Margin = new System.Windows.Forms.Padding(0);
            this.restoreWindowButton.Name = "restoreWindowButton";
            this.restoreWindowButton.Size = new System.Drawing.Size(40, 38);
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
            this.closeAppButton.Location = new System.Drawing.Point(825, 0);
            this.closeAppButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(40, 38);
            this.closeAppButton.TabIndex = 1;
            this.closeAppButton.Text = "x";
            this.closeAppButton.UseVisualStyleBackColor = true;
            this.closeAppButton.Click += new System.EventHandler(this.closeAppButton_Click);
            this.closeAppButton.MouseLeave += new System.EventHandler(this.closeAppButton_MouseLeave);
            this.closeAppButton.MouseHover += new System.EventHandler(this.closeAppButton_MouseHover);
            // 
            // newBOPanel
            // 
            this.newBOPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.newBOPanel.Controls.Add(this.panelCustomerSelection);
            this.newBOPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newBOPanel.Location = new System.Drawing.Point(189, 38);
            this.newBOPanel.Name = "newBOPanel";
            this.newBOPanel.Size = new System.Drawing.Size(676, 423);
            this.newBOPanel.TabIndex = 2;
            // 
            // panelCustomerSelection
            // 
            this.panelCustomerSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelCustomerSelection.Controls.Add(this.panelInputBOData);
            this.panelCustomerSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustomerSelection.Location = new System.Drawing.Point(0, 0);
            this.panelCustomerSelection.Name = "panelCustomerSelection";
            this.panelCustomerSelection.Size = new System.Drawing.Size(676, 423);
            this.panelCustomerSelection.TabIndex = 3;
            // 
            // panelInputBOData
            // 
            this.panelInputBOData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelInputBOData.Controls.Add(this.panelStandard);
            this.panelInputBOData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputBOData.Location = new System.Drawing.Point(0, 0);
            this.panelInputBOData.Name = "panelInputBOData";
            this.panelInputBOData.Size = new System.Drawing.Size(676, 423);
            this.panelInputBOData.TabIndex = 3;
            // 
            // panelStandard
            // 
            this.panelStandard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelStandard.Controls.Add(this.bbLogo);
            this.panelStandard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStandard.Location = new System.Drawing.Point(0, 0);
            this.panelStandard.Name = "panelStandard";
            this.panelStandard.Size = new System.Drawing.Size(676, 423);
            this.panelStandard.TabIndex = 4;
            // 
            // bbLogo
            // 
            this.bbLogo.Image = ((System.Drawing.Image)(resources.GetObject("bbLogo.Image")));
            this.bbLogo.Location = new System.Drawing.Point(139, 72);
            this.bbLogo.Name = "bbLogo";
            this.bbLogo.Size = new System.Drawing.Size(330, 259);
            this.bbLogo.TabIndex = 0;
            this.bbLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 461);
            this.Controls.Add(this.newBOPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.sidePanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.newBOPanel.ResumeLayout(false);
            this.panelCustomerSelection.ResumeLayout(false);
            this.panelInputBOData.ResumeLayout(false);
            this.panelStandard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidePanel;
        private UserControls.CustomButton newFileButton;
        private CustomButton customerSelectionButton;
        private CustomButton PanelBODataInput;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button hideWindowButton;
        private System.Windows.Forms.Button restoreWindowButton;
        private System.Windows.Forms.Button closeAppButton;
        private System.Windows.Forms.Panel newBOPanel;
        private System.Windows.Forms.Panel panelCustomerSelection;
        private System.Windows.Forms.Panel panelInputBOData;
        private System.Windows.Forms.Panel panelStandard;
        private System.Windows.Forms.PictureBox bbLogo;
    }
}

