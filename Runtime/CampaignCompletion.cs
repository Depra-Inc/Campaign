// SPDX-License-Identifier: Apache-2.0
// © 2024 Nikolay Melnikov <n.melnikov@depra.org>

using System.Linq;

namespace Depra.Campaign
{
	public sealed class CampaignCompletion
	{
		private readonly CampaignDatabase _database;

		public CampaignCompletion(CampaignDatabase database) => _database = database;

		public CampaignLevel Next() => _database.Levels.First();
	}
}