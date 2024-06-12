// SPDX-License-Identifier: Apache-2.0
// © 2024 Nikolay Melnikov <n.melnikov@depra.org>

using Depra.Scenes.Definitions;
using UnityEngine;
using static Depra.Campaign.Module;

namespace Depra.Campaign
{
	[CreateAssetMenu(fileName = FILE_NAME, menuName = MENU_PATH + FILE_NAME, order = DEFAULT_ORDER)]
	public sealed class CampaignLevel : ScriptableObject
	{
		[field: SerializeField] public string DisplayName { get; private set; }
		[field: SerializeField] public string Description { get; private set; }
		[field: SerializeField] public SceneDefinition Scene { get; private set; }

		private const string FILE_NAME = nameof(CampaignLevel);
	}
}