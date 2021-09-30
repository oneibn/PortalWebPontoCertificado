# PortalWebPontoCertificado

 Desafio 1 - para a Ponto Certificado - Stefanini
 Portal Web para cadastro de Funcionários
 
 Algumas ideias minhas para melhorar no projeto:

 - Otimizar o sistema de buscas para ele verificar automáticamente se é CPF ou Nome;
 - Colocar scripts para forçar a formatação desejada nos campos de cadastro e edição, tentei adicionar uma biblioteca jquerry pra isso, mas não obtive sucesso na implementação;
 - Utilizar um sistema banco de dados com menos limitações e mais desenvolvido, como MariaDB (ou MySQL), SQLServer, PostgreSQL, Oracle...;
 - Criar um model para um sistema de busca avançado;
 - Utilizar listas suspensas ou inputs do tipo "radio" para cadastrar/editar informações universais e pré-definidas;
 
 
 Algumas considerações sobre a experiência e o código:

 - Foi meu primeiro contato com programação para .NET Core e .NET no geral;
 - O portal foi gerado com os parâmetros "mvc auth -Individual", para gerar automaticamente referências para o banco de dados, o arquivo de contexto e os modelos das "Migrations";
 - O sistema de Banco de Dados utilizado foi o "SQLite" no arquivo "app.db" encontrado na pasta raiz do portal, por isso apresenta certas limitações e restrições, porém, como rodei e testei em Sistemas Operacionais diferentes (Windows e Linux), optei por essa forma para evitar eventuais bugs ou problemas de importação dos scripts do banco de dados;
 - O mecanismo de buscas está funcional, porém, deve-se selecionar o botão "RADIO" correspondente a informação antes de filtrar, e como dito antes, devido ao banco de dados, há diferenciação entre letras maiúsculas e minúsculas, no caso de CPF precisa ser escrito inteiro e no padrão que foi cadastrado (com pontos e traço ou sem);
 - A página de exibição de gastos apresenta uma tabela com dados de identificação dos funcionários e seus respectivos salários, com a soma de todos no final, o script foi feito na própria View;
 - Acrescentei algumas alterações mínimas no CSS, para uma melhor visualização e interação com botões e links;
 - Caso apresente erro no banco de dados ou descrito como algo relacionado ao SQLite, apagar o arquivo "app.db" para que ele gere novamente ao compilar e rodar.
