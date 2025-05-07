<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="mywebapp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox2" runat="server" Height="20px" style="z-index: 1; left: 129px; top: 71px; position: absolute" Width="120px"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="20px" style="z-index: 1; left: 129px; top: 29px; position: absolute; bottom: 322px" Width="120px"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="EmplyeeId:-"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 10px; top: 72px; position: absolute" Text="EmplyeeName :-"></asp:Label>
        </p>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 10px; top: 110px; position: absolute" Text="Designetion :-"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" Height="20px" style="z-index: 1; left: 129px; top: 110px; position: absolute" Width="120px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox4" runat="server" Height="20px" style="z-index: 1; left: 128px; top: 150px; position: absolute" Width="120px"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 14px; top: 147px; position: absolute" Text="City :-"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" Height="20px" OnTextChanged="TextBox5_TextChanged" style="z-index: 1; left: 127px; top: 184px; position: absolute" Width="120px"></asp:TextBox>
        </p>
        <asp:Button ID="Insert" runat="server" Height="25px" OnClick="Insert_Click" OnClientClick="insert data" style="z-index: 1; top: 241px; position: absolute; left: 36px" Text="Insert" Width="50px" />
        <asp:Button ID="Update" runat="server" Height="25px" OnClick="Button1_Click" style="z-index: 1; left: 104px; top: 241px; position: absolute" Text="Update" Width="60px" />
        <asp:Label ID="Label5" runat="server" Enabled="False" style="z-index: 1; left: 9px; top: 183px; position: absolute" Text="Salary :-"></asp:Label>
        <p>
            <asp:Button ID="Delete" runat="server" Height="25px" OnClick="Delete_Click" style="z-index: 1; left: 186px; top: 241px; position: absolute; right: 717px" Text="Delete" Width="50px" />
        </p>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="z-index: 1; left: 337px; top: 70px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>
        <asp:Button ID="Show" runat="server" Height="25px" OnClick="Show_Click" style="z-index: 1; left: 263px; top: 241px; position: absolute" Text="Show" Width="50px" />
    </form>
    
</body>

</html>
