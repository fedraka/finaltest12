using System;
using System.Collections.Generic;


namespace generic
{
    public class Program
    {
       public static void Main()
		{
            var prs = new PersonDoc<Person>();


            prs.AddPerson(new Person("Shahab", "Tima"));
            prs.AddPerson(new Person("Sheri", "Tima"));

            prs.ReturnPerson(1);

			prs.AllReturnPerson();
			
		}


		public class PersonDoc<TPerson>where TPerson : IPerson 
		{
			private readonly List<TPerson> PersonList = new List<TPerson>();

			public void AddPerson(TPerson person)
			{
					PersonList.Add(person);
			}

			public void ReturnPerson(int num )
			{
				Console.WriteLine(PersonList[num].Firstname +" " + PersonList[num].Lastname);
			}

			public void AllReturnPerson()
			{
			//	var newList =from s in PersonList orderby s.Person.Firstname
					//PersonList.order(x => x.fi).ToList();

				foreach (TPerson p in PersonList)
                {
                    Console.WriteLine(p.Firstname);
                }
            }

		}



		public interface IPerson
		{
			string Firstname {get;set;}

			string Lastname{ get; set; }
		}

		public class Person : IPerson
		{
			public Person()
			{
			}
			public Person(string first, string last)
			{
				this.Firstname = first;
				this.Lastname = last;
			}

			public string Firstname { get; set; }

			public string Lastname { get; set; }
		}

	}
}
