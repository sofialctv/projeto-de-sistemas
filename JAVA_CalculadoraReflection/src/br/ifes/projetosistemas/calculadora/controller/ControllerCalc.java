package br.ifes.projetosistemas.calculadora.controller;

import br.ifes.projetosistemas.calculadora.dto.RequestDTO;
import br.ifes.projetosistemas.calculadora.dto.ResponseDTO;
import br.ifes.projetosistemas.calculadora.model.operation.IOperation;
//import br.ifes.projetosistemas.calculadora.model.Calculadora;
//import br.ifes.projetosistemas.calculadora.model.CalcX;
//import br.ifes.projetosistemas.calculadora.model.ICalc;


public class ControllerCalc {

    public ResponseDTO calc(RequestDTO requestDTO) {
        try {
            String nomeIOperation = getOperationClassName(requestDTO.getOpcao());
            Class<?> classIOperation = Class.forName(nomeIOperation);

            IOperation instanciaOperation = (IOperation) classIOperation.getDeclaredConstructor().newInstance();

            int result = instanciaOperation.calculate(requestDTO.getValor1(), requestDTO.getValor2());

            return new ResponseDTO(result);
        } catch (Exception e) {
            e.printStackTrace();
            return new ResponseDTO(-1);
        }
    }

    private String getOperationClassName(int opcao) {
        return switch (opcao) {
            case 1 -> "br.ifes.projetosistemas.calculadora.model.operation.Somar";
            case 2 -> "br.ifes.projetosistemas.calculadora.model.operation.Subtrair";
            case 3 -> "br.ifes.projetosistemas.calculadora.model.operation.Multiplicar";
            case 4 -> "br.ifes.projetosistemas.calculadora.model.operation.Dividir";
            default -> "";
        };
    }
}

//        int result = 0;
//        ICalc calc = null;
//        if (requestDTO.getOpcao() == 1){
//            calc = new Calculadora();
//
//        }else {
//            calc = new CalcX();
//        }
//
//
//        IOperation operation = null;
//        switch (requestDTO.getOpcao()) {
//            case 1:
//                operation = new Somar();
//                break;
//            case 2:
//                operation = new Subtrair();
//                break;
//            case 3:
//                operation = new Multiplicar();
//                break;
//            case 4:
//                operation = new Dividir();
//                break;
//        }
//        result = calc.calculation(operation,requestDTO.getValor1(),requestDTO.getValor2());
//        return new ResponseDTO(result);
//
//    }
//}

