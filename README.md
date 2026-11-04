# Sistema de Transferência de Dinheiro

Aplicação de console desenvolvida em C# para simular transferências de dinheiro entre usuários. O projeto foi criado com o objetivo de praticar os fundamentos da Programação Orientada a Objetos (POO), incluindo modelagem de classes, encapsulamento, manipulação de objetos e validação de entradas do usuário.

## Funcionalidades

- Consulta de saldo dos usuários em tempo real.
- Transferência de valores entre usuários.
- Validação de saldo insuficiente.
- Validação de entradas utilizando `int.TryParse()`.
- Tratamento de valores inválidos.
- Atualização automática dos saldos após cada operação.

## Tecnologias Utilizadas

- C#
- .NET
- Console Application

## Estrutura do Projeto

### Classe `Guy`

Representa um usuário do sistema e contém:

- Nome
- Saldo disponível
- Método para exibir informações (`WriteMyInfo`)
- Método para envio de dinheiro (`GiveCash`)
- Método para recebimento de dinheiro (`ReceiveCash`)

### Fluxo da Aplicação

1. Exibição dos usuários e seus respectivos saldos.
2. Solicitação do valor da transferência.
3. Validação da entrada informada pelo usuário.
4. Seleção do remetente.
5. Transferência do valor entre os objetos.
6. Atualização e exibição dos novos saldos.

## Conceitos Aplicados

- Programação Orientada a Objetos (POO)
- Classes e Objetos
- Propriedades
- Métodos
- Encapsulamento
- Estruturas condicionais (`if`, `else`)
- Estruturas de repetição (`while`)
- Tratamento e validação de entrada de dados
- Conversão segura de tipos com `int.TryParse()`

## Objetivo

Este projeto faz parte da minha jornada de aprendizado em C# e .NET, com foco no desenvolvimento de uma base sólida em lógica de programação e Programação Orientada a Objetos.

## Autor

Jonathan Garica Oliveira

LinkedIn: [(https://www.linkedin.com/in/jonathan-garcia-2b5090284/)]  
GitHub: [(https://github.com/programasJG15/C-)]

