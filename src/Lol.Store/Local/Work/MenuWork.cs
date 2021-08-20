using Lol.Data.Store;
using Lol.Foundation.Mvvm;
using System.Collections.Generic;

namespace Lol.Store.Local.Work
{
	public class MenuWork : ObservableObject
	{
		public List<StoreMenuModel> Menus;

		#region Constructor

		public MenuWork()
		{
			Menus = GetMenus();
		}
        #endregion

        #region GetMenus

        private List<StoreMenuModel> GetMenus()
        {
            List<StoreMenuModel> source = new()
            {
                new StoreMenuModel(0, "Champions"),
                new StoreMenuModel(1, "Eternals"),
                new StoreMenuModel(2, "Bundles")
            };
            return source;
        }
        #endregion
    }
}
