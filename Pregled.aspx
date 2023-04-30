<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pregled.aspx.cs" Inherits="B20.Pregled" %>

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
                <asp:Label ID="Label1" runat="server" Text="Datum:"></asp:Label>
                <!--Koristimo Calendar jer DatePicker ne postoji u Web Forms nego u Windows Forms-->
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                <!--2. nacin bi bio textbox koji prima podatke tipa date, sto odgovara dizajnu(slici zadatka)-->
                <!--<asp:TextBox ID="TextBox1" runat="server" TextMode="DateTime"></asp:TextBox>-->
                <asp:Label ID="Label2" runat="server" Text="Valuta:"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                <asp:Button ID="Button1" runat="server" Text="Prikaži" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="Dodaj" />

                <hr class="fading_line"/>

                <asp:Label ID="Label3" runat="server" Text="Kurs valute" ForeColor="#264c73" Font-Size="30pt" Font-Bold="true"></asp:Label>
                
                
            </div>
        </div>
        <div class="footer">
            <div class="fcol1">
                Elektrotehnička škola "Zemun" Beograd
            </div>
            <div class="fcol2">              
                <a class="a" href="/Azuriranje.aspx">Unos kursa</a>
                <a class="a" href="">O autoru</a>               
            </div>           
        </div>
        </div>
    </form>
</body>
</html>
