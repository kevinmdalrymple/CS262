using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Drawing.Text;

    public partial class GreetingCardMaker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                string[] colorArray = Enum.GetNames(typeof(KnownColor));

                lstBackColor.DataSource = colorArray;
                lstBackColor.DataBind();
                lstForeColor.DataSource = colorArray;
                lstForeColor.DataBind();
                lstForeColor.SelectedIndex = 34;
                lstBackColor.SelectedIndex = 163;

                InstalledFontCollection fonts = new InstalledFontCollection();

                foreach (FontFamily family in fonts.Families)
                {
                    lstFontName.Items.Add(family.Name);
                }

                string[] borderStyleArray = Enum.GetNames(typeof(BorderStyle));

                lstBorder.DataSource = borderStyleArray;
                lstBorder.DataBind();
                lstBorder.SelectedIndex = 0;

                imgDefault.ImageUrl = "defaultpic.png";
            }
        }

        private void UpdateCard()
        {
            pnlCard.BackColor = Color.FromName(lstBackColor.SelectedItem.Text);
            lblGreeting.ForeColor = Color.FromName(lstForeColor.SelectedItem.Text);
            lblGreeting.Font.Name = lstFontName.SelectedItem.Text;
            try
            {
                if (Int32.Parse(txtFontSize.Text) > 0)
                {
                    lblGreeting.Font.Size = FontUnit.Point(Int32.Parse(txtFontSize.Text));
                }
            }
            catch
            {
                // Ignore invalid value.
            }

            try
            {
                if (Int32.Parse(txtFontSize.Text) > 0)
                {
                    lblGreeting.Font.Size =
                    FontUnit.Point(Int32.Parse(txtFontSize.Text));
                }
            }
            catch
            {
                // Ignore invalid value.
            }

            TypeConverter cnvrt = TypeDescriptor.GetConverter(typeof(BorderStyle));

            pnlCard.BorderStyle =
            (BorderStyle)cnvrt.ConvertFromString(lstBorder.SelectedItem.Text);

            if (chkPicture.Checked == true)
            {
                imgDefault.Visible = true;
            }
            else
            {
                imgDefault.Visible = false;
            }

            lblGreeting.Text = txtGreeting.Text;
        }

        protected void ControlChanged(Object sender, EventArgs e)
        {
            UpdateCard();
        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            UpdateCard();
        }
    }
