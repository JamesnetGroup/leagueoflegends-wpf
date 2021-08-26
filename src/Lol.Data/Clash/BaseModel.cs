namespace Lol.Data.Clash
{
	public class BaseModel
	{
		public int Seq { get; set; }
		public string Name { get; set; }

		public BaseModel(int seq, string name)
		{
			Seq = seq;
			Name = name;
		}
	}
}
