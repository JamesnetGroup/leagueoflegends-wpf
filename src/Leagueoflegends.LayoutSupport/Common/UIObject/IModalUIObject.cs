namespace Leagueoflegends.LayoutSupport.Common.UIObject
{
	public interface IModalUIObject
	{
		bool IsModalVisible { get; set; }
		void ShowModal(string name);
	}
}
