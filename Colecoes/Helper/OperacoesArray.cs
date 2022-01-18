using System;

namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        //MÉTODO PARA ORDENAR ARRAY PELO BUBBLE SORT:
        public void OrdenarBubbleSort(ref int[] array) //ref = por referencia. não retorna um novo array, se trabalha com a mesma referencia do array original
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public void ImprimirArray(int[] array)
        {
            //SEGUNDO MÉTODO/OPÇÃO - IMPRIMIR EM UMA LINHA:
            var linha = string.Join(", ", array); //array vai ser transformado em linha, com elementos separados por virgulas
            System.Console.WriteLine(linha);


            //PRIMEIRO MÉTODO/OPÇÃO:
            /*
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i]);
            }*/
        }

        //ORDENANDO PELA CLASSE ARRAY, MÉTODO SORT:
        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }

        //COPIAR COM CLASSE ARRAY = Array.Copy:
        public void Copiar(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }

        //VERIFICANDO UM ELEMENTO EXISTENTE:
        public bool Existe(int[] array, int valor) //nao sera passado por referencia (ref array) pq nao iremos manipular o array, apenas o retornar existente ou não
        {
            return Array.Exists(array, elemento => elemento == valor); //elemento é como se fosse cada variavel do array, como o elemento atual de uma expressão for
        }

        //VERIFICANDO TODOS OS ELEMENTOS DO ARRAY (CONDICIONAL):
        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        //ENCONTRANDO UM ELEMENTO NO ARRAY E O RETORNANDO:
        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, element => element == valor);
        }

        //ENCONTRANDO O INDICE DE UM VALOR:
        public int ObterIndice(int[] array, int valor)
        {
            return Array.IndexOf(array, valor);
        }

        //REDIMENSIONANDO UM ARRAY:
        public void RedimensionarArray(ref int[] array, int novoTamanho)  //ref pq quero alterar meu array
        {
            Array.Resize(ref array, novoTamanho);
        }

        //CONVERTENDO UM ARRAY: (de int para string)
        public string[] ConverterParaArrayString(int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString()); //esta é uma conversão simples. Conversão de classe é mais complicado
        }
    }
}