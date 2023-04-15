<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Azuriranje.aspx.cs" Inherits="B20.Azuriranje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="header">
            <div class="hcol1">
                Zadatak 10
            </div>
            <div class="hcol2">
                Kursna lista           
            </div>           
        </div>
        <div class="main">
            <div class="container">                
                <h2>Unos kursa</h2>

                <hr class="fading_line"/>
                <asp:Label ID="Label1" runat="server" Text="Datum:"></asp:Label>
                &nbsp;
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Valuta:"></asp:Label>
                &nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Iznos:"></asp:Label>
                &nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                <hr class="fading_line"/>

                <asp:Button ID="Button1" runat="server" Text="Snimi" />
                <asp:Button ID="Button2" runat="server" Text="Odustani" />

                
                
            </div>
        </div>
        <div class="footer">
            <div class="fcol1">
                Elektrotehnička škola "Zemun" Beograd
            </div>
            <div class="fcol2">              
                <a class="a" href="/Pregled.aspx">Kurs na dan</a>
                <a class="a" href="">O autoru</a>               
            </div>           
        </div>
        </div>
    </form>
</body>
</html>
