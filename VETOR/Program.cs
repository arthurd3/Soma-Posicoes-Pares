// Escreva um programa que leia um vetor de 15 números inteiros e exiba ao final apenas os números que estão armazenados nas posições pares do vetor.
using System;

class Vetor{

    static int[] lerVet (int[] vet , int i){

        while(i < vet.Length){
            Console.WriteLine($"Digite Um Numero : {i +1} / {vet.Length}");
            vet[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }
        return vet;
    }
    static void ImprimirVet (int[] vet ){

        for (int i = 0 ; i < vet.Length ; i++){
            Console.WriteLine($"Vetor Preenchido : {vet[i],15} | {i+1,12}/{vet.Length}");
        }

    }

    static void Main(string[] args)
    {
        
        int[] num = new int[15];
        int i=0;

        lerVet(num , i);
        ImprimirVet(num);

    }



}