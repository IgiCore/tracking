using System;
using NFive.SDK.Core.Models;

namespace IgiCore.Tracking.Shared.Models
{
	public interface ITrackingObject : IIdentityModel
	{
		int? Handle { get; set; }
		Guid TrackingUserId { get; set; }
		int? NetId { get; set; }
	}
}
