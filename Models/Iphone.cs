using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOOCelular.Models.Abstract;

namespace DesafioPOOCelular.Models
{
    public class Iphone : SmartPhone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}

        public override void InstalarAplicativo(string nome) {
            Console.WriteLine($"Aplicativo {nome} instalado com sucesso no Iphone!");
        }
    }
}