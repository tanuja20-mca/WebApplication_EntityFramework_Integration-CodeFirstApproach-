<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="WebApplication_EntityFramework_Integration.StudentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblID" runat="server" Text="ID:"></asp:Label>
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox><br />
             <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
             <asp:Label ID="lblCourse" runat="server" Text="Course:"></asp:Label>
             <asp:TextBox ID="txtCourse" runat="server"></asp:TextBox><br />
             <asp:Label ID="lblFee" runat="server" Text="Fee:"></asp:Label>
           <asp:TextBox ID="txtFee" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnSelect" runat="server" Text="Select" OnClick="btnSelect_Click" />
        </div>
    </form>
</body>
</html>

