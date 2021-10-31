using Lol.Database.Controller;
using Lol.Database.Entites.Schema;
using Lol.Foundation.Mvvm;
using System;
using System.Collections.Generic;

namespace Lol.GameRoom.Local.ViewModels
{
    public class CreateCustomViewModel : ObservableObject
    {
        #region Variables

        private Action<object> _customConfirm;
        private GameRoomsCustom _currentCusTom;
        public List<GameRoomsCustom> Customs { get; set; }

        #endregion

        #region ICommand
        public RelayCommand<object> ConfirmCommand { get; set; }
        #endregion

        #region CurrentCustom

        public GameRoomsCustom CurrentCustom
        {
            get { return _currentCusTom; }
            set { _currentCusTom = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public CreateCustomViewModel(Action<object> customConfirm)
        {
            _customConfirm = customConfirm;
            Customs = new GameRoomApi().GetGameRoomsCustom();

            CurrentCustom = Customs[0];
            ConfirmCommand = new RelayCommand<object>(RoomCreateCommand, CanRoomCreateCommand);
        }
        #endregion


        #region RoomCreateCommand

        private void RoomCreateCommand(object obj)
        {
            _customConfirm.Invoke(obj);
        }
        #endregion

        #region CanRoomCreateCommand

        private bool CanRoomCreateCommand(object obj)
        {
            return true;
        }
        #endregion


    }
}
