package br.ifes.projetosistemas.calculadora.dto;

public class RequestDTO {
    private int opcao;
    private int valor1;
    private int valor2;

    public RequestDTO(int opcao, int valor1, int valor2) {
        this.opcao = opcao;
        this.valor1 = valor1;
        this.valor2 = valor2;
    }

    public int getOpcao() {
        return opcao;
    }

    public int getValor1() {
        return valor1;
    }

    public int getValor2() {
        return valor2;
    }
}
