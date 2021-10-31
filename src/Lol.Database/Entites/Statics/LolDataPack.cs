using Lol.Database.Entites.Schema;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Lol.Database.Entites.Statics
{
    public class LolDataPack
    {
        internal static LolDataPack Instance;

        static LolDataPack()
        {
            Instance = new LolDataPack();
        }

        private LolDataPack()
        {

        }

        #region Variables

        private List<Users> _users;
        private List<Friends> _friends;
        internal List<CodeItems> _codeItems;
        internal List<Spells> _spells;
        internal List<PlayTypes> _playTypes;
        internal List<Items> _items;
        internal List<MapTypes> _mapTypes;
        internal List<TeamFights> _teamFights;
        internal List<GameRooms> _gameRooms;
        internal List<GameRoomsCustom> _gameRoomsCustom;
        internal List<ClashCups> _clashCups;
        internal List<History> _historys;
        internal List<History> _activities;
        internal List<History> _playChampions;
        internal List<ClashTabs> _clashTabs;
        internal List<ClashTiers> _clashTiers;
        internal List<ClashTierDetails> _clashTierDetails;
        internal List<ClashSchedules> _clashSchedules;
        internal List<StoreChampTypes> _storeChampTypes;
        internal List<StoreChampSortings> _storeChampSortings;
        internal List<SettingMenus> _settingMenus;
        internal List<Champs> _champs;
        internal List<ChampCb> _champCb;
        internal List<Resolutions> _resolutions;
        internal List<Runes> _runes;
        internal List<RuneDetail> _runeDetail;
        internal List<Loots> _loots;
        internal List<Loots> _lootItems;
        internal List<LootItemSortings> _lootItemSortings;
        internal List<PlantHeaders> _plantHeaders;
        internal List<PlantItems> _plantItems;
        internal List<StoreChamps> _storeChamps;
        internal List<ChampHeaders> _champHeaders;
        internal List<ChampItems> _champItems;
        internal List<NewSkins> _newSkins;
        internal List<SkinSets> _skinSets;
        internal List<Popularities> _popularities;
        internal List<PopularityDetails> _popularityDetails;
        internal List<LobbyLists> _lobbyLists;
        #endregion

        #region GetYamlData

        private static string GetYamlData(string table)
        {
            string file = $"/datas/{table}.yml";
            string path = Environment.CurrentDirectory + file;
            string text = File.ReadAllText(path);

            return text;
        }
        #endregion

        #region Users

        internal List<Users> Users
        {
            get
            {
                if (_users == null)
                {
                    string readText = GetYamlData("users");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _users = deserializer.Deserialize<List<Users>>(readText);
                }
                return _users;
            }
        }
        #endregion

        #region Friends

        internal List<Friends> Friends
        {
            get
            {
                if (_friends == null)
                {
                    string readText = GetYamlData("friends");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _friends = deserializer.Deserialize<List<Friends>>(readText);
                }
                return _friends;
            }
        }
        #endregion

        #region CodeItems

        internal List<CodeItems> CodeItems
        {
            get
            {
                if (_codeItems == null)
                {
                    string readText = GetYamlData("codeitems");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _codeItems = deserializer.Deserialize<List<CodeItems>>(readText);
                }
                return _codeItems;
            }
        }
        #endregion

        #region Spells

        internal List<Spells> Spells
        {
            get
            {
                if (_spells == null)
                {
                    string readText = GetYamlData("spells-en");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _spells = deserializer.Deserialize<List<Spells>>(readText);
                }
                return _spells;
            }
        }
        #endregion

        #region Items

        internal List<Items> Items
        {
            get
            {
                if (_items == null)
                {
                    string readText = GetYamlData("items");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _items = deserializer.Deserialize<List<Items>>(readText);
                }
                return _items;
            }
        }
        #endregion

        #region MapTypes

        internal List<MapTypes> MapTypes
        {
            get
            {
                if (_mapTypes == null)
                {
                    string readText = GetYamlData("mapTypes");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _mapTypes = deserializer.Deserialize<List<MapTypes>>(readText);
                }
                return _mapTypes;
            }
        }
        #endregion

        #region PlayTypes

        internal List<PlayTypes> PlayTypes
        {
            get
            {
                if (_playTypes == null)
                {
                    string readText = GetYamlData("playTypes");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _playTypes = deserializer.Deserialize<List<PlayTypes>>(readText);
                }
                return _playTypes;
            }
        }
        #endregion

        #region TeamFights

        internal List<TeamFights> TeamFights
        {
            get
            {
                if (_teamFights == null)
                {
                    string readText = GetYamlData("teamFights");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _teamFights = deserializer.Deserialize<List<TeamFights>>(readText);
                }
                return _teamFights;
            }
        }
        #endregion

        #region GameRooms

        internal List<GameRooms> GameRooms
        {
            get
            {
                if (_gameRooms == null)
                {
                    string readText = GetYamlData("gameRooms");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _gameRooms = deserializer.Deserialize<List<GameRooms>>(readText);
                }
                return _gameRooms;
            }
        }
        #endregion

        #region GameRoomsCustom

        internal List<GameRoomsCustom> GameRoomsCustom
        {
            get
            {
                if (_gameRoomsCustom == null)
                {
                    string readText = GetYamlData("gameRoomsCustom");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _gameRoomsCustom = deserializer.Deserialize<List<GameRoomsCustom>>(readText);
                }
                return _gameRoomsCustom;
            }
        }
        #endregion

        #region ClashCups

        internal List<ClashCups> ClashCups
        {
            get
            {
                if (_clashCups == null)
                {
                    string readText = GetYamlData("clashCups");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _clashCups = deserializer.Deserialize<List<ClashCups>>(readText);
                }
                return _clashCups;
            }
        }
        #endregion

        #region ClashTabs

        internal List<ClashTabs> ClashTabs
        {
            get
            {
                if (_clashTabs == null)
                {
                    string readText = GetYamlData("clashTabs");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _clashTabs = deserializer.Deserialize<List<ClashTabs>>(readText);
                }
                return _clashTabs;
            }
        }
        #endregion

        #region ClashTiers

        internal List<ClashTiers> ClashTiers
        {
            get
            {
                if (_clashTiers == null)
                {
                    string readText = GetYamlData("clashTiers");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _clashTiers = deserializer.Deserialize<List<ClashTiers>>(readText);
                }
                return _clashTiers;
            }
        }
        #endregion

        #region ClashTabs

        internal List<ClashTierDetails> ClashTierDetails
        {
            get
            {
                if (_clashTierDetails == null)
                {
                    string readText = GetYamlData("clashTierDetails");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _clashTierDetails = deserializer.Deserialize<List<ClashTierDetails>>(readText);
                }
                return _clashTierDetails;
            }
        }
        #endregion

        #region Historys

        internal List<History> History
        {
            get
            {
                if (_historys == null)
                {
                    string readText = GetYamlData("histories");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _historys = deserializer.Deserialize<List<History>>(readText);
                }

                return _historys;
            }
        }
        #endregion

        #region Activities

        internal List<History> Activities
        {
            get
            {
                if (_activities == null)
                {
                    string readText = GetYamlData("activities");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _activities = deserializer.Deserialize<List<History>>(readText);
                }

                return _activities;
            }
        }
        #endregion

        #region PlayChampions

        internal List<History> PlayChampions
        {
            get
            {
                if (_playChampions == null)
                {
                    string readText = GetYamlData("playChampions");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _playChampions = deserializer.Deserialize<List<History>>(readText);
                }

                return _playChampions;
            }
        }
        #endregion

        #region StoreChampTypes

        internal List<StoreChampTypes> StoreChampTypes
        {
            get
            {
                if (_storeChampTypes == null)
                {
                    string readText = GetYamlData("storeChampTypes");
                    var deserializer = new DeserializerBuilder()
                      .WithNamingConvention(CamelCaseNamingConvention.Instance)
                      .Build();
                    _storeChampTypes = deserializer.Deserialize<List<StoreChampTypes>>(readText);
                }

                return _storeChampTypes;
            }
        }
        #endregion

        #region StoreChampTypes

        internal List<StoreChampSortings> StoreChampSortings
        {
            get
            {
                if (_storeChampSortings == null)
                {
                    string readText = GetYamlData("storeChampSortings");
                    var deserializer = new DeserializerBuilder()
                      .WithNamingConvention(CamelCaseNamingConvention.Instance)
                      .Build();
                    _storeChampSortings = deserializer.Deserialize<List<StoreChampSortings>>(readText);
                }

                return _storeChampSortings;
            }
        }
        #endregion

        #region SettingMenus

        internal List<SettingMenus> SettingMenus
        {
            get
            {
                if (_settingMenus == null)
                {
                    string readText = GetYamlData("settingMenus");
                    var deserializer = new DeserializerBuilder()
                      .WithNamingConvention(CamelCaseNamingConvention.Instance)
                      .Build();
                    _settingMenus = deserializer.Deserialize<List<SettingMenus>>(readText);
                }

                return _settingMenus;
            }
        }
        #endregion

        #region SettingMenus

        internal List<Resolutions> Resolutions
        {
            get
            {
                if (_resolutions == null)
                {
                    string readText = GetYamlData("resolutions");
                    var deserializer = new DeserializerBuilder()
                      .WithNamingConvention(CamelCaseNamingConvention.Instance)
                      .Build();
                    _resolutions = deserializer.Deserialize<List<Resolutions>>(readText);
                }

                return _resolutions;
            }
        }
        #endregion

        #region Champs

        internal List<Champs> Champs
        {
            get
            {
                if (_champs == null)
                {
                    string readText = GetYamlData("champs");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _champs = deserializer.Deserialize<List<Champs>>(readText);
                }

                return _champs;
            }
        }
        #endregion

        #region ChampCb

        internal List<ChampCb> ChampCb
        {
            get
            {
                if (_champCb == null)
                {
                    string readText = GetYamlData("champCb");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _champCb = deserializer.Deserialize<List<ChampCb>>(readText);
                }

                return _champCb;
            }
        }
        #endregion

        #region ClashSchedules

        internal List<ClashSchedules> ClashSchedules
        {
            get
            {
                if (_clashSchedules == null)
                {
                    string readText = GetYamlData("clashSchedules");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _clashSchedules = deserializer.Deserialize<List<ClashSchedules>>(readText);
                }

                return _clashSchedules;
            }
        }
        #endregion

        #region Runes

        internal List<Runes> Runes
        {
            get
            {
                if (_runes == null)
                {
                    string readText = GetYamlData("runes");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _runes = deserializer.Deserialize<List<Runes>>(readText);
                }

                return _runes;
            }
        }
        #endregion

        #region RuneDetail

        internal List<RuneDetail> RuneDetail
        {
            get
            {
                if (_runeDetail == null)
                {
                    string readText = GetYamlData("runeDetail");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _runeDetail = deserializer.Deserialize<List<RuneDetail>>(readText);
                }

                return _runeDetail;
            }
        }
        #endregion

        #region Loots

        internal List<Loots> Loots
        {
            get
            {
                if (_loots == null)
                {
                    string readText = GetYamlData("loots");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _loots = deserializer.Deserialize<List<Loots>>(readText);
                }

                return _loots;
            }
        }
        #endregion

        #region LootItems

        internal List<Loots> LootItems
        {
            get
            {
                if (_lootItems == null)
                {
                    string readText = GetYamlData("lootItems");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _lootItems = deserializer.Deserialize<List<Loots>>(readText);
                }

                return _lootItems;
            }
        }
        #endregion

        #region LootItemSortings

        internal List<LootItemSortings> LootItemSortings
        {
            get
            {
                if (_lootItemSortings == null)
                {
                    string readText = GetYamlData("lootItemSortings");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _lootItemSortings = deserializer.Deserialize<List<LootItemSortings>>(readText);
                }

                return _lootItemSortings;
            }
        }
        #endregion

        #region PlantHeaders

        internal List<PlantHeaders> PlantHeaders
        {
            get
            {
                if (_plantHeaders == null)
                {
                    string readText = GetYamlData("plantHeaders");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _plantHeaders = deserializer.Deserialize<List<PlantHeaders>>(readText);
                }

                return _plantHeaders;
            }
        }
        #endregion

        #region PlantItems

        internal List<PlantItems> PlantItems
        {
            get
            {
                if (_plantItems == null)
                {
                    string readText = GetYamlData("plantItems");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _plantItems = deserializer.Deserialize<List<PlantItems>>(readText);
                }

                return _plantItems;
            }
        }
        #endregion

        #region StoreChamps

        internal List<StoreChamps> StoreChamps
        {
            get
            {
                if (_storeChamps == null)
                {
                    string readText = GetYamlData("storeChamps");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _storeChamps = deserializer.Deserialize<List<StoreChamps>>(readText);
                }

                return _storeChamps;
            }
        }
        #endregion

        #region ChampHeaders

        internal List<ChampHeaders> ChampHeaders
        {
            get
            {
                if (_champHeaders == null)
                {
                    string readText = GetYamlData("champHeaders");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _champHeaders = deserializer.Deserialize<List<ChampHeaders>>(readText);
                }

                return _champHeaders;
            }
        }
        #endregion

        #region ChampItems

        internal List<ChampItems> ChampItems
        {
            get
            {
                if (_champItems == null)
                {
                    string readText = GetYamlData("champItems");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _champItems = deserializer.Deserialize<List<ChampItems>>(readText);
                }

                return _champItems;
            }
        }

        #endregion

        #region NewSkins

        internal List<NewSkins> NewSkins
        {
            get
            {
                if (_newSkins == null)
                {
                    string readText = GetYamlData("newSkins");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _newSkins = deserializer.Deserialize<List<NewSkins>>(readText);
                }

                return _newSkins;
            }
        }

        #endregion

        #region NewSkins

        internal List<SkinSets> SkinSets
        {
            get
            {
                if (_skinSets == null)
                {
                    string readText = GetYamlData("skinSets");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _skinSets = deserializer.Deserialize<List<SkinSets>>(readText);
                }

                return _skinSets;
            }
        }

        #endregion

        #region Popularities

        internal List<Popularities> Popularities
        {
            get
            {
                if (_popularities == null)
                {
                    string readText = GetYamlData("popularities");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _popularities = deserializer.Deserialize<List<Popularities>>(readText);
                }

                return _popularities;
            }
        }

        #endregion

        #region PopularityDetails

        internal List<PopularityDetails> PopularityDetails
        {
            get
            {
                if (_popularityDetails == null)
                {
                    string readText = GetYamlData("popularityDetails");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _popularityDetails = deserializer.Deserialize<List<PopularityDetails>>(readText);
                }

                return _popularityDetails;
            }
        }

        #endregion

        #region LobbyLists

        internal List<LobbyLists> LobbyLists
        {
            get
            {
                if (_lobbyLists == null)
                {
                    string readText = GetYamlData("lobbyLists");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _lobbyLists = deserializer.Deserialize<List<LobbyLists>>(readText);
                }

                return _lobbyLists;
            }
        }
        #endregion
    }
}
