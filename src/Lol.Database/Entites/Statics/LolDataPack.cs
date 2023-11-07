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
        internal List<StoreChampSortings> _storeChampSortings;
        internal List<SettingMenus> _settingMenus;
        internal List<ChampFilter> _champFilter;
        internal List<SkinFilter> _skinFilter;
        internal List<Resolutions> _resolutions;
        internal List<Runes> _runes;
        internal List<RuneDetail> _runeDetail;
        internal List<Loots> _loots;
        internal List<Loots> _lootSummary;
        internal List<LootItemSortings> _lootItemSortings;
        internal List<PlantHeaders> _plantHeaders;
        internal List<PlantItems> _plantItems;
        internal List<StoreItems> _storeChamps;
        internal List<ChampTreeItem> _champTreeItem;
        internal List<Champions> _champions;
        internal List<NewSkins> _newSkins;
        internal List<SkinSets> _skinSets;
        internal List<Popularities> _popularities;
        internal List<PopularityDetails> _popularityDetails;
        internal List<LobbyList> _lobbyList;
        internal List<UserCount> _userCount;
        internal List<StoreItems> _storeSkins;
        internal List<StoreTypes> _storeTypes;
        internal List<StoreDetails> _storeDetails;
        internal List<StoreItems> _storeTFTs;
        internal List<StoreItems> _storeLoots;
        internal List<StoreItems> _storeEtcItems;
        internal List<MyItemInfos> _myItemInfos;
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

                    var deserializer = new DeserializerBuilder ()
                        .WithNamingConvention(new CamelCaseNamingConvention())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _clashTiers = deserializer.Deserialize<List<ClashTiers>>(readText);
                }
                return _clashTiers;
            }
        }
        #endregion

        #region ClashTierDetails

        internal List<ClashTierDetails> ClashTierDetails
        {
            get
            {
                if (_clashTierDetails == null)
                {
                    string readText = GetYamlData("clashTierDetails");

                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _playChampions = deserializer.Deserialize<List<History>>(readText);
                }

                return _playChampions;
            }
        }
        #endregion

        #region StoreChampSortings

        internal List<StoreChampSortings> StoreChampSortings
        {
            get
            {
                if (_storeChampSortings == null)
                {
                    string readText = GetYamlData("storeChampSortings");
                    var deserializer = new DeserializerBuilder()
                      .WithNamingConvention(new CamelCaseNamingConvention ())
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
                      .WithNamingConvention(new CamelCaseNamingConvention ())
                      .Build();
                    _settingMenus = deserializer.Deserialize<List<SettingMenus>>(readText);
                }

                return _settingMenus;
            }
        }
        #endregion

        #region Resolutions

        internal List<Resolutions> Resolutions
        {
            get
            {
                if (_resolutions == null)
                {
                    string readText = GetYamlData("resolutions");
                    var deserializer = new DeserializerBuilder()
                      .WithNamingConvention(new CamelCaseNamingConvention ())
                      .Build();
                    _resolutions = deserializer.Deserialize<List<Resolutions>>(readText);
                }

                return _resolutions;
            }
        }
        #endregion

        #region ChampFilter

        internal List<ChampFilter> ChampFilter
        {
            get
            {
                if (_champFilter == null)
                {
                    string readText = GetYamlData("champFilter");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _champFilter = deserializer.Deserialize<List<ChampFilter>>(readText);
                }

                return _champFilter;
            }
        }
        #endregion

        #region ChampTreeItem

        internal List<ChampTreeItem> ChampTreeItem
        {
            get
            {
                if (_champTreeItem == null)
                {
                    string readText = GetYamlData("champTreeItem");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _champTreeItem = deserializer.Deserialize<List<ChampTreeItem>>(readText);
                }

                return _champTreeItem;
            }
        }
        #endregion

        #region Champions

        internal List<Champions> Champions
        {
            get
            {
                if (_champions == null)
                {
                    string readText = GetYamlData("champions");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _champions = deserializer.Deserialize<List<Champions>>(readText);
                }

                return _champions;
            }
        }
        #endregion

        #region SkinFilter

        internal List<SkinFilter> SkinFilter
        {
            get
            {
                if (_skinFilter == null)
                {
                    string readText = GetYamlData("skinFilter");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _skinFilter = deserializer.Deserialize<List<SkinFilter>>(readText);
                }

                return _skinFilter;
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _loots = deserializer.Deserialize<List<Loots>>(readText);
                }

                return _loots;
            }
        }
        #endregion

        #region LootSummary

        internal List<Loots> LootSummary
        {
            get
            {
                if (_lootSummary == null)
                {
                    string readText = GetYamlData("lootSummary");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _lootSummary = deserializer.Deserialize<List<Loots>>(readText);
                }

                return _lootSummary;
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _plantItems = deserializer.Deserialize<List<PlantItems>>(readText);
                }

                return _plantItems;
            }
        }
        #endregion

        #region StoreChamps

        internal List<StoreItems> StoreChamps
        {
            get
            {
                if (_storeChamps == null)
                {
                    string readText = GetYamlData("storeChamps");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _storeChamps = deserializer.Deserialize<List<StoreItems>>(readText);
                }

                return _storeChamps;
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
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
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _popularityDetails = deserializer.Deserialize<List<PopularityDetails>>(readText);
                }

                return _popularityDetails;
            }
        }

        #endregion

        #region LobbyList

        internal List<LobbyList> LobbyList
        {
            get
            {
                if (_lobbyList == null)
                {
                    string readText = GetYamlData("lobbyList");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _lobbyList = deserializer.Deserialize<List<LobbyList>>(readText);
                }

                return _lobbyList;
            }
        }
        #endregion

        #region UserCounts
        internal List<UserCount> UserCount
        {
            get
            {
                if (_userCount == null)
                {
                    string readText = GetYamlData("userCount");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _userCount = deserializer.Deserialize<List<UserCount>>(readText);
                }

                return _userCount;
            }
        }
        #endregion

        #region StoreTypes

        internal List<StoreTypes> StoreTypes
        {
            get
            {
                if (_storeTypes == null)
                {
                    string readText = GetYamlData("storeTypes");
                    var deserializer = new DeserializerBuilder()
                      .WithNamingConvention(new CamelCaseNamingConvention ())
                      .Build();
                    _storeTypes = deserializer.Deserialize<List<StoreTypes>>(readText);
                }

                return _storeTypes;
            }
        }
        #endregion

        #region StoreSkins

        internal List<StoreItems> StoreSkins
        {
            get
            {
                if (_storeSkins == null)
                {
                    string readText = GetYamlData("storeSkins");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _storeSkins = deserializer.Deserialize<List<StoreItems>>(readText);
                }

                return _storeSkins;
            }
        }
        #endregion

        #region StoreDetails

        internal List<StoreDetails> StoreDetails
        {
            get
            {
                if (_storeDetails == null)
                {
                    string readText = GetYamlData("storeDetails");
                    var deserializer = new DeserializerBuilder()
                      .WithNamingConvention(new CamelCaseNamingConvention ())
                      .Build();
                    _storeDetails = deserializer.Deserialize<List<StoreDetails>>(readText);
                }

                return _storeDetails;
            }
        }
        #endregion

        #region StoreTFTs

        internal List<StoreItems> StoreTFTs
        {
            get
            {
                if (_storeTFTs == null)
                {
                    string readText = GetYamlData("storeTFTs");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _storeTFTs = deserializer.Deserialize<List<StoreItems>>(readText);
                }

                return _storeTFTs;
            }
        }
        #endregion

        #region StoreLoots

        internal List<StoreItems> StoreLoots
        {
            get
            {
                if (_storeLoots == null)
                {
                    string readText = GetYamlData("storeLoots");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _storeLoots = deserializer.Deserialize<List<StoreItems>>(readText);
                }

                return _storeLoots;
            }
        }
        #endregion

        #region StoreEtcItems

        internal List<StoreItems> StoreEtcItems
        {
            get
            {
                if (_storeEtcItems == null)
                {
                    string readText = GetYamlData("storeEtcItems");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _storeEtcItems = deserializer.Deserialize<List<StoreItems>>(readText);
                }

                return _storeEtcItems;
            }
        }
        #endregion

        #region MyItemInfos

        internal List<MyItemInfos> MyItemInfos
        {
            get
            {
                if (_myItemInfos == null)
                {
                    string readText = GetYamlData("myItemInfos");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(new CamelCaseNamingConvention ())
                        .Build();
                    _myItemInfos = deserializer.Deserialize<List<MyItemInfos>>(readText);
                }

                return _myItemInfos;
            }
        }
        #endregion

    }
}
