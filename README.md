Para criar a sua API, vamos utilizar um modelo de CRUD completo, você pode se basear na API Fake abaixo, para visualizar a documentação acesse:
https://reqres.in/api-docs/#/
Para criar a sua API, você pode utilizar Sql Server, Mysql, ou Postgresql como base de dados.
Envie também os comandos para recriar suas tabelas ou um backup do banco utilizado. Iremos aceitar nos dois formatos.
Ao final do teste envie um Zip do Projeto ou o Link via GitHub.
*Rotas que devem existir no seu Projeto de C#.

Endpoint para login
O endpoint de login realiza a autenticação dos usuários com base no email e senha. Para descobrir os usuários e senhas consulte os endpoints do usuário /users.
POST https://reqres.in/api/login

Endpoint para lista de usuários
GET https://reqres.in/api/users?page=1&per_page=5

Endpoint usuário por id
GET https://reqres.in/api/users/1

Endpoint atualizar usuário por id
PUT https://reqres.in/api/users/1

Endpoint deletar usuário por id
DELETE https://reqres.in/api/users/1


OBS:
- Banco de dados SQL Server

- Projeto realizado em .NET 6

- Utilizado as seguintes dependencias:
** Microsoft.EntityFrameworkCore
** Microsoft.EntityFrameworkCore.Design
** Microsoft.EntityFrameworkCore.SqlServer 
** Microsoft.EntityFrameworkCore.Tools

Banco de dados é criado atraves de migration.
Comandos (Package Manager Console):
PM> Add-Migration IniciarDB -Context SistemaDBContex
PM> Update-Database -Context SistemaDBContex
