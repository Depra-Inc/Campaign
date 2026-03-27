// SPDX-License-Identifier: Apache-2.0
// © 2024-2025 Depra <n.melnikov@depra.org>

using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static Depra.Campaign.Module;

namespace Depra.Campaign
{
	[CreateAssetMenu(fileName = FILE_NAME, menuName = MENU_PATH + FILE_NAME, order = DEFAULT_ORDER)]
	public sealed class CampaignDatabase : ScriptableObject
	{
		[SerializeField] private CampaignLevel[] _levels;
		[SerializeField] private GameObject _playerPrefabFallback;

		private const string FILE_NAME = nameof(CampaignDatabase);

		public IEnumerable<CampaignLevel> Levels => _levels;
		public GameObject PlayerPrefabFallback => _playerPrefabFallback;

		public CampaignLevel Find(string sceneName) => _levels.FirstOrDefault(level => level.SceneName == sceneName);
	}
}