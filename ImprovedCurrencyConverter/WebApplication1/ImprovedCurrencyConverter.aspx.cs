﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CurrencyConverter : System.Web.UI.Page
{
    protected void Convert_ServerClick(object sender, EventArgs e)
    {
        decimal oldAmount;
        bool success = Decimal.TryParse(US.Value, out oldAmount);
        if ((oldAmount <= 0) || (success == false))
        {
            Result.Style["color"] = "Red";
            Result.InnerText = "Specify a positive number";
        }
        else
        {
            Result.Style["color"] = "Black";

            ListItem item = Currency.Items[Currency.SelectedIndex];

            decimal newAmount = oldAmount * Decimal.Parse(item.Value);
            Result.InnerText = oldAmount.ToString() + "U.S. dollars=";
            Result.InnerText += newAmount.ToString() + " " + item.Text;

            Graph.Src = "Pic" + Currency.SelectedIndex.ToString() + ".png";
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            Currency.Items.Add(new ListItem("Euro", "0.85"));
            Currency.Items.Add(new ListItem("Japanese Yen", "110.33"));
            Currency.Items.Add(new ListItem("Canadian Dollar", "1.2"));

            Graph.Visible = false;
        }
    }
    protected void ShowGraph_ServerClick(Object sender, EventArgs e)
    {
        Graph.Src = "Pic" + Currency.SelectedIndex.ToString() + ".png";
        Graph.Visible = true;
    }
}


