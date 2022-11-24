namespace MVC_LAB.Models.Person
{
    public class PersonModel
    {
        public PersonModel()
        {

        }

        public int ID { get; set; }

        public string Name { get; set; }

        public GenderEnum Gender { get; set; }

        public string City { get; set; }

        public List<PersonModel> GetPersons()
        {
            return new List<PersonModel>()
            {
                new PersonModel()
                {
                    ID = 1,
                    Name = "Przemysław",
                    Gender = GenderEnum.Male,
                    City = "Ropczyce",

                },
                new PersonModel()
                {
                    ID = 2,
                    Name = "Weronika",
                    Gender = GenderEnum.Female,
                    City = "Ropczyce",

                },
                new PersonModel()
                {
                    ID = 3,
                    Name = "Katarzyna",
                    Gender = GenderEnum.Female,
                    City = "Rzeszów",

                },
                new PersonModel()
                {
                    ID = 4,
                    Name = "Piotr",
                    Gender = GenderEnum.Male,
                    City = "Białystok",

                }
            };
        }
    }
}