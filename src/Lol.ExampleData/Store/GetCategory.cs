using Lol.Data.Store;
using System.Collections.Generic;

namespace Lol.ExampleData.Store
{
	public partial class ExamStore
	{
		public static List<StoreMenuModel> GetCategory()
		{
			List<StoreMenuModel> source = new()
			{
				new StoreMenuModel(0, "CHAMPIONS"),
				new StoreMenuModel(1, "ETERNALS"),
				new StoreMenuModel(2, "BUNDLES")
			};

			return source;
		}
	}
}
