using System;
using Menu.Interfaces;
using Zenject;

namespace Menu
{
    public abstract class MenuControllerBase : IInitializable, IDisposable
    {
        protected MenuControllerBase(IMenuView view)
        {
            _view = view;
            Initialize();
        }

        private readonly IMenuView _view;

        protected abstract void Play();
        protected abstract void Exit();
        
        public void Initialize()
        {
            _view.OnPlayRequested += Play;
            _view.OnExitRequested += Exit;
        }

        public void Dispose()
        {
            _view.OnPlayRequested -= Play;
            _view.OnExitRequested -= Exit;
        }
    }
}