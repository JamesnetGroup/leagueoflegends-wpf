using Lol.Database.Entites.Core;
using Lol.Database.Entites.Schema;

namespace Lol.Database.Controller
{
    public class GameRoomApi : LolDbContext
    {
        #region GetGameRooms

        public List<GameRooms> GetGameRooms()
        {
            var query = from i in Db.GameRooms
                        select new GameRooms
                        {
                            Seq = i.Seq,
                            MapName = i.MapName,
                            WarType = i.WarType,
                            Content = i.Content,
                            GameTypes = i.GameTypes
                        };
            return query.ToList();
        }
        #endregion

        #region GetGameRoomsCustom

        public List<GameRoomsCustom> GetGameRoomsCustom()
        {
            var query = from i in Db.GameRoomsCustom
                        select new GameRoomsCustom
                        {
                            Seq = i.Seq,
                            MapName = i.MapName

                        };
            return query.ToList();
        }

        #endregion

        #region MyRegion

        public List<LobbyLists> GetLobbyLists()
        {
            var query = from i in Db.LobbyLists
                        select new LobbyLists
                        {
                            Seq = i.Seq,
                            Host = i.Host,
                            Lobby = i.Lobby,
                            Map = i.Map,
                            Spectator = i.Spectator,
                            TotalNumber = i.TotalNumber
                        };
            return query.ToList();
        }
        #endregion
    }
}
