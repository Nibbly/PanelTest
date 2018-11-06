﻿namespace PanelTest2.UserControls
{
    partial class CustomButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.actionNameButton = new System.Windows.Forms.Button();
            this.actionImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.actionImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.actionNameButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(49, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 40);
            this.panel2.TabIndex = 1;
            // 
            // actionNameButton
            // 
            this.actionNameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionNameButton.FlatAppearance.BorderSize = 0;
            this.actionNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionNameButton.ForeColor = System.Drawing.Color.White;
            this.actionNameButton.Location = new System.Drawing.Point(0, 0);
            this.actionNameButton.Name = "actionNameButton";
            this.actionNameButton.Size = new System.Drawing.Size(141, 40);
            this.actionNameButton.TabIndex = 2;
            this.actionNameButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.actionNameButton.UseVisualStyleBackColor = true;
            // 
            // actionImage
            // 
            this.actionImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.actionImage.Location = new System.Drawing.Point(10, 0);
            this.actionImage.Name = "actionImage";
            this.actionImage.Size = new System.Drawing.Size(39, 40);
            this.actionImage.TabIndex = 0;
            this.actionImage.TabStop = false;
            // 
            // CustomButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomButton";
            this.Size = new System.Drawing.Size(190, 40);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actionImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox actionImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button actionNameButton;
    }
}
