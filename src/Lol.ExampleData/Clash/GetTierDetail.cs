using Lol.Data.Clash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.ExampleData.Clash
{
	public partial class ExamClash
	{
		public static List<TierDetailModel> GetTierDetail()
		{
			List<TierDetailModel> source = new()
			{
				new TierDetailModel(0, "격전의신", "GOD", "28:57"),
			};

			return source;
		}
	}
}
