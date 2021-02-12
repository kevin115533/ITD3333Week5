<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body style="height: 104px"  >
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="firstLbl" runat="server" Text="First Name:"></asp:Label>
            <asp:TextBox ID="firstTxtbox" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lastLbl" runat="server" Text="Last Name:"></asp:Label>
            <asp:TextBox ID="lastTxtbox" runat="server"></asp:TextBox>
            
        </div>
        <div>
            <asp:Label ID="postNameLbl" runat="server" Text="Postback Name: " ></asp:Label>
            <asp:Label ID="postedNameLbl" runat="server" ></asp:Label>
        </div>
        <div>
            <asp:Label ID="postLbl" runat="server" Text="Post counter:"></asp:Label>
            <asp:Label ID="postCountLbl" runat="server" Text ='<%# postCounter%>' ></asp:Label>
        </div>    
        <asp:Button ID="postBtn" runat="server" Text="Post page"  OnClick="cmdPostback_Click"  />
    </form>
</body>
</html>

<style>
    body{
        line-height: 2;
    }
</style>
