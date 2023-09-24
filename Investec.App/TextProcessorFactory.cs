using System;

namespace Investec.App
{
    public class TextProcessorFactory
    {
        public ITextProcessor CreateTextProcessor(string textInput)
        {
            switch (textInput)
            {
                case "1":
                    return new TextDuplicateChecker();
                case "2":
                    return new VowelCounter();
                case "3":
                    return new VowelAndNoVowelCounter();
                default:
                    throw new ArgumentException("Invalid text Input provided!");
            }
        }

    }
}
