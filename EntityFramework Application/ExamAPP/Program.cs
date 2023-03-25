using Bogus;
using ExamAPP.Models;

namespace ExamAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lisdsa = new Faker<Course>().RuleFor(e => e.Title, f => f.Person.FirstName).RuleFor(e => e.Id, f => f.Random.Number(1, 100)).GenerateBetween(1, 5);
            Console.WriteLine("Hello, World!");
        }
    }
}