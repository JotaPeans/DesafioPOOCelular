using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOOCelular.Models.Abstract;

namespace DesafioPOOCelular.Models
{
    public class Nokia : SmartPhone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}

        public override void InstalarAplicativo(string nome) {
            Console.WriteLine($"Aplicativo {nome} instalado com sucesso no Nokia!");
        }
    }
}