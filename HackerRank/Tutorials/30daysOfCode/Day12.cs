using System;

namespace _30daysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-inheritance
    /// </summary>
    public class Day12
    {
        class Person
        {
            protected string firstName;
            protected string lastName;
            protected int id;

            public Person() { }
            public Person(string firstName, string lastName, int identification)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.id = identification;
            }
            public void printPerson()
            {
                Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
            }
        }

        class Student : Person
        {
            private int[] testScores;

            public Student(string firstName, string lastName, int id, int[] scores)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.id = id;
                this.testScores = scores;
            }

            public char calculate()
            {
                int sum = 0;
                foreach (int r in testScores) sum += r;

                double average = sum / (double)testScores.Length;

                if (average < 40) return 'T';
                if (average < 55) return 'D';
                if (average < 70) return 'P';
                if (average < 80) return 'A';
                if (average < 90) return 'E';
                if (average <= 100) return 'O';

                throw new InvalidOperationException();
            }
        }
    }
}
