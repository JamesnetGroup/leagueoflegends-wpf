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
            source.Add(new SpellModel { Name = "회복", ImageSource = imgResource("heal"), Level = 1, Maps = "무작위 총력전, 클래식, 튜토리얼", Content = "자신과 대상 아군 챔피언의 체력을 90~345만큼 (챔피언 레벨에 따라 변동) 회복시키고 1초 동안 이동 속도가 30% 증가합니다. 최근 소환사 주문 회복의 영향을 받은 유닛의 경우 치유량이 절반만 적용됩니다.", Delay = 240 });
            source.Add(new SpellModel { Name = "방어막", ImageSource = imgResource("barrier"), Level = 4, Maps = "무작위 총력전, 클래식", Content = "2초 동안 방어막으로 감싸 피해를 115~455(챔피언 레벨에 따라 변동)만큼 흡수합니다.", Delay = 180 });
            source.Add(new SpellModel { Name = "탈진", ImageSource = imgResource("exhaust"), Level = 4, Maps = "무작위 총력전, 클래식", Content = "적 챔피언을 지치게 만들어 3초 동안 이동 속도를 30% 느리게 하고 이 동안 가하는 피해량을 40% 낮춥니다.", Delay = 210 });
            source.Add(new SpellModel { Name = "총명", ImageSource = imgResource("mana"), Level = 6, Maps = "무작위 총력전", Content = "최대 마나량의 50%를 회복합니다. 주변 아군도 최대 마나량의 25%가 회복됩니다.", Delay = 240 });
            source.Add(new SpellModel { Name = "표식", ImageSource = imgResource("snowball"), Level = 6, Maps = "무작위 총력전", Content = "적을 향해 직선으로 눈덩이를 던집니다. 눈덩이가 적을 맞히면 표식이 남아 절대 시야가 생기고, 표식이 붙은 대상을 향해 챔피언이 빠르게 이동할 수 있습니다.", Delay = 80 });
            source.Add(new SpellModel { Name = "순간이동", ImageSource = imgResource("teleport"), Level = 7, Maps = "클래식", Content = "4초 동안 정신을 집중한 다음, 챔피언이 지정한 아군 구조물, 미니언, 혹은 와드로 순간이동하고 이동 속도가 증가합니다. 순간이동의 재사용 대기시간은 챔피언 레벨에 따라 420~210초입니다.", Delay = 210 });
            source.Add(new SpellModel { Name = "점멸", ImageSource = imgResource("flash"), Level = 7 , Maps = "무작위 총력전, 클래식", Content = "커서 방향으로 챔피언이 짧은 거리를 순간이동합니다.", Delay = 300 });
            source.Add(new SpellModel { Name = "강타", ImageSource = imgResource("smite"), Level = 9 , Maps = "클래식", Content = "대상 에픽 및 대형/중형 몬스터 또는 미니언에게 강타의 고정피해를 입힙니다.", Delay = 15 });
            source.Add(new SpellModel { Name = "점화", ImageSource = imgResource("dot"), Level = 9   , Maps = "무작위 총력전, 클래식", Content = "적 챔피언을 불태워 5초 동안 70~410의 고정 피해(챔피언 레벨에 따라 변동)을 입히고 모습을 드러내며 치료 호과를 감소시킵니다.", Delay = 180 });
            source.Add(new SpellModel { Name = "정화", ImageSource = imgResource("boost"), Level = 9, Maps = "무작위 총력전, 클래식", Content = "챔피언에 걸린 모든 이동 불가와 (제압 및 공중으로 띄우는 효과제외) 소환사 주문에 의한 해로운 효과를 제거하고 새로 적용되는 이동 불가 효과들의 지속시간을 3초간 65% 감소시킵니다.", Delay = 210 });

            return source;
        }
    }
}
