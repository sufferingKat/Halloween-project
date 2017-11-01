namespace Halloween_Project
{
    partial class UserInputForm
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
            this.UserInputBox = new System.Windows.Forms.TextBox();
            this.OkayButton = new System.Windows.Forms.Button();
            this.BackoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserInputBox
            // 
            this.UserInputBox.Location = new System.Drawing.Point(13, 13);
            this.UserInputBox.Name = "UserInputBox";
            this.UserInputBox.Size = new System.Drawing.Size(110, 20);
            this.UserInputBox.TabIndex = 0;
            // 
            // OkayButton
            // 
            this.OkayButton.Location = new System.Drawing.Point(12, 39);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(50, 23);
            this.OkayButton.TabIndex = 1;
            this.OkayButton.Text = "Okay";
            this.OkayButton.UseVisualStyleBackColor = true;
            this.OkayButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // BackoutButton
            // 
            this.BackoutButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackoutButton.Location = new System.Drawing.Point(73, 39);
            this.BackoutButton.Name = "BackoutButton";
            this.BackoutButton.Size = new System.Drawing.Size(50, 23);
            this.BackoutButton.TabIndex = 2;
            this.BackoutButton.Text = "Cancel";
            this.BackoutButton.UseVisualStyleBackColor = true;
            this.BackoutButton.Click += new System.EventHandler(this.BackoutButton_Click);
            // 
            // UserInputForm
            // 
            this.AcceptButton = this.OkayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BackoutButton;
            this.ClientSize = new System.Drawing.Size(135, 69);
            this.ControlBox = false;
            this.Controls.Add(this.BackoutButton);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.UserInputBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(151, 108);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(151, 108);
            this.Name = "UserInputForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "UserInputForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.Button BackoutButton;
        public System.Windows.Forms.TextBox UserInputBox;
    }
}