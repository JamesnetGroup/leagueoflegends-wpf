namespace Lol.Data.Setting.InGame
{
    public class GamePlay
    {
        public bool AutoAttack { get; set; } = true;
        public bool ForeseeMove { get; set; } = true;
        public bool TowerIntersection { get; set; } = true;
        public bool MoveToCursorLocation { get; set; } = true;
    }

    public class GameModel
    {
        public bool DX9LegacyMode { get; set; } = true;
        public bool SoftwareMouse { get; set; } = true;
        public int MouseMoveSpeed { get; set; } = 100;
        public int CamMoveSpeedMouse { get; set; } = 100;
        public int CamMoveSpeedKeyBoard { get; set; } = 100;
        public bool RevivalCamera { get; set; } = false;
        public bool CameraRevision { get; set; } = false;
        public bool DragScroll { get; set; } = true;
        public string CamLockMode { get; set; } = "Fixed Offset";
        public GamePlay GamePlay { get; set; } = new GamePlay();

        public GameModel()
        {
        }
    }
}
