using System;
using System.Collections.Generic;
using System.Text;

namespace MangaShopSolution.Utilities.Exceptions
{
    public class MangaShopException : Exception
{
    public MangaShopException()
    {
    }

    public MangaShopException(string message)
        : base(message)
    {
    }

    public MangaShopException(string message, Exception inner)
        : base(message, inner)
    {
    }


    }
}
