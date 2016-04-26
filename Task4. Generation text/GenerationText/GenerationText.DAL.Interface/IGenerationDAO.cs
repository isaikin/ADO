using System.Collections.Generic;

namespace GenerationText.DAL
{
    public interface IGenerationDAO
    {
        void AddWords(string path);
        void AddWords(List<string> text);
        string ClearWord(string temp);
        List<string> GetSeparator(string text);
        IDictionary<string, List<string>> Getwords();
    }
}