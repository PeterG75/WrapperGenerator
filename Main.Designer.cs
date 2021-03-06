﻿namespace WrapperGenerator
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
            this.bntBrowser = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.CBoxMode = new System.Windows.Forms.ComboBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.tbCodeBox = new System.Windows.Forms.TextBox();
            this.lblRegex = new System.Windows.Forms.Label();
            this.tbRegex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntBrowser
            // 
            this.bntBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntBrowser.Location = new System.Drawing.Point(659, 11);
            this.bntBrowser.Name = "bntBrowser";
            this.bntBrowser.Size = new System.Drawing.Size(32, 24);
            this.bntBrowser.TabIndex = 0;
            this.bntBrowser.Text = "...";
            this.bntBrowser.UseVisualStyleBackColor = true;
            this.bntBrowser.Click += new System.EventHandler(this.SelectFileClicked);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilePath.Location = new System.Drawing.Point(12, 12);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(641, 23);
            this.tbFilePath.TabIndex = 1;
            // 
            // CBoxMode
            // 
            this.CBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxMode.FormattingEnabled = true;
            this.CBoxMode.Location = new System.Drawing.Point(59, 41);
            this.CBoxMode.Name = "CBoxMode";
            this.CBoxMode.Size = new System.Drawing.Size(268, 23);
            this.CBoxMode.TabIndex = 2;
            this.CBoxMode.SelectedIndexChanged += new System.EventHandler(this.ModeChanged);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(12, 44);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(41, 15);
            this.lblMode.TabIndex = 3;
            this.lblMode.Text = "Mode:";
            // 
            // tbCodeBox
            // 
            this.tbCodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodeBox.Location = new System.Drawing.Point(12, 70);
            this.tbCodeBox.Multiline = true;
            this.tbCodeBox.Name = "tbCodeBox";
            this.tbCodeBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCodeBox.Size = new System.Drawing.Size(680, 420);
            this.tbCodeBox.TabIndex = 4;
            this.tbCodeBox.WordWrap = false;
            // 
            // lblRegex
            // 
            this.lblRegex.AutoSize = true;
            this.lblRegex.Location = new System.Drawing.Point(333, 44);
            this.lblRegex.Name = "lblRegex";
            this.lblRegex.Size = new System.Drawing.Size(41, 15);
            this.lblRegex.TabIndex = 3;
            this.lblRegex.Text = "Regex:";
            // 
            // tbRegex
            // 
            this.tbRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegex.Location = new System.Drawing.Point(380, 41);
            this.tbRegex.Name = "tbRegex";
            this.tbRegex.Size = new System.Drawing.Size(311, 23);
            this.tbRegex.TabIndex = 1;
            this.tbRegex.TextChanged += new System.EventHandler(this.RegexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 502);
            this.Controls.Add(this.lblRegex);
            this.Controls.Add(this.tbRegex);
            this.Controls.Add(this.tbCodeBox);
            this.Controls.Add(this.CBoxMode);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.bntBrowser);
            this.MinimumSize = new System.Drawing.Size(720, 540);
            this.Name = "Main";
            this.Text = "WrapperGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntBrowser;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.ComboBox CBoxMode;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox tbCodeBox;
        private System.Windows.Forms.Label lblRegex;
        private System.Windows.Forms.TextBox tbRegex;
    }
}