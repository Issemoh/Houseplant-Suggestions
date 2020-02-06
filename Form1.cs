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
        public Form1()
        {
            InitializeComponent();
            this.trkTemp.Scroll += new System.EventHandler(this.HouseConditionsChanged);
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

            string suggestedPlant = GenerateSuggestion(homeTemp, southFacingWindowAvailable);

            lblSuggestion.Text = suggestedPlant;
        }
        private string GenerateSuggestion(int temp, bool soutFacing)
        {
            if (soutFacing)
            {
                if (temp > 65)
                {
                    return "Peace Lily";
                }
                else
                {
                    return "Spider Plant";
                }
            }
            else
            {
                    if (temp > 65)
                {
                    return "Dragon Tree";
                }
                else
                {
                    return "Ivy";
                }
            }
        }

        private void lblSuggestion_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
