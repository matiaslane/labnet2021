using Lab.Tp7.Common.RepoModels;
using Lab.Tp8.Repository.StarWars;
using System.Collections.Generic;

namespace Lab.Tp3.Logic
{
    public class StarWarsLogic : IStarWarsLogic
    {
        public List<PersonModel> GetPeople()
        {
            var reposw = new StarWars();

            return reposw.GetPeople();
        }
    }
}
