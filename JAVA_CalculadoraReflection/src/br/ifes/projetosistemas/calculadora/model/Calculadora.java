package br.ifes.projetosistemas.calculadora.model;

import br.ifes.projetosistemas.calculadora.model.operation.IOperation;

public class Calculadora implements ICalc{

    public int calculation (IOperation operation, int value1, int value2){

        return operation.calculate(value1,value2);
    }

}
