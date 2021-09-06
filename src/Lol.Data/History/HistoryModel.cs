using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.Data.History
{
	public class HistoryModel
	{
		public int Seq { get; set; }
		public string Name { get; set; }

		public HistoryModel(int seq, string name)
		{
			Seq = seq;
			Name = name;
		}
	}
}
