<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SchoolWeb.Client._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:ListBox runat="server" ID="courselist" ClientIDMode="Static"></asp:ListBox>
    <asp:ListBox runat="server" ID="studentlist" ClientIDMode="Static"></asp:ListBox>
    <asp:ListBox runat="server" ID="teacherlist" ClientIDMode="Static"></asp:ListBox>
    <asp:ListBox runat="server" ID="majorlist" ClientIDMode="Static"></asp:ListBox>
    <asp:ListBox runat="server" ID="schedulelist" ClientIDMode="Static"></asp:ListBox>
    <asp:ListBox runat="server" ID="departmentlist" ClientIDMode="Static"></asp:ListBox>
    <asp:ListBox runat="server" ID="classdatelist" ClientIDMode="Static"></asp:ListBox>
    </div>
    </form>
</body>
</html>
