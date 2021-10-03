using Lol.YamlDatabase.Entites.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Lol.YamlDatabase.Entites.Statics
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

        private List<Users>? _users;
        private List<Friends>? _friends;
        internal List<CodeItems>? _codeItems;
        internal List<Spells>? _spells;
        internal List<PlayTypes>? _playTypes;
        internal List<Items>? _items;
        internal List<MapTypes>? _mapTypes;
        internal List<TeamFights>? _teamFights;
        internal List<GameRooms>? _gameRooms;
        internal List<Historys> _historys;

        private static string GetYamlData(string table)
        {
            string file = $"/datas/{table}.yml";
            string path = Environment.CurrentDirectory + file;
            string text = File.ReadAllText(path);

            return text;
        }

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
                    string readText = GetYamlData("spells");

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
                    string readText = GetYamlData("teamfights");

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

        internal List<Historys> Historys
        {
            get
            {
                if (_historys == null)
                {
                    string readText = GetYamlData("historys");
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    _historys = deserializer.Deserialize<List<Historys>>(readText);
                }

                return _historys;
            }
        }
    }
}
