using System;
using System.Collections.Generic;
using System.Globalization;


namespace ExercicioList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employes will be registered? ");

            int qtd = int.Parse(Console.ReadLine());

            List<Employes> list = new List<Employes>();
           
            Console.WriteLine("-------------------------------------------------------------");

            for (int i = 1; i < qtd; i++)
            {
                Console.WriteLine("Employoee #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employes(id, name, salary));
                Console.WriteLine("-------------------------------------------------------------");
            }

            Console.WriteLine();

            Console.WriteLine("Enter the employee id that will have salary increase:");
            int serachId = int.Parse(Console.ReadLine());

            Employes emp = list.Find(x => x.Id == serachId);
            
            if (emp != null )
            {
                Console.WriteLine("Enter the percentage: ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(porcent);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();

            Console.WriteLine("Updated list of employees:");

            foreach (var employes in list)
            {
                Console.WriteLine(employes);
            }


           // Console.WriteLine("Updated list of employees:");

            Console.ReadKey();
        }
    }
}
