<%@ Page Title="GreetingCardMaker" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="True" Inherits="GreetingCardMaker" Codebehind="GreetingCardMaker.aspx.cs" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <form runat="server">
        <div>
                Choose a background color:<br />
                <asp:DropDownList ID="lstBackColor" runat="server" Height="22px"
                    Width="194px" AutoPostBack="True"
                    OnSelectedIndexChanged="ControlChanged">
                </asp:DropDownList><br />
                <br />
                Choose a foreground (text) color:<br />
                <asp:DropDownList ID="lstForeColor" runat="server" Height="22px"
                    Width="194px" AutoPostBack="True"
                    OnSelectedIndexChanged="ControlChanged">
                </asp:DropDownList><br />
                <br />
                Choose a font name:<br />
                <asp:DropDownList ID="lstFontName" runat="server" Height="22px"
                    Width="194px" AutoPostBack="True"
                    OnSelectedIndexChanged="ControlChanged">
                </asp:DropDownList><br />
                <br />
                Specify&nbsp;a font size:<br />
                <asp:TextBox ID="txtFontSize" runat="server" AutoPostBack="True"
                    OnTextChanged="ControlChanged"></asp:TextBox><br />
                <br />
                Choose a border style:<br />
                <asp:RadioButtonList ID="lstBorder" runat="server" Height="59px"
                    Width="177px" Font-Size="X-Small" AutoPostBack="True" RepeatColumns="2"
                    OnSelectedIndexChanged="ControlChanged">
                </asp:RadioButtonList><br />
                <br />
                <asp:CheckBox ID="chkPicture" runat="server" Text="Add the Default Picture"
                    AutoPostBack="True" OnCheckedChanged="ControlChanged"></asp:CheckBox><br />
                <br />
                Enter the greeting text below:<br />
                <asp:TextBox ID="txtGreeting" runat="server" Height="85px" Width="240px"
                    TextMode="MultiLine" AutoPostBack="True"
                    OnTextChanged="ControlChanged"></asp:TextBox><br />
                <br />
                <asp:Button ID="cmdUpdate" runat="server" Height="24px" Width="71px"
                    Text="Update" OnClick="cmdUpdate_Click"></asp:Button>&nbsp;
            </div>
            <asp:Panel ID="pnlCard" Style="left: 355px; position: absolute; top: 16px"
                runat="server"
                Height="507px" Width="339px" HorizontalAlign="Center">
                <br />
                &nbsp;
                <asp:Label ID="lblGreeting" runat="server" Height="150px"
                    Width="256px"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Image ID="imgDefault" runat="server" Height="160px" Width="212px"
                    Visible="False"></asp:Image>
            </asp:Panel>
    </form>
</asp:Content>