using System;
using System.Collections.Generic;

namespace carro_classes_c
{
    class Program
    {
        static void Main(string[] args)
        {
            CarroLista tudo = new CarroLista();
            CaractCarros carrocadastro = new CaractCarros();
            char resposta;

            Console.WriteLine("Qual a marca do teu carro?");
            carrocadastro.marca = Console.ReadLine();

            Console.WriteLine("qual a cor do teu carro?");
            carrocadastro.cor = Console.ReadLine();

            Console.WriteLine("qual o valor do carro?");
            carrocadastro.valor = Double.Parse(Console.ReadLine());

            Console.WriteLine("quer mesmo fazer o cadastro? s/n");
            resposta = Char.Parse(Console.ReadLine());

            if(resposta == 's'){

                TodoCarro();

            }
            if(resposta == 'n')
            {
                tudo.obrigado();
            }

        
        void TodoCarro()
        {
            Console.Write("o carro cadastrado é um(a) " +carrocadastro.marca); 
            Console.Write(" é da cor " +carrocadastro.cor);
            Console.Write(" que custa: " +carrocadastro.valor);
        }

        }
    }
}