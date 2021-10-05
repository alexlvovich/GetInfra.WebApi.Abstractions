using System.Text.RegularExpressions;

namespace GetInfra.WebApi.Abstractions.Models.Validation
{
    public interface IRegularExpressions
    {
        Regex GetExpression(string expressionName);
        bool IsMatch(string expressionName, string input);
        string Clean(string expressionName, string input);
    }
}
