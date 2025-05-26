<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 32px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" PlaceHolder="Email" Height="23px" Width="195px"></asp:TextBox>
        </div>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" PlaceHolder="Mobile" Height="23px" Width="195px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" PlaceHolder="Company" Height="23px" Width="195px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox4" runat="server" PlaceHolder="Password" Height="23px" Width="195px"></asp:TextBox>
        </p>
        <asp:TextBox ID="TextBox5" runat="server" Type="Date" PlaceHolder="Date" Height="23px" Width="195px"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox6" runat="server" PlaceHolder="Status" Height="23px" Width="195px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style1" Text="Save Data" Width="86px" OnClick="Button1_Click" />
        </p>
        <asp:GridView ID="GridView1" runat="server" Width="305px">
            <Columns>
                <asp:ButtonField ButtonType="Button" Text="Delete" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
