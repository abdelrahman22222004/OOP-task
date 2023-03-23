using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class player
    {   //attributes 
        public string name;
        public int age;
        public int weight;
        public int length;
        public string nationality;
        public string position;
        public bool is_sociable;
        public string feeling;
        //constructors 
        public player()
        {
            Console.WriteLine("New player ");
        }
        public player(string name)
        {
            this.name = name;
            Console.WriteLine("Name: {0}", name);
        }
        public player(int age)
        {
            this.age = age;
            Console.WriteLine("Age: " + age);
        }
        public player(int weight, int lenght)
        {
            this.weight = weight;
            this.weight = lenght;
            Console.WriteLine("Weight: {0}", weight);
            Console.WriteLine("Lenght: {0}", lenght);
        }
        public player(bool is_sociable)
        {
            if (is_sociable)
                Console.WriteLine("Cat is sociable");
        }
        //methods
        public void input_name()
        {
            Console.WriteLine("Name:");
            name = Console.ReadLine();
        }
        public void input_age()
        {
            Console.WriteLine("Age:");
            age = int.Parse(Console.ReadLine());
        }
        public void input_weight()
        {
            Console.WriteLine("Weight:");
            weight = int.Parse(Console.ReadLine());
        }
        public void input_lenght()
        {
            Console.WriteLine("Lenght:");
            length = int.Parse(Console.ReadLine());
        }
        public void input_nationality()
        {
            Console.WriteLine("nationality:");
            nationality = Console.ReadLine();
        }
        public void input_position (string position)
        {
            this.position = position;
            Console.WriteLine(position);
        }
        public void print(string name, int age, int weight, int length, bool is_sociable)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.length = length;
            this.is_sociable = is_sociable;
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Weight: {0}", weight);
            Console.WriteLine("Lenght: {0}", length);
            Console.WriteLine("Is sociable: {0}", is_sociable);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            player playereeer = new player();
            playereeer.input_name();
            playereeer.input_age();
            playereeer.input_weight();
            playereeer.input_lenght();
            playereeer.input_nationality();
            playereeer.input_position(" play macker" );
            playereeer.print(playereeer.name, playereeer.age, playereeer.weight, playereeer.length, true);
        }
    }
}