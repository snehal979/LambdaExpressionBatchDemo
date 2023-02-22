using System;

namespace LambdaExpressionBatchDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lambda Expression Batch Demo");
            List<PersonData> listPersonInCity = new List<PersonData>();
            AddRecord(listPersonInCity);
            Display(listPersonInCity);
            Console.WriteLine("Hint 1.Retrieving Top Two Record For Age Is Less Than 60 \n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //UC 2 
                    Console.WriteLine("Retrieving Top Two Record For Age Is Less Than 60");
                    var personList =listPersonInCity.FindAll(e => (e.Age <= 60)).Take(2).ToList();
                    Display(personList);
                    break;
            }
            Console.ReadLine();
        }
        private static void AddRecord(List<PersonData> listPersonInCity)
        {
            listPersonInCity.Add(new PersonData(1, "Snehal", "plot no 12,sindewahi", 24));
            listPersonInCity.Add(new PersonData(2, "Raju", "plot no 13,sindewahi", 68));
            listPersonInCity.Add(new PersonData(3, "Mayur", "plot no 9,sindewahi", 20));
            listPersonInCity.Add(new PersonData(4, "Vaibhav", "plot no 28,sindewahi", 17));
            listPersonInCity.Add(new PersonData(5, "Lata", "plot no 89,sindewahi", 62));
            listPersonInCity.Add(new PersonData(6, "Anu", "plot no 57,sindewahi", 80));
            listPersonInCity.Add(new PersonData(7, "Mayur", "plot no 29,sindewahi", 9));
            listPersonInCity.Add(new PersonData(8, "Bharti", "plot no 10,sindewahi", 45));
            //Display(listPersonInCity);
        }
        private static void Display(List<PersonData> listPersonInCity)
        {
            foreach (PersonData data in listPersonInCity)
            {
                Console.WriteLine("Id person :"+data.Id+"\n Name : "+data.Name+"\n address :"+data.Address+"\n Age: "+data.Age+"\n");
            }
        }

    }
}
