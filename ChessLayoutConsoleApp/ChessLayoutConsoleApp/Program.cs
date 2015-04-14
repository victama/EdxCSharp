using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLayoutConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is what your output should look like:
            // XOXOXOXO
            // OXOXOXOX
            // XOXOXOXO
            // OXOXOXOX
            // XOXOXOXO
            // OXOXOXOX
            // XOXOXOXO
            // OXOXOXOX

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    // 'X' appears on cells (1, 1),  (1, 3),  (2, 2), etc.
                    // In other words, the sum of that cell's line and column is even
                    // 'O' appears on odd sums
                    string cellContent = (i + j) % 2 == 0 ? "X" : "O";
                    Console.Write(cellContent);
                }
                // Line completed, to the next!
                Console.WriteLine();
            }

            // Wait for user key to be able to see output
            Console.ReadKey();
        }
    }
}
