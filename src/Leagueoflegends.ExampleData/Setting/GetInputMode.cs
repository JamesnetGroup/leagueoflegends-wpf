using Leagueoflegends.Data.Codes;
using Leagueoflegends.Data.Enums;
using System.Collections.Generic;

namespace Leagueoflegends.ExampleData.Setting
{
    public partial class ExamSettings
    {
        public static List<VoiceInputModes> GetInputMode()
        {
			List<VoiceInputModes> source = new()
			{
				new VoiceInputModes { Mode = VoiceInputMode.InputStatus, Name = "입력 모드 상태" },
				new VoiceInputModes { Mode = VoiceInputMode.Press, Name = "눌러서 말하기" }
			};

			return source;
        }
    }
}
