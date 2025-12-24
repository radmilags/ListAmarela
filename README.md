# 📞 ListAmarela

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET 8](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Status](https://img.shields.io/badge/Status-Refactoring-orange?style=for-the-badge)

> **"Onde quem precisa encontra quem faz."**

Uma aplicação de console em **C#** inspirada nas clássicas listas telefônicas amarelas dos anos 90. O sistema conecta prestadores de serviços a clientes, permitindo cadastro, busca e gerenciamento de serviços via terminal.

---

## 🚀 Sobre o Projeto

Este projeto foi desenvolvido inicialmente como atividade acadêmica para consolidar conceitos de **Programação Orientada a Objetos (POO)** e agora está em processo de **Refatoração para Clean Architecture**.

O diferencial técnico é a **Persistência de Dados em XML** feita "na unha" (sem banco de dados relacional), demonstrando domínio sobre manipulação de arquivos e serialização em C#.

---

## 🛠️ Tecnologias e Conceitos

* **Linguagem:** C# (.NET 8.0)
* **Arquitetura:** Evoluindo para MVC/Layered Architecture (Separação de Services e Models).
* **Dados:** Serialização e Deserialização XML (`System.Xml.Serialization`).
* **Conceitos Aplicados:**
    * CRUD Completo (Create, Read, Update, Delete).
    * Manipulação de Listas e LINQ.
    * Tratamento de Exceções.
    * Clean Code (Refatoração em andamento).

---

## 📂 Estrutura do Projeto

A organização de pastas segue um padrão intuitivo:

```text
src/
├── Services/       # Lógica de negócio (Regras de cadastro, validação)
├── Models/         # (Em breve) Classes de Entidade (Cliente, Prestador)
├── persistencia.cs # Motor de gravação XML genérico
└── Program.cs      # Interface de Usuário (Console) e Menu
docs/               # Documentação funcional e diagramas UML