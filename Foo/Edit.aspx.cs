using System.Web.Routing;
using System.Web.UI;

namespace RoutingWithAttributes.Foo
{
	[MapToRoute(RouteUrl = "Foo/Edit/{id}", PhysicalFile = "~/Foo/Edit.aspx")]
	public partial class Edit : Page
	{
		public static RouteValueDictionary Defaults 
		{ 
			get
			{
				return new RouteValueDictionary { { "id", "" } };
			} 
		}

		public static RouteValueDictionary Constraints
		{
			get
			{
				return new RouteValueDictionary { { "id", "^[0-9]*$" } };
			}
		}
	}
}