﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUnitTest
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Subtrair(int num1, int num2);
    }
}
