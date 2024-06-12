// SPDX-License-Identifier: Apache-2.0
// © 2024 Nikolay Melnikov <n.melnikov@depra.org>

using System.Collections.Generic;
using UnityEngine;
using static Depra.Campaign.Module;

namespace Depra.Campaign
{
	[CreateAssetMenu(fileName = FILE_NAME, menuName = MENU_PATH + FILE_NAME, order = DEFAULT_ORDER)]
	public sealed class CampaignDatabase : ScriptableObject
	{
		[SerializeField] private CampaignLevel[] _levels;

		private const string FILE_NAME = nameof(CampaignDatabase);

		public IEnumerable<CampaignLevel> Levels => _levels;
	}
}