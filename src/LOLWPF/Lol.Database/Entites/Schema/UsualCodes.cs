namespace Lol.Database.Entites.Schema
{
    public class UsualCodes : CodeItems
    {
        public UsualCodes(CodeItems codes)
        {
            Id = codes.Id;
            ItemName = codes.ItemName;
            ItemValue = codes.ItemValue;

            // Deep Copy
        }
    }
}
