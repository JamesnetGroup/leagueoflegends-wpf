namespace Lol.Data.Main
{
	public class SubMenuModel
	{
		public int Seq { get; set; }
		public int MainSeq { get; set; }
		public string Name { get; set; }

		public SubMenuModel(int seq, int mainSeq, string name)
		{
			Seq = seq;
			MainSeq = mainSeq;
			Name = name;
		}
	}
}
