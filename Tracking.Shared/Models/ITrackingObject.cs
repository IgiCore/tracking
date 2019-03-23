using JetBrains.Annotations;
using NFive.SDK.Core.Models;
using System;

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
