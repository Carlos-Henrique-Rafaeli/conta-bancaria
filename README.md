# 💎 Conta Corrente 💳

## Demonstração

![](https://i.imgur.com/jpMKjeN.png)

## Introdução

Este é um aplicativo simples que simula as operações básicas de um banco.

## Funcionalidades

- **Saque de Dinheiro:** Permite retirar um valor da conta, descontando do saldo disponível.
- **Depósito de Dinheiro:** Adiciona um valor ao saldo da conta, registrando o movimento.
- **Transferência entre Contas:** Realiza a transferência de valores entre contas cadastradas no sistema.
- **Consulta do Extrato:** Verifica o saldo atual da conta e todas as transições tanto de crédito e débito feitos nela.

## Como utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Em seguida, compile a solução utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project ContaBancaria.ConsoleApp
```

6. Para executar o arquivo compilado, navegue até a pasta `./ContaBancaria.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
ContaBancaria.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.