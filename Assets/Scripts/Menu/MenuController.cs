using Menu.Interfaces;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu
{
    public class MenuController : MenuControllerBase
    {
        public MenuController(IMenuView view, int gameSceneIndex) : base(view)
        {
            _gameSceneIndex = gameSceneIndex;
        }

        private readonly int _gameSceneIndex;

        protected override void Play()
        {
            SceneManager.LoadScene(_gameSceneIndex);
        }

        protected override void Exit()
        {
            Application.Quit();
        }
    }
}