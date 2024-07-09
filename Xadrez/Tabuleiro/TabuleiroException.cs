using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xadrez.Tabuleiro
{
    public class TabuleiroException : Exception
    {

        public TabuleiroException(string message) : base(message)
        {

        }

    }
}