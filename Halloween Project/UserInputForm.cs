using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Halloween_Project
{
    public partial class UserInputForm : Form
    {
        public UserInputForm()
        {
            InitializeComponent();
            this.Text = "Enter a name:";
        }
        public bool Continuing = true;
        private void OkayButton_Click(object sender, EventArgs e)
        {
            if(UserInputBox.Text == "")
            {
                this.Text = "No name entered!";
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(UserInputBox.Text, @"^[a-zA-Z]+$"))
            {
                this.Text = "No robots!";
                return;
            }
            Continuing = false;
            this.Close();
        }

        private void BackoutButton_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = "Jim";
            Continuing = false;
            this.Close();
        }
    }
}
