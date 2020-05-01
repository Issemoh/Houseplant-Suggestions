using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Houseplant_Suggestions
{
    public partial class Form1 : Form
    {
         readonly int MinTemp = 50; // Global variable, 
        readonly int MaxTemp = 90; // Conventtion
         bool ShownMinWarning = true;
         bool ShownMaxWarning = false;

        HousePlantInfo plantInfo = new HousePlantInfo();

        public Form1()
        {
            InitializeComponent();
            this.trkTemp.Scroll += new System.EventHandler(this.HouseConditionsChanged);
            
            this.trkTemp.Minimum = MinTemp;
            this.trkTemp.Maximum = MaxTemp;
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trkTemp_Scroll(object sender, EventArgs e)
        {
            lblTemp.Text = trkTemp.Value.ToString("# °F");
        }

        private void HouseConditionsChanged(object sender, EventArgs e)
        {
            int homeTemp = trkTemp.Value;
           
            bool southFacingWindowAvailable = chkSouthFacing.Checked;

            if (ShownMinWarning == false && homeTemp == MinTemp)
            {
                MessageBox.Show(text: "Your home may be too cold for most houseplants", caption: "Information");
                ShownMinWarning = true;
            }
            if (ShownMaxWarning == false && homeTemp == MaxTemp)
            {
                MessageBox.Show(text: "Your home may be too warm for most houseplant", caption: "Information");
                ShownMaxWarning = true;
         
            }
     
            string suggestedPlant = plantInfo.GenerateSuggestion(homeTemp, southFacingWindowAvailable);

            lblSuggestion.Text = suggestedPlant;
        }

        
        private void lnkHousePlantInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblSuggestion.Text == "plant suggestion here")
            {
              plantInfo.ShowWebPage();
            }
            else
            {
                plantInfo.ShowWebPage(lblSuggestion.Text);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
