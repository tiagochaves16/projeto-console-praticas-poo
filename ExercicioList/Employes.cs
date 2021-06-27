using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ExercicioList
{
    public class Employes
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; set; }

        public Employes(int id, string nome, double salary)
        {
            Id = id;
            Name = nome;
            Salary = salary;
        }


        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }



        public override string ToString()
        {
            return +Id
                   + ", " 
                   + Name 
                   + ", " 
                   + Salary.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
