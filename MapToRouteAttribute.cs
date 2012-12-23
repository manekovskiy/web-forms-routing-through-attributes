using System;

namespace RoutingWithAttributes
{
	public class MapToRouteAttribute : Attribute
	{
		public string RouteUrl { get; set; }
		public string PhysicalFile { get; set; }
		public bool CheckPhysicalUrlAccess { get; set; }
	}
}