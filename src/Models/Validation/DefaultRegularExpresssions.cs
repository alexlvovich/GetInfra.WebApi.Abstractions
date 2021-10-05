using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GetInfra.WebApi.Abstractions.Models.Validation
{
    public class DefaultRegularExpresssions : IRegularExpressions
    {
        private Dictionary<string, Regex> expressions;

        public DefaultRegularExpresssions()
        {

            loadExpressions();
        }
        public string Clean(string expressionName, string input)
        {
            Regex expression = expressions[expressionName];

            return expression.Replace(input, "");
        }

        public Regex GetExpression(string expressionName)
        {
            return expressions[expressionName];
        }

        public bool IsMatch(string expressionName, string input)
        {
            Regex expression = expressions[expressionName];

            return expression.IsMatch(input);
        }

        protected void loadExpressions()
        {
            expressions = new Dictionary<string, Regex>(7)
            {
                {
                    "IsPageName",
                    new Regex(
                        "^[a-z0-9-_]+$",
                        RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Multiline
                        )
                },
                {
                    "IsPageNameReplace",
                    new Regex(
                        "([^a-z0-9-_]?)",
                        RegexOptions.IgnoreCase | RegexOptions.Compiled
                        )
                },

                {
                    "IsEmail",
                    new Regex(
                        @"^[a-z0-9]+([-+\.]*[a-z0-9]+)*@[a-z0-9]+([-\.][a-z0-9]+)*$",
                        RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Multiline
                        )
                },
                {
                    "IsUrl",
                    new Regex(
                        "^https?://(?:[^./\\s'\"<)\\]]+\\.)+[^./\\s'\"<\")\\]]+(?:/[^'\"<]*)*$",
                        RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Multiline
                        )
                },
                {
                    "IsUserName",
                    new Regex(
                        "[^a-z0-9]",
                        RegexOptions.Compiled
                        )
                },
                {
                    "IsNumeric",
                    new Regex(
                        "[0-9]+",
                        RegexOptions.Compiled
                        )
                }
            };
        }
    }
}
