using System;
using Trabalho;
using TrabalhoFluxoLoja;

Sistema s = new Sistema();

//s.InicializarSistema();

GerenciadorFretes.Estados();
Console.WriteLine("digite o estado que deseja consultar ");
int Frete = int.Parse(Console.ReadLine());
GerenciadorFretes.ConsultarFretePorId(Frete);