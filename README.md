# 📚 Sistema Genérico de Cadastro em C#

## 🧾 Descrição

Este projeto consiste no desenvolvimento de um sistema de cadastro genérico utilizando a linguagem C#. A proposta é implementar uma aplicação simples, porém funcional, que permita armazenar e gerenciar diferentes tipos de dados de forma reutilizável, por meio do uso de genéricos.

O sistema foi construído com foco na aplicação de conceitos fundamentais da programação, incluindo estruturas de dados, organização em classes, uso de métodos e controle de fluxo. A utilização de uma classe genérica torna o sistema flexível, permitindo o cadastro de qualquer tipo de objeto, como pessoas, produtos ou outros modelos definidos pelo usuário.

A aplicação funciona via console e oferece um menu interativo que possibilita realizar operações básicas de um CRUD simplificado:
- Adicionar novos registros
- Listar todos os dados cadastrados
- Buscar informações específicas por identificador
- Remover registros existentes

Internamente, os dados são armazenados utilizando um `Dictionary<int, T>`, onde o identificador numérico é utilizado como chave e o objeto genérico como valor.

Este projeto tem como principal objetivo consolidar o entendimento sobre:
- Classes genéricas
- Estruturas de dados (`List` e `Dictionary`)
- Métodos e organização de código
- Estruturas de repetição (`while`)
- Estruturas condicionais (`switch`)
- Construção de menus interativos em aplicações de console

Trata-se de uma implementação simples, voltada para fins educacionais, mas que pode servir como base para sistemas mais complexos no futuro.
