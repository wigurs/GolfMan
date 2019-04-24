using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace GolfMan.Models
{
    public class Tee
    {
        public int TeeID { get; set; }
        public int TeeNo { get; set; }
        public string TeeColor { get; set; }
        public int TeeColorID { get; set; }
        public string TeeName { get; set; }
        public int Length { get; set; }
        public int SlopeValue { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }
        public static bool IsSelected { get; internal set; }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("TeeID: {0}\n", TeeID));
            sb.Append(string.Format("TeeNo: {0}\n", TeeNo));
            sb.Append(string.Format("TeeColor: {0}\n", TeeColor));
            sb.Append(string.Format("TeeColorID: {0}\n", TeeColorID));
            sb.Append(string.Format("TeeName: {0}\n", TeeName));
            sb.Append(string.Format("Length: {0}\n", Length));
            sb.Append(string.Format("SlopeValue: {0}\n", SlopeValue));
            sb.Append(string.Format("Latitude: {0}\n", Latitude));
            sb.Append(string.Format("Longitude: {0}\n", Longitude));
            return base.ToString();
        }
    }

    public class TeeManager
    {
        public static void GetTees(ObservableCollection<Tee> Tees, int optionalint1=0  , int optionalint2=0 )
        {
            var allitems = GetTees();

            var filteredTees = allitems;

            if (optionalint1 != 0 && optionalint2 !=0)
            {
                filteredTees = allitems.Where(p => p.TeeNo == optionalint1 && p.TeeColorID == optionalint2).ToList();
            }

            Tees.Clear();

            foreach (var TeeID in filteredTees) { Tees.Add(TeeID); }
            //           filteredTees.ForEach(p => Tees.Add(p));

        }

        public static List<Tee> GetTees()
        {
            var Items = new List<Tee>
            {
                new Tee() { TeeID = 1, TeeNo = 1, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 252, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 2, TeeNo = 1, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 315, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 3, TeeNo = 1, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 315, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 4, TeeNo = 1, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 359, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 5, TeeNo = 1, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 372, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 6, TeeNo = 2, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 215, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 7, TeeNo = 2, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 220, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 8, TeeNo = 2, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 269, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 9, TeeNo = 2, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 295,SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 10, TeeNo = 2, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 308, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 11, TeeNo = 3, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 363, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 12, TeeNo = 3, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 424, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 13, TeeNo = 3, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 424, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 14, TeeNo = 3, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 476, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 15, TeeNo = 3, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 488, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 16, TeeNo = 4, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 220, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 17, TeeNo = 4, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 290, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 18, TeeNo = 4, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 290, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 19, TeeNo = 4, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 326, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 20, TeeNo = 4, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 350, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 21, TeeNo = 5, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 100, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 22, TeeNo = 5, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 105, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 23, TeeNo = 5, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 115, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 24, TeeNo = 5, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 115, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 25, TeeNo = 5, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 120, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 26, TeeNo = 6, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 224, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 27, TeeNo = 6, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 290, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 28, TeeNo = 6, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 337, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 29, TeeNo = 6, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 337, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 30, TeeNo = 6, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 344, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 31, TeeNo = 7, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 362, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 32, TeeNo = 7, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 414, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 33, TeeNo = 7, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 414, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 34, TeeNo = 7, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 482, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 35, TeeNo = 7, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 492, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 36, TeeNo = 8, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 102, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 37, TeeNo = 8, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 128, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 38, TeeNo = 8, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 147, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 39, TeeNo = 8, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 147, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 40, TeeNo = 8, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 156, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 41, TeeNo = 9, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 240, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 42, TeeNo = 9, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 301, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 43, TeeNo = 9, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 301, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 44, TeeNo = 9, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 359, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 45, TeeNo = 9, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 367, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 46, TeeNo = 10, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 119, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 47, TeeNo = 10, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 127, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 48, TeeNo = 10, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 144, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 49, TeeNo = 10, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 144, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 50, TeeNo = 10, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 170, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 51, TeeNo = 11, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 220, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 52, TeeNo = 11, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 385, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 53, TeeNo = 11, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 385, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 54, TeeNo = 11, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 476, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 55, TeeNo = 11, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 492, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 56, TeeNo = 12, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 80, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 57, TeeNo = 12, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 108, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 58, TeeNo = 12, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 130, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 59, TeeNo = 12, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 145, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 60, TeeNo = 12, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 155, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 61, TeeNo = 13, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 275, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 62, TeeNo = 13, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 332, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 63, TeeNo = 13, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 332, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 64, TeeNo = 13, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 364, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 65, TeeNo = 13, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 379, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 66, TeeNo = 14, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 315, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 67, TeeNo = 14, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 410, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 68, TeeNo = 14, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 410, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 69, TeeNo = 14, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 455, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 70, TeeNo = 14, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 455, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 71, TeeNo = 15, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 242, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 72, TeeNo = 15, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 291, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 73, TeeNo = 15, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 334, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 74, TeeNo = 15, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 334, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 75, TeeNo = 15, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 343, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 76, TeeNo = 16, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 278, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 77, TeeNo = 16, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 327, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 78, TeeNo = 16, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 327, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 79, TeeNo = 16, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 363, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 80, TeeNo = 16, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 380, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 81, TeeNo = 17, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 216, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 82, TeeNo = 17, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 282, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 83, TeeNo = 17, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 312, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 84, TeeNo = 17, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 324, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 85, TeeNo = 17, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 334, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 86, TeeNo = 18, TeeColor = "Orange", TeeColorID = 1, TeeName = "", Length = 245, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 87, TeeNo = 18, TeeColor = "Red", TeeColorID = 2, TeeName = "", Length = 304, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 88, TeeNo = 18, TeeColor = "Blue", TeeColorID = 3, TeeName = "", Length = 346, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 89, TeeNo = 18, TeeColor = "Yellow", TeeColorID = 4, TeeName = "", Length = 346, SlopeValue = 0, Latitude = 0, Longitude = 0 },
                new Tee() { TeeID = 90, TeeNo = 18, TeeColor = "White", TeeColorID = 5, TeeName = "", Length = 374, SlopeValue = 0, Latitude = 0, Longitude = 0 }
            };
            return Items;
        }
    }
}
