﻿namespace ООО__Рулевой_.Forms
{
    partial class AutorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizationForm));
            this.LogoGroupBox = new System.Windows.Forms.GroupBox();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.ViewButton = new System.Windows.Forms.Button();
            this.EntranceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PWDTextBox = new System.Windows.Forms.TextBox();
            this.LogoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoGroupBox
            // 
            this.LogoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoGroupBox.Controls.Add(this.LogoLabel);
            this.LogoGroupBox.Controls.Add(this.LogoPictureBox);
            this.LogoGroupBox.Location = new System.Drawing.Point(58, -7);
            this.LogoGroupBox.MinimumSize = new System.Drawing.Size(181, 52);
            this.LogoGroupBox.Name = "LogoGroupBox";
            this.LogoGroupBox.Size = new System.Drawing.Size(181, 52);
            this.LogoGroupBox.TabIndex = 0;
            this.LogoGroupBox.TabStop = false;
            // 
            // LogoLabel
            // 
            this.LogoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Location = new System.Drawing.Point(45, 19);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(134, 23);
            this.LogoLabel.TabIndex = 2;
            this.LogoLabel.Text = "ООО «Рулевой»";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.InitialImage")));
            this.LogoPictureBox.Location = new System.Drawing.Point(0, 13);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(42, 32);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 1;
            this.LogoPictureBox.TabStop = false;
            // 
            // ViewButton
            // 
            this.ViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewButton.Location = new System.Drawing.Point(12, 205);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(109, 32);
            this.ViewButton.TabIndex = 1;
            this.ViewButton.Text = "Просмотр";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // EntranceButton
            // 
            this.EntranceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EntranceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.EntranceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntranceButton.Location = new System.Drawing.Point(204, 205);
            this.EntranceButton.Name = "EntranceButton";
            this.EntranceButton.Size = new System.Drawing.Size(79, 32);
            this.EntranceButton.TabIndex = 2;
            this.EntranceButton.Text = "Вход";
            this.EntranceButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginTextBox.Location = new System.Drawing.Point(12, 83);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(271, 30);
            this.LoginTextBox.TabIndex = 5;
            // 
            // PWDTextBox
            // 
            this.PWDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PWDTextBox.Location = new System.Drawing.Point(12, 150);
            this.PWDTextBox.Name = "PWDTextBox";
            this.PWDTextBox.PasswordChar = '*';
            this.PWDTextBox.Size = new System.Drawing.Size(271, 30);
            this.PWDTextBox.TabIndex = 6;
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(295, 249);
            this.Controls.Add(this.PWDTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EntranceButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.LogoGroupBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(311, 288);
            this.Name = "AutorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AutorizationForm_FormClosed);
            this.LogoGroupBox.ResumeLayout(false);
            this.LogoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LogoGroupBox;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button EntranceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PWDTextBox;
    }
}