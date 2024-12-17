using System;

namespace app
{
    class Program
    {
        /*
            The entry method of the application. It reads input from the user and outputs the processed message to the console.
        */
        public static void Main(String[] args)
        {
            Processor InputProcessor = new Processor();

            String input = Console.ReadLine() ?? String.Empty;
            String answer = InputProcessor.ProcessInput(input);
            Console.WriteLine("Message: " + answer);

        }
    }
}