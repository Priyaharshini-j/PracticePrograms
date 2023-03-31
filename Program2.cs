using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPracticeQuestions
{
    /*
     *Create a class monkey with jump ( ) and bite ( ) methods 
     *Create a class human which inherits this monkey class and implements 
     *basic animal interface with eat ( ) and sleep methods 
     */
    internal class Program2
    {
        static void Main2(string[] args)
        {
            Monkey mon = new Human();
            mon.Bite();
            mon.Jump();
            Human human = new Human();
            human.Jump();
            human.Bite();
            human.Eat();
        }
    }
     abstract class Monkey
    {
        abstract public void Bite();
        abstract public void Jump();
    }
    class Human : Monkey
    {
        public override void Bite()
        {
            Console.WriteLine("We can Bite");
        }
        public override void Jump()
        {
            Console.WriteLine("we can jump");
        }
        public void Eat()
        {
            Console.WriteLine("Humans can Eat");
        }
    }
}
