using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Support.Local.Datas;

public interface IScheduleDataLoader
{
    List<Schedule> LoadSchedules();
}
