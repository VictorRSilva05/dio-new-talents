using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> ListaHistorico;
        private string Data;

        public Calculadora(string data)
        {
            ListaHistorico = new List<string>();
            Data = data;
        }
        public int Somar(int x, int y)
        {
            int res = x + y;
            ListaHistorico.Insert(0, "Res: " + res + " - data: " + Data);
            return res;
        }

        public int Subtrair(int x, int y)
        {
            int res = x - y;
            ListaHistorico.Insert(0, "Res: " + res + " - data: " + Data);
            return res;
        }

        public int Multiplicar(int x, int y)
        {
            int res = x * y;
            ListaHistorico.Insert(0, "Res: " + res + " - data: " + Data);
            return res;
        }

        public int Dividir(int x, int y)
        {
            int res = x / y;
            ListaHistorico.Insert(0, "Res: " + res + " - data: " + Data);
            return res;
        }

        public List<string> Historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }
    }
}