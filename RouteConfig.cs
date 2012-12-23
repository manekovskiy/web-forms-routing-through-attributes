using System;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Routing;

namespace RoutingWithAttributes
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			var mappedPages = Assembly.GetAssembly(typeof(RouteConfig))
					.GetTypes()
					.AsEnumerable()
					.Where(type => type.GetCustomAttributes(typeof(MapToRouteAttribute), false).Length == 1);

			foreach (var pageType in mappedPages)
			{
				var defaultsProperty = pageType.GetProperty("Defaults");
				var defaults = defaultsProperty != null ? (RouteValueDictionary)defaultsProperty.GetValue(null, null) : null;

				var constraintsProperty = pageType.GetProperty("Constraints");
				var constraints = constraintsProperty != null ? (RouteValueDictionary)constraintsProperty.GetValue(null, null) : null;

				var dataTokensProperty = pageType.GetProperty("DataTokens");
				var dataTokens = dataTokensProperty != null ? (RouteValueDictionary)dataTokensProperty.GetValue(null, null) : null;

				var routeAttribute = (MapToRouteAttribute)pageType.GetCustomAttributes(typeof(MapToRouteAttribute), false)[0];

				if (string.IsNullOrEmpty(routeAttribute.RouteUrl))
					throw new NullReferenceException("RouteUrl property cannot be null");

				if (string.IsNullOrEmpty(routeAttribute.PhysicalFile))
					throw new NullReferenceException("PhysicalFile property cannot be null");

				if (!VirtualPathUtility.IsAppRelative(routeAttribute.PhysicalFile))
					throw new ArgumentException("Properееy should be application relative URL", "PhysicalFile");

				routes.MapPageRoute(pageType.FullName, routeAttribute.RouteUrl, routeAttribute.PhysicalFile, true, defaults, constraints, dataTokens);
			}
		}
	}
}