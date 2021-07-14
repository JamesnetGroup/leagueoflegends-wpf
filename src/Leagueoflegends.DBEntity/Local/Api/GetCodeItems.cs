using System.Linq;
using System.Collections.Generic;
using Leagueoflegends.DBEntity.Local.Entities;
using Leagueoflegends.DBEntity.Local.Entities.Extend;

namespace Leagueoflegends.DBEntity.Local.Api
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
