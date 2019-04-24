using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System;


namespace GolfMan
{
    public class Score: MvvmHelpers.ObservableObject
    {
//        ScoreView scoreview = new ScoreView();
        int scoreid;
        public int ScoreID
        {
            get { return scoreid; }
            set { SetProperty(ref scoreid, value); }
        }

        int sgfcompetitionid;
        public int SGFCompetitionID
        {
            get { return sgfcompetitionid; }
            set { SetProperty(ref sgfcompetitionid, value); }
        }

        int golfplayerid;
        public int GolfPlayerID
        {
            get { return golfplayerid; }
            set { SetProperty(ref golfplayerid, value); }
        }

        int markergolfid;
        public int MarkerGolfID
        {
            get { return markergolfid; }
            set { SetProperty(ref markergolfid, value); }
        }
/*
        int score1;
        public int Score1
        {
            get { return score1; }
            set
            {
                if (SetProperty(ref score1, value))
                {
                    OnPropertyChanged(nameof(Score1));
                    Debug.WriteLine("Scores.score1 = " + score1);
                }
            }
        }
*/
        int score1;
        public int Score1
        {
            get { return score1; }
            set { SetProperty(ref score1, value); }
        }



        int score2;
        public int Score2
        {
            get { return score2; }
            set { SetProperty(ref score2, value); }
        }

        int score3;
        public int Score3
        {
            get { return score3; }
            set { SetProperty(ref score3, value); }
        }

        int score4;
        public int Score4
        {
            get { return score4; }
            set { SetProperty(ref score4, value); }
        }

        int score5;
        public int Score5
        {
            get { return score5; }
            set { SetProperty(ref score5, value); }
        }

        int score6;
        public int Score6
        {
            get { return score6; }
            set { SetProperty(ref score6, value); }
        }

        int score7;
        public int Score7
        {
            get { return score7; }
            set { SetProperty(ref score7, value); }
        }

        int score8;
        public int Score8
        {
            get { return score8; }
            set { SetProperty(ref score8, value); }
        }

        int score9;
        public int Score9
        {
            get { return score9; }
            set { SetProperty(ref score9, value); }
        }

        int score10;
        public int Score10
        {
            get { return score10; }
            set { SetProperty(ref score10, value); }
        }

        int score11;
        public int Score11
        {
            get { return score11; }
            set { SetProperty(ref score11, value); }
        }

        int score12;
        public int Score12
        {
            get { return score12; }
            set { SetProperty(ref score12, value); }
        }

        int score13;
        public int Score13
        {
            get { return score13; }
            set { SetProperty(ref score13, value); }
        }

        int score14;
        public int Score14
        {
            get { return score14; }
            set { SetProperty(ref score14, value); }
        }

        int score15;
        public int Score15
        {
            get { return score15; }
            set { SetProperty(ref score15, value); }
        }

        int score16;
        public int Score16
        {
            get { return score16; }
            set { SetProperty(ref score16, value); }
        }

        int score17;
        public int Score17
        {
            get { return score17; }
            set { SetProperty(ref score17, value); }
        }

        int score18;
        public int Score18
        {
            get { return score18; }
            set { SetProperty(ref score18, value); }
        }

        int scorein;
        public int ScoreIn
        {
            get { return scorein; }
            set { SetProperty(ref scorein, value); }

        }

        int scoreout;
        public int ScoreOut
        {
            get { return scoreout; }
            set { SetProperty(ref scoreout, value); }
        }

        int scoretot;
        public int ScoreTot;
//        internal Score score1;
//        internal int Score1;

        public int TotalValue
        {
            get { return scoretot; }
            set { scoretot = scoreout + scorein; }
        }

        public int Index { get; internal set; }

        //        public Score score1 { get; internal set; }

        public static implicit operator ObservableCollection<object>(Score v)
        {
            if (v == null)
            {
                throw new ArgumentNullException(nameof(v));
            }

            throw new NotImplementedException();
        }
    }

    public class ScoreManager
    {
//        const string XMLFILE = "scoredata.xml";
//        const string JSONFILE = "scoredata.json";
        //            private string InfoTextBlock;


        public static void GetScores(ObservableCollection<Score> Scores, int optionalint = 0)
        {

            var allitems = GetScores();

            var filteredScores = allitems;

            if (optionalint != 0)
            {
                filteredScores = allitems.Where(p => p.GolfPlayerID == optionalint).ToList();
            }
            Scores.Clear();

            foreach (var ScoreID in filteredScores) { Scores.Add(ScoreID); }
            //                filteredScores.ForEach(p => Scores.Add(p));
        }


        public static List<Score> GetScores()
        {
            var items = new List<Score>
        {
            new Score() { ScoreID = 1, SGFCompetitionID = 0, GolfPlayerID = 1, MarkerGolfID = 0, Score1 = 0, Score2 = 0, Score3 = 0, Score4 = 0, Score5 = 0, Score6 = 0, Score7 = 0, Score8 = 0, Score9 = 0, Score10 = 0, Score11 = 0, Score12 = 0, Score13 = 0, Score14 = 0, Score15 = 0, Score16 = 0, Score17 = 0, Score18 = 0, ScoreIn = 0, ScoreOut = 0, TotalValue = 0 },
            new Score() { ScoreID = 2, SGFCompetitionID = 0, GolfPlayerID = 2, MarkerGolfID = 0, Score1 = 0, Score2 = 0, Score3 = 0, Score4 = 0, Score5 = 0, Score6 = 0, Score7 = 0, Score8 = 0, Score9 = 0, Score10 = 0, Score11 = 0, Score12 = 0, Score13 = 0, Score14 = 0, Score15 = 0, Score16 = 0, Score17 = 0, Score18 = 0, ScoreIn = 0, ScoreOut = 0, TotalValue = 0 },
            new Score() { ScoreID = 3, SGFCompetitionID = 0, GolfPlayerID = 3, MarkerGolfID = 0, Score1 = 0, Score2 = 0, Score3 = 0, Score4 = 0, Score5 = 0, Score6 = 0, Score7 = 0, Score8 = 0, Score9 = 0, Score10 = 0, Score11 = 0, Score12 = 0, Score13 = 0, Score14 = 0, Score15 = 0, Score16 = 0, Score17 = 0, Score18 = 0, ScoreIn = 0, ScoreOut = 0, TotalValue = 0 },
            new Score() { ScoreID = 4, SGFCompetitionID = 0, GolfPlayerID = 4, MarkerGolfID = 0, Score1 = 0, Score2 = 0, Score3 = 0, Score4 = 0, Score5 = 0, Score6 = 0, Score7 = 0, Score8 = 0, Score9 = 0, Score10 = 0, Score11 = 0, Score12 = 0, Score13 = 0, Score14 = 0, Score15 = 0, Score16 = 0, Score17 = 0, Score18 = 0, ScoreIn = 0, ScoreOut = 0, TotalValue = 0 }
        };
            return items;
        }
    }
}





