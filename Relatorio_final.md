# **RELATÓRIO TÉCNICO**

## Eixo 3 - Projeto: Desenvolvimento de Sistema para Redes de Computadores


**Integrantes do grupo:**

- Eric Gelmine A A Caldeira
- Gabriel de Oliveira Alves
- Pedro de Vasconcelos Cantão
- Charles Frederico N O Junior
- Lucas Emanuel
- Weverton de Oliveira



### Roteiro de instalação
   
Instalação baseada na distribuição Ubunto do Linux.

- Adicionar arquivo trocasenha.sh na pasta raiz do usuário.

- Instalar o .NET SDK
```
  sudo apt update
  sudo apt install -y
  dotnet-sdk-7.0
```
- Verificando a  versão da instalação:
```
  dotnet --version
```
- Criar o projeto ASP.NET Core
  
  - Criação da pasta 
```
  mkdir TrocaSenhaApi
  cd TrocaSenhaApi
```

  - Inicialização 
```
  dotnet new web -o TrocaSenhaApi
```

  - Adicionar o código no arquivo Program.cs
```
  nano Program.cs
```	
  - Compilar o projeto
    
  - verificar se há algum erro
```
  dotnet build
```
  - Executar
```
  dotnet run
```
- Resultado da execução do código:
  
![image](https://github.com/user-attachments/assets/e18af29f-acca-4d84-9078-05b1808a0721)

- Utilização da URL
  
  - Ela irá ser utilizada num Front end com execução em javascript chamando esse URL e interagindo com a API para executar o comando.
  - A API interage com o arquivo shellscript que, por fim, realiza o comando no servidor para realizar a troca de senha no Linux.
  - É requisito que o usuário já esteja criado, pois o objetivo é somente a troca de senha.
  - URL usada nos testes deve ser alterada de acordo com aporta gerada ao executar o comando dotnet run.
  - Exemplo: http://localhost:5098/trocasenha/user/123456789


2. Registro de Reunião com o Cliente

Na reunião, se faz presente o Felipe Vaz, representando da empresa Corporativa Telecomunicações para apresentação do projeto, e como realizar a instalação.

  ![Reuniao](https://github.com/user-attachments/assets/d5d0d096-ce25-44f6-928e-8586ed32d1f7)

3. Avaliação do impacto do produto desenvolvido na empresa
   
	O produto desenvolvido irá revolucionar a forma como os funcionários técnicos da empresa, que tem acesso aos equipamentos de rede, poderão trocar a senha dos seus acessos, havendo maior liberdade e segurança na alteração de senha, visto que, anteriormente, teria que solicitar a troca de senha e receber de volta uma senha aleatória. A liberdade gerada para realizar essa troca de senha também alvo de investimento tecnológico, uma visão condizente com a da empresa.

4. Avaliação do impacto do projeto na formação do discente
 - Ao reunir com o grupo do projeto, foram destacados pontos como:
 
   - Experiencia parecida com a de um time de projetos de desenvolvimento.
   - Ganho de conhecimento de diversas línguas de programação
   - Estabelecimento de técnicas de pesquisa de ferramentas.
   - Aumento de visão empreendedora ao tratar com uma empresa real
	
