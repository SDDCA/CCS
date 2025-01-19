# CCO_Customer-Control-System

Este projeto é um sistema desenvolvido em C# para controle de clientes, permitindo o cadastro e manipulação de informações, bem como o cálculo de impostos com base no tipo de cliente.

## Funcionalidades

- Cadastro de clientes diferenciados em **Pessoa Física** e **Pessoa Jurídica**.
- Solicitação de dados relevantes, como nome, endereço, CPF/CNPJ, RG/IE.
- Cálculo de impostos baseados no valor da compra e no tipo de cliente.

## Estrutura do Projeto

O sistema é composto pelas seguintes classes, organizadas em arquivos separados:

1. **Clientes.cs**  
   - Classe base que representa as propriedades comuns a todos os clientes:
     - `nome`
     - `endereco`
   - Método: `Pagar_Imposto` (definido para ser sobrescrito pelas classes derivadas).

2. **Pessoa_Fisica.cs**  
   - Deriva da classe `Clientes` e adiciona:
     - Propriedades:
       - `cpf`
       - `rg`.

3. **Pessoa_Juridica.cs**  
   - Deriva da classe `Clientes` e adiciona:
     - Propriedades:
       - `cnpj`
       - `ie`.

4. **Program.cs**  
   - Ponto de entrada do sistema:
     - Gerencia a interação com o usuário.
     - Instancia as classes de acordo com o tipo de cliente selecionado.
     - Exibe o resultado do cálculo de impostos.

## Como Executar

1. Certifique-se de que o [SDK do .NET](https://dotnet.microsoft.com/) está instalado.
2. Clone este repositório:
   ```bash
   git clone https://github.com/SDDCA/CCS.git
3. Navegue até a pasta do projeto
4. Compile e execute o projeto

Exemplo de Uso
Ao executar o programa, você será solicitado a fornecer as seguintes informações:

Nome
Endereço
Tipo de cliente (Pessoa Física ou Jurídica)
CPF ou CNPJ, RG ou IE
Valor da compra
O sistema então calculará e exibirá o imposto com base no tipo de cliente.


