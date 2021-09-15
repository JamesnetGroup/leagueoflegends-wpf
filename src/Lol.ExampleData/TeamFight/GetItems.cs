using Lol.Data.TeamFight;
using System.Collections.Generic;

namespace Lol.ExampleData.TeamFight
{
    public partial class ExamTeamFight
    {
        public static List<TeamFightModel> GetItems()
        {
            string BaseUrl = "/Lol.Resources;component/Images/TFT/";

            List<TeamFightModel> source = new()
            {
                new TeamFightModel { Seq = 0, Name = "비취 황제 도깨비", Level = 1, Explain = "고귀한 초록색 친구와 함께 제국과 은하를 지배하세요. 패스+로 업그레이드하면 즉시 획득할 수 있습니다.", IsPremium = true, MD5 = BaseUrl + "lol-goblin.jpg", IsFree = false },
                new TeamFightModel { Seq = 1, Name = "부탁이야", Level = 2, Explain = "살랑꼬리가 원하는 대로 해 줘도 나쁠 거 없잖아요?", IsPremium = false, MD5 = BaseUrl + "lol-emoji-beg.jpg", IsFree = true },
                new TeamFightModel { Seq = 2, Name = "1성 커튼 콜", Level = 3, Explain = "마지막 한 발로 적을 날려버리세요.", IsPremium = true, MD5 = BaseUrl + "lol-curtaincall.png", IsFree = false },
                new TeamFightModel { Seq = 3, Name = "별 파편 30개", Level = 4, Explain = "별에서 얻은 이 파편으로 꼬마 전설이를 업그레이드하세요!", IsPremium = true, MD5 = BaseUrl + "lol-star-item.jpg", IsFree = false },
                new TeamFightModel { Seq = 4, Name = "작은 영웅 알", Level = 5, Explain = "작은 영웅 꼬마 전설이 아오 신, 배불뚝이, 크릉이 중 하나가 부화할 수 있습니다.", IsPremium = true, MD5 = BaseUrl + "lol-smallegg.png", IsFree = false },
                new TeamFightModel { Seq = 5, Name = "1성 칸메이 폭발", Level = 6, Explain = "영혼의 불꽃으로 적을 날려버리세요.", IsPremium = true, MD5 = BaseUrl + "lol-kanmei.png", IsFree = false },
                new TeamFightModel { Seq = 6, Name = "무작위 감정표현", Level = 7, Explain = "무작위 감정표현으로 기분을 나타내 보세요!", IsPremium = false, MD5 = BaseUrl + "lol-emoji-random.png", IsFree = true },
                new TeamFightModel { Seq = 7, Name = "별 파편 30개", Level = 8, Explain = "별에서 얻은 이 파편으로 꼬마 전설이를 업그레이드하세요!", IsPremium = true, MD5 = BaseUrl + "lol-star-item.jpg", IsFree = false },
                new TeamFightModel { Seq = 8, Name = "2성 커튼 콜", Level = 9, Explain = "마지막 한 발로 적을 날려버리세요. 유닛들이 함께 발사합니다.", IsPremium = true, MD5 = BaseUrl + "lol-curtaincall2.png", IsFree = false },
                new TeamFightModel { Seq = 9, Name = "별 파편 30개", Level = 10, Explain = "별에서 얻은 이 파편으로 꼬마 전설이를 업그레이드하세요!", IsPremium = true, MD5 = BaseUrl + "lol-star-item.jpg", IsFree = false },
                new TeamFightModel { Seq = 10, Name = "1성 행운의 꿀렁이", Level = 11, Explain = "행운과 미소를 가져다주는 황금색 친구입니다. 휘파람을 불면 반응하기도 하죠.", IsPremium = true, MD5 = BaseUrl + "lol-luckypig.png", IsFree = false },
                new TeamFightModel { Seq = 11, Name = "꼬마 전설이 알(1~6탄 중 무작위)", Level = 12, Explain = "무작위 꼬마 전설이 1~6탄 중 하나가 부화할 수 있습니다.", IsPremium = false, MD5 = BaseUrl + "lol-smallegg.png", IsFree = true },
                new TeamFightModel { Seq = 12, Name = "3성 커튼 콜", Level = 13, Explain = "멋진 마지막 한 발로 적을 날려버리세요. 유닛들이 함께 발사합니다.", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 13, Name = "별 파편 30개", Level = 14, Explain = "별에서 얻은 이 파편으로 꼬마 전설이를 업그레이드하세요!", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 14, Name = "2성 칸메이 폭발", Level = 15, Explain = "영혼의 불꽃으로 적을 날려버리세요. 유닛들이 함께 발사합니다.", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 15, Name = "무작위 감정표현", Level = 16, Explain = "무작위 감정표현으로 기분을 나타내 보세요!", IsPremium = false, MD5 = "", IsFree = true },
                new TeamFightModel { Seq = 16, Name = "별 파편 30개", Level = 17, Explain = "별에서 얻은 이 파편으로 꼬마 전설이를 업그레이드하세요!", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 17, Name = "1성 그림자 낙서", Level = 18, Explain = "어두운 물감을 뿌려 적의 품위를 떨어트리세요.", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 18, Name = "별 파편 30개", Level = 19, Explain = "별에서 얻은 이 파편으로 꼬마 전설이를 업그레이드하세요!", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 19, Name = "여정의 시작 결투장", Level = 20, Explain = "출발할 시점을 결정하는 것이 가장 중요할 때도 있습니다.", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 20, Name = "만세", Level = 21, Explain = "멜리스마가 즐거운 비명을 지르고 있습니다.", IsPremium = false, MD5 = "", IsFree = true },
                new TeamFightModel { Seq = 21, Name = "3성 칸메이 폭발", Level = 22, Explain = "영혼의 불꽃으로 적을 날려버리세요. 유닛들이 함께 발사합니다.", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 22, Name = "작은 영웅 알", Level = 23, Explain = "작은 영웅 꼬마 전설이 아오 신, 배불뚝이, 크릉이 중 하나가 부화할 수 있습니다.", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 23, Name = "별 파편 30개", Level = 24, Explain = "별에서 얻은 이 파편으로 꼬마 전설이를 업그레이드하세요!", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 24, Name = "2성 그림자 낙서", Level = 25, Explain = "어두운 물감을 뿌려 적의 품위를 떨어트리세요. 유닛들이 함께 발사합니다.", IsPremium = true, MD5 = "", IsFree = false },
                new TeamFightModel { Seq = 25, Name = "꼬마 전설이 알(1~6탄 중 무작위)", Level = 26, Explain = "무작위 꼬마 전설이 1~6탄 중 하나가 부화할 수 있습니다.", IsPremium = false, MD5 = "", IsFree = true },
            };
            return source;
        }
    }
}
