<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RouteDataValuesList.ascx.cs" Inherits="RoutingWithAttributes.RouteDataValuesList" %>

<span>Route parameters:</span>
<ul>
	<% foreach (var kvp in Request.RequestContext.RouteData.Values)
	{ %>
	<li><%: kvp.Key + " = " + kvp.Value %></li>
	<% } %>
</ul>
