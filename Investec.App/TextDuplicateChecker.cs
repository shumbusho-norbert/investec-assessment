using System.Linq;

namespace Investec.App
{
    public class TextDuplicateChecker : ITextProcessor
    {
        public string ProcessText(string input)
        {
            var textData = input
                            .GroupBy(c => char.ToLower(c))
                            .Where(group => group.Count() > 1)
                            .Select(group => group.Key)
                            .ToArray();

            var duplicates = new string(textData.ToArray());

            if (!string.IsNullOrEmpty(duplicates))
                return $"Found the following duplicates: {duplicates.Replace(" ","")}";


            return "No duplicate found.";
        }
    }
}