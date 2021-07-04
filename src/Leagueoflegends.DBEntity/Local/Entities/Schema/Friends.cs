using System;
using System.ComponentModel.DataAnnotations;

namespace Leagueoflegends.DBEntity.Local.Entities.Schema
{
	public class Friends
	{
		[Key]
		public int Seq { get; set; }
		public int UserSeq { get; set; }
		public int FriendsSeq { get; set; }
		public bool IsAccept { get; set; }
		public DateTime Created { get; set; }
		public DateTime Updated { get; set; }
	}
}
