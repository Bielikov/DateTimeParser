using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class Tokens
    {
        public List<KeyValuePair<Format, Dictionary<char, char>>> CollectionTokens { get; private set; }

        public Tokens(Dictionary<char, char> dateTokens, Dictionary<char, char> timeTokens)
        {
            CollectionTokens = new List<KeyValuePair<Format, Dictionary<char, char>>>()
                {
                    {new KeyValuePair<Format, Dictionary<char, char>>(Format.Date, dateTokens) },
                    {new KeyValuePair<Format, Dictionary<char, char>>(Format.Time, timeTokens) }
                };
        }
    }
    public class LocaleResource
    {        
        public Dictionary<string, Tokens> Storage { get; private set; }

        public LocaleResource()
        {
            Storage = new Dictionary<string, Tokens>()
            {
                {"en_US", new Tokens(dateTokensEn, timeTokensEn) },
                {"fr_CA", new Tokens(dateTokensFr, timeTokensFr) },
                {"pt_BR", new Tokens(dateTokensPt, timeTokensPt) },
                {"he_IL", new Tokens(dateTokensHe, timeTokensHe) }
            };
        }

        Dictionary<char, char> dateTokensEn = new Dictionary<char, char>()
        {
            {'d', 'g'},
            {'D', 'g'},
            {'m', 'f'},
            {'M', 'F'},
            {'y', 'j'},
            {'Y', 'J'}
        };

        Dictionary<char, char> timeTokensEn = new Dictionary<char, char>()
        {
            {'H', ' '},
            {'h', ' '},
            {'m', ' '},
            {'s', ' '},
        };

        Dictionary<char, char> dateTokensFr = new Dictionary<char, char>()
        {
            {'d', ' '},
            {'D', ' '},
            {'m', ' '},
            {'M', ' '},
            {'y', ' '},
            {'Y', ' '}
        };

        Dictionary<char, char> timeTokensFr = new Dictionary<char, char>()
        {
            {'H', ' '},
            {'h', ' '},
            {'m', ' '},
            {'s', ' '},
        };

        Dictionary<char, char> dateTokensPt = new Dictionary<char, char>()
        {
            {'d', ' '},
            {'D', ' '},
            {'m', ' '},
            {'M', ' '},
            {'y', ' '},
            {'Y', ' '}
        };

        Dictionary<char, char> timeTokensPt = new Dictionary<char, char>()
        {
            {'H', ' '},
            {'h', ' '},
            {'m', ' '},
            {'s', ' '},
        };

        Dictionary<char, char> dateTokensHe = new Dictionary<char, char>()
        {
            {'d', ' '},
            {'D', ' '},
            {'m', ' '},
            {'M', ' '},
            {'y', ' '},
            {'Y', ' '}
        };

        Dictionary<char, char> timeTokensHe = new Dictionary<char, char>()
        {
            {'H', ' '},
            {'h', ' '},
            {'m', ' '},
            {'s', ' '},
        };
    }
}
