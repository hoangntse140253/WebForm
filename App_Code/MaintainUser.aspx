<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaintainUser.aspx.cs" Inherits="App_Code.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="en" xml:lang="en"> 
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="WEB FORM">
            User Name:<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            Password:<asp:TextBox ID="txtPassword" type="password" runat="server"></asp:TextBox>
            <br />
            BirthDate:<asp:TextBox ID="txtBirth" runat="server"></asp:TextBox>
            <br />
            Address:<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br />
            Email:<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <br />
            <asp:GridView ID="gvUserInfoList" runat="server" AutoGenerateSelectButton="True" BackColor="#FFFFCC" BorderColor="#CCD5F0" BorderStyle="Inset" BorderWidth="3px" Caption="Account Manager" CaptionAlign="Top" OnSelectedIndexChanging="gvUserInfoList_SelectedIndexChanging " >
            </asp:GridView>
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
