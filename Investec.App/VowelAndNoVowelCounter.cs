using System.Linq;

namespace Investec.App
{
    public class VowelAndNoVowelCounter : ITextProcessor
    {
        public string ProcessText(string textInput)
        {
            int vowelCount = textInput.ToLower().Count(c => "iuoae".ToLower().Contains(c));

            // Remove spaces
            int nonVowels = textInput.Replace(" ","").Length - vowelCount;

            if (vowelCount > nonVowels)
            {
                return "The text has more vowels than nonvowels";
            }
            else if (vowelCount < nonVowels)
            {
                return "The text has more non vowels than vowels";
            }
            else
            {
                return "The text has an equal amount of vowels and non vowels.";
            }
        }
    }
}