using System.Collections.Generic;

namespace GenerationText.BLL.Interface
{
    public interface IGenerationLogic
    {
        string GetGenerateText1();

        string GetGenerateText2(char begWord);

        string GetGenerateText3(int countWords);

        void AddWords(List<string> text);
    }
}