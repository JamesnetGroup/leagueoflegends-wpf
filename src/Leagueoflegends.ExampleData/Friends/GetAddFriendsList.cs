using Leagueoflegends.Data.Main;
using Leagueoflegends.ExampleData.Local;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Leagueoflegends.ExampleData.Friends
{
	public partial class ExamFriends
    {
        public static List<AddUserModel> GetAddFriendsList()
        {
            var friends = new List<AddUserModel>
            {
                new AddUserModel("Tony Stark"),
                new AddUserModel("Thor"),
                new AddUserModel("Steave Rogers"),
                new AddUserModel("Groot"),
                new AddUserModel("Drax"),
                new AddUserModel("Loki"),
                new AddUserModel("Mantis"),
                new AddUserModel("Wanda Maximoff"),
                new AddUserModel("Nebula"),
                new AddUserModel("Peter Quill"),
                new AddUserModel("Pepper Potts"),
                new AddUserModel("Peter Parker"),
                new AddUserModel("James Rhodes"),
                new AddUserModel("Scott Lang"),
                new AddUserModel("Rocket"),
                new AddUserModel("Natasha Romanoff"),
                new AddUserModel("Doctor Strange"),
                new AddUserModel("T'Challa"),
                new AddUserModel("Thanos"),
                new AddUserModel("Hope van Dyne"),
                new AddUserModel("Sharon Carter"),
                new AddUserModel("Phil Coulson"),
                new AddUserModel("Peggy Carter"),
                new AddUserModel("Jane Foster"),
                new AddUserModel("Yondu Udonta"),
                new AddUserModel("Brock Rumlow"),
                new AddUserModel("Grandmaster"),
                new AddUserModel("Heimdall"),
                new AddUserModel("Happy Hogan"),
                new AddUserModel("Alexander Pierce"),
                new AddUserModel("Hank Pym"),
                new AddUserModel("Flash Thompson"),
            };

			RandomHelper.Shuffle(friends);
            return friends.Take(15).ToList();
        }
    }
}
