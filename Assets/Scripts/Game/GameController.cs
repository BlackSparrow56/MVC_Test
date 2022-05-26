using Game.Interfaces;
using Menu.Interfaces;
using UnityEngine.SceneManagement;

namespace Game
{
    public class GameController : GameControllerBase
    {
        public GameController(IGameView view, IMenuData data) : base(view)
        {
            _data = data;
        }

        private readonly IMenuData _data;

        protected override void Back()
        {
            var index = _data.MenuSceneIndex;
            SceneManager.LoadScene(index);
        }
    }
}