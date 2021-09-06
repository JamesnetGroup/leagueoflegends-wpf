using Lol.Data.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.ExampleData.History
{
	public partial class ExamHistory
	{
		public static List<HistoryModel> GetHistory()
		{
			List<HistoryModel> source = new()
			{
				new HistoryModel(0, "Ⅰ"),
				new HistoryModel(1, "Ⅱ"),
				new HistoryModel(2, "Ⅲ"),
				new HistoryModel(3, "Ⅳ")
			};

			return source;
		}
	}
}
