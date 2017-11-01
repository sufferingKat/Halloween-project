namespace Halloween_Project
{
    partial class MainInterface
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
            this.MainTextBox = new System.Windows.Forms.RichTextBox();
            this.NameRequestButton = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.DeathButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.PumpkinButton = new System.Windows.Forms.Button();
            this.BucketButton = new System.Windows.Forms.Button();
            this.InventoryOpenButton = new System.Windows.Forms.Button();
            this.InventoryExitButton = new System.Windows.Forms.Button();
            this.WitchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTextBox
            // 
            this.MainTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainTextBox.Enabled = false;
            this.MainTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.MainTextBox.Location = new System.Drawing.Point(6, 6);
            this.MainTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.ReadOnly = true;
            this.MainTextBox.Size = new System.Drawing.Size(336, 287);
            this.MainTextBox.TabIndex = 0;
            this.MainTextBox.Text = "";
            this.MainTextBox.TextChanged += new System.EventHandler(this.MainTextBox_TextChanged);
            // 
            // NameRequestButton
            // 
            this.NameRequestButton.Location = new System.Drawing.Point(4, 301);
            this.NameRequestButton.Name = "NameRequestButton";
            this.NameRequestButton.Size = new System.Drawing.Size(80, 23);
            this.NameRequestButton.TabIndex = 1;
            this.NameRequestButton.Text = "Enter Name";
            this.NameRequestButton.UseVisualStyleBackColor = true;
            this.NameRequestButton.Click += new System.EventHandler(this.NameRequestButton_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(4, 301);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(80, 23);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "Continue";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Visible = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(4, 301);
            this.Button3.Name = "Button3";
            this.Button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Button3.Size = new System.Drawing.Size(80, 23);
            this.Button3.TabIndex = 3;
            this.Button3.Text = "Choice 1";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Visible = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(90, 301);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(80, 23);
            this.Button4.TabIndex = 4;
            this.Button4.Text = "Choice 2";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // DeathButton
            // 
            this.DeathButton.Location = new System.Drawing.Point(176, 301);
            this.DeathButton.Name = "DeathButton";
            this.DeathButton.Size = new System.Drawing.Size(80, 23);
            this.DeathButton.TabIndex = 5;
            this.DeathButton.Text = "Oh No";
            this.DeathButton.UseVisualStyleBackColor = true;
            this.DeathButton.Click += new System.EventHandler(this.DeathButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(262, 301);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(80, 23);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PumpkinButton
            // 
            this.PumpkinButton.Location = new System.Drawing.Point(4, 301);
            this.PumpkinButton.Name = "PumpkinButton";
            this.PumpkinButton.Size = new System.Drawing.Size(80, 23);
            this.PumpkinButton.TabIndex = 7;
            this.PumpkinButton.Text = "The Pumpkin";
            this.PumpkinButton.UseVisualStyleBackColor = true;
            this.PumpkinButton.Click += new System.EventHandler(this.PumpkinButton_Click);
            // 
            // BucketButton
            // 
            this.BucketButton.Location = new System.Drawing.Point(90, 301);
            this.BucketButton.Name = "BucketButton";
            this.BucketButton.Size = new System.Drawing.Size(80, 23);
            this.BucketButton.TabIndex = 8;
            this.BucketButton.Text = "The Bucket";
            this.BucketButton.UseVisualStyleBackColor = true;
            this.BucketButton.Click += new System.EventHandler(this.BucketButton_Click);
            // 
            // InventoryOpenButton
            // 
            this.InventoryOpenButton.Location = new System.Drawing.Point(176, 301);
            this.InventoryOpenButton.Name = "InventoryOpenButton";
            this.InventoryOpenButton.Size = new System.Drawing.Size(80, 23);
            this.InventoryOpenButton.TabIndex = 9;
            this.InventoryOpenButton.Text = "Inventory";
            this.InventoryOpenButton.UseVisualStyleBackColor = true;
            this.InventoryOpenButton.Click += new System.EventHandler(this.InventoryOpenButton_Click);
            // 
            // InventoryExitButton
            // 
            this.InventoryExitButton.Enabled = false;
            this.InventoryExitButton.Location = new System.Drawing.Point(4, 301);
            this.InventoryExitButton.Name = "InventoryExitButton";
            this.InventoryExitButton.Size = new System.Drawing.Size(166, 23);
            this.InventoryExitButton.TabIndex = 10;
            this.InventoryExitButton.Text = "Exit Inventory";
            this.InventoryExitButton.UseVisualStyleBackColor = true;
            this.InventoryExitButton.Visible = false;
            this.InventoryExitButton.Click += new System.EventHandler(this.InventoryExitButton_Click);
            // 
            // WitchButton
            // 
            this.WitchButton.Location = new System.Drawing.Point(4, 301);
            this.WitchButton.Name = "WitchButton";
            this.WitchButton.Size = new System.Drawing.Size(80, 23);
            this.WitchButton.TabIndex = 11;
            this.WitchButton.Text = "Witchery";
            this.WitchButton.UseVisualStyleBackColor = true;
            this.WitchButton.Click += new System.EventHandler(this.WitchButton_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(350, 333);
            this.Controls.Add(this.WitchButton);
            this.Controls.Add(this.InventoryOpenButton);
            this.Controls.Add(this.BucketButton);
            this.Controls.Add(this.PumpkinButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.DeathButton);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.NameRequestButton);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.InventoryExitButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MainInterface";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox MainTextBox;
        private System.Windows.Forms.Button NameRequestButton;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button DeathButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button PumpkinButton;
        private System.Windows.Forms.Button BucketButton;
        private System.Windows.Forms.Button InventoryOpenButton;
        private System.Windows.Forms.Button InventoryExitButton;
        private System.Windows.Forms.Button WitchButton;
    }
}

