﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary 
{
    public interface IClassLibrary
    {
        char[,] BoardSize();
        bool WinCondition();
    }
}
