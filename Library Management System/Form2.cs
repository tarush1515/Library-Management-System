using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            isSlidingPanel_expanded = true;
            ImageList ImageList2=new ImageList();
            ImageList2.Images.Add(Properties.Resources.left_arrow);
            ImageList2.Images.Add(Properties.Resources.fast_forward);
            ImageList2.ImageSize = new Size(48, 48);
            slidingpanel_toggle.ImageList = ImageList2;
            expandingPanelGUI();

        }

        public void addImages()
        {
            ImageList ImageList1= new ImageList();
            ImageList1.Images.Add(Properties.Resources.open_book);
            ImageList1.Images.Add(Properties.Resources.multiple_users_silhouette);
            ImageList1.Images.Add(Properties.Resources.transaction);
            ImageList1.Images.Add(Properties.Resources.settings);
            ImageList1.Images.Add(Properties.Resources.information_button);
            
            ImageList1.ImageSize = new Size(48, 48);
            
            BooksButton.ImageList=ImageList1;
            BorrowerButton.ImageList=ImageList1; 
            TransactionButton.ImageList=ImageList1;
            SettingsButton.ImageList=ImageList1;
            AboutButton.ImageList = ImageList1;
            BooksButton.ImageIndex = 0;
            BorrowerButton.ImageIndex=1;
            TransactionButton.ImageIndex=2; 
            SettingsButton.ImageIndex=3;
            AboutButton.ImageIndex=4;
            slidingpanel_toggle.ImageIndex = 1;
            slidingpanel_toggle.ImageAlign = ContentAlignment.MiddleLeft;
        }

        public void expandingPanelGUI()
        {
            BooksButton.Text = "BOOKS";
            BorrowerButton.Text = "BORROWERS";
            TransactionButton.Text = "  TRANSACTIONS";
            SettingsButton.Text = "SETTINGS";
            AboutButton.Text = "ABOUT";
            slidingpanel_toggle.ImageIndex = 0;
            slidingpanel_toggle.ImageAlign = ContentAlignment.MiddleCenter;
            BooksButton.Image = null;
            BorrowerButton.Image = null;    
            TransactionButton.Image = null;
            SettingsButton.Image = null;
            AboutButton.Image = null;
        } 
        public void retractingPanelGUI()
        {
            BooksButton.Text = "";
            BorrowerButton.Text = "";
            TransactionButton.Text = "";
            SettingsButton.Text = "";
            AboutButton.Text = "";

            addImages();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        bool isSlidingPanel_expanded;
        const int MaxSliderWidth=231;
        const int MinSliderWidth=75;

        private void slidingpanel_toggle_Click(object sender, EventArgs e)
        {
            if (isSlidingPanel_expanded)
            {
                retractingPanelGUI();
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isSlidingPanel_expanded)
            {
                SlidingPanel.Width -= 15;
                if (SlidingPanel.Width <= MinSliderWidth)
                {
                    isSlidingPanel_expanded = false;
                    timer1.Stop();
                    
                    this.Refresh();
                }
            }
            else
            {
                SlidingPanel.Width += 15;
                if(SlidingPanel.Width >= MaxSliderWidth)
                {
                    isSlidingPanel_expanded = true;
                    timer1.Stop();
                    expandingPanelGUI();
                    this.Refresh();
                }
            }
        }

        private void SlidingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BooksButton_Click(object sender, EventArgs e)
        {

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void BorrowerButton_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
