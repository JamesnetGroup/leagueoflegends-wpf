using Jamesnet.Core;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;

namespace Leagueoflegends.Clash.Local.Datas;

public class ScheduleDataLoader : BaseResourceLoader<Schedule, List<Schedule>>, IScheduleDataLoader
{
    protected override string AssemblyName => "Leagueoflegends.Support";
    protected override string ResourcePath => "Leagueoflegends.Support.Datas.Schedules.yml";

    public List<Schedule> LoadSchedules() => LoadAndOrganize();

    protected override IEnumerable<Schedule> ConvertToItems(YamlData rawData)
    {
        return rawData.Select(item => new Schedule
        {
            Title = item.GetValue<string>("title"),
            Day = item.GetValue<int>("day"),
            Timestamp = item.GetValue<DateTime>("timestamp")
        });
    }

    protected override List<Schedule> OrganizeItems(IEnumerable<Schedule> schedules)
    {
        return schedules.ToList();
    }
}
