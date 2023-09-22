using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOOCelular.Models;

namespace DesafioPOOCelular
{
    public class Program
    {
        public static void Main() {
            Iphone iphone = new("81999999999", "15 Pro", "10923801923812", 128);
            Nokia nokia = new("81999999991", "23", "10923812323812", 16);

            iphone.InstalarAplicativo("Instagram");
            nokia.InstalarAplicativo("Avast");
            iphone.Ligar();
            nokia.ReceberLigacao();
        }
    }
}