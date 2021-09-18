using Lol.Data.Collection;
using System.Collections.Generic;

namespace Lol.ExampleData.Collection
{
    public partial class ExamSpell
    {
        static string imgResource(string name)
        {
            return $"/Lol.Resources;component/Images/Spell/{name}.png";
        }

        public static List<SpellModel> GetSpell()
        {
            var source = new List<SpellModel>();

            source.Add(new SpellModel { Name = "유체화", ImageSource = imgResource("haste"), Level = 1, Maps = "무작위 총력전, 클래식, 튜토리얼", Content = "챔피언이 10초 동안 유닛과 충돌하지 않게 되며 챔피언 레벨에 따라 이동 속도가 24~48% 증가합니다. 처치 관여 시 유체화 지속시간이 늘어납니다.", Delay = 210 });
            source.Add(new SpellModel { Name = "회복", ImageSource = imgResource("heal"), Level = 1, Maps = "무작위 총력전, 클래식, 튜토리얼", Content = "챔피언이 10초 동안 유닛과 충돌하지 않게 되며 챔피언 레벨에 따라 이동 속도가 24~48% 증가합니다. 처치 관여 시 유체화 지속시간이 늘어납니다.", Delay = 210 });
            source.Add(new SpellModel { Name = "방어막", ImageSource = imgResource("barrier"), Level = 4, Maps = "무작위 총력전, 클래식, 튜토리얼", Content = "챔피언이 10초 동안 유닛과 충돌하지 않게 되며 챔피언 레벨에 따라 이동 속도가 24~48% 증가합니다. 처치 관여 시 유체화 지속시간이 늘어납니다.", Delay = 210 });
            source.Add(new SpellModel { Name = "탈진", ImageSource = imgResource("exhaust"), Level = 4, Maps = "무작위 총력전, 클래식, 튜토리얼", Content = "챔피언이 10초 동안 유닛과 충돌하지 않게 되며 챔피언 레벨에 따라 이동 속도가 24~48% 증가합니다. 처치 관여 시 유체화 지속시간이 늘어납니다.", Delay = 210 });
            source.Add(new SpellModel { Name = "총명", ImageSource = imgResource("mana"), Level = 6, Maps = "무작위 총력전, 클래식, 튜토리얼", Content = "챔피언이 10초 동안 유닛과 충돌하지 않게 되며 챔피언 레벨에 따라 이동 속도가 24~48% 증가합니다. 처치 관여 시 유체화 지속시간이 늘어납니다.", Delay = 210 });
            source.Add(new SpellModel { Name = "표식", ImageSource = imgResource("snowball"), Level = 6, Maps = "무작위 총력전, 클래식, 튜토리얼", Content = "챔피언이 10초 동안 유닛과 충돌하지 않게 되며 챔피언 레벨에 따라 이동 속도가 24~48% 증가합니다. 처치 관여 시 유체화 지속시간이 늘어납니다.", Delay = 210 });
            source.Add(new SpellModel { Name = "순간이동", ImageSource = imgResource("teleport"), Level = 7, Maps = "무작위 총력전, 클래식, 튜토리얼", Content = "챔피언이 10초 동안 유닛과 충돌하지 않게 되며 챔피언   레벨에 따라 이동 속도가 24~48% 증가합니다. 처치 관여 시 유체화 지속시간이 늘어납니다.", Delay = 210 });
            source.Add(new SpellModel { Name = "점멸", ImageSource = imgResource("flash"), Level = 7 , Maps = "무작위 총력전, 클래식, 튜토리얼", Content = "챔피언이 10초 동안 유닛과 충돌하지 않게 되며 챔피언 레벨에 따라 이동 속도가 24~48% 증가합니다. 처치 관여 시 유체화 지속시간이 늘어납니다.", Delay = 210 });
            source.Add(new SpellModel { Name = "강타", ImageSource = imgResource("smite"), Level = 9 , Maps = "무작위 총력전, 클래식, 튜토리얼", Content = "챔피언이 10초 동안 유닛과 충돌하지 않게 되며 챔피언 레벨에 따라 이동 속도가 24~48% 증가합니다. 처치 관여 시 유체화 지속시간이 늘어납니다.", Delay = 210 });
            source.Add(new SpellModel { Name = "점화", ImageSource = imgResource("dot"), Level = 9   , Maps = "무작위 총력전, 클래식, 튜토리얼", Content = "챔피언이 10초 동안 유닛과 충돌하지 않게 되며 챔피언 레벨에 따라 이동 속도가 24~48% 증가합니다. 처치 관여 시 유체화 지속시간이 늘어납니다.", Delay = 210 });
            source.Add(new SpellModel { Name = "정화", ImageSource = imgResource("boost"), Level = 9, Maps = "무작위 총력전, 클래식, 튜토리얼", Content = "챔피언이 10초 동안 유닛과 충돌하지 않게 되며 챔피언 레벨에 따라 이동 속도가 24~48% 증가합니다. 처치 관여 시 유체화 지속시간이 늘어납니다.", Delay = 210 });

            return source;
        }
    }
}
