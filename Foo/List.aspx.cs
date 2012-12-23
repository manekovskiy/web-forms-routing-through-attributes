using System;
using System.Web.Routing;
using System.Web.UI;

namespace RoutingWithAttributes.Foo
{
	[MapToRoute(RouteUrl = "Foo/List/{year}/{month}", PhysicalFile = "~/Foo/List.aspx")]
	public partial class List : Page
	{
		public static RouteValueDictionary Defaults
		{
			get
			{
				return new RouteValueDictionary
				{
					{ "year", DateTime.Today.Year },
					{ "month", DateTime.Today.Month }
				};
			}
		}

		public static RouteValueDictionary Constraints
		{
			get
			{
				return new RouteValueDictionary
				{
					{ "year", "^[0-9]{4}$" },
					{ "month", "^[0-9]{0,1}[1-9]$" }
				};
			}
		}
	}
}