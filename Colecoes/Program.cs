using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ - consulta integrada a linguagem; é uma maneira de fazer operações nas coleções de modo padronizado utilizando cláusulas comuns de consulta(max, min, count....etc..)
            //sum e distinct:
            int[] arrayNumeros = new int[10] { 100, 1, 4, 0, 8, 15, 19, 19, 4, 100 };

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();

            System.Console.WriteLine($"Minimo: {minimo}");
            System.Console.WriteLine($"Máximo: {maximo}");
            System.Console.WriteLine($"Médio: {medio}");
            System.Console.WriteLine($"Soma: {soma}");
            System.Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
            System.Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");

            
            
            
            
            //valores min, max e medio:
            /*
            int[] arrayNumeros = new int[7] { 100, 1, 4, 0, 8, 15, 19 };

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();

            System.Console.WriteLine($"Minimo: {minimo}");
            System.Console.WriteLine($"Máximo: {maximo}");
            System.Console.WriteLine($"Médio: {medio}");
            */




            //obtendo e ordenando valores com LINQ
            //criando novo array com numeros pares:
            /*
            int[] arrayNumeros = new int[5] { 1, 4, 8, 15, 19 };

            var numerosParesQuery = 
                    from num in arrayNumeros
                    where num % 2 == 0
                    orderby num
                    select num;

            var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            System.Console.WriteLine("Números pares query: " + string.Join(", ", numerosParesQuery));
            System.Console.WriteLine("Números pares método: " + string.Join(", ", numerosParesMetodo));
            */


            //DICIONARIOS - acessando de maneira segura
            /*
            Dictionary<string, string> estados = new Dictionary<string, string>(); //<tipo da chave(que pode ser int também), tipo do valor>
           
            estados.Add("SP", "São Paulo");
            estados.Add("MG", "Minas Gerais");
            estados.Add("BA", "Bahia");

            foreach (KeyValuePair<string, string> item in estados) //KeyValuePair coleção de chaves e valores
            {
                //System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            string valorProcurado = "SC";
            
            //var teste = estados["SC"];

            if(estados.TryGetValue(valorProcurado, out string estadoEncontrado)) //TryGetValue não interrompe o programa caso de false / acessa valor sem vc ter certeza de que ele existe no seu dicionario 
            {
                System.Console.WriteLine(estadoEncontrado);                
            }
            else
            {
                System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
            }
            */




            //DICIONARIOS - removendo um valor:
            /*
            Dictionary<string, string> estados = new Dictionary<string, string>(); //<tipo da chave(que pode ser int também), tipo do valor>
           
            estados.Add("SP", "São Paulo");
            estados.Add("MG", "Minas Gerais");
            estados.Add("BA", "Bahia");

            foreach (KeyValuePair<string, string> item in estados) //KeyValuePair coleção de chaves e valores
            {
                System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            string valorProcurado = "BA";

            System.Console.WriteLine($"Removendo o valor: {valorProcurado}");

            estados.Remove(valorProcurado);

            foreach (KeyValuePair<string, string> item in estados) //KeyValuePair coleção de chaves e valores
            {
                System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }
            */







            //DICIONARIOS - atualizando um valor:
            /*
            Dictionary<string, string> estados = new Dictionary<string, string>(); //<tipo da chave(que pode ser int também), tipo do valor>
            estados.Add("SP", "São Paulo");
            estados.Add("MG", "Minas Gerais");
            estados.Add("BA", "Bahia");

            string valorProcurado = "BA";

            System.Console.WriteLine("Valor original:");
            System.Console.WriteLine(estados[valorProcurado]);

            estados[valorProcurado] = "BA - teste atualização";

            System.Console.WriteLine("Valor atualizado:");
            System.Console.WriteLine(estados[valorProcurado]);
            */




            //DICIONARIOS - acessando um valor: (tem que passar chave, e é retornado o valor)
            /*Dictionary<string, string> estados = new Dictionary<string, string>(); //<tipo da chave(que pode ser int também), tipo do valor>
            estados.Add("SP", "São Paulo");
            estados.Add("MG", "Minas Gerais");
            estados.Add("BA", "Bahia");

            string valorProcurado = "BA";
            System.Console.WriteLine(estados[valorProcurado]);
            */


            //DICIONARIOS: não podem ter chaves repetidas, mas valores sim
            /*
            Dictionary<string, string> estados = new Dictionary<string, string>(); //<tipo da chave(que pode ser int também), tipo do valor>
            estados.Add("SP", "São Paulo");
            estados.Add("MG", "Minas Gerais");
            estados.Add("BA", "Bahia");

            foreach (KeyValuePair<string, string> item in estados) //KeyValuePair coleção de chaves e valores
            {
                System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }
            */





            //PILHA
            /*
            Stack<string> pilhaLivros = new Stack<string>();

            pilhaLivros.Push(".NET");
            pilhaLivros.Push("DDD");
            pilhaLivros.Push("Código limpo");

            System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
            while (pilhaLivros.Count > 0)
            {
                System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}"); //Peek mostra o livro mas não o remove da pilha
                System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso"); //Pop obtem o ultimo livro e o remove da pilha
            }

            System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
            */





            //FILAS - First In First Out
            /*
            Queue<string> fila = new Queue<string>(); // ()é opção dar valores iniciais
            
            fila.Enqueue("Mariana"); //Enqueue add objeto no fim da fila
            fila.Enqueue("Bruno");
            fila.Enqueue("Mexirica");

            System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            while (fila.Count > 0)
            {
                System.Console.WriteLine($"Vez de: {fila.Peek()}"); //Peek retorna a pessoa que esta no começo da fila, mas não a remove
                System.Console.WriteLine($"{fila.Dequeue()} atendido"); //chamando a pessoa e retornando o proprio elemento. retorna o elemento ao mesmo tempo que o remove da fila
            }

            System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
            */



            //ADICIONANDO ELEMENTOS POR ÍNDICE
            /*
            OperacoesLista opLista = new OperacoesLista();
            List<string> estados = new List<string>() { "SP", "MG", "BA" };
            string[] estadosArray = new string[2] { "SC", "MT" };
            
            System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");
            
            opLista.ImprimirListaString(estados);

            estados.Insert(1, "RJ");
            opLista.ImprimirListaString(estados);
            */




            //ADICIONANDO COLEÇÕES NA LISTA
            /*
            OperacoesLista opLista = new OperacoesLista();
            List<string> estados = new List<string>() { "SP", "MG", "BA" }; //lista de string. não precisamos manipular seu tamanho, como fizemos com array. lista faz isso automaticamente
            string[] estadosArray = new string[2] { "SC", "MT" };
            
            System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");
            
            opLista.ImprimirListaString(estados);

            estados.AddRange(estadosArray);            
            opLista.ImprimirListaString(estados);
            */





            //REMOVENDO ELEMENTO DA LISTA
            /*
            OperacoesLista opLista = new OperacoesLista();
            List<string> estados = new List<string>(); //lista de string. não precisamos manipular seu tamanho, como fizemos com array. lista faz isso automaticamente
            estados.Add("SP");
            estados.Add("MG");
            estados.Add("BA");

            System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");
            
            opLista.ImprimirListaString(estados);

            System.Console.WriteLine("Removendo o elemento");
            estados.Remove("MG");
            
            opLista.ImprimirListaString(estados);
            */





            //DECLARANDO E ACESSANDO UMA LISTA
            /*
            List<string> estados = new List<string>(); //lista de string. não precisamos manipular seu tamanho, como fizemos com array. lista faz isso automaticamente
            estados.Add("SP");
            estados.Add("MG");
            estados.Add("BA");

            System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");
            
            foreach (var item in estados)
            {
                System.Console.WriteLine(item);
            }

            for (int i = 0; i < estados.Count; i++)
            {
                System.Console.WriteLine($"Índice {i}, Valor: {estados[i]}");
            }
            */





            //ARRAY:
            /*
            OperacoesArray op = new OperacoesArray();

            int[] array = new int[5] { 6, 3, 8, 1, 9 };
            int[] arrayCopia = new int[10]; //valor padrão dos elementos é 0.
            */




            //CONVERTENDO UM ARRAY:
            /*
            string[] arrayString = op.ConverterParaArrayString(array);
            //feito pelo debbug --> F5
            */




            //REDIMENSIONANDO UM ARRAY:
            /*
            System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

            op.RedimensionarArray(ref array, array.Length * 2);

            System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");
            */



            //ENCONTRANDO O INDICE DE UM VALOR
            /*
            int valorProcurado = 4;
            
            int indice = op.ObterIndice(array, valorProcurado);

            if(indice > -1) //-1 não é uma posição valida no array, por isso o valor não seria encontrado
            {
                System.Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indice);
                //System.Console.WriteLine($"O indice do elemento {valorProcurado} é: {indice}"); --> outra maneira de concatenar string com variavel (interpolação de string)
            }
            else
            {
                System.Console.WriteLine("Valor não existente no array");
            }
            */


            //ENCONTRANDO UM ELEMENTO NO ARRAY E O RETORNANDO:
            /*
            int valorProcurado = 15;

            int valorAchado = op.ObterValor(array, valorProcurado);

            if(valorAchado > 0)
            {
                System.Console.WriteLine("Encontrei o valor");
            }
            else
            {
                System.Console.WriteLine("Não encontrei o valor");
            }
            */





            //VERIFICANDO TODOS OS ELEMENTOS DO ARRAY (CONDICIONAL):
            /*
            int valorProcurado = 5;

            bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado); // (parâmetro array, verificando todos os valores do array)

            if(todosMaiorQue)
            {
                System.Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado);// "{0}" valor a ser substituido. não é o valor 0 em si. Só significa que será substituido pela variavel valorProcurado
            }
            else
            {
                System.Console.WriteLine("Existe valores que não são maiores do que {0}", valorProcurado);
            }
            */



            //VERIFICANDO UM ELEMENTO EXISTENTE:
            /*
            int valorProcurado = 10;
            bool existe = op.Existe(array, valorProcurado);

            if(existe)
            {
                System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            }
            else
            {
                System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
            }
            */





            //System.Console.WriteLine("Array original: ");
            //op.ImprimirArray(array);



            //COPIANDO PELA CLASSE ARRAY E MÉTODO COPY:
            /*
            System.Console.WriteLine("Array antes da cópia: ");
            op.ImprimirArray(arrayCopia);

            op.Copiar(ref array, ref arrayCopia);
            System.Console.WriteLine("Array após a cópia: ");
            op.ImprimirArray(arrayCopia);
            */




            //ORDENANDO COM CLASSE ARRAY E MÉTODO SORT = Array.Sort
            /*
            op.Ordenar(ref array);
            System.Console.WriteLine("Array ordenado: ");
            op.ImprimirArray(array);
            */




            //ORDENANDO POR BUBBLE SORT:
            /*
            op.OrdenarBubbleSort(ref array);
            System.Console.WriteLine("Array ordenado: ");
            op.ImprimirArray(array);
            */



            
            
            //PARTE 3
            /*
            int[,] matriz = new int[4, 2] //[linhas, colunas]
            {
                { 8, 8 }, 
                { 10, 20 },
                { 50, 100 },
                { 90, 200 }
            };

            for (int i = 0; i < matriz.GetLength(0); i++) // 1º FOR para percorrer as linhas
            {
                for (int j = 0; j < matriz.GetLength(1); j++) // 2º FOR para percorrer as colunas
                {
                    System.Console.WriteLine(matriz[i, j]);
                }    
            }

            //matriz[0, 0] = 5; //ex: quero que elemento na primeira coluna e primeira linha seja 5.
            */




            //PARTE 2
            // int[] arrayInteiros = new int[3]; //[capacidade máxima do array]
        
            // arrayInteiros[0] = 10; // [posição dentro do array onde que quero adicionar um valor (array na posição 0 recebe o valor de 10)]
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("30"); // int.Parse transforma string em int (mas só podem numeros nessa string)





            //PARTE 1
            // System.Console.WriteLine("Percorrendo array pelo for");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Percorrendo array pelo forEach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }        
        }
    }
}
