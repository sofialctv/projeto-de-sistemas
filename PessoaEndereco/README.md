# Crie uma API usando Minimal API e MVC

Crie um API para cadastrar uma pessoa (Nome, Idade e email) e seus endereços (Logradouro, número, estado (UF), cidade e Bairro). Uma pessoa pode ter mais de um endereço. A API deve ter um rota para cadastrar Pessoa e outra para Endereço. Ao cadastrar o Endereço deve ser enviado o ID da pessoa e ao listar uma pessoa, a API deve trazer os dados da pessoa e a lista de endereço. 

## Estrutura
- Context: para armazenar lógica do banco de dados em memória. É aqui onde defino o relacionamento entre as entidades

- Controllers: Responsável por processar as requisições, manipular os dados do modelo, e passar os dados necessários para a View

- Models: Armazena as classes que modelam as entidades. Dados e Regras de Negócio

https://www.macoratti.net/14/04/mvc_crud.htm