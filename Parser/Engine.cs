using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Parser
{
    public class Engine
    {
        private LocaleResource res;
        public Engine(LocaleResource res)
        {
            this.res = res;
        }
        public string Parser(Format format, string locale, string input)
        {
            string output = string.Empty;
            List<KeyValuePair<Format, Dictionary<char, char>>> collectionTokens = res.TokensCollection[locale].CollectionTokens;
            var tokens = collectionTokens.First(item => item.Key == format).Value;

            foreach (var symbol in input)
            {
                if(tokens.ContainsKey(symbol))
                {
                    output += tokens[symbol];
                }
                else
                {
                    output += symbol;
                }
            }
            return output;
        }
    }
}
