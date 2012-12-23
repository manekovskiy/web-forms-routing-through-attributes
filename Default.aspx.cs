using System.Web.Routing;
using System.Web.UI;

namespace RoutingWithAttributes
{
	[MapToRoute(RouteUrl = "Home/{*greeting}", PhysicalFile = "~/Default.aspx")]
	public partial class Default : Page
	{
		public static RouteValueDictionary Defaults
		{
			get
			{
				return new RouteValueDictionary
				{
					{ "greeting", "" }
				};
			}
		}

		protected override void OnLoad(System.EventArgs e)
		{
			hlFooEdit.DataBind();
		}
	}
}