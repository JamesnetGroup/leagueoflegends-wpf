using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Leagueoflegends.DBEntity.Local.Entities.Schema
{
	public class CodeItem
	{
		[Key]
		public int Seq { get; set; }
		public string Id { get; set; }
		public string CodeId { get; set; }
		public string ItemName { get; set; }
		public string ItemValue{ get; set; }
		public string Explain { get; set; }
		public int Sort { get; set; }
	}
}
