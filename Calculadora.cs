using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> _ListaHistorico;
        private string _data;

        public Calculadora(string data)
        {
            _ListaHistorico = new List<string>();
            this._data = data;
        }
        public int somar(int val1, int val2) 
        {
            int resultado = val1 + val2;
            _ListaHistorico.Insert(0, "Resultado: " + resultado + " -data:" + _data);
            return resultado;
        }
        public int dividir(int val1, int val2)
        {
            int resultado = val1 / val2;
            _ListaHistorico.Insert(0, "Resultado: " + resultado + " -data:" + _data);
            return resultado;
        }
        public int multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;
            _ListaHistorico.Insert(0, "Resultado: " + resultado + " -data:" + _data);
            return resultado;
        }
        public int subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            _ListaHistorico.Insert(0, "Resultado: " + resultado + " -data:" + _data);
            return resultado;
        }
        public List<string> historico()
        {
            _ListaHistorico.RemoveRange(3 ,_ListaHistorico.Count - 3);
            return _ListaHistorico;
        }

    }
}
