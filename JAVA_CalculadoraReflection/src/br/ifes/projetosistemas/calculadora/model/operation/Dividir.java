package br.ifes.projetosistemas.calculadora.model.operation;

public class Dividir implements IOperation{

    public int calculate(int valor1, int valor2){
        if (valor2 == 0)  throw new ArithmeticException("Não é possível dividir por zero.");
        return valor1 / valor2;
    }
}
