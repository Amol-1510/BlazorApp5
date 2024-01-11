namespace BlazorApp5.Services
{

    public interface ILabelDictionaryService
    {
        public Dictionary<int, string> GetLabelDictionary();
    }
    public class LabelDictionaryService : ILabelDictionaryService
    {
        public Dictionary<int, string> GetLabelDictionary()
        {
          
            var dictionary = new Dictionary<int, string>
        {
            { 1, "One" },
            { 2, "Two" },
            { 3, "Three" }
           
        };

            return dictionary;
        }
    }
}
