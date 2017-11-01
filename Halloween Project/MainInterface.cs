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
    public partial class MainInterface : Form
    //the button management works for this, but it obviously needs a replacement if this is made bigger
    {
        private string userName; //name of user, if it is ever needed... probably not? superflous 
        TextManagement textManager = new TextManagement(); //contains all text so it doesn't clutter the main window
        Inventoriere inventory = new Inventoriere(); //inventory management class

        public MainInterface()
        {
            InitializeComponent();
            this.Text = "Halloween Project";
            Getting_Started();
        }

        private void MainTextBox_TextChanged(object sender, EventArgs e) //ensures text is scrolled down automatically
        {
            MainTextBox.SelectionStart = MainTextBox.Text.Length;
            MainTextBox.ScrollToCaret();
        }

        public string UserName { get => userName; set => userName = value; }

        private void Getting_Started() //initiates everything with default settings
        {
            #region Reset everything
            NameRequestButton.Enabled = true;
            NameRequestButton.Visible = true;
            Button2.Enabled = true;
            Button2.Visible = false;
            Button3.Enabled = true;
            Button3.Visible = false;
            Button4.Enabled = true;
            Button4.Visible = false;
            DeathButton.Enabled = true;
            DeathButton.Visible = false;
            PumpkinButton.Enabled = true;
            PumpkinButton.Visible = false;
            BucketButton.Enabled = true;
            BucketButton.Visible = false;
            WitchButton.Enabled = true;
            WitchButton.Visible = false;
            InventoryOpenButton.Visible = false;
            InventoryExitButton.Visible = false;
            InventoryExitButton.SendToBack();
            ResetButton.Visible = false;
            button2ClickCount = 0;
            button3ClickCount = 0;
            button4ClickCount = 0;
            deathButtonClickCount = 0;
            pumpkinBClickCount = 0;
            bucketBClickCount = 0;
            witchButtonClickCount = 0;
            //InventoryOpenButtonClickCount = 0;
            PumpkinButton.Text = textManager.Pumpkin0B();
            BucketButton.Text = textManager.Bucket0B();
            
            #endregion
            MainTextBox.Text = textManager.GettingStarted();
        }

        private void NameRequestButton_Click(object sender, EventArgs e)
        {
            using (UserInputForm form2 = new UserInputForm() { StartPosition = FormStartPosition.CenterParent })
            {

                while (form2.Continuing) //Shows dialogue while no name is confirmed, cancelling puts default name
                    form2.ShowDialog();

                UserName = form2.UserInputBox.Text;
                MainTextBox.AppendText("\nWelcome, " + UserName + ".\n");
                NameRequestButton.Visible = false;
                Button2.Visible = true;
                Button2.Text = "Get Started";
                ResetButton.Visible = true;

            }

        }

        int button2ClickCount = 0;
        private void Button2_Click(object sender, EventArgs e) //initiates the intro and hides itself
        {
            button2ClickCount++;
            switch (button2ClickCount)
            {
                case 1:
                    MainTextBox.Clear();
                    MainTextBox.AppendText(textManager.Intro1());
                    Button2.Text = textManager.Intro1B();
                    break;
                case 2:
                    MainTextBox.AppendText(textManager.Intro2());
                    Button2.Text = textManager.Intro2B();
                    break;
                default:
                    InventoryOpenButton.Visible = true;
                    MainTextBox.AppendText(textManager.Intro3());
                    inventory.AddItem("Shoes");
                    inventory.AddItem("Jacket");

                    Button3.Visible = true;
                    Button3.Text = "Go Left";
                    Button4.Visible = true;
                    Button4.Text = "Go Right";

                    Button2.Visible = false;
                    button2ClickCount = 0;
                    break;
            }
        }

        int button3ClickCount = 0;
        private void Button3_Click(object sender, EventArgs e) //first option of the first choice
        {
            button3ClickCount++;
            switch (button3ClickCount)
            {
                case 1:
                    MainTextBox.AppendText(textManager.West1());
                    Button3.Text = textManager.West1B();
                    Button4.Enabled = false;
                    break;
                case 2:
                    MainTextBox.AppendText(textManager.West2());
                    Button3.Text = textManager.West2B();
                    break;
                default:
                    MainTextBox.AppendText(textManager.West3());
                    Button3.Text = textManager.West3B();
                    Button3.Enabled = false;
                    button3ClickCount = 0;
                    DeathButton.Visible = true;
                    break;
            }
        }

        int button4ClickCount = 0;
        private void Button4_Click(object sender, EventArgs e) //second option of the first choice
        {
            button4ClickCount++;
            switch (button4ClickCount)
            {
                case 1:
                    MainTextBox.AppendText(textManager.East1());
                    Button4.Text = textManager.East1B();
                    Button3.Enabled = false;
                    break;
                case 2:
                    MainTextBox.AppendText(textManager.East2());
                    Button4.Text = textManager.East2B();
                    break;
                case 3:
                    MainTextBox.AppendText(textManager.East3());
                    Button4.Text = textManager.East3B();
                    break;
                default:
                    MainTextBox.AppendText(textManager.East4());
                    Button4.Visible = false;
                    button4ClickCount = 0;
                    PumpkinButton.Visible = true;
                    BucketButton.Visible = true;
                    break;
            }
        }

        int deathButtonClickCount = 0;
        private void DeathButton_Click(object sender, EventArgs e) //death confirmation dialogue
        {
            deathButtonClickCount++;
            switch (deathButtonClickCount)
            {
                case 1:
                    MainTextBox.AppendText(textManager.Ded1());
                    break;
                case 2:
                    MainTextBox.AppendText(textManager.Ded2());
                    break;
                default:
                    MainTextBox.AppendText(textManager.GameOver());
                    MainTextBox.ScrollToCaret();
                    deathButtonClickCount = 0;
                    DeathButton.Enabled = false;
                    break;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e) //resets all progress and returns to the start
        {
            MainTextBox.Clear();
            Getting_Started();
        }

        int pumpkinBClickCount = 0;
        private void PumpkinButton_Click(object sender, EventArgs e) //first option of the second coice
        {
            pumpkinBClickCount++;
            switch (pumpkinBClickCount)
            {
                case 1:
                    MainTextBox.AppendText(textManager.Pumpkin1());
                    PumpkinButton.Text = textManager.Pumpkin1B();
                    BucketButton.Enabled = false;
                    break;
                case 2:
                    MainTextBox.AppendText(textManager.Pumpkin2());
                    PumpkinButton.Text = textManager.Pumpkin2B();
                    inventory.AddItem("Knife");
                    break;
                default:
                    MainTextBox.AppendText(textManager.Pumpkin3());
                    PumpkinButton.Enabled = false;
                    BucketButton.Enabled = true;
                    break;
            }
        }

        int bucketBClickCount = 0;
        private void BucketButton_Click(object sender, EventArgs e) //second option of the second choice
        {
            bucketBClickCount++;
            if (inventory.HaveItem("Knife")) //check if you have the knife
            {
                switch (bucketBClickCount)
                {
                    case 1:
                        MainTextBox.AppendText(textManager.Bucketing1());
                        BucketButton.Text = textManager.Bucketing1B();
                        PumpkinButton.Enabled = false;
                        break;
                    case 2:
                        MainTextBox.AppendText(textManager.Bucketing2());
                        BucketButton.Text = textManager.Bucketing2B();
                        inventory.RemoveItem("Jacket");
                        inventory.AddItem("Apple");
                        break;
                    default:
                        MainTextBox.AppendText(textManager.Bucketing3());
                        BucketButton.Visible = false;
                        PumpkinButton.Visible = false;
                        WitchButton.Visible = true;
                        break;
                }
            }
            else
            {
                switch (bucketBClickCount)
                {
                    case 1:
                        MainTextBox.AppendText(textManager.Bucket1());
                        BucketButton.Text = textManager.Bucket1B();
                        PumpkinButton.Enabled = false;
                        break;
                    case 2:
                        MainTextBox.AppendText(textManager.Bucket2());
                        BucketButton.Text = textManager.Bucket2B();
                        break;
                    default:
                        DeathButton.Visible = true;
                        InventoryOpenButton.Visible = false;
                        BucketButton.Enabled = false;
                        break;
                }
            }

        }

        string tempBox;
        private void InventoryOpenButton_Click(object sender, EventArgs e) //save textbox and show inventory list instead
        {
            InventoryExitButton.Visible = true;
            InventoryExitButton.Enabled = true;
            InventoryExitButton.BringToFront();
            InventoryOpenButton.Enabled = false;
            tempBox = MainTextBox.Text;
            MainTextBox.Clear();
            InventoryOpenButton.Text = "Opened";
            MainTextBox.AppendText(textManager.InventoryList(inventory));
        }

        private void InventoryExitButton_Click(object sender, EventArgs e) //return the saved textbox and clean up
        {
            InventoryExitButton.Visible = false;
            InventoryExitButton.SendToBack();
            InventoryOpenButton.Enabled = true;
            MainTextBox.Clear();
            MainTextBox.AppendText(tempBox);
            InventoryOpenButton.Text = "Inventory";

            tempBox = "";
        }

        int witchButtonClickCount = 0;
        private void WitchButton_Click(object sender, EventArgs e)
        {
            witchButtonClickCount++;
            switch (witchButtonClickCount)
            {
                case 1:
                    MainTextBox.AppendText(textManager.Witch1());
                    WitchButton.Text = textManager.Witch1B();
                    PumpkinButton.Enabled = false;
                    break;
                case 2:
                    MainTextBox.AppendText(textManager.Witch2());
                    WitchButton.Text = textManager.Witch2B();
                    break;
                case 3:
                    MainTextBox.AppendText(textManager.Witch3());
                    WitchButton.Text = textManager.Witch3B();
                    break;
                case 4:
                    MainTextBox.AppendText(textManager.Home1());
                    WitchButton.Text = textManager.Home1B();
                    break;
                case 5:
                    MainTextBox.AppendText(textManager.Home2());
                    WitchButton.Text = textManager.Home2B();
                    break;
                default:
                    MainTextBox.Clear();
                    MainTextBox.AppendText(textManager.Home3());
                    WitchButton.Enabled = false;
                    break;
            }
        }
    }
}
