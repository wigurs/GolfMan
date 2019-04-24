using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace GolfMan
{
    public class Slope
    {
        public int SlopeID { get; set; }
        public Decimal CourseRating { get; set; }
        public int SlopeValue { get; set; }
        public Byte Gender { get; set; }
        public string TeeColor { get; set; }
        public string TeeAlias { get; set; }
        public int TeeColorID { get; set; }

        public static bool IsSelected { get; internal set; }

    }


    public class SlopeManager
    {
        public static void GetSlopes(ObservableCollection<Slope> Slopes, int optionalint = 0)
        {
            var allitems = GetSlopes();

            var filteredSlopes = allitems;

            if (optionalint != 0)
            {
                filteredSlopes = allitems.Where(p => p.SlopeID == optionalint).ToList();
            }

            Slopes.Clear();

            foreach (var SlopeID in filteredSlopes) { Slopes.Add(SlopeID); }
            //           filteredmySlopes.ForEach(p => Slopes.Add(p));

        }

        private static List<Slope> GetSlopes()
        {
            var Items = new List<Slope>
            {

                //Gender Ladies = 0
                //Gender Men    = 1
                // Course Rating Value = Decimal ( Value 722 = 72,2)
                new Slope() { SlopeID = 1, CourseRating = 0, Gender = 1, SlopeValue = 0, TeeColor = "White", TeeAlias = "", TeeColorID = 5 },
                new Slope() { SlopeID = 2, CourseRating = 740, Gender = 0, SlopeValue = 136, TeeColor = "White", TeeAlias = "", TeeColorID = 5 },

                new Slope() { SlopeID = 3, CourseRating = 789, Gender = 1, SlopeValue = 139, TeeColor = "Yellow", TeeAlias = "", TeeColorID = 4 },
                new Slope() { SlopeID = 4, CourseRating = 729, Gender = 0, SlopeValue = 133, TeeColor = "Yellow", TeeAlias = "", TeeColorID = 4 },

                new Slope() { SlopeID = 5, CourseRating = 758, Gender = 1, SlopeValue = 132, TeeColor = "Blue", TeeAlias = "", TeeColorID = 3 },
                new Slope() { SlopeID = 6, CourseRating = 703, Gender = 0, SlopeValue = 129, TeeColor = "Blue", TeeAlias = "", TeeColorID = 3 },

                new Slope() { SlopeID = 7, CourseRating = 741, Gender = 1, SlopeValue = 128, TeeColor = "Red", TeeAlias = "", TeeColorID = 2 },
                new Slope() { SlopeID = 8, CourseRating = 689, Gender = 0, SlopeValue = 126, TeeColor = "Red", TeeAlias = "", TeeColorID = 2 },

                new Slope() { SlopeID = 9, CourseRating = 720, Gender = 1, SlopeValue = 113, TeeColor = "Orange", TeeAlias = "", TeeColorID = 1 },
                new Slope() { SlopeID = 10, CourseRating = 720, Gender = 0, SlopeValue = 113, TeeColor = "Orange", TeeAlias = "", TeeColorID = 1 },

                new Slope() { SlopeID = 11, CourseRating = 720, Gender = 1, SlopeValue = 113, TeeColor = "General", TeeAlias = "", TeeColorID = 0 },
                new Slope() { SlopeID = 12, CourseRating = 720, Gender = 0, SlopeValue = 113, TeeColor = "General", TeeAlias = "", TeeColorID = 0 }
            };
            return Items;
        }
    }
}

