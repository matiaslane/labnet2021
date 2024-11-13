using Lab.Tp7.Common.RepoModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StarWarsApiCSharp;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace Lab.Tp8.Repository.StarWars
{
    public class StarWars
    {
        private string Get(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            using (WebResponse response = request.GetResponse())
            {
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader == null) return string.Empty;

                    using (StreamReader objReader = new StreamReader(strReader))
                    {
                        var responseBody = objReader.ReadToEnd();
                        return responseBody;
                    }
                }
            }
        }

        // Todo
        // metodo get para pasarle la URL y "id" para traer solamente uno.

        public List<PersonModel> GetPeople()
        {

            var people = new Repository<Person>();
            List<Person> peopleList = people.GetEntities(size: int.MaxValue).ToList();

            List<PersonModel> peopleModelList = peopleList.Select(p => new PersonModel()
            {
                Name = p.Name,
                Height = p.Height,
                EyeColor = p.EyeColor
            }).ToList();

            return peopleModelList;
        }
    }
}