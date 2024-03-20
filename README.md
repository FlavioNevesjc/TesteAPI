Para criar a sua API, vamos utilizar um modelo de CRUD completo, você pode se basear na API Fake abaixo, para visualizar a documentação acesse: <br>
https://reqres.in/api-docs/#/ <br>
<br>
Para criar a sua API, você pode utilizar Sql Server, Mysql, ou Postgresql como base de dados. <br>
Envie também os comandos para recriar suas tabelas ou um backup do banco utilizado. Iremos aceitar nos dois formatos. <br>
Ao final do teste envie um Zip do Projeto ou o Link via GitHub. <br>
*Rotas que devem existir no seu Projeto de C#. <br>
<br>
Endpoint para login <br>
O endpoint de login realiza a autenticação dos usuários com base no email e senha. Para descobrir os usuários e senhas consulte os endpoints do usuário /users. <br>
POST https://reqres.in/api/login <br>
<br>
Endpoint para lista de usuários <br>
GET https://reqres.in/api/users?page=1&per_page=5 <br>
<br>
Endpoint usuário por id <br>
GET https://reqres.in/api/users/1 <br>
<br>
Endpoint atualizar usuário por id <br>
PUT https://reqres.in/api/users/1 <br>
<br>
Endpoint deletar usuário por id <br>
DELETE https://reqres.in/api/users/1 <br>
<br>
<br>
OBS: <br>
- SQL Server 2022 (banco em backup) e para criar o banco e tabela, utilizei uma migration. <br>
- Visual Studio 2022 <br>
- Projeto realizado em .Net 6 <br>
<br>
- Utilizado as seguintes dependencias: <br>
** Microsoft.EntityFrameworkCore <br>
** Microsoft.EntityFrameworkCore.Design <br>
** Microsoft.EntityFrameworkCore.SqlServer <br>
** Microsoft.EntityFrameworkCore.Tools <br>
<br>
Banco de dados é criado atraves de migration. <br>
Comandos (Package Manager Console): <br>
PM> Add-Migration IniciarDB -Context SistemaDBContex <br>
PM> Update-Database -Context SistemaDBContex <br>
<br>
<br>
Na imagem do Front End, a tela de login está informando os campos usuario e password para validar o login. Com isto validei a senha utilizando o campo e-mail e senha, mas deixei disponível o campo username como está na API Fake, caso seja necessario utilizar este campo futuramente.
