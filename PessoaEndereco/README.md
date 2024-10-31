# Crie uma API usando Minimal API e MVC

Crie um API para cadastrar uma pessoa (Nome, Idade e email) e seus endere�os (Logradouro, n�mero, estado (UF), cidade e Bairro). Uma pessoa pode ter mais de um endere�o. A API deve ter um rota para cadastrar Pessoa e outra para Endere�o. Ao cadastrar o Endere�o deve ser enviado o ID da pessoa e ao listar uma pessoa, a API deve trazer os dados da pessoa e a lista de endere�o. 

## Estrutura
- Context: para armazenar l�gica do banco de dados em mem�ria. � aqui onde defino o relacionamento entre as entidades

- Controllers: Respons�vel por processar as requisi��es, manipular os dados do modelo, e passar os dados necess�rios para a View

- Models: Armazena as classes que modelam as entidades. Dados e Regras de Neg�cio

https://www.macoratti.net/14/04/mvc_crud.htm