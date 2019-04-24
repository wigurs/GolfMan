using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmHelpers;
using GolfMan.Models;
using Xamarin.Forms;
using GolfMan.ViewModels;
//using System.Drawing;

namespace GolfMan
{
    public class ScoreViewModel : MvvmHelpers.BaseViewModel
    {
        public readonly ObservableCollection<Courses> Courses;
        private readonly ObservableCollection<Tee> TeeID;
        private readonly ObservableCollection<Player> Players;
        private readonly ObservableCollection<Slope> Slopes;

        public ScoreViewModel()
        {
            Title = "ScoreCard";

            Scores = new ObservableRangeCollection<Score>();
            //            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));

            Scores.CollectionChanged += (sender, args) =>
            {
                Debug.WriteLine($"Item {args.Action}");
            };
            GetScoresCommand = new Xamarin.Forms.Command(async () => await GetScoresAsync());

            BirdieCLickedCommand = new Xamarin.Forms.Command(BirdieClicked);
            ParClickedCommand = new Xamarin.Forms.Command(ParClicked);
            BogeyClickedCommand = new Xamarin.Forms.Command(BogeyClicked);
            SubmitClickedCommand = new Xamarin.Forms.Command(SubmitClicked);
            IncreaseCountCommand = new Xamarin.Forms.Command(IncreaseCount);
            PlusClickedCommand = new Command(PlusClicked);
            MinusClickedCommand = new Command(MinusClicked);
            HoleNoClickedCommand = new Command(HoleNoClicked);

            WhiteClickedCommand = new Command(WhiteClicked);
            YellowClickedCommand = new Command(YellowClicked);
            BlueClickedCommand = new Command(BlueClicked);
            RedClickedCommand = new Command(RedClicked);
            OrangeClickedCommand = new Command(OrangeClicked);

            Courses = new ObservableCollection<Courses>();
            CourseManager.GetCourses(Courses, 1);
            TeeID = new ObservableCollection<Tee>();
            TeeManager.GetTees(TeeID);
            Players = new ObservableCollection<Player>();
            PlayerManager.GetPlayers(Players);
            Slopes = new ObservableCollection<Slope>();
            SlopeManager.GetSlopes(Slopes);
            Scores = new ObservableRangeCollection<Score>();
            ScoreManager.GetScores(Scores, 1);

            BindigContext = this;
            //            BindigContext = new ScoreViewModel();


            InitPlayerData();
        }
        public ObservableRangeCollection<Score> Score { get; private set; }
        public ICommand GetScoresCommand { get; }

        public int Slope = 0;
        public int PlayHcp = 0;
        public int NoOfHoles = 18;
        private int holeno;
        public int LoopPar;
        readonly bool Course = true;


        private static readonly int[] hHCP = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static readonly int[] chHCP = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static readonly int[] hPOINT = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        private static readonly int[] PAR = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static readonly int[] INDEX = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static readonly string[] DISPLAY = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        private static readonly int[] SCORE = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        int count; int count1=0;

        public async Task GetScoresAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                await Task.Delay(4000);

                //Load new data

                IsBusy = false;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void InitPlayerData()
        {
            INDEX[0] = Courses[0].Index1; INDEX[1] = Courses[0].Index2; INDEX[2] = Courses[0].Index3; INDEX[3] = Courses[0].Index4; INDEX[4] = Courses[0].Index5; INDEX[5] = Courses[0].Index6; INDEX[6] = Courses[0].Index7; INDEX[7] = Courses[0].Index8; INDEX[8] = Courses[0].Index9;
            INDEX[9] = Courses[0].Index10; INDEX[10] = Courses[0].Index11; INDEX[11] = Courses[0].Index12; INDEX[12] = Courses[0].Index13; INDEX[13] = Courses[0].Index14; INDEX[14] = Courses[0].Index15; INDEX[15] = Courses[0].Index16; INDEX[16] = Courses[0].Index17; INDEX[17] = Courses[0].Index18;

            PAR[0] = Courses[0].Par1; PAR[1] = Courses[0].Par2; PAR[2] = Courses[0].Par3; PAR[3] = Courses[0].Par4; PAR[4] = Courses[0].Par5; PAR[5] = Courses[0].Par6; PAR[6] = Courses[0].Par7; PAR[7] = Courses[0].Par8; PAR[8] = Courses[0].Par9;
            PAR[9] = Courses[0].Par10; PAR[10] = Courses[0].Par11; PAR[11] = Courses[0].Par12; PAR[12] = Courses[0].Par13; PAR[13] = Courses[0].Par14; PAR[14] = Courses[0].Par15; PAR[15] = Courses[0].Par16; PAR[16] = Courses[0].Par17; PAR[17] = Courses[0].Par18;

            SCORE[0] = Scores[0].Score1; SCORE[1] = Scores[0].Score2; SCORE[2] = Scores[0].Score3; SCORE[3] = Scores[0].Score4; SCORE[4] = Scores[0].Score5; SCORE[5] = Scores[0].Score6; SCORE[6] = Scores[0].Score7; SCORE[7] = Scores[0].Score8; SCORE[8] = Scores[0].Score9;
            SCORE[9] = Scores[0].Score10; SCORE[10] = Scores[0].Score11; SCORE[11] = Scores[0].Score12; SCORE[12] = Scores[0].Score13; SCORE[13] = Scores[0].Score14; SCORE[14] = Scores[0].Score15; SCORE[15] = Scores[0].Score16; SCORE[16] = Scores[0].Score17; SCORE[17] = Scores[0].Score18;

            DISPLAY[0] = ScoreDisplay1; DISPLAY[1] = ScoreDisplay2; DISPLAY[2] = ScoreDisplay3; DISPLAY[3] = ScoreDisplay4; DISPLAY[4] = ScoreDisplay5; DISPLAY[5] = ScoreDisplay6; DISPLAY[6] = ScoreDisplay7; DISPLAY[7] = ScoreDisplay8; DISPLAY[8] = ScoreDisplay9;
            DISPLAY[9] = ScoreDisplay10; DISPLAY[10] = ScoreDisplay11; DISPLAY[11] = ScoreDisplay12; DISPLAY[12] = ScoreDisplay13; DISPLAY[13] = ScoreDisplay14; DISPLAY[14] = ScoreDisplay15; DISPLAY[15] = ScoreDisplay16; DISPLAY[16] = ScoreDisplay17; DISPLAY[17] = ScoreDisplay18;
//            DISPLAY[18] = ScoreNettoDisplay; DISPLAY[19] = PointsDisplay;
        }

        string scoreDisplay = "You clicked 0 times.";               //ScoreDisplay
        public string ScoreDisplay
        {
            get { return scoreDisplay; }
            set { scoreDisplay = value; OnPropertyChanged(); }
        }

        string countDisplay = "You clicked 0 times.";               //CountDisplay
        public string CountDisplay
        {
            get { return countDisplay; }
            set { countDisplay = value; OnPropertyChanged(); }
        }

        public ICommand IncreaseCountCommand { get; }               //IncreasedCountCommand
        void IncreaseCount() =>
            CountDisplay = $"You clicked {++count} times";

        public ICommand PlusClickedCommand { get; }                 //HOLE + Command
        void PlusClicked()
        {
            //            ButtonCount = 0;
            if (holeno < 18) HoleNoDisplay = $"{ ++holeno }";
        }

        public ICommand MinusClickedCommand { get; }                //HOLE - Command
        void MinusClicked()
        {
            ButtonCount = 0;
            if (holeno > 0) HoleNoDisplay = $"{ --holeno }";
        }

        public ICommand ParClickedCommand { get; }                  //PAR Command
        void ParClicked()
        {
            if (holeno > 0)
            {
                int i = holeno - 1;

                SCORE[i] = PAR[i]; OnPropertyChanged();
                DISPLAY[i] = $" {SCORE[i]}"; OnPropertyChanged();
                ParDisplay = $" Par\n   {SCORE[i] }";
                chHCP[i] = hHCP[i];

                BirdieDisplay = $"Birdie "; BogeyDisplay = $"Bogey "; ButtonCount = 0;
                UpdateSummeries();
            }
        }
        public ICommand BirdieCLickedCommand { get; }               //BIRDIE Command
        void BirdieClicked()
        {
            if (holeno > 0)
            {
                int i = holeno - 1;
                if (SCORE[i] < 2 || SCORE[i] >= PAR[i])
                {   //BIRDIE
                    SCORE[i] = PAR[i] - 1; BirdieDisplay = $" Birdie  -\n      {SCORE[i] }"; OnPropertyChanged(); chHCP[i] = hHCP[i] + 1;
                }
                else if (SCORE[i] == 4 && PAR[i] == 5 || SCORE[i] == 3 && PAR[i] == 4)
                {   //EAGLE
                    SCORE[i]--; BirdieDisplay = $" Eagle -\n      {SCORE[i]}"; OnPropertyChanged(); chHCP[i] = hHCP[i] + 2;
                }
                else if (SCORE[i] == 3 && PAR[i] == 5)
                {   //ALBATROS
                    SCORE[i]--; BirdieDisplay = $"Albatros -\n       {SCORE[i]}"; OnPropertyChanged(); chHCP[i] = hHCP[i] + 3;
                }
                else if (SCORE[i] == 2)
                {   //HIO
                    SCORE[i]--; BirdieDisplay = $" HIO \n    {SCORE[i]}"; chHCP[i] = hHCP[i] + 4;
                }
                else if (SCORE[i] == 1)
                {
                    BirdieDisplay = $" Birdie"; SCORE[i] = 0; OnPropertyChanged();
                }
                if (SCORE[i] > 0)
                {
                    hPOINT[i] = SCORE[i] - PAR[i] + 2; }
                else
                {
                    hPOINT[i] = 0;
                }

                DISPLAY[i] = $" {SCORE[i]}"; OnPropertyChanged(); OnPropertyChanged();
                ParDisplay = $"Par { PAR[i]}"; BogeyDisplay = $"Bogey "; OnPropertyChanged();
                UpdateSummeries();
            }
        }

        public ICommand BogeyClickedCommand { get; }                //BOGEYCommand
        void BogeyClicked()
        {
            if (holeno > 0)
            {
                int i = holeno - 1;
                if (SCORE[i] < PAR[i] + 1)  //If Bogey
                {
                    SCORE[i] = PAR[i] + 1;
                    chHCP[i] = hHCP[i] - 1;
                }
                else
                {
                    SCORE[i]++; OnPropertyChanged();
                    chHCP[i]--;
                }


                DISPLAY[i] = $" {SCORE[i]}"; OnPropertyChanged();;
                BogeyDisplay = $" Bogey +\n      {SCORE[i] }"; OnPropertyChanged();
                BirdieDisplay = $"Birdie "; ParDisplay = $"Par { PAR[i]}"; OnPropertyChanged();
                UpdateSummeries();
            }
        }

        public ICommand WhiteClickedCommand { get; }                //WHITE Command
        void WhiteClicked()
        {
            TeeManager.GetTees(TeeID, holeno, 5);
            WhiteDisplay = $"{TeeID[0].Length } m";
            if (Players[0].Gender == 0) { SlopeManager.GetSlopes(Slopes, 2); } else { SlopeManager.GetSlopes(Slopes, 1); }
            GetCalculatedSlope();
        }

        public ICommand YellowClickedCommand { get; }               //YELLOW Command
        void YellowClicked()
        {
            TeeManager.GetTees(TeeID, holeno, 4);
            YellowDisplay = $"{TeeID[0].Length } m";
            if (Players[0].Gender == 0) { SlopeManager.GetSlopes(Slopes, 4); } else { SlopeManager.GetSlopes(Slopes, 3); }
            GetCalculatedSlope();
        }

        public ICommand BlueClickedCommand { get; }                 //BLUE Command
        void BlueClicked()
        {
            TeeManager.GetTees(TeeID, holeno, 3);
            BlueDisplay = $"{TeeID[0].Length } m";
            if (Players[0].Gender == 0) { SlopeManager.GetSlopes(Slopes, 6); } else { SlopeManager.GetSlopes(Slopes, 5); }
            GetCalculatedSlope();
        }

        public ICommand RedClickedCommand { get; }                  //RED Command
        void RedClicked()
        {
            TeeManager.GetTees(TeeID, holeno, 2);
            RedDisplay = $"{TeeID[0].Length } m";
            if (Players[0].Gender == 0) { SlopeManager.GetSlopes(Slopes, 8); } else { SlopeManager.GetSlopes(Slopes, 7); }
            GetCalculatedSlope();
        }

        public ICommand OrangeClickedCommand { get; }               //ORANGE Command
        void OrangeClicked()
        {
            TeeManager.GetTees(TeeID, holeno, 1);
            OrangeDisplay = $"{TeeID[0].Length } m";
            if (Players[0].Gender == 0) { SlopeManager.GetSlopes(Slopes, 10); } else { SlopeManager.GetSlopes(Slopes, 9); }
            GetCalculatedSlope();
        }

        public ICommand SubmitClickedCommand { get; }               //SUBMIT Command
        void SubmitClicked()
        {
        }

        int ButtonCount;
        public ICommand HoleNoClickedCommand { get; }
        void HoleNoClicked()                                        //HOLE CLICKED
        {
            //Reset Current Score

            if (ButtonCount < 1)
            {
                ButtonCount++;
                HoleNoDisplay = "RESET";
            }
            else
            {
                if (HoleNoDisplay == "RESET")
                    DISPLAY[18] = ScoreNettoDisplay; DISPLAY[19] = PointsDisplay;
                {
                    for (int i = 0; i <= NoOfHoles +2; i++)
                    {
                        if (NoOfHoles <18) { SCORE[i] = 0;}
                        DISPLAY[i] = "0";
                    }
                    ButtonCount = 0;
                    UpdateSummeries();
                }
            }
        }

        string holeNoDisplay = "0";                                 //HOLE CHANGED
        public string HoleNoDisplay
        {
            get { return holeNoDisplay; }
            set
            {
                holeNoDisplay = value; OnPropertyChanged();
                if (holeno > 0)
                {
                    int i = holeno - 1;

                    //Reset ScoreData Names
                    BirdieDisplay = "Birdie"; BogeyDisplay = "Bogey";

                    //Select Player
                    PlayerManager.GetPlayers(Players, "Jan Wigur");
                    //and Tee
                    YellowClicked();

                    // Didsplay Player Data
                    PlayerNameDisplay = $"{Players[0].FullName}";
                    PlayerHcpDisplay = $"Hcp {Convert.ToDecimal(Players[0].Hcp) / 10}";
               PlayerGolfIDDisplay = $"ID { Players[0].GolfID}";
     
                    if (Course == false) { BirdieDisplay = "Par 3"; ParDisplay = "Par 4"; BogeyDisplay = "Par 5"; }

                    BirdieDisplay = $"Birdie "; ParDisplay = $"Par"; BogeyDisplay = $"Bogey ";// WhiteDisplay = "0"; WhiteDisplay = "0"; YellowDisplay = "0"; BlueDisplay = "0"; RedDisplay = "0"; OrangeDisplay = "0";

                    if( hHCP[i] > 0) { ParDisplay = $" Par/Index \n    " + PAR[i] + "+" + hHCP[i] + " /" + INDEX[i]; } else { ParDisplay = $" Par/Index \n     " + PAR[i] +" /" + INDEX[i]; }

                    ScoreOutDisplay = $" { Scores[0].Score1 + Scores[0].Score2 + Scores[0].Score3 + Scores[0].Score4 + Scores[0].Score5 + Scores[0].Score6 + Scores[0].Score7 + Scores[0].Score8 + Scores[0].Score9}";
                    ScoreInDisplay = $" { Scores[0].Score10 + Scores[0].Score11 + Scores[0].Score12 + Scores[0].Score13 + Scores[0].Score14 + Scores[0].Score15 + Scores[0].Score16 + Scores[0].Score17 + Scores[0].Score18}";
                    ScoreBruttoDisplay = $" { Scores[0].ScoreIn + Scores[0].ScoreOut }";
                }
                else        //HoleNo = 0 = SETTINGS
                {

                }
            }
        }

        string scoreDisplay1 = "0";                                 //SCORE 1 DISPLAY CHANGED
        public string ScoreDisplay1
        {
            get { return scoreDisplay1; }
            set { scoreDisplay1 = value; scoreOutDisplay = value; OnPropertyChanged();}
        }

        string scoreDisplay2 = "0";
        public string ScoreDisplay2
        {
            get { return scoreDisplay2; }
            set { scoreDisplay2 = value; scoreOutDisplay = value; OnPropertyChanged(); }
        }

        string scoreDisplay3 = "0";
        public string ScoreDisplay3
        {
            get { return scoreDisplay3; }
            set { scoreDisplay3 = value; scoreOutDisplay = value; OnPropertyChanged(); }
        }

        string scoreDisplay4 = "0";
        public string ScoreDisplay4
        {
            get { return scoreDisplay4; }
            set { scoreDisplay4 = value; scoreOutDisplay = value; OnPropertyChanged(); }
        }

        string scoreDisplay5 = "0";
        public string ScoreDisplay5
        {
            get { return scoreDisplay5; }
            set { scoreDisplay5 = value; scoreOutDisplay = value; OnPropertyChanged(); }
        }

        string scoreDisplay6 = "0";
        public string ScoreDisplay6
        {
            get { return scoreDisplay6; }
            set { scoreDisplay6 = value; scoreOutDisplay = value; OnPropertyChanged(); }
        }

        string scoreDisplay7 = "0";
        public string ScoreDisplay7
        {
            get { return scoreDisplay7; }
            set { scoreDisplay7 = value; scoreOutDisplay = value; OnPropertyChanged(); }
        }

        string scoreDisplay8 = "0";
        public string ScoreDisplay8
        {
            get { return scoreDisplay8; }
            set { scoreDisplay8 = value; scoreOutDisplay = value; OnPropertyChanged(); }
        }

        string scoreDisplay9 = "0";
        public string ScoreDisplay9
        {
            get { return scoreDisplay9; }
            set { scoreDisplay9 = value; scoreOutDisplay = value; OnPropertyChanged(); }
        }

        string scoreDisplay10 = "0";
        public string ScoreDisplay10
        {
            get { return scoreDisplay10; }
            set { scoreDisplay10 = value; scoreInDisplay = value; OnPropertyChanged(); }
        }

        string scoreDisplay11 = "0";
        public string ScoreDisplay11
        {
            get { return scoreDisplay11; }
            set { scoreDisplay11 = value; scoreInDisplay = value; OnPropertyChanged(); }
        }

        string scoreDisplay12 = "0";
        public string ScoreDisplay12
        {
            get { return scoreDisplay12; }
            set { scoreDisplay12 = value; scoreInDisplay = value; OnPropertyChanged(); }
        }

        string scoreDisplay13 = "0";
        public string ScoreDisplay13
        {
            get { return scoreDisplay13; }
            set { scoreDisplay13 = value; scoreInDisplay = value; OnPropertyChanged(); }
        }

        string scoreDisplay14 = "0";
        public string ScoreDisplay14
        {
            get { return scoreDisplay14; }
            set { scoreDisplay14 = value; scoreInDisplay = value; OnPropertyChanged(); }
        }

        string scoreDisplay15 = "0";
        public string ScoreDisplay15
        {
            get { return scoreDisplay15; }
            set { scoreDisplay15 = value; scoreInDisplay = value; OnPropertyChanged(); }
        }

        string scoreDisplay16 = "0";
        public string ScoreDisplay16
        {
            get { return scoreDisplay16; }
            set { scoreDisplay16 = value; scoreInDisplay = value; OnPropertyChanged(); }
        }

        string scoreDisplay17 = "0";
        public string ScoreDisplay17
        {
            get { return scoreDisplay17; }
            set { scoreDisplay17 = value; scoreInDisplay = value; OnPropertyChanged(); }
        }

        string scoreDisplay18 = "0";                                    //Score 18 DISPLAY CHANGED
        public string ScoreDisplay18
        {
            get { return scoreDisplay18; }
            set { scoreDisplay18 = value; scoreInDisplay = value; OnPropertyChanged(); }
        }

        string scoreInDisplay = "0";                                    //SCORE IN DISPLAY CHANGED
        public string ScoreInDisplay
        {
            get { return scoreInDisplay; }
            set { scoreInDisplay = value; OnPropertyChanged(); }
        }

        string scoreBruttoDisplay = "0";                                //SCORE BRUTTO DISPLAY CHANGED
        public string ScoreBruttoDisplay
        {
            get { return scoreBruttoDisplay; }
            set { scoreBruttoDisplay = value; OnPropertyChanged(); }
        }

        string scoreOutDisplay = "0";                                   //SCORE OUT DISPLAY CHANGED
        public string ScoreOutDisplay
        {
            get { return scoreOutDisplay; }
            set { scoreOutDisplay = value; OnPropertyChanged(); }
        }

        string scoreNettoDisplay = "0";                                 //SCORE NETTO DISPLAY CHANGED
        public string ScoreNettoDisplay
        {
            get { return scoreNettoDisplay; }
            set { scoreNettoDisplay = value; OnPropertyChanged(); }
        }

        string scoreHcpDisplay = "0";                                   //HCP DISPLAY CHANGED
        public string ScoreHcpDisplay
        {   get { return scoreHcpDisplay; }
            set { scoreHcpDisplay = value; OnPropertyChanged();}
        }

        string pointsDisplay = "0";                                      //POINTS DISPLAY CHANGED
        public string PointsDisplay
        {
            get { return pointsDisplay; }
            set { pointsDisplay = value; OnPropertyChanged(); }
        }

        string coursePar1Display = "0";                                  //PAR 1 DISPLAY CHANGED
        public string CoursePar1Display
        {
            get { return coursePar1Display; }
            set { coursePar1Display = value; OnPropertyChanged(); }
        }

        string coursePar2Display = "0";
        public string CoursePar2Display
        {
            get { return coursePar2Display; }
            set { coursePar2Display = value; OnPropertyChanged(); }
        }

        string coursePar3Display = "0";
        public string CoursePar3Display
        {
            get { return coursePar3Display; }
            set { coursePar3Display = value; OnPropertyChanged(); }
        }

        string coursePar4Display = "0";
        public string CoursePar4Display
        {
            get { return coursePar4Display; }
            set { coursePar4Display = value; OnPropertyChanged(); }
        }

        string coursePar5Display = "0";
        public string CoursePar5Display
        {
            get { return coursePar5Display; }
            set { coursePar5Display = value; OnPropertyChanged(); }
        }

        string coursePar6Display = "0";
        public string CoursePar6Display
        {
            get { return coursePar6Display; }
            set { coursePar6Display = value; OnPropertyChanged(); }
        }

        string coursePar7Display = "0";
        public string CoursePar7Display
        {
            get { return coursePar7Display; }
            set { coursePar7Display = value; OnPropertyChanged(); }
        }

        string coursePar8Display = "0";
        public string CoursePar8Display
        {
            get { return coursePar8Display; }
            set { coursePar8Display = value; OnPropertyChanged(); }
        }

        string coursePar9Display = "0";
        public string CoursePar9Display
        {
            get { return coursePar9Display; }
            set { coursePar9Display = value; OnPropertyChanged(); }
        }

        string coursePar10Display = "0";
        public string CoursePar10Display
        {
            get { return coursePar10Display; }
            set { coursePar10Display = value; OnPropertyChanged(); }
        }

        string coursePar11Display = "0";
        public string CoursePar11Display
        {
            get { return coursePar11Display; }
            set { coursePar11Display = value; OnPropertyChanged(); }
        }

        string coursePar12Display = "0";
        public string CoursePar12Display
        {
            get { return coursePar12Display; }
            set { coursePar12Display = value; OnPropertyChanged(); }
        }

        string coursePar13Display = "0";
        public string CoursePar13Display
        {
            get { return coursePar13Display; }
            set { coursePar13Display = value; OnPropertyChanged(); }
        }

        string coursePar14Display = "0";
        public string CoursePar14Display
        {
            get { return coursePar14Display; }
            set { coursePar14Display = value; OnPropertyChanged(); }
        }

        string coursePar15Display = "0";
        public string CoursePar15Display
        {
            get { return coursePar15Display; }
            set { coursePar15Display = value; OnPropertyChanged(); }
        }

        string coursePar16Display = "0";
        public string CoursePar16Display
        {
            get { return coursePar16Display; }
            set { coursePar16Display = value; OnPropertyChanged(); }
        }

        string coursePar17Display = "0";
        public string CoursePar17Display
        {
            get { return coursePar17Display; }
            set { coursePar17Display = value; OnPropertyChanged(); }
        }

        string coursePar18Display = "0";                                        //SCORE 18 DISPLAY
        public string CoursePar18Display
        {
            get { return coursePar18Display; }
            set { coursePar18Display = value; OnPropertyChanged(); }
        }

        string courseIndex1Display = "0";                                       // INDEX 1 DISPLAY
        public string CourseIndex1Display
        {
            get { return courseIndex1Display; }
            set { courseIndex1Display = value; OnPropertyChanged(); }
        }

        string courseIndex2Display = "0";
        public string CourseIndex2Display
        {
            get { return courseIndex2Display; }
            set { courseIndex2Display = value; OnPropertyChanged(); }
        }

        string courseIndex3Display = "0";
        public string CourseIndex3Display
        {
            get { return courseIndex3Display; }
            set { courseIndex3Display = value; OnPropertyChanged(); }
        }

        string courseIndex4Display = "0";
        public string CourseIndex4Display
        {
            get { return courseIndex4Display; }
            set { courseIndex4Display = value; OnPropertyChanged(); }
        }

        string courseIndex5Display = "0";
        public string Coursendex5Display
        {
            get { return courseIndex5Display; }
            set { courseIndex5Display = value; OnPropertyChanged(); }
        }

        string courseIndex6Display = "0";
        public string CourseIndex6Display
        {
            get { return courseIndex6Display; }
            set { courseIndex6Display = value; OnPropertyChanged(); }
        }

        string courseIndex7Display = "0";
        public string CourseIndex7Display
        {
            get { return courseIndex7Display; }
            set { courseIndex7Display = value; OnPropertyChanged(); }
        }

        string courseIndex8Display = "0";
        public string CourseIndex8Display
        {
            get { return courseIndex8Display; }
            set { courseIndex8Display = value; OnPropertyChanged(); }
        }

        string courseIndex9Display = "0";
        public string CourseIndex9Display
        {
            get { return courseIndex9Display; }
            set { courseIndex9Display = value; OnPropertyChanged(); }
        }

        string courseIndex10Display = "0";
        public string CourseIndex10Display
        {
            get { return courseIndex10Display; }
            set { courseIndex10Display = value; OnPropertyChanged(); }
        }

        string courseIndex11Display = "0";
        public string CourseIndex11Display
        {
            get { return courseIndex11Display; }
            set { courseIndex11Display = value; OnPropertyChanged(); }
        }

        string courseIndex12Display = "0";
        public string CourseIndex12Display
        {
            get { return courseIndex12Display; }
            set { courseIndex12Display = value; OnPropertyChanged(); }
        }

        string courseIndex13Display = "0";
        public string CourseIndex13Display
        {
            get { return courseIndex13Display; }
            set { courseIndex13Display = value; OnPropertyChanged(); }
        }

        string courseIndex14Display = "0";
        public string CourseIndex14Display
        {
            get { return courseIndex14Display; }
            set { courseIndex14Display = value; OnPropertyChanged(); }
        }

        string courseIndex15Display = "0";
        public string CourseIndex15Display
        {
            get { return courseIndex15Display; }
            set { courseIndex15Display = value; OnPropertyChanged(); }
        }

        string courseIndex16Display = "0";
        public string CourseIndex16Display
        {
            get { return courseIndex16Display; }
            set { courseIndex16Display = value; OnPropertyChanged(); }
        }

        string courseIndex17Display = "0";
        public string CourseIndex17Display
        {
            get { return courseIndex17Display; }
            set { courseIndex17Display = value; OnPropertyChanged(); }
        }

        string courseIndex18Display = "0";                                      //index 18 DISPLAY
        public string CourseIndex18Display
        {
            get { return courseIndex18Display; }
            set { courseIndex18Display = value; OnPropertyChanged(); }
        }

        string whiteDisplay = "0";                                              //TEE WHITE DISPLAY
        public string WhiteDisplay
        {
            get { return whiteDisplay; }
            set { whiteDisplay = value; OnPropertyChanged(); }
        }

        public ICommand Command { get; private set; }

        string yellowDisplay = "0";                                             //TEE YELLOW DISPLAY
        public string YellowDisplay
        {
            get { return yellowDisplay; }
            set { yellowDisplay = value; OnPropertyChanged(); }
        }

        string blueDisplay = "0";                                               //TEE BLUE DISPLAY
        public string BlueDisplay
        {
            get { return blueDisplay; }
            set { blueDisplay = value; OnPropertyChanged(); }
        }

        string redDisplay = "0";                                                //TEE RED DISPLAY
        public string RedDisplay
        {
            get { return redDisplay; }
            set { redDisplay = value; OnPropertyChanged(); }
        }

        string orangeDisplay = "0";                                             // TEE ORANGE DISPLAY
        public string OrangeDisplay
        {
            get { return orangeDisplay; }
            set { orangeDisplay = value; OnPropertyChanged(); }
        }

        string playerNameDisplay = "0";                                         //Player /NAME DISPLAY
        public string PlayerNameDisplay
        {
            get { return playerNameDisplay; }
            set { playerNameDisplay = value; OnPropertyChanged(); }
        }

        string playerGolfIDDisplay = "0";                                       //Player GOLF ID DISPLAY
        public string PlayerGolfIDDisplay
        {
            get { return playerGolfIDDisplay; }
            set { playerGolfIDDisplay = value; OnPropertyChanged(); }
        }

        string playerHcpDisplay = "0";                                          //PLAYER HCP DISPLAY
        public string PlayerHcpDisplay
        {
            get { return playerHcpDisplay; }
            set { playerHcpDisplay = value; OnPropertyChanged(); }
        }

        string playHcpDisplay = "0";                                            //PLAYHCP DISPLAY
        public string PlayHcpDisplay
        {
            get { return playHcpDisplay; }
            set { playHcpDisplay = value; OnPropertyChanged(); }
        }

        string Display = "0";                                                   //BIRDIE DISPLAY
        public string BirdieDisplay
        {
            get { return Display; }
            set { Display = value; OnPropertyChanged(); }
        }

        string bogeyDisplay = "0";                                              //BOGEY DISPLAY
        public string BogeyDisplay
        {
            get { return bogeyDisplay; }
            set { bogeyDisplay = value; OnPropertyChanged(); }
        }

        string parDisplay = "0";                                                //PAR DISPLAY
        public string ParDisplay
        {
            get { return parDisplay; }
            set { parDisplay = value; OnPropertyChanged(); }
        }

        public ObservableRangeCollection<Score> Scores { get; private set; }
        public Action ICommand { get; private set; }
        public ScoreViewModel BindigContext { get; private set; }

        private void GetCalculatedSlope()
        {
            LoopPar = Courses[0].Par1 + Courses[0].Par2 + Courses[0].Par3 + Courses[0].Par4 + Courses[0].Par5 + Courses[0].Par6 + Courses[0].Par7 + Courses[0].Par8 + Courses[0].Par9 + Courses[0].Par10 + Courses[0].Par11 + Courses[0].Par12 + Courses[0].Par13 + Courses[0].Par14 + Courses[0].Par15 + Courses[0].Par16 + Courses[0].Par17 + Courses[0].Par18;
            decimal x = Convert.ToInt32((Convert.ToDecimal(Players[0].Hcp) + 5) / 10);
            PlayHcp = (Convert.ToInt32(x * Slopes[0].SlopeValue / 113 + Slopes[0].CourseRating / 10) - LoopPar);

            for (int i = 0; i < NoOfHoles; i++) { hHCP[i] = 0; }                // RESET
            int count = (PlayHcp);                     // sET PARAMETERS

            for (int i = 0; i < count; i++)
            {
                if (count >= NoOfHoles) { count1 = NoOfHoles; } else count1 = count;

                for (int j = 0; j < NoOfHoles; j++)
                    if (INDEX[j] <= count1)
                    {
                        if (Players[0].Hcp.Substring(0, 1) == "+")
                        { hHCP[j]--; }              // + Hcp
                        else
                        { hHCP[j]++; }             // - Hcp
                    }
                count -= count1;
            }

            if (Players[0].Hcp.Substring(0, 1) == "+")
            {
                PlayHcpDisplay = $"PlayHcp - {PlayHcp}";
            }
            else
            {
                PlayHcpDisplay = $"PlayHcp {PlayHcp}";
            }
        }

        private void UpdateSummeries()
        {
            Scores[0].Score1 = SCORE[0]; Scores[0].Score2 = SCORE[1]; Scores[0].Score3 = SCORE[2]; Scores[0].Score4 = SCORE[3]; Scores[0].Score5 = SCORE[4]; Scores[0].Score6 = SCORE[5]; Scores[0].Score7 = SCORE[6]; Scores[0].Score8 = SCORE[7]; Scores[0].Score9 = SCORE[8];
            Scores[0].Score10 = SCORE[9]; Scores[0].Score11 = SCORE[10]; Scores[0].Score12 = SCORE[11]; Scores[0].Score13 = SCORE[12]; Scores[0].Score14 = SCORE[13]; Scores[0].Score15 = SCORE[14]; Scores[0].Score16 = SCORE[15]; Scores[0].Score17 = SCORE[16]; Scores[0].Score18 = SCORE[17];

            ScoreDisplay1 = "2";

            Scores[0].ScoreOut = Scores[0].Score1 + Scores[0].Score2 + Scores[0].Score3 + Scores[0].Score4 + Scores[0].Score5 + Scores[0].Score6 + Scores[0].Score7 + Scores[0].Score8 + Scores[0].Score9;
            Scores[0].ScoreIn = Scores[0].Score10 + Scores[0].Score11 + Scores[0].Score12 + Scores[0].Score13 + Scores[0].Score14 + Scores[0].Score15 + Scores[0].Score16 + Scores[0].Score17 + Scores[0].Score18;


            ScoreBruttoDisplay = $" { Scores[0].ScoreIn + Scores[0].ScoreOut }";
            //            ScoreNettoDisplay = $" { Scores[0].ScoreIn + Scores[0].ScoreOut - Slope }";

            ScoreDisplay1 = DISPLAY[0]; ScoreDisplay2 = DISPLAY[1]; ScoreDisplay3 = DISPLAY[2]; ScoreDisplay4 = DISPLAY[3]; ScoreDisplay5 = DISPLAY[4]; ScoreDisplay6 = DISPLAY[5]; ScoreDisplay7 = DISPLAY[6]; ScoreDisplay8 = DISPLAY[7]; ScoreDisplay9 = DISPLAY[8];
            ScoreDisplay10 = DISPLAY[9]; ScoreDisplay11 = DISPLAY[10]; ScoreDisplay12 = DISPLAY[11]; ScoreDisplay13 = DISPLAY[12]; ScoreDisplay14 = DISPLAY[13]; ScoreDisplay15 = DISPLAY[14]; ScoreDisplay16 = DISPLAY[15]; ScoreDisplay17 = DISPLAY[16]; ScoreDisplay18 = DISPLAY[17];

            ScoreOutDisplay = $" {Scores[0].ScoreOut}";
            ScoreInDisplay = $" {Scores[0].ScoreIn}";

            int point = 0; int chcp = 0; int hcp = 0; int score = 0;
            for (int i = 0; i < NoOfHoles; i++)
            {
                if (SCORE[i] > 0)
                {
                    point = point + PAR[i] - SCORE[i] + hHCP[i] + 2;
                    score += SCORE[i];
                    chcp = chcp + hHCP[i] - chHCP[i];
                    hcp += hHCP[i];

                }
                else
                {
                    point =0;
                    score = 0;
                    hcp = 0;

                }

//                ScoreHcpDisplay = $" {chcp}";
//                ScoreNettoDisplay = $" {LoopPar}";

            }
            PointsDisplay = $" {point}";
            ScoreHcpDisplay = $" {chcp - hcp}";
            ScoreNettoDisplay = $" {LoopPar + chcp - hcp}";

        }

        private class BackgroundColor1
        {
        }
    }

}


