﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoNoPlano
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 600, L = 800;

            Console.Write("Digite X inicial: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite Y inicial: ");
            int y = int.Parse(Console.ReadLine());

            Objeto2D obj = new Objeto2D();
            obj.x = x;
            obj.y = y;

            Console.Write("Digite comando: ");
            ConsoleKey direcao = Console.ReadKey().Key;
            while (direcao != ConsoleKey.Escape)
            {
                if (direcao == ConsoleKey.RightArrow)
                {
                    obj.AndarParaDireita();
                    Console.WriteLine(obj.Coordenadas());
                }
                if (direcao == ConsoleKey.LeftArrow)
                {
                    obj.AndarParaEsquerda();
                    Console.WriteLine(obj.Coordenadas());
                }
                if (direcao == ConsoleKey.UpArrow)
                {
                    obj.AndarParaCima();
                    Console.WriteLine(obj.Coordenadas());
                }
                if (direcao == ConsoleKey.DownArrow)
                {
                    obj.AndarParaBaixo();
                    Console.WriteLine(obj.Coordenadas());
                }

                Console.Write("Digite comando: ");
                direcao = Console.ReadKey().Key;
            }
        }
    }
}