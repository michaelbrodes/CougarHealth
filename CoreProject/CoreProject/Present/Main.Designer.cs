﻿namespace CoreProject.Present
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
            this.billTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // billTestButton
            // 
            this.billTestButton.Location = new System.Drawing.Point(75, 85);
            this.billTestButton.Name = "billTestButton";
            this.billTestButton.Size = new System.Drawing.Size(132, 68);
            this.billTestButton.TabIndex = 0;
            this.billTestButton.Text = "Bill Test Button";
            this.billTestButton.UseVisualStyleBackColor = true;
            this.billTestButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.billTestButton);
            this.Name = "Main";
            this.Text = "CougarHealth";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button billTestButton;
    }
}