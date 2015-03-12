<%@ Page Language="C#" AutoEventWireup="True" Inherits="CurrencyConverter" Codebehind="ImprovedCurrencyConverter.aspx.cs" %>

<!DOCTYPE html>

<html>
    <head>
        <title>Currency Converter</title>
    </head>
    <body>
        <form runat="server">
            <div class="aspNetHidden">
                <input type="hidden" name="_VIEWSTATE" id="_VIEWSTATE" value="/dDw3NDg2NTI5MDg70z4..." />
            </div>
            <div class="aspNetHidden">
                <input type="hidden" name="_EVENTVALIDATION" id="_EVENTVALIDATION" value="/wEWAwLr3rr0BgLr797..." />
            </div>
            <div>
                Convert:&nbsp;
                <input type="text" ID="US" runat="server"/>
                &nbsp;U.S. dollars to Euros.
                <select id="Currency" runat="server" />
                <br /><br />
                <input type="submit" value="OK" ID="Convert" runat="server" OnServerClick="Convert_ServerClick"/>
                <input type="submit" value="Show Graph" id="ShowGraph" OnServerClick="ShowGraph_ServerClick" runat="server" />
                <br /><br />
                <img id="Graph" src="" alt="Currency Graph" runat="server" />
                <br /><br />
                <p style="font-weight: bold" id="Result" runat="server"></p>
            </div>
        </form>
    </body>
</html>