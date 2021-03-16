using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Application.Services
{
    public class TopCompetitorsService : ITopCompetitorsService
    {
        public List<string> TopCompetitors(int numCompetitors, int topNCompetitors, List<string> competitors, int numReviews, List<string> reviews)
        {
            List<string> result = new List<string>();
            List<int> listQtd = new List<int>();
            int controller = 0;
            int first = 0;
            int second = 0;
            int indexFirst = 0;
            int indexSecond = 0;

            for (int i = 0; i < competitors.Count; i++)
            {
                if (result.Count != 0)
                    controller += 1;

                int qtd = 0;

                for (int p = 0; p < reviews.Count; p++)
                {
                    qtd += reviews[p].Split(competitors[i]).Length - 1;
                }

                listQtd.Add(qtd);
            }

            for (int i = 0; i < listQtd.Count - 1; i++)
            {
                if (i == 0)
                {
                    first = listQtd[i];
                    indexFirst = i;
                }

                if (listQtd[i] < listQtd[i + 1])
                {
                    if (listQtd[i + 1] > first)
                    {
                        first = listQtd[i + 1];
                        indexFirst = i + 1;
                    }

                }
            }

            for (int i = 0; i < listQtd.Count - 1; i++)
            {
                if (i != indexFirst)
                {
                    if (i == 0)
                    {
                        second = listQtd[i];
                        indexSecond = i;
                    }

                    if (i + 1 == indexFirst)
                    {
                        second = listQtd[i];
                        indexSecond = i;
                    }
                    else
                    {
                        if (second == 0)
                        {
                            second = listQtd[i];
                            indexSecond = i;
                        }
                    }

                    if (listQtd[i] < listQtd[i + 1])
                    {
                        second = listQtd[i + 1];
                        indexSecond = i;
                    }

                }
            }

            result.Add(competitors[indexFirst]);
            result.Add(competitors[indexSecond]);

            return result;
        }

    }
}
