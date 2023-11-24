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

        #region GetLobbyList

        public List<LobbyList> GetLobbyList()
        {
            var query = from i in Db.LobbyList
                        select new LobbyList
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

        #region GetUserCount

        public List<UserCount> GetUserCount()
        {
            var query = from i in Db.UserCount
                        select new UserCount
                        {
                            Seq = i.Seq,
                            Count = i.Count
                        };
            return query.ToList();
        }
        #endregion
    }
}
