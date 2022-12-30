using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTutorial.BinaryConvertionOfNumber.Operation
{
    /// <summary>
    /// Class has its own method to take int number as parameter
    /// </summary>
    internal class ConvertNumberToBinary
    {
        /// <summary>
        /// Send a number to convert its binary representation
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string ConvertNumberToBinaryRepresentation(int number)
        {
            return Convert.ToString(number, 2);
        }

        public int GetCountOfZerosInString(string binaryRep)
        {
            return binaryRep.Count(c => c == '0');
        }

        public int GetCountOfOnesInString(string binaryRep)
        {
            return binaryRep.Count(c => c == '1');
        }

    }
}
