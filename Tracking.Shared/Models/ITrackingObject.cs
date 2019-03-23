using System;
using JetBrains.Annotations;
using NFive.SDK.Core.Models;

namespace IgiCore.Tracking.Shared.Models
{
	[PublicAPI]
	public interface ITrackingObject : IIdentityModel
	{
		int? Handle { get; set; }
		Guid? TrackingUserId { get; set; }
		int? NetId { get; set; }
	}
}
