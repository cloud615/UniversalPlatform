<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="UniversalPlatform.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>链接列表</title>
    <link href="Content/css.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.8.2.js"></script>
    <script src="JS/Index.js"></script>
</head>
<body>
    <div>
        <table id="webList"  border="1" class="maintable">
            <caption>网站列表</caption>
            <tr>
                <th style="width:50px;">编号</th><th style="width:100px;">名称</th><th style="width:300px;">网址</th>
            </tr>
        </table>
    </div>
</body>
</html>
