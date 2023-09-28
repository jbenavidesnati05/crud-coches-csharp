using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_carro
{
    internal class Concesionario
    {
        private Carro[] _carros;
        private int _limite;
        private int _numCarros;

        public Concesionario(int limite)
        {
            this._carros = new Carro[limite];
            _limite = limite;
            _numCarros = 0;
        }

        public void anadirCarro(Carro c) 
        {
            if (c != null && _numCarros < _carros.Length)
            {
                _carros[_numCarros] = c;
                _numCarros++;
            }
        }        
        public void mostrarCarro() 
        {
            for (int i = 0; i< _numCarros; i++) 
            {
                Console.WriteLine(_carros[i].ToString());
            }
        }        
        public void vaciarCarro() 
        {
            this._carros = new Carro[_limite];
            _numCarros = 0;
        }      
        public void eliminarCarro(Carro c) 
        {
            if (c != null && _numCarros != 0)
            {
                int posicion = -1;
                for (int i = 0; i < _numCarros; i++)
                {
                    if (c.id == _carros[i].id)
                    {
                      posicion = i;
                    }
                }
                if (posicion == -1)
                {
                    Console.WriteLine("el coche no existe");
                }
                else
                {
                    _carros[posicion] = null;
                    for (int i = posicion; i < _numCarros; i++) 
                    {
                        _carros[i] = _carros[i + 1];
                    }
                    _numCarros--;
                }

            }
            
        }
    }
}
