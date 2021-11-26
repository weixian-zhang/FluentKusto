
namespace FluentKusto
{
    public class CSharpFuncNameKqlFuncNameMap
    {
        public CSharpFuncNameKqlFuncNameMap(string funcName, string kqlFuncName)
        {
            RegexFuncNamePattern = funcName;
            KqlFuncName = kqlFuncName;
        }

        public string RegexFuncNamePattern { get; set; }
        public string KqlFuncName { get; set; }

    }
}