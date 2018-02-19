using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void handleChanged(object sender, EventArgs e)
        {
            performCalculation();
        }

        private void performCalculation()
        {
            //check if value exists in text box and the radio button
            if (!valueExists()) return;

            //what's the volume
            int volume = 0;
            if (!calculateVolume(out volume)) return;

            //determine multiplier
            double multiplier = determineMultiplier();

            //determin cost = volume * multiplier
            double cost = volume * multiplier;

            //display results
            resultLabel.Text = String.Format("You're parcel will cost {0:C} to ship.", cost);
        }
        
        private bool valueExists()
        {
            if (widthTextBox.Text.Trim().Length == 0 
                || heightTextBox.Text.Trim().Length == 0) return false;

            if (!groundRadioButton.Checked 
                && !airRadioButton.Checked
                && !nextDayRadioButton.Checked) return false;

            return true;
        }

        private bool calculateVolume(out int volume)
        {
            volume = 0;
            int width = 0;
            int length = 0;
            int height = 0;

            if (!int.TryParse(widthTextBox.Text.Trim(), out width)) return false;
            if (!int.TryParse(heightTextBox.Text.Trim(), out height)) return false;
            if (!int.TryParse(lengthTextBox.Text.Trim(), out length)) length = 1;

            volume = width * height * length;
            return true;
        }

        private double determineMultiplier()
        {
            if (groundRadioButton.Checked) return 0.15;
            else if (airRadioButton.Checked) return 0.25;
            else if (nextDayRadioButton.Checked) return 0.45;
            else return 0;
        }
    }
}