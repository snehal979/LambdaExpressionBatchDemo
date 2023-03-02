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
            Console.WriteLine("Hint 1.Retrieving Top Two Record For Age Is Less Than 60 \n 2.Retrieving Teen Age Person\n 3. All PersonAverage Of Age" +
                "\n4.Search Name is present or not \n 5.Skip record from the list for age is less than 60 \n 6.Remove Name");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //UC 2 
                    Console.WriteLine("Retrieving Top Two Record For Age Is Less Than 60");
                    var personList =listPersonInCity.FindAll(e => (e.Age <= 60)).Take(2).ToList();
                    Display(personList);
                    break;
                case 2:
                    //Uc3
                    Console.WriteLine("Retrieving Teen ager age Person");
                    if (listPersonInCity.Any(e => (e.Age >= 15 && e.Age < 18))) //Teenagers (15-17 years of age)
                    {
                        Console.WriteLine("Yes, we have Teenagers age of person");
                    }
                    else
                    {
                        Console.WriteLine("No, we have no Teenagers age of person");
                    }
                    break;
                case 3:
                    // Uc4 Average
                    Console.WriteLine(" All Person Average of Age");
                    double average = listPersonInCity.Average(e => e.Age);
                    Console.WriteLine("the average of all person age is " +average);
                    break;
                case 4:
                    //Uc5
                    CheckPersonExistOrNot(listPersonInCity);
                    break;
                case 5:
                    SkipRecordFromList_AgeIsLessThan60(listPersonInCity);
                    break;
                case 6:
                    Remove(listPersonInCity);
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
            foreach (var data in listPersonInCity)
            {
                Console.WriteLine("Id person :"+data.Id+"\n Name : "+data.Name+"\n address :"+data.Address+"\n Age: "+data.Age+"\n");
            }
        }
        //Uc5 Search Name
        private static void CheckPersonExistOrNot(List<PersonData> listPersonInCity)
        {
            Console.WriteLine("Enter the name For search");
            string name = Console.ReadLine();
            if (listPersonInCity.Any(e => (e.Name.Contains(name))))
                Console.WriteLine("Person is present");
            else
                Console.WriteLine("Person is not present");
        }
        /// <summary>
        /// Uc6  Skip record from the list for age is less than 60
        /// </summary>
        /// <param name="listPersonInCity"></param>
        public static void SkipRecordFromList_AgeIsLessThan60(List<PersonData> listPersonInCity)
        {
            var record = listPersonInCity.SkipWhile(e => (e.Age <= 60));
            foreach(var data in record)
            {
                Console.WriteLine("Name "+data.Name+" age "+data.Age);
            }
        }
        /// <summary>
        /// Uc7 Remove specific name from the list
        /// </summary>
        public static void Remove(List<PersonData> listPersonInCity)
        {
            Console.WriteLine("Enter the Remove Name");
            string specificName = Console.ReadLine();
            int name =listPersonInCity.RemoveAll(e => (e.Name == specificName));//Return integer
            if(name > 0)
            {
                Console.WriteLine("Name {0} is remove Special name From List",specificName);
            }
            else
            {
                Console.WriteLine("Name {0} is not found in list",specificName);
            }
            
        }
    }
}
