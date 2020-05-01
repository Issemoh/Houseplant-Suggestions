using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houseplant_Suggestions
{
    class HousePlantInfo
    {
        public string GenerateSuggestion(int temp, bool soutFacing)
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
        public void ShowWebPage(string plantName = null) // optional parameter
        {
            string url = "https://www.houseplant411.com/";

            if (plantName != null)
            {
                //link to a specific plant
                url = url + "houseplant?hpq=" + plantName;
            }
            System.Diagnostics.Process.Start(url); // Launch web browser, 
        }
    }
}
