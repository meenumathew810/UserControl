<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalenderControl.aspx.cs" Inherits="UserControlDemo.CalenderControl" %>

<%@ Register Src="~/ReusableViews/FullCalendarControl.ascx" TagPrefix="uc1" TagName="FullCalendarControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:FullCalendarControl runat="server" id="FullCalendarControl" />
    </div>
    </form>
</body>
</html>

   