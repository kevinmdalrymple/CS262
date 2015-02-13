<%@ Page Language = "C#" AutoEventWireup = "true" 
    CodeFile = "CurrencyConverter.aspx.cs" Inherits = "CurrencyConverter" %> 

<!DOCTYPE html> 
<html> 
 <head> 
    <title>CurrencyConverter</title> 
 </head> 
 <body> 
    <form runat="server"> 
     <div> 
         Convert: &nbsp;
         <input type="text" ID="US" runat="server"/> 
         &nbsp; U.S. dollars to Euros. 
        <br/> <br/> 
        <input type="submit" value="OK" ID="Convert" runat="server" OnServerClick="Convert_ServerClick" />
         <br/> <br/>
         <p style="font-weight:bold" ID="Result" runat="server"> </p>
     </div> 
    </form> 
 </body> 
</html>

