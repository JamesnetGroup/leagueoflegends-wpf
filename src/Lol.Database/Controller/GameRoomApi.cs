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

        #region GetLobbyLists

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

        #region GetUserCounts

        public List<UserCounts> GetUserCounts()
        {
            var query = from i in Db.UserCounts
                        select new UserCounts
                        {
                            Seq = i.Seq,
                            UserCount = i.UserCount
                        };
            return query.ToList();
        }
        #endregion


    }
}
