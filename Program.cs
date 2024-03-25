using System;
using System.Collections.Generic;
namespace TestTask
{
    class Program
    {

        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Нет Входных значений");
                return;
            }

            bool okValues = false;
            List<int> HomeTeamScores = new List<int>();
            List<int> GuestTeamSores = new List<int>();
            int HomeTeamScore = 0;
            int GuestTeamScore = 0;
            foreach (string s in args)
            {
                string l = s.TrimEnd(',');
                string[] scrores = l.Split(":");
                if (scrores.Length == 2)
                {
                    int tHomeScore;
                    int tGuestStore;
                    if (int.TryParse(scrores[0], out tHomeScore))
                    {
                        if (int.TryParse(scrores[1], out tGuestStore))
                        {
                            okValues = true;
                            if (tHomeScore > tGuestStore)
                            {
                                HomeTeamScore += 3;
                                HomeTeamScores.Add(3);
                                GuestTeamSores.Add(0);
                            }
                            else if (tHomeScore == tGuestStore)
                            {
                                HomeTeamScore += 1;
                                GuestTeamScore += 1;
                                HomeTeamScores.Add(1);
                                GuestTeamSores.Add(1);
                            }
                            else
                            {
                                GuestTeamScore += 3;
                                HomeTeamScores.Add(0);
                                GuestTeamSores.Add(3);
                            }
                        }
                        else
                        {
                            HomeTeamScores.Add(-1);
                            GuestTeamSores.Add(-1);
                        }
                    }
                    else
                    {
                        HomeTeamScores.Add(-1);
                        GuestTeamSores.Add(-1);
                    }
                }
                else
                {
                    HomeTeamScores.Add(-1);
                    GuestTeamSores.Add(-1);
                }

            }
            if (okValues)
            {
                string HomeScores = "";
                string GuestScores = "";
                for (int i = 0; i < HomeTeamScores.Count; i++)
                {
                    HomeScores += "Матч " + (i + 1) + ": ";
                    GuestScores += "Матч " + (i + 1) + ": ";
                    if (HomeTeamScores[i] == -1)
                    {
                        HomeScores += "Неверный ввод";
                    }
                    else
                    {
                        HomeScores += HomeTeamScores[i];
                    }
                    if (GuestTeamSores[i] == -1)
                    {
                        GuestScores += "Неверный ввод";
                    }
                    else
                    {
                        GuestScores += GuestTeamSores[i];
                    }
                    HomeScores += "; ";
                    GuestScores += "; ";
                }
                Console.WriteLine("Комманда 1(Хозяева) заработала " + HomeScores);
                Console.WriteLine("Koмманда 2(Гости) заработала " + GuestScores);

                Console.WriteLine("Комманда 1(Хозяева) заработала всего " + HomeTeamScore + " Очков");
                Console.WriteLine("Koмманда 2(Гости) заработала всего " + GuestTeamScore + " Очков");
            }


        }

    }
}
