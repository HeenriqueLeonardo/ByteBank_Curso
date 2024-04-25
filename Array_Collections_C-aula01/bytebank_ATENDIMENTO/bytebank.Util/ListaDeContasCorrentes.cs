﻿using bytebank.Modelos.Conta;
namespace bytebank_ATENDIMENTO.bytebank.Util;
public class ListaDeContasCorrentes
{
    private ContaCorrente[] itens = null;
    private int proximaPosicao=0;

    public ListaDeContasCorrentes(int tamanhoInicial = 5)
    {
        itens = new ContaCorrente[tamanhoInicial];
    }

    public void Adicionar(ContaCorrente item)
    {
        VerificarCapacidadeArray(proximaPosicao + 1);
        Console.WriteLine($"Adicionando item na posicao {proximaPosicao}");
        itens[proximaPosicao] = item;
        proximaPosicao++;
    }

    private void VerificarCapacidadeArray(int tamanhoNecessario)
    {
        if(itens.Length >= tamanhoNecessario)
        {
            return;
        }
        Console.WriteLine("Aumentando a capacidade da lista!");
        ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

        for (int i = 0; i < itens.Length; i++)
        {
            novoArray[i] = itens[i];
        }
        itens = novoArray;
        
    }
    public void Remover(ContaCorrente item)
    {
        int indiceItem = -1;
        for (int i = 0; i < proximaPosicao; i++)
        {
            ContaCorrente contaAtual = itens[i];
            if (contaAtual == conta)
            {
                indiceItem = i;
                break;
            }
        }
        // 0         1       2
        //[conta1][conta2][conta4][conta5][null]
        for (int i = indiceItem; i < proximaPosicao - 1; i++)
        {
            itens[i] = itens[i + 1];
        }
        proximaPosicao--;
        itens[proximaPosicao] = null;
    }


}
