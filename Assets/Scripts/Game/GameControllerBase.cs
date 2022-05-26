using System;
using Game.Interfaces;
using Zenject;

namespace Game
{
    public abstract class GameControllerBase : IInitializable, IDisposable
    {
        protected GameControllerBase(IGameView view)
        {
            _view = view;
            Initialize();
        }

        private readonly IGameView _view;

        protected abstract void Back();
        
        public void Initialize()
        {
            _view.OnBackRequested += Back;
        }

        public void Dispose()
        {
            _view.OnBackRequested -= Back;
        }
    }
}