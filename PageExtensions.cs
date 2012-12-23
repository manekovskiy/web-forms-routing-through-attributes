using System;
using System.Web.Routing;
using System.Web.UI;

namespace RoutingWithAttributes
{
	public static class PageExtensions
	{
		public static string GetMappedRouteUrl(this Page thisPage, Type targetPageType, object routeParameters)
		{
			return thisPage.GetRouteUrl(targetPageType.FullName, routeParameters);
		}

		public static string GetMappedRouteUrl(this Page thisPage, Type targetPageType, RouteValueDictionary routeParameters)
		{
			return thisPage.GetRouteUrl(targetPageType.FullName, routeParameters);
		}
	}
}