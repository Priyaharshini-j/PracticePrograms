namespace AbstractionPracticeQuestions
{
    /*
     * Create an abstract class pen with methods write () and refill () as abstract methods
     */
    public class Program1
    {
        static void Main1(string[] args)
        {
            FountainPen foundain=new FountainPen();
            foundain.write();
            foundain.refil();
            foundain.clean();

        }
        
    }
    abstract public class Pen
    {
        abstract public void write();
        abstract public void refil();
    }
    public class FountainPen : Pen
    {
        public override void write()
        {
            Console.WriteLine("Pen is usedto write.");
        }

        public override void refil()
        {
            Console.WriteLine("Pen should be refilled to write");
        }
        public void clean()
        {
            Console.WriteLine("Pen is getting cleaned");
        }
    }
}