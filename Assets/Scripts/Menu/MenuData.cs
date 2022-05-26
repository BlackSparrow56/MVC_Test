using Menu.Interfaces;

namespace Menu
{
    public class MenuData : IMenuData
    {
        public MenuData(int menuSceneIndex)
        {
            MenuSceneIndex = menuSceneIndex;
        }

        public int MenuSceneIndex
        {
            get;
        }
    }
}