using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace livrocsharp
{
    internal class funcoesTexto
    {
        static void Main(string[] args)
        {
             WriteLine("----Funções de Textos------");
             string empresa = "Microsoft Corporation  ";
             WriteLine("TRIM - retirar os espaços em branco ante e após a expressão");
             WriteLine($"Nome sem espaços: {empresa.Trim()}");
             WriteLine("Length - retonar a qtde de caracteres");
             WriteLine($"Tamanho do Texto:{empresa.Length}");
             empresa = empresa.Trim();
             WriteLine($"Tamanho do texto a após o TRIM():{empresa.Length}");
             WriteLine("ToUpper - Converte todos os caracteres para maiúsculo");
             WriteLine($"Converte para maiúsculo: {empresa.ToUpper()}");
             WriteLine("ToLower - converte todos os caracteres em minúsculo ");
             WriteLine($"Converte para minúsculo: {empresa.ToLower()}");

            var nomeUpper = "AIRTON SENNA";
            var nomeLower = "airton senna";
            //comparação 1
            if (nomeUpper == nomeLower)

                WriteLine("1 - nomes iguais");
            
            else
            
                WriteLine("1 - nomes diferentes");

            //comparação 2
            if (nomeUpper.ToLower() == nomeLower)

                WriteLine("2 - nomes iguais");
            else
                WriteLine("2 - nomes diferentes");
            //comparação 1
            if (nomeUpper.Equals(nomeLower, StringComparison.OrdinalIgnoreCase))
                WriteLine("3 - nomes iguais");
            else
                WriteLine("3 - nomes diferentes");
            WriteLine("Remove - extrai x caracteres a partir da esquerda da expressão");
            WriteLine($"Texto esquerdo: {empresa.Remove(9)}");
            WriteLine("Captura apenas o primeiro nome das pessoas");
            string[] nomes = {"Fabricio dos Santos","José da Silva","Roberta Brasil"};
            foreach(var n in nomes)
            {
                WriteLine($"{n.Remove(n.IndexOf(" "))}");
  
            }
            WriteLine("Replace - troca o conteúdo da  expressão");
            WriteLine($"texto atual: {empresa}");
            var novaEmpresa = empresa.
            Replace("Corporation", "Google");
            WriteLine($"texto trocado: {novaEmpresa}");
            WriteLine("Split - divide  e  extrai  cada  palavra  em um array");
            string NivelLivro = "Este livro é básico de C#.";
            string[] blocos = NivelLivro.Split(' ');
            var contador = 1;
            foreach (var exp in blocos)
            {
                WriteLine($"texto { contador++}: {exp}");
            }
            WriteLine($"Qtde de palavras: {blocos.Count()}");
            WriteLine("Substring é usado para extrair parte do texto");
            WriteLine(NivelLivro.Substring(5,14));
            string[] cesta = { "5 Laranjas", "10 Goiabas Vermelhas", "5 Pessegos doces", "5 Bananas" };
            foreach (var p in cesta)
            {
                WriteLine($"{p.Substring(p.IndexOf(" ")+1)}");

            };

            string[]cesta2 = { "5 Laranjas", "10 Goiabas vermelhas", "5 Pêssegos doces", "5 Bananas" };
            int qtde = 0;
            foreach (var p in cesta2)
            {
                // p.IndexOf(“ “) +1 retorna a posição inicial logo após o número
                // ex: 5 Laranjas = posição 1+1 = 2
                WriteLine($"{p.Substring(p.IndexOf(" ") + 1)}");
                // Ler apenas os números para somar na variável qtde
                qtde += Convert.ToInt32(p.Substring(0, p.IndexOf(" ")));
            }
            WriteLine($"Qtde total: {qtde:n0}");
            WriteLine("IsNullOrEmpty  verifica  se  a  string  está nula ou vazia");
            string nome = "Renato";
            string sobrenome = null;
            if (!String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(sobrenome))
            {
                WriteLine($"Nome completo:  {nome} {sobrenome}");
            }





        }
    }
}