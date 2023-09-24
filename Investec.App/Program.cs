using System;
using System.Linq;


namespace Investec.App
{
    class Program
    {
        static void Main()
        {
            try
            {
                string inputText;
                do
                {

                    Console.WriteLine("Enter text to be analysed");

                    inputText = Console.ReadLine();

                    Console.WriteLine("Enter which operations to perform on the supplied text:");
                    Console.WriteLine("1 for duplicate character check");
                    Console.WriteLine("2 for counting the number of vowels");
                    Console.WriteLine("3 for checking if there are more vowels or non-vowels");
                    Console.WriteLine("You can also enter a combination of 1,2 and 3 to perform multiple checks");

                    string promptInput = Console.ReadLine();

                    if (!String.IsNullOrWhiteSpace(inputText) && ValidateInput(promptInput))
                    {
                        foreach (char code in promptInput)
                        {
                            ITextProcessor iTextProcessor = new TextProcessorFactory().CreateTextProcessor(code.ToString()); ;

                            Console.WriteLine(iTextProcessor.ProcessText(inputText));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Operation text, only 1,2 and 3 or a combination");
                    }

                } while (inputText.ToLower() != "quit");
            }
            catch (Exception)
            {
                //Error log here..
            }
        }

        #region Validation supporting methods
        static bool ValidateInput(string textInput)
        {
            if (String.IsNullOrWhiteSpace(textInput))
                return false;


            string allowedCharacters = "123";

            bool isValid = textInput.All(c => allowedCharacters.Contains(c));

            return isValid;
        }
        #endregion

    }
}
