using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;


namespace GolfMan
{
    public class Player : MvvmHelpers.ObservableObject
    {
        int playerid;
        public int PlayerID
        {
            get { return playerid; }
            set
            {
                SetProperty(ref playerid, value);
            }
        }

        string golfid;
        public string GolfID
        {
            get { return golfid; }
            set
            {
                if (SetProperty(ref golfid, value))
                {
                    //Do something
                }
                else
                {
                    //Do something else
                }
            }
        }

        string golflub;
        public string GolfClub
        {
            get { return golflub; }
            set
            {
                SetProperty(ref golflub, value);
            }
        }


        string firstname;
        public string FirstName
        {
            get { return firstname; }
            set
            {
                SetProperty(ref firstname, value);
            }
        }

        string lastname;
        public string LastName
        {
            get { return lastname; }
            set
            {
                SetProperty(ref lastname, value);
            }
        }

        string fullName;
        public string FullName
        {
            get { return fullName; }
            set
            {
                SetProperty(ref fullName, value);
            }
        }

        string hcp;
        public string  Hcp
        {
            get { return hcp; }
            set
            {
                SetProperty(ref hcp, value);
            }
        }

        byte gender;
        public byte Gender
        {
            get { return gender; }
            set
            {
                SetProperty(ref gender, value);
            }
        }
    }

    public class PlayerManager
    {
//        private const string XMLFile = "playerdata.xml";
//        private const string JSONFILE = "data.json";

//        public static string XMLFILE { get; private set; }

        public static void GetPlayers(ObservableCollection<Player> Players, string optionalstr = "")
        {
            var allitems = GetPlayers();

            var filteredPlayers = allitems;

            if (optionalstr != "")
            {
                filteredPlayers = allitems.Where(p => p.GolfID == optionalstr || p.FullName == optionalstr).ToList();
            }
            Players.Clear();

            foreach (var FullName in filteredPlayers) { Players.Add(FullName); }
//            filteredmyPlayers.ForEach(p => myPlayers.Add(p));
        }
/*
        internal static void GetPlayers(ObservableCollection<Player> players)
        {
            throw new NotImplementedException();
        }
*/
        private static List<Player> GetPlayers()
        {
            var items = new List<Player>
            {
                new Player() { PlayerID = 0, GolfID = "xxxxxx-xx1", GolfClub = "? GK", FirstName = "?", LastName = "?", FullName = "Unknown 1", Hcp = "0", Gender = 0 },
                new Player() { PlayerID = 1, GolfID = "xxxxxx-xx2", GolfClub = "? GK", FirstName = "?", LastName = "?", FullName = "Unknown 2", Hcp = "0", Gender = 1 },
                new Player() { PlayerID = 2, GolfID = "xxxxxx-xx3", GolfClub = "? GK", FirstName = "?", LastName = "?", FullName = "Unknown 3", Hcp = "0", Gender = 0 },
                new Player() { PlayerID = 3, GolfID = "xxxxxx-xx4", GolfClub = "? GK", FirstName = "?", LastName = "?", FullName = "Unknown 4", Hcp = "0", Gender = 1 },
                new Player() { PlayerID = 4, GolfID = "390903-008", GolfClub = "Tranås GK", FirstName = "Jan", LastName = "Wigur", FullName = "Jan Wigur", Hcp = "100", Gender = 0 },
                new Player() { PlayerID = 5, GolfID = "431026-014", GolfClub = "Tranås GK", FirstName = "Lars-Åke", LastName = "Nilsson", FullName = "Lars-Åke Nilsson", Hcp = "353", Gender = 0 },
                new Player() { PlayerID = 6, GolfID = "320904-004", GolfClub = "Tranås GK", FirstName = "Sten", LastName = "Nilsson", FullName = "Sten Nilsson", Hcp = "272", Gender = 0 },
                new Player() { PlayerID = 7, GolfID = "320207-004", GolfClub = "Tranås GK", FirstName = "Kerstin", LastName = "Nilsson", FullName = "Kerstin Nilsson", Hcp = "348", Gender = 1 },
                new Player() { PlayerID = 8, GolfID = "371002-008", GolfClub = "Tranås GK", FirstName = "Bo", LastName = "Sundström", FullName = "Bo Sundström", Hcp = "304", Gender = 0 },
                new Player() { PlayerID = 9, GolfID = "371008-009", GolfClub = "Tranås GK", FirstName = "Stig", LastName = "Emmertz", FullName = "Stig Emmertz", Hcp = "191", Gender = 0 }
            };
            return items;
        }

        /*
    private static async Task PlayerwriteXMLAsync()
     {
         var myPlayers = GetPlayers();

         var serializer = new System.Runtime.Serialization.DataContractSerializer(typeof(List<Player>));
         using (var stream = await ApplicationData.Current.LocalFolder.CreateFileAsync{ XMLFILE, CreationCollisionOption.ReplaceExisting};

         {
             serializer.WriteObject(stream, myPlayers);
         }
//            ResultTextBlock.Text = "Write succeeded";
     }

             private static async Task PlayerreadXMLAsync()
             {
                 string content = string.Empty;

                 var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(XMLFILE);
                 using (StreamReader reader = new StreamReader(myStream))
                 {
                     content = await reader.ReadToEndAsync();
                 }
     //            ResultTextBlock.Text = content;
             }

             public static async Task PlayerwritejsonAsync()
             {
                 var myPlayers = GetPlayers();

                 var serializer = new DataContractJsonSerializer(typeof(List<Player>));
                 using (var stream = await ApplicationData.Current.LocalFolder.OpenStreamForWriteAsync(XMLFILE, CreationCollisionOption.ReplaceExisting))
                 {
                     serializer.WriteObject(stream, myPlayers);
                 }
     //            ResultTextBlock.Text = "Write succeeded";
             }

             private static async Task PlayerReadJsonAsync()
             {
                 string content = string.Empty;

                 var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(XMLFILE);
                 using (StreamReader reader = new StreamReader(myStream))
                 {
                     content = await reader.ReadToEndAsync();
                 }
     //            ResultTextBlock.Text = content;
             }

             private static async Task PlayerdeserializeJsonAsync()
             {
                 string content = string.Empty;

                 List<Player> myPlayers;
                 var jsonSerializer = new DataContractJsonSerializer(typeof(List<Player>));

                 var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(JSONFILE);

                 myPlayers = (List<Player>)jsonSerializer.ReadObject(myStream);

                 foreach (var player in myPlayers)
                 {
                     content += String.Format("PlayerID: {0},GolfID: {1},GolfClub: {2},FirstName: {3},LastName: {4},FullName: {5},Hcp: {6},Gender: {7}",
                         player.PlayerID, player.GolfClub, player.FirstName, player.LastName, player.FullName, player.Hcp, player.Gender);
                 }
     //            ResultTextBlock.Text = content;
             }
     */
    }
}



