using System;

namespace Menu.Interfaces
{
    public interface IMenuView
    {
        event Action OnPlayRequested;
        event Action OnExitRequested;
    }
}