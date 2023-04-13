using System;
using Lol.Main.Local.ViewModels;

namespace Lol.Main.Local.Work
{
    public class GameWork
    {
        #region Variables

        private readonly MainContentViewModel _vm;
        #endregion

        #region Constructor

        public GameWork(MainContentViewModel vm)
        {
            _vm = vm;
        }
        #endregion

        #region OpenGameRoom

        internal void OpenGameRoom(Type _)
        {
            // TODO: [Kevin] 게임시작 버튼 클릭시 화면 변경 수정 필히 필요
            _vm.MainMenu.CurrentMenu = _vm.MainMenu.Menus[8];
            _vm.MainMenu.MenuChanged(_vm.MainMenu.CurrentMenu);
        }
        #endregion
    }
}
