using System.Collections.Generic;

namespace Algorithms.Application
{
    public interface ITopCompetitorsService
    {
        public List<string> TopCompetitors(int numCompetitors, int topNCompetitors, List<string> competitors, int numReviews, List<string> reviews);
    }
}
