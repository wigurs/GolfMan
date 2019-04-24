using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace GolfMan
{
    public class Courses
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int Par1 { get; set; }
        public int Par2 { get; set; }
        public int Par3 { get; set; }
        public int Par4 { get; set; }
        public int Par5 { get; set; }
        public int Par6 { get; set; }
        public int Par7 { get; set; }
        public int Par8 { get; set; }
        public int Par9 { get; set; }
        public int Par10 { get; set; }
        public int Par11 { get; set; }
        public int Par12 { get; set; }
        public int Par13 { get; set; }
        public int Par14 { get; set; }
        public int Par15 { get; set; }
        public int Par16 { get; set; }
        public int Par17 { get; set; }
        public int Par18 { get; set; }
        public int Index1 { get; set; }
        public int Index2 { get; set; }
        public int Index3 { get; set; }
        public int Index4 { get; set; }
        public int Index5 { get; set; }
        public int Index6 { get; set; }
        public int Index7 { get; set; }
        public int Index8 { get; set; }
        public int Index9 { get; set; }
        public int Index10 { get; set; }
        public int Index11 { get; set; }
        public int Index12 { get; set; }
        public int Index13 { get; set; }
        public int Index14 { get; set; }
        public int Index15 { get; set; }
        public int Index16 { get; set; }
        public int Index17 { get; set; }
        public int Index18 { get; set; }
        public static bool IsSelected { get; internal set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("ID: {0}\n", CourseID));
            sb.Append(string.Format("CourseName: {0}\n", CourseName));
            sb.Append(string.Format("Par1: {0}\n", Par1));
            sb.Append(string.Format("Par2: {0}\n", Par2));
            sb.Append(string.Format("Par3: {0}\n", Par3));
            sb.Append(string.Format("Par4: {0}\n", Par4));
            sb.Append(string.Format("Par5: {0}\n", Par5));
            sb.Append(string.Format("Par6: {0}\n", Par6));
            sb.Append(string.Format("Par7: {0}\n", Par7));
            sb.Append(string.Format("Par8: {0}\n", Par8));
            sb.Append(string.Format("Par9: {0}\n", Par9));
            sb.Append(string.Format("Par10: {0}\n", Par10));
            sb.Append(string.Format("Par11: {0}\n", Par11));
            sb.Append(string.Format("Par12: {0}\n", Par12));
            sb.Append(string.Format("Par13: {0}\n", Par13));
            sb.Append(string.Format("Par14: {0}\n", Par14));
            sb.Append(string.Format("Par15: {0}\n", Par15));
            sb.Append(string.Format("Par16: {0}\n", Par16));
            sb.Append(string.Format("Par17: {0}\n", Par17));
            sb.Append(string.Format("Par18: {0}\n", Par18));
            sb.Append(string.Format("Index1: {0}\n", Index1));
            sb.Append(string.Format("Index2: {0}\n", Index2));
            sb.Append(string.Format("Index3: {0}\n", Index3));
            sb.Append(string.Format("Index4: {0}\n", Index4));
            sb.Append(string.Format("Index5: {0}\n", Index5));
            sb.Append(string.Format("Index6: {0}\n", Index6));
            sb.Append(string.Format("Index7: {0}\n", Index7));
            sb.Append(string.Format("Index8: {0}\n", Index8));
            sb.Append(string.Format("Index9: {0}\n", Index9));
            sb.Append(string.Format("Index10: {0}\n", Index10));
            sb.Append(string.Format("Index11: {0}\n", Index11));
            sb.Append(string.Format("Index12: {0}\n", Index12));
            sb.Append(string.Format("Index13: {0}\n", Index13));
            sb.Append(string.Format("Index14: {0}\n", Index14));
            sb.Append(string.Format("Index15: {0}\n", Index15));
            sb.Append(string.Format("Index16: {0}\n", Index16));
            sb.Append(string.Format("Index17: {0}\n", Index17));
            sb.Append(string.Format("Index18: {0}\n", Index18));

            return base.ToString();
        }
    }

    public class CourseManager
    {
        public static void GetCourses(ObservableCollection<Courses> Courses,int optionalint = 0)
        {
            var allitems = GetCourses();

            var filteredCourses = allitems;

            if (optionalint != 0)
            {
                filteredCourses = allitems.Where(p => p.CourseID == optionalint).ToList();
            }

            Courses.Clear();

            foreach (var CourseName in filteredCourses) { Courses.Add(CourseName); }
            //            fiteredCourses.ForEach(p => Courses.Add(p));
        }

        private static List<Courses> GetCourses()
        {
            var items = new List<Courses>
            {
                new Courses() { CourseID = 1, CourseName = "Tranås Golfklubb", Par1 = 4, Par2 = 4, Par3 = 5, Par4 = 4, Par5 = 3, Par6 = 4, Par7 = 5, Par8 = 3, Par9 = 4, Par10 = 3, Par11 = 5, Par12 = 3, Par13 = 4, Par14 = 5, Par15 = 4, Par16 = 4, Par17 = 4, Par18 = 4, Index1 = 5, Index2 = 13, Index3 = 1, Index4 = 11, Index5 = 17, Index6 = 7, Index7 = 9, Index8 = 15, Index9 = 3, Index10 = 16, Index11 = 8, Index12 = 18, Index13 = 2, Index14 = 10, Index15 = 12, Index16 = 4, Index17 = 14, Index18 = 6 }
            };
            return items;
        }
    }
}
