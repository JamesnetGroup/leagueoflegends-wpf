namespace Lol.Data.Setting.Clients
{
    public class GeneralModel
    {
        public bool LowSpecMode { get; set; } = true;
        public bool ShutClient { get; set; } = true;
        public bool BugAutoReport { get; set; } = true;
        public bool BeginnerGuide { get; set; } = true;
        public string WinSizeValue { get; set; } = "1280 x 720";

        public GeneralModel()
        {
        }
    }
}
