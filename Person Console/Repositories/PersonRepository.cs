using Person.Console.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Console.Repositories
{
    public class PersonReporitory
    {
        public List<PersonEntity> _personEntities { get; set; }



        public PersonReporitory()
        {
            FromFile();
        }

        private void FromFile()
        {
            String path;
            string[] lines;

            path = "D:\\FES ARAGON\\INTERSEMESTRALES\\.Net\\Person\\Person Console\\Repositories\\Persons.txt";
            lines = File.ReadAllLines(path);

            foreach(var line in lines)
            {
                string[] pieces;
                PersonEntity personEntity;

                pieces = line.Split("|");
                personEntity = new PersonEntity()
                {
                    Id = Convert.ToInt32(pieces[0]),
                    Name = pieces[1],
                    LastName = pieces[2],
                    IsActive = Convert.ToBoolean(pieces[3])
                };
                _personEntities.Add(personEntity);
            }

        }
        private void FromMemory()
        {
            _personEntities = new List<PersonEntity>();
            PersonEntity personEntity01 = new PersonEntity();
            personEntity01.Id = 1;
            personEntity01.Name= "Nicolas";
            personEntity01.LastName = "Gonzalez";
            personEntity01.Birthday = DateTime.Now;
            personEntity01.DateRegistration= DateTime.Now;
            personEntity01.IsActive = true;

            PersonEntity personEntity02 = new PersonEntity();
            personEntity02.Id = 2;
            personEntity02.Name = "Nicolas";
            personEntity02.LastName = "Gonzalez";
            personEntity02.Birthday = DateTime.Now;
            personEntity02.DateRegistration = DateTime.Now;
            personEntity02.IsActive = true;

            _personEntities.Add(personEntity01);
            _personEntities.Add(personEntity02);
        }

        public List<PersonEntity> GetAll()
        {
            return _personEntities;
        }

    }
}
