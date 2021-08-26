using Lol.Data.Clash;
using System.Collections.Generic;

namespace Lol.ExampleData.Clash
{
	public partial class ExamClash
	{
		public static List<BaseModel> GetCategory()
		{
			List<BaseModel> source = new()
			{
				new BaseModel(0, "일정"),
				new BaseModel(1, "전적")
			};

			return source;
		}
	}
}
