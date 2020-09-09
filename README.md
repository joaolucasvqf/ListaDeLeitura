# ListaDeLeitura

## Este projeto consiste em uma lista de leitura, a que é integrada à API do GoogleBooks, permitindo que seja realizada uma busca por títulos e então armazenados os dados em uma base local.

### Tecnologias utilizadas:
- .Net Cores 3.1
    -NET Core é um framework livre e de código aberto para os sistemas operacionais Windows, Linux e macOS. É um sucessor de código aberto do .NET Framework. O projeto é desenvolvido principalmente pela Microsoft e lançado com a Licença MIT.
- Angular 8
    - Angular é uma plataforma de aplicações web de código-fonte aberto e front-end baseado em TypeScript liderado pela Equipe Angular do Google e por uma comunidade de indivíduos e corporações. Angular é uma reescrita completa do AngularJS, feito pela mesma equipe que o construiu.
- PostgreSQL
    - PostgreSQL é um sistema gerenciador de banco de dados objeto relacional, desenvolvido como projeto de código aberto.
    - Hoje, o PostgreSQL é um dos SGBDs (Sistema Gerenciador de Bancos de Dados) de código aberto mais avançados.
- Entity Framework Core
    - O EF (Entity Framework) Core é uma versão leve, extensível, de software livre e multiplataforma da popular tecnologia de acesso a dados do Entity Framework.
    - O EF Core pode servir como um ORM (Mapeador de Objeto Relacional), permitindo que os desenvolvedores de .NET trabalhem com um banco de dados usando objetos do .NET e eliminando a necessidade de grande parte do código de acesso aos dados que eles geralmente precisam escrever.

### Requisitos para a compilação do projeto:
- possuir .Net Core 3.1 SDK instalado na máquina local.
    > https://dotnet.microsoft.com/download 
- Possuir PostgreSQL na versão 10 ou superior instalado na máquina.
    > https://www.postgresql.org/download/
- Possuir o NodeJS instalado na máquina, com o NPM configurado.
    > https://nodejs.org/en/download/ 
- Possuir instalada a IDE do visual studio ou semelhante.
    > https://visualstudio.microsoft.com/pt-br/vs/ 

### Instruções para a execução do projeto:
- Abrir a IDE do Visual Studio
- Acessar o menu Ferramentas -> Gerenciador de Pacotes do NuGet -> Console do Gerenciador de Pacotes
Inserir o comando Update-Database para a criação do banco de dados.
- Após a conclusão, executar o projeto através do IIS Express
- Após inicializar o projeto, a página inicial será aberta em uma aba do navegador.

### Dificuldades encontradas:
- Falta de familiaridade com o desenvolvimento do front-end  devido ao foco atual da função que exerço na empresa atual, que está direcionado à criação de Api’s, levando à perda das habilidades práticas.

### Facilidades encontradas:
- Grande familiaridade com o ambiente de desenvolvimento.
- Prática na construção de Api’s e WebServices.
- Fácil compreensão dos requisitos.

### Horas gastas durante o desenvolvimento:
- Total: 8h 
    - 1h - Configuração do ambiente.
    - 3h - Criação da API com seus endpoints e entidades
    - 4h - Criação do Front-End  e comunicação com a API.
