using Menu.Interfaces;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SceneManagement;
using Zenject;

namespace Menu
{
    public class MenuInstaller : MonoInstaller<MenuInstaller>
    {
        [SerializeField] private MenuModel model;
        [SerializeField] private MenuView view;

        public override void InstallBindings()
        {
            var controller = new MenuController(view, model.GameSceneBuildIndex);

            Container
                .BindInstance(controller)
                .AsSingle();

            var menuScene = SceneManager.GetActiveScene();

            if (!ProjectContext.Instance.Container.HasBinding<IMenuData>())
            {
                ProjectContext.Instance.Container
                    .BindInterfacesTo<MenuData>()
                    .AsSingle()
                    .WithArguments(menuScene.buildIndex);
            }
        }
    }
}