# 💼 Cálculo de Salário com Contratos em C#

Sistema em C# para cálculo de renda mensal de um funcionário com base em salário base e contratos por hora vinculados a um departamento.

## 📌 Sobre o projeto

Este projeto simula o cálculo de renda de um funcionário considerando:

- Um **salário base fixo**
- Múltiplos **contratos por hora (HourContract)**
- Um **departamento associado**
- Um **nível profissional (Junior, MidLevel, Senior)**

A renda final é calculada com base no mês e ano informados, somando o salário base com os contratos realizados naquele período.

---

## 🧱 Estrutura do projeto

O projeto é organizado utilizando conceitos de orientação a objetos:

```text
SalarioFuncionario/
│
├── Entities/
│   ├── Worker.cs
│   ├── Department.cs
│   ├── HourContract.cs
│   └── Enums/
│       └── WorkerLevel.cs
│
└── Program (Project.cs)
```

---

## 🧠 Modelagem

### 👤 Worker

Representa o funcionário:

- Nome  
- Nível (`WorkerLevel`)  
- Salário base  
- Departamento  
- Lista de contratos  

#### Métodos importantes:

- `AddContract()` → adiciona contrato  
- `Remove()` → remove contrato  
- `Income(year, month)` → calcula renda mensal  
- `returnDates()` → retorna string formatada com resultado  

---

### 📄 HourContract

Representa um contrato por hora:

- Data  
- Valor por hora  
- Quantidade de horas  

#### Método:

- `TotalValue()` → calcula valor total do contrato  

---

### 🏢 Department

Representa o departamento do funcionário:

- Nome  

---

### 📊 WorkerLevel (Enum)

Define o nível do funcionário:

```csharp
Junior
MidLevel
Senior
```

---

## ⚙️ Funcionamento

1. O usuário informa:  
   - Nome do departamento  
   - Dados do funcionário  
   - Nível profissional  
   - Salário base  

2. Em seguida, informa quantos contratos deseja cadastrar  

3. Para cada contrato:  
   - Data  
   - Valor por hora  
   - Quantidade de horas  

4. Por fim:  
   - Informa mês/ano (MM/YYYY)  
   - O sistema calcula a renda do período  

---

## ▶️ Como executar

### Pré-requisitos

- .NET SDK instalado  
https://dotnet.microsoft.com/download  

### Passos

```bash
git clone https://github.com/LuisGuilhermeCipriani/Salario-Funcionario-C-Sharp.git
cd Salario-Funcionario-C-Sharp
dotnet run
```

---

## 💻 Exemplo de execução

```text
Entre com o nome do departamento: Design
Entre com os dados do funcionário:
Nome: Alex
Nível (Junior/MidLevel/Senior): MidLevel
Salário base: 1200.00
Quantos contratos para este funcionário? 3

Entre com os dados do contrato #1
Data (DD/MM/YYYY): 20/08/2018
Valor por hora: 50.00
Duração (horas): 20.00

Entre com os dados do contrato #2
Data (DD/MM/YYYY): 13/06/2018
Valor por hora: 30.00
Duração (horas): 18

Entre com os dados do contrato #3
Data (DD/MM/YYYY): 25/08/2018
Valor por hora: 80.00
Duração (horas): 10

Entre com o mês e o ano para calcular o salário (MM/YYYY): 08/2018

Nome: Alex
Departamento: esign
Salário para 08/2018: 3000.00
```

---

## 🧩 Conceitos aplicados

- Programação Orientada a Objetos (POO)  
- Enumerações (`enum`)  
- Listas (`List<T>`)  
- Encapsulamento  
- Manipulação de datas (`DateTime`)  
- Cultura invariável (`CultureInfo.InvariantCulture`)  
- Entrada de dados via console  

---

## 🎯 Objetivo

Projeto desenvolvido para praticar:

- Modelagem de domínio em C#  
- Relacionamento entre classes  
- Cálculo baseado em dados filtrados por data  

---

## 👨‍💻 Autor

Luís Guilherme da Cunha Cipriani  
https://github.com/LuisGuilhermeCipriani  
