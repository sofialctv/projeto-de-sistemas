package br.ifes.projetosistemas.calculadora.model.operation;

public class Multiplicar implements IOperation{

    public int calculate(int valor1, int valor2){
        return valor1 * valor2;
    }
}
