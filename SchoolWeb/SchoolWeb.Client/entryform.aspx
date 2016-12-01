<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="entryform.aspx.cs" Inherits="SchoolWeb.Client.entryform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label runat="server" ID="SchoolCourse"></asp:Label>
    <asp:DropDownList runat="server" ID="SchoolCourse_Text"></asp:DropDownList>

    <asp:Label runat="server" ID="SchoolClassDate"></asp:Label>
    <asp:DropDownList runat="server" ID="SchoolClassDate_Text"></asp:DropDownList>

    <asp:Label runat="server" ID="SchoolMajor"></asp:Label>
    <asp:DropDownList runat="server" ID="SchoolMajor_Text"></asp:DropDownList>

    <asp:Label runat="server" ID="SchoolDepartment"></asp:Label>
    <asp:DropDownList runat="server" ID="SchoolDepartment_Text"></asp:DropDownList>

    <asp:Label runat="server" ID="SchoolStudent"></asp:Label>
    <asp:DropDownList runat="server" ID="SchoolStudent_Text"></asp:DropDownList>

    <asp:Label runat="server" ID="SchoolTeacher"></asp:Label>
    <asp:DropDownList runat="server" ID="SchoolTeacher_Text"></asp:DropDownList>

    </div>
    </form>
</body>
</html>
