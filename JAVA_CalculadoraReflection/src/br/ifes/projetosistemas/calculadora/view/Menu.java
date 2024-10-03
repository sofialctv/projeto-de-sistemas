package br.ifes.projetosistemas.calculadora.view;

import br.ifes.projetosistemas.calculadora.dto.RequestDTO;
import br.ifes.projetosistemas.calculadora.dto.ResponseDTO;

import java.util.Scanner;

public class Menu {

    public RequestDTO show(){
        Scanner input = new Scanner(System.in);
        System.out.println("#    JAVA  CALC    #");
        System.out.println("Escolha uma das opções:");
        System.out.println("1 - Somar");
        System.out.println("2 - Subtrair");
        System.out.println("3 - Multiplicar");
        System.out.println("4 - Dividir");
        System.out.println("5 - SAIR");

        int opcao = input.nextInt();

        System.out.println("Informe o primeiro valor:");
        int valor1 = input.nextInt();
        System.out.println("Informe o segundo valor:");
        int valor2 = input.nextInt();

        return new RequestDTO(opcao,valor1,valor2);

    }

    public void showResult(ResponseDTO responseDTO) {
        if (responseDTO.getResult() == -1) {
            System.out.println("Erro ao calcular.");
        } else {
            System.out.println(STR."O Resultado é: \{responseDTO.getResult()}");
        }
    }
}