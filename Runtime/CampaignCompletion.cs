// SPDX-License-Identifier: Apache-2.0
// © 2024-2026 Depra <n.melnikov@depra.org>

using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Depra.Campaign
{
	public sealed class CampaignCompletion
	{
		private readonly CampaignDatabase _database;

		public CampaignCompletion(CampaignDatabase database) => _database = database;

		public CampaignLevel NextLevel() => _database.Levels.First();

		// TODO: implement current level tracking
		public CampaignLevel CurrentLevel() => _database.Levels.First();

		public GameObject PlayerPrefab()
		{
			var activeScene = SceneManager.GetActiveScene();
			if (activeScene.IsValid())
			{
				var level = _database.Find(activeScene.name);
				if (level != null)
				{
					return level.PlayerPrefab ?? _database.PlayerPrefabFallback;
				}
			}

			return _database.PlayerPrefabFallback;
		}
	}
}