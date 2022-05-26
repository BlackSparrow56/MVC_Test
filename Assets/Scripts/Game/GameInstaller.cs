using Menu;
using Menu.Interfaces;
using UnityEngine;
using Zenject;

namespace Game
{
    public class GameInstaller : MonoInstaller<GameInstaller>
    {
        [SerializeField] private GameView view;
        
        public override void InstallBindings()
        {
            var data = ProjectContext.Instance.Container.Resolve<IMenuData>();
            var controller = new GameController(view, data);

            Container
                .BindInstance(controller)
                .AsSingle();
        }
    }
}