// See https://aka.ms/new-console-template for more information


using Entity;
using System;

namespace FactoryMethod // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fabrica fabrica = new Fabrica();
            fabrica.GetConexion("oracle").Conectar();
        }
    }
}
