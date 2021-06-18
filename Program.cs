using System;

namespace Eletrodomesticos
{
    class Program
    {
        static void Main(string[] args)
        {

            Televisao televisao1 = new Televisao();
            Televisao televisao2 = new Televisao();
            

            Fogao fogao1 = new Fogao();
            Fogao fogao2 = new Fogao();
            

            Lavadora lavadora1 = new Lavadora();
            Lavadora lavadora2 = new Lavadora();
            Lavadora lavadora3 = new Lavadora();


            Console.WriteLine("Super Promocao de Inverno");
            
            Console.WriteLine(string.Format("Lavadoura Cor {0}", lavadora1.Cor = "Cinza"));
            Console.WriteLine(string.Format("Capacidade {0}", lavadora1.Litros = 06));

            if (lavadora1.Litros > 10)
            {
                lavadora1.Secadora = true;
                Console.WriteLine("Com secadora Automatica");
            }
            else
            {
                lavadora1.Secadora = false;
            }
            Console.WriteLine("--------------------------------------------------------------------------");
            
            Console.WriteLine(string.Format("Marca {0}", lavadora2.Marca = "Eletronicos Ivan"));

            Console.WriteLine(string.Format("Lavadoura Cor {0}", lavadora2.Cor = "Azul"));
            Console.WriteLine(string.Format("Capacidade {0}", lavadora2.Litros = 25));

            if (lavadora2.Litros > 10)
            {
                lavadora2.Secadora = true;
                Console.WriteLine("Com secadora Automatica");
            }
            else
            {
                lavadora2.Secadora = false;
            }

            Console.WriteLine(string.Format("Marca {0}", lavadora1.Marca = "Eletronicos XPTO"));

            Console.WriteLine("--------------------------------------------------------------------------");

            Console.WriteLine(string.Format("Marca {0}", lavadora3.Marca = "Eletrolux"));

            Console.WriteLine(string.Format("Lavadoura Cor {0}", lavadora3.Cor = "Dourado"));
            Console.WriteLine(string.Format("Capacidade {0}", lavadora3.Litros = 5));

            if (lavadora3.Litros > 10)
            {
                lavadora3.Secadora = true;
                Console.WriteLine("Com secadora Automatica");
            }
            else
            {
                lavadora3.Secadora = false;
            }

            Console.WriteLine(string.Format("Marca {0}", lavadora1.Marca = "Eletronicos XPTO"));

            Console.WriteLine("--------------------------------------------------------------------------");

            Console.WriteLine(string.Format("Televisao Cor {0}", televisao1.Cor = "Dourado"));

            Console.WriteLine(string.Format("Polegadas {0}", televisao1.Polegadas = 40));
            
            Console.WriteLine(string.Format("Controle Remoto {0}", televisao1.ControleRemoto = false));

            Console.WriteLine("--------------------------------------------------------------------------");

            Console.WriteLine(string.Format("Televisao Cor {0}", televisao2.Cor));

            Console.WriteLine(string.Format("Polegadas {0}", televisao2.Polegadas));

            Console.WriteLine(string.Format("Controle Remoto {0}", televisao2.ControleRemoto));

            Console.WriteLine("--------------------------------------------------------------------------");

            Console.WriteLine(string.Format("Fogao Cor {0}", fogao1.Cor = "Laranja"));

            Console.WriteLine(string.Format("Bocas {0}", fogao1.Bocas = 4));

            Console.WriteLine(string.Format("Acendedor Automatico {0}", fogao1.AcendedorAutomatico));

            Console.WriteLine("--------------------------------------------------------------------------");

            Console.WriteLine(string.Format("Fogao Cor {0}", fogao1.Cor));

            Console.WriteLine(string.Format("Bocas {0}", fogao1.Bocas));

            Console.WriteLine(string.Format("Acendedor Automatico {0}", fogao1.AcendedorAutomatico = false));







        }
    }
}
