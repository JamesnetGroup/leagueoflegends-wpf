using System.Linq;
using System.Collections.Generic;
using Lol.DBEntity.Local.Entities;
using Lol.DBEntity.Local.Entities.Extend;

namespace Lol.DBEntity.Local.Api
{
	public class GetCodeItems
	{
		public List<UsualCodes> Run(string codeId)
		{
			using RiotContext db = new();

			var items = db.CodeItems
				.Where(x => x.CodeId == codeId)
				.OrderBy(x => x.Sort)
				.Select(x => new UsualCodes(x))
				.ToList();

			return items;
		}
	}
}
