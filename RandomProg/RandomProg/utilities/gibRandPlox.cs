using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RandomProg.utilities
{
    public class gibRandPlox
    {

        Random rnd;
        MersenneTwister mt;
        string[] adjectives, verbs, subjectives, adverbs;

        gibRandPlox()
        {
            rnd = new Random();
            mt = new MersenneTwister();

            //Prepare all stuff
            #region lotsAstuff

            adjectives = new string[]{ "American",
            "French",
            "Japanese",
            "Blue",
            "Red",
            "Swaggalicious",
            "angry",
            "bewildered",
            "clumsy",
            "defeated",
            "embarrassed",
            "massive"};

            verbs = new string[] { "crushing",
            "forgiving",
            "rekking",
            "outperforming",
            "wanking",
            "exterminating",
            "walking"};

            subjectives = new string[] { "you",
            "me",
            "showers",
            "alpacas",
            "wallace and gromit",
            "orcs",
            "wizards of great power",
            "faggots"};

            adverbs = new string[] { "swaggingly",
            "unappealingly",
            "as well as bob ross"};

            #endregion


        }

        int gibRand(int max)
        {
            //Just return a random number.
            return rnd.Next(0,max);
        }

        int gibLeetRand(int max)
        {
            //Return a random number using the mersenne twister.
            return mt.Next(0, max);
        }

        string gibText()
        {
            /*
             * This function constructs a sentence from the adjectives and stuff.
             */

            //Generate four random numbers, general sentence form
            /*
             * *Subjective* are *adverb* *verb* *adjective* *subjective*
             */

            int s1, av, v, ad, s2;

            s1 = rnd.Next(0,subjectives.Length-1);
            s2 = rnd.Next(0, subjectives.Length - 1);
            av = rnd.Next(0, adverbs.Length - 1);
            v = rnd.Next(0, verbs.Length - 1);
            ad = rnd.Next(0, adjectives.Length - 1);

            return subjectives[s1] + "are" + adverbs[av] + verbs[v] + adjectives[ad] + subjectives[s2];

        }


        string gibLeetText()
        {
            /*
             * This function constructs a sentence from the adjectives and stuff.
             */

            //Generate four random numbers, general sentence form
            /*
             * *Subjective* are *adverb* *verb* *adjective* *subjective*
             */

            int s1, av, v, ad, s2;

            s1 = mt.Next(0, subjectives.Length - 1);
            s2 = mt.Next(0, subjectives.Length - 1);
            av = mt.Next(0, adverbs.Length - 1);
            v = mt.Next(0, verbs.Length - 1);
            ad = mt.Next(0, adjectives.Length - 1);

            return subjectives[s1] + "are" + adverbs[av] + verbs[v] + adjectives[ad] + subjectives[s2];

        }

    }
}
