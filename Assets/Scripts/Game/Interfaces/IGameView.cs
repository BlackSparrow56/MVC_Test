using System;

namespace Game.Interfaces
{
    public interface IGameView
    {
        event Action OnBackRequested;
    }
}