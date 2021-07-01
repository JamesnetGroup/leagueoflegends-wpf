using Leagueoflegends.Data.TeamFight;
using Leagueoflegends.Foundation.Mvvm;
using System.Collections.Generic;
using System.Linq;

namespace Leagueoflegends.TeamFight.Local.ViewModel
{
	public class TeamFightViewModel : ObservableObject
    {
        #region TeamFightItem

        private List<TeamFightModel> _teamFightItem;
        public List<TeamFightModel> TeamFightItem
        {
            get { return _teamFightItem; }
            set { _teamFightItem = value; OnPropertyChanged(); }
        }

        private TeamFightModel _currentTeamFightItem;
        public TeamFightModel CurrentTeamFightItem
        {
            get { return _currentTeamFightItem; }
            set { _currentTeamFightItem = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public TeamFightViewModel()
        {
            TeamFightItem = InitItems();
            CurrentTeamFightItem = TeamFightItem.First();
        }

        #endregion

        #region InitItems

        private List<TeamFightModel> InitItems()
        {
            List<TeamFightModel> source = new List<TeamFightModel>
            {
                new TeamFightModel { Seq = 0, Name = "비취 황제 도깨비", Level = 1, Explain = "고귀한 초록색 친구와 함께 제국과 은하를 지배하세요. 패스+로 업그레이드하면 즉시 획득할 수 있습니다.", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 1, Name = "부탁이야", Level = 2, Explain = "살랑꼬리가 원하는 대로 해 줘도 나쁠 거 없잖아요?", IsPremium = false, MD5 = "", IsFree = true },
                new TeamFightModel { Seq = 2, Name = "1성 커튼 콜", Level = 3, Explain = "마지막 한 발로 적을 날려버리세요.", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 3, Name = "별 파편 30개", Level = 4, Explain = "별에서 얻은 이 파편으로 꼬마 전설이를 업그레이드하세요!", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 4, Name = "작은 영웅 알", Level = 5, Explain = "작은 영웅 꼬마 전설이 아오 신, 배불뚝이, 크릉이 중 하나가 부화할 수 있습니다.", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 5, Name = "1성 칸메이 폭발", Level = 6, Explain = "영혼의 불꽃으로 적을 날려버리세요.", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 6, Name = "무작위 감정표현", Level = 7, Explain = "무작위 감정표현으로 기분을 나타내 보세요!", IsPremium = false, MD5 = "", IsFree = true },
                new TeamFightModel { Seq = 7, Name = "별 파편 30개", Level = 8, Explain = "별에서 얻은 이 파편으로 꼬마 전설이를 업그레이드하세요!", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 8, Name = "2성 커튼 콜", Level = 9, Explain = "마지막 한 발로 적을 날려버리세요. 유닛들이 함께 발사합니다.", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 9, Name = "별 파편 30개", Level = 10, Explain = "별에서 얻은 이 파편으로 꼬마 전설이를 업그레이드하세요!", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 10, Name = "1성 행운의 꿀렁이", Level = 11, Explain = "행운과 미소를 가져다주는 황금색 친구입니다. 휘파람을 불면 반응하기도 하죠.", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 11, Name = "꼬마 전설이 알(1~6탄 중 무작위)", Level = 12, Explain = "무작위 꼬마 전설이 1~6탄 중 하나가 부화할 수 있습니다.", IsPremium = false, MD5 = "", IsFree = true }
            };
            return source;
        }
        #endregion
    }
}
