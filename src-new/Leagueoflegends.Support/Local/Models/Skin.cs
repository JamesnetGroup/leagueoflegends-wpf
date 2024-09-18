namespace Leagueoflegends.Support.Local.Models;

public class Skin
{
    public string Name { get; set; }
    public string SkinName { get; set; }
    public string ImageUrl { get; set; }
    public bool IsPurchased { get; set; }

    public string DisplayName => string.IsNullOrWhiteSpace(SkinName) ?Name : SkinName;
}
