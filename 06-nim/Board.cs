using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_nim
{
    /// <summary>
    /// Keeps track of all of the pieces in play.
    /// 
    /// Stereotype:
    ///     Information Holder
    /// </summary>
    class Board
    {
        // TODO: Declare any member variables here.
        List<int> _piles = new List<int>();
        int _pileCount;
        Random rnd = new Random();
        /// <summary>
        /// Initialize the Board
        /// </summary>
        public Board()
        {
            Prepare();
        }

        /// <summary>
        /// A helper method that sets up the board in a new random state.
        /// This could be called by the constructor, or if it is desired
        /// to play again.
        /// 
        /// It should have 2-5 piles with 1-9 stones in each.
        /// </summary>
        private void Prepare()
        {
            _pileCount = rnd.Next(2,5);
            for (int i = 0; i <= _pileCount; i++)
            {
                _piles.Add(rnd.Next(1,9));
            }
            // throw new NotImplementedException();
        }
        public void FireWorks()
        {
            Console.WriteLine(
            "      )  \n",
            "      (  \n",
            "    .-`-.\n",
            "    :   :\n",
            "    :TNT:\n",
            "    :___:");
            Task.Delay(100);
            Console.WriteLine(
            "      |/ \n",
            "    - o -\n",
            "    /-`-.\n",
            "    :   :\n",
            "    :TNT:\n",
            "    :___:\n");
            Task.Delay(100);
            Console.WriteLine(
            "    .---.\n",
            "    : | :\n",
            "    :-o-:\n",
            "    :_|_:");
            Task.Delay(100);
            Console.WriteLine(
            "    .---.\n",
            "    ( |/)\n",
            "    --0--\n",
            "    (/| )");
            Task.Delay(100);
            Console.WriteLine(
            "   '.`|/.'\n",
            "   (`   /)\n",
            "   - -O- -\n",
            "   (/   `)\n",
            "   ,'/|`'.");
            Task.Delay(100);
            Console.WriteLine(
            "'.  ` | /  ,'\n",
            "  `. `.' ,'\n",
            " ( .`.|,' .)\n",
            " - ~ -0- ~ -\n",
            " ( ','|'. `)\n",
            "  .' .'. '.\n",
            ",'  / | `  '.");
        }

        /// <summary>
        /// Applies this move by removing the number of stones
        /// from the pile specified in the move.
        /// </summary>
        /// <param name="move">Contains the pile and the number of stones</param>
        public void Apply(Move move)
        {
            int movePileNumber = move.GetPile();
            int stonesToRemove = move.GetStones();
            int _newPileNumber = _piles[movePileNumber] - stonesToRemove;
            _piles[movePileNumber] = _newPileNumber;
            // throw new NotImplementedException();            
        }

        /// <summary>
        /// Indicates if the board is empty (no more stones)
        /// </summary>
        /// <returns>True, if there are no more stones</returns>
        public bool IsEmpty()
        {
            int _rockSum = 0;
            bool _empty = false;
            for (int s = 0; s <= _pileCount; s++)
            {
                _rockSum += _piles[s];

            }
            if(_rockSum == 0 || _rockSum < 0)
            {
                _empty = true;
            }
            return _empty;
            // throw new NotImplementedException();
        }

        /// <summary>
        /// Get's a string representation of the board in the format:
        /// 
        /// --------------------
        /// 0: O O O O O O 
        /// 1: O O O O O O O
        /// 2: O O O O O O O O 
        /// 3: O O O O 
        /// --------------------
        /// </summary>
        /// <returns>The string representation.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string bars = "--------------------";
            for (int u = 0; u <= _pileCount + 2; u++)
            {
                if (u == 0 || u == _pileCount +2)
                {
                    sb.Append($"{bars} \n");
                }
                else if (u >= 1 || u <= _pileCount + 1)
                {
                    sb.Append($"{GetTextForPile(u - 1, _piles[u - 1])} \n");
                    // GetTextForPile(u, _piles[u]));
                }
            }
            return sb.ToString();
            // throw new NotImplementedException();
        }

        /// <summary>
        /// A helper function that is used by the general ToString method.
        /// This one gets the text for a specific pile in the format:
        /// 
        /// 2: O O O O O O O O 
        /// 
        /// </summary>
        /// <param name="pileNumber">The pile number to display at the front of the line.</param>
        /// <param name="stones">The number of stones in the pile</param>
        /// <returns></returns>
        private string GetTextForPile(int pileNumber, int stones)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{pileNumber}: ");
            for (int o = 1; o <= stones; o++)
            {
                sb.Append("O ");
            }
            
            return sb.ToString();
        }
    }
}
