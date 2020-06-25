using System;

namespace Aula25Fibonacci
{
    public class Fibonacci
    {

        // Exemplo para gerar uma sequencia Fibonacci começando de um valor, intervalo especifico e quantidade de repetiçoes

        public void SequenciaFibonacci(int numero1, int numero2, int repeticao)
        {
            //condiçao obrigatoria para a recursividade do método

            if(repeticao >= 0){
                System.Console.WriteLine(numero1);
                SequenciaFibonacci(numero2, numero1 + numero2, repeticao - 1);
            }
        }


        //exemplo Fatorial
        // 5! = 5 * 4 * 3 * 2 * 1

        public int GerarFatorial(int numero){

            //condiçao para quebrar a recursividade do método
            if(numero == 1){
                return 1;
            }else{
                return numero = GerarFatorial(numero -1);
            }
        }











    }
}