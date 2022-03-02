# CalculaJuros.Api

### Ferramentas utilizadas
Foi utilizado .NET Core 3.1, e xUnit para os testes. A IDE utilizada foi o Visual Studio 2022. Sistema Operacional utilizado foi Windows 10.

### Passos para rodar o projeto no visual studio
##### 1. Faça um clean e build do projeto Api
Clique com o botão direito na Solution e escolha a opção Clean. Depois, clique novamente com o botão direito na solution e escolha a opção Build. Caso não apresente erros pode passar para o próximo passo. Caso apresente erros, tente fazer os builds por projeto, um de cada vez, começando pela Models, depois pela Services e por fim pela API. Faça o mesmo com os projetos nas pastas testes.

##### 2. Rode o projeto CalculaJuros.Api
Rode o projeto clicando no botão Run do Visual Studio, escolhendo IIS Express como opção de Host.

##### 3. Rode a Api JurosApi (https://github.com/DDLibaneo/Juros.Api)
A regra da camada services é fazer uma requisição para a JurosApi. Rode este projeto tambem.

##### 4. Endpoints
Teste os Endpoints no Postman.

* Calcula Juros
  * Método: GET
  * Url exemplo: https://localhost/api/calculaJuros?valorInicial=100&meses=5
  
##### 5. Rodando os Testes
Para rodar os testes da Solução abra o test Explorer e clique em "Run all tests". Os projetos de teste são aqueles com o sufixo ".Tests".
