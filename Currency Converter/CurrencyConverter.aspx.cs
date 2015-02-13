using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
public partial class CurrencyConverter : System.Web.UI.Page
{
    protected void Convert_ServerClick(object sender, EventArgs e)
    {
        decimal USAmount;
        // Attempt the conversion. 
        bool success = Decimal.TryParse(US.Value, out USAmount);
        // Check if it succeeded. 
        if (success)
        {
            // The conversion succeeded. 
            decimal euroAmount = USAmount * 0.85M;
            Result.InnerText = USAmount.ToString() + "U.S.dollars=";
            Result.InnerText += euroAmount.ToString() + "Euros.";
        }
        else
        { // The conversion failed. 
            Result.InnerText = "The number you typed in was not in the " +
                "correct format. Use only numbers.";
        }
    }
}