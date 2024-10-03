package br.ifes.projetosistemas.calculadora.dto;

public class ResponseDTO {
    private int result;

    public ResponseDTO(int result) {
        this.result = result;
    }

    public int getResult() {
        return result;
    }
}
