<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RoutingWithAttributes.Default" %>
<%@ Register Src="~/RouteDataValuesList.ascx" TagPrefix="uc" TagName="RouteDataValuesList" %>
<%@ Import Namespace="RoutingWithAttributes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
	    <h1>Home</h1>
	    <ul>
			<li>
				<asp:HyperLink ID="hlFooEdit" runat="server" Text="Foo.List - HyperLink control" 
					NavigateUrl='<%# Page.GetMappedRouteUrl(typeof(RoutingWithAttributes.Foo.List), new { year = "2012" }) %>' />
			</li>
			<li>
			    <a href='<%= Page.GetMappedRouteUrl(typeof(RoutingWithAttributes.Foo.Edit), new { id = 1 }) %>'>Foo.Edit - anchor</a>
		    </li>
	    </ul>
		<uc:RouteDataValuesList runat="server" id="RouteDataValuesList" />
    </div>
    </form>
</body>
</html>