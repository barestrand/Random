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
        string[] adjectives, verbs, subjectives, adverbs;

        gibRandPlox()
        {
            rnd = new Random();

            //Prepare all stuff
            #region lotsAstuff

            adjectives = new string[]{ "American",
                                        "French",
                                        "Japanese"};

            #endregion


        }

        int gibRand(int max)
        {
            //Just return a random number.
            return rnd.Next(1,max);
        }

        string gibText()
        {
            /*
             * This function constructs a sentence from the adjectives and stuff.
             */

        }

    }
}
