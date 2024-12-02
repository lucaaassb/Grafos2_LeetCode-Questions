using System;
using System.Collections.Generic;

public class Solution
{
    public IList<int> GrayCode(int n)
    {
        var resultado = new List<int>();
        int tamanho = 1 << n; // 2^n
        for (int i = 0; i < tamanho; i++)
        {
            resultado.Add(i ^ (i >> 1)); // Gera o código de Gray
        }
        return resultado;
    }
}