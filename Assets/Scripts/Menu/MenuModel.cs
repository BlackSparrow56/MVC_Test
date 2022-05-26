using System;
using Menu.Interfaces;
using UnityEngine;

namespace Menu
{
    [Serializable]
    public struct MenuModel : IMenuModel
    {
        [SerializeField] private int menuSceneBuildIndex;
        [SerializeField] private int gameSceneBuildIndex;

        public int MenuSceneBuildIndex => menuSceneBuildIndex;
        public int GameSceneBuildIndex => gameSceneBuildIndex;
    }
}