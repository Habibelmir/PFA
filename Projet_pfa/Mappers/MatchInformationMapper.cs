using Projet_pfa.Models;
using Projet_pfa.ViewModel;

namespace Projet_pfa.Mappers
{
    public class MatchInformationMapper
    {
        public static MatchInformations GetMatchInfoFromMatch(Match m)
        {
            string dateOnly = m.Date.ToString().Substring(0, 10);
            MatchInformations matchinfo = new MatchInformations
            {
                equipe1 = m.Equipe1,
                equipe2 = m.Equipe2,

                date = dateOnly
            };


            return matchinfo;
        }
    }
}
