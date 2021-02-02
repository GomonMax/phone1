using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephone.DAL.DBFiles;
using TelephoneBook.Models;
using static Bogus.DataSets.Name;

namespace TelephoneBook.Services
{
    public class BookService
    {
        public static AbonentDataCollection FillRandomAbonents(MyContext context) 
        {
            Faker f = new Faker();
            Faker<AbonentData> faker = new Faker<AbonentData>("uk");

            AbonentDataCollection coll = BookService.Search(context, new SearchModel { page = 1, countOnePage = 10 });
            for (int i = 0; i < 100; i++) 
            {
                Gender gender = f.PickRandom<Gender>();

                faker.RuleFor((AbonentData data) => data.FullName, (Faker faker) => 
                faker.Name.LastName(gender) + " " 
                + faker.Name.FirstName(gender) + " " 
                + faker.Name.FirstName(Gender.Male) + (gender == Gender.Male ? "ович" : "івна"));

                faker.RuleFor((AbonentData data) => data.Gender, (Faker gen) => (gender == Gender.Male ? false : true));

                faker.RuleFor((AbonentData data) => data.telNummer, (Faker faker) => faker.Phone.PhoneNumber());
                AbonentData data = faker.Generate();
                context.persons.Add(new TelBookPerson
                {
                    FirstName = data.FullName.Split(" ")[1],
                    SecondName = data.FullName.Split(" ")[0],
                    LastName = data.FullName.Split(" ")[2],
                    Gender = gender == Gender.Male ? false : true,
                    telNummer = data.telNummer
                });
                coll.abonents.Add(data);
            }
            context.SaveChanges();
            return coll;
        }

        public static AbonentDataCollection Search(MyContext context, SearchModel search = null) 
        {
            var query = context.persons.AsQueryable();

            if (search != null)
            {
                if (!string.IsNullOrEmpty(search.Name))
                {
                    query = query.Where(x => (x.SecondName + " " + x.FirstName + " " + x.LastName).Contains(search.Name));
                }
                if (!string.IsNullOrEmpty(search.telNum))
                {
                    query = query.Where(x => x.telNummer.Contains(search.telNum));
                }
                if (search.State.HasValue) 
                {
                query = search.State == true ?
                    query
                    .Where(x => x.Gender == true) :
                    query
                    .Where(x => x.Gender == false);
                }
            }
             
            AbonentDataCollection collection = new AbonentDataCollection();
            collection.abonents = query
                .Select(x => new AbonentData
                {
                    FullName = x.SecondName + " " + x.FirstName + " " + x.LastName,
                    Gender = x.Gender,
                    Id = x.Id,
                    telNummer = x.telNummer
                })
                .OrderBy(x => x.Id)
                .Skip((search.page - 1) * search.countOnePage)
                .Take(search.countOnePage).ToList();
            collection.Count = query.Count();

            return collection;
        }
    }
}
