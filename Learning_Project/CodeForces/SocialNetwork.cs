using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning_Project.CodeForces
{
    class SocialNetwork
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var tokens = line.Split(' ');
            int[] nandk = Array.ConvertAll(tokens, int.Parse);
            int temp;
            Queue<int> myQueue = new Queue<int>();

            line = Console.ReadLine();
            tokens = line.Split(' ');
            int[] numbers = Array.ConvertAll(tokens, int.Parse);
            for (int i = 0; i < nandk[0]; i++)
            {
                temp = numbers[i];
                if (!myQueue.Contains(temp))
                {
                    myQueue.Enqueue(temp);
                }
                while (myQueue.Count > nandk[1])
                {
                    myQueue.Dequeue();
                }
            }
            Console.WriteLine(myQueue.Count);
            myQueue = new Queue<int>(myQueue.Reverse());
            while (myQueue.Count > 0)
            {
                Console.Write(myQueue.Dequeue() + " ");
            }
        }
    }
}
