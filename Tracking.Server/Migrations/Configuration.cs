using JetBrains.Annotations;
using NFive.SDK.Server.Migrations;
using IgiCore.Tracking.Server.Storage;

namespace IgiCore.Tracking.Server.Migrations
{
	[UsedImplicitly]
	public sealed class Configuration : MigrationConfiguration<StorageContext> { }
}
