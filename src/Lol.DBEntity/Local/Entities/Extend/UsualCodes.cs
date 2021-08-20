using Lol.DBEntity.Local.Entities.Schema;

namespace Lol.DBEntity.Local.Entities.Extend
{
    public class UsualCodes : CodeItems
    {
        public UsualCodes(CodeItems codes)
        {
            Id = codes.Id;
            ItemName = codes.ItemName;
            ItemValue = codes.ItemValue;
        }
    }
}
