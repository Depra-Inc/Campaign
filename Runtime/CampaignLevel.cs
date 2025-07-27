// SPDX-License-Identifier: Apache-2.0
// © 2024-2025 Depra <n.melnikov@depra.org>

using Depra.Scenes;
using UnityEngine;
using static Depra.Campaign.Module;

namespace Depra.Campaign
{
	[CreateAssetMenu(fileName = FILE_NAME, menuName = MENU_PATH + FILE_NAME, order = DEFAULT_ORDER)]
	public sealed class CampaignLevel : ScriptableObject
	{
		[SerializeField] private string _displayName;
		[TextArea] [SerializeField] private string _description;
		[SerializeField] private SceneDefinition _scene;
		[SerializeField] private GameObject _playerPrefab;

		private const string FILE_NAME = nameof(CampaignLevel);

		public string DisplayName => _displayName;
		public string Description => _description;
		public SceneDefinition Scene => _scene;
		public string SceneName => Scene.DisplayName;
		public GameObject PlayerPrefab => _playerPrefab;
	}
}