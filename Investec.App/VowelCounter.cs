using System.Linq;

namespace Investec.App
{
    public class VowelCounter : ITextProcessor
    {
        public string ProcessText(string textInput)
        {
            int vowelCount = textInput.ToLower().Count(c => "iuoae".Contains(c));

            if (vowelCount > 0)
                return $"The number of vowels is:{vowelCount}";

            return "No vowels found.";

        }
    }
}