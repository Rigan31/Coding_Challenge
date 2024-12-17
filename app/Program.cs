using System;

namespace app
{
    class Program
    {
        public static void Main(String[] args)
        {
            Processor InputProcessor = new Processor();

            String input = Console.ReadLine() ?? String.Empty;
            String answer = InputProcessor.ProcessInput(input);
            Console.WriteLine("Message: " + answer);

        }
    }
}