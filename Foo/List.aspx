<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="RoutingWithAttributes.Foo.List" %>
<%@ Import Namespace="RoutingWithAttributes" %>
<%@ Register Src="~/RouteDataValuesList.ascx" TagPrefix="uc" TagName="RouteDataValuesList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Foo.List</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<h1>Foo.List</h1>
		<uc:RouteDataValuesList runat="server" id="RouteDataValuesList" />
		<a href='<%= Page.GetMappedRouteUrl(typeof(RoutingWithAttributes.Default), new { greeting = HttpUtility.JavaScriptStringEncode("hello from Foo-List") }) %>'>Home</a>
    </div>
    </form>
</body>
</html>
