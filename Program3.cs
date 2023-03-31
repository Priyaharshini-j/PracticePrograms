using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPracticeQuestions
{
    /*
     * Create an interface TVremote and use it to inherit another interface smart TVremote 
     * Create a class TV which implements TVremote interface from 
     */
    internal class Program3
    {
        public static void Main3(string[] args)
        {
            Tv Tele = new Tv();
            Tele.ChangeChannel();
            Tele.VoiceRecognition();
        }
    }
    interface ITvRemote : IsmartTvRemote
    {
        void ChangeChannel();
    }
    interface IsmartTvRemote
    {
        void VoiceRecognition();
    }
    class Tv : ITvRemote
    {
        public void ChangeChannel()
        {
            Console.WriteLine("Change to next Channel");
        }
        public void VoiceRecognition()
        {
            Console.WriteLine("Lets Use Voice Recognition to change the channel");
        }
        
    }
}
