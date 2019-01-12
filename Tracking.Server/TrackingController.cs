using JetBrains.Annotations;
using NFive.SDK.Core.Diagnostics;
using NFive.SDK.Server.Controllers;
using NFive.SDK.Server.Events;
using NFive.SDK.Server.Rcon;
using NFive.SDK.Server.Rpc;

namespace IgiCore.Tracking.Server
{
	[PublicAPI]
	public class TrackingController : ConfigurableController<Configuration>
	{
		public TrackingController(ILogger logger, IEventManager events, IRpcHandler rpc, IRconManager rcon, Configuration configuration) : base(logger, events, rpc, rcon, configuration)
		{
			this.Logger.Debug("Hello World!");
		}
	}
}
