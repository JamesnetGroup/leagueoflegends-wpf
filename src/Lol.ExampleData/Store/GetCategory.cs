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
				new StoreMenuModel(0, "Champions"),
				new StoreMenuModel(1, "Eternals"),
				new StoreMenuModel(2, "Bundles")
			};

			return source;
		}
	}
}
