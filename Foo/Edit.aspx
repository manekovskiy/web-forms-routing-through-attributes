<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="RoutingWithAttributes.Foo.Edit" %>
<%@ Import Namespace="RoutingWithAttributes" %>
<%@ Register Src="~/RouteDataValuesList.ascx" TagPrefix="uc" TagName="RouteDataValuesList" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Foo.Edit</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<h1>Foo.Edit</h1>
		<uc:RouteDataValuesList runat="server" id="RouteDataValuesList" />
		<a href='<%= Page.GetMappedRouteUrl(typeof(RoutingWithAttributes.Default), new { greeting = "hello from Foo-Edit" }) %>'>Home</a>
	</div>
    </form>
</body>
</html>
