using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElephantConsoleApp
{
    internal class Elephant
    {
        public string Name = "";
        public int EarSize = 0;

        public void WhoAmI()
        {
            Console.WriteLine($"My name is {Name}.");
            Console.WriteLine($"My ears are {EarSize} inches tall.");
        }

        /// <summary>
        /// Simulates the Elephant hearing a message from another Elephant.
        /// In the context of Program.cs 'choice == 5', lloyd is the one hearing
        /// because lucinda speaks to him.
        /// </summary>
        /// <param name="message">The message the Elephant heard.</param>
        /// <param name="whoSaidIt">The Elephant who sent the message</param>
        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine($"{Name} heard a message");
            // WhoSaidIt is the elephant who called the SpeakTo method.
            // In the context of Program.cs 'choice == 5', whoSaidIt is lucinda.
            Console.WriteLine($"{whoSaidIt.Name} said this: {message}");
        }

        /// <summary>
        /// Simulates the Elephant speaking to another Elephant by calling the
        /// other Elephant's HearMessage method.
        /// In the context of Program.cs 'choice == 5', lucinda is the one calling
        /// this method.
        /// </summary>
        /// <param name="whoToTalkTo">The Elephant to speak to.</param>
        /// <param name="message">The message to send.</param>
        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            // 'this' refers to the current Elephant object, which is the one calling
            // this method. In the context of Program.cs 'choice == 5', 'this' refers
            // to lucinda.

            whoToTalkTo.HearMessage(message, this);

            // Program.cs : choice == 5
            //      lucinda.SpeakTo(lloyd, "Hi, Lloyd! How are you doing?"); becomes
            //   lloyd.HearMessage("Hi, Lloyd! How are you doing?", lucinda);

            // this: This is crucial! this represents the Elephant object that is calling
            // the SpeakTo method (the one sending the message). So, this is passed as
            // the whoSaidIt argument to the HearMessage method.
        }
    }
}
