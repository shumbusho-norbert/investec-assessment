using System.Linq;

namespace Investec.App
{
    public class VowelCounter : ITextProcessor
    {
        public string ProcessText(string textInput)
        {
            int vowelCount = textInput.ToLower()
                                      .Where(c => "iuoae".Contains(c))
                                      .Distinct()
                                      .Count();

            if (vowelCount > 0)
                return $"The number of vowels is:{vowelCount}";

            return "No vowels found.";

        }
    }
}