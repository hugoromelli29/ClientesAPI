<h1>API de Clientes</h1>

> Status do projeto: completo

O projeto é uma API simples que roda na porta ```https://localhost:5001/cliente``` e realiza CRUD de clientes. Implementa validação de parâmetro por expressão regular na classe ```Cliente```.

O projeto está escrito em C# no Framework .NET 5. O banco de dados utilizado é o MySQL Workbench. As requisições podem ser feitas através do Postman. 

A conexão com o banco de dados é feita no console do gerenciador de pacotes do Visual Studio com os comandos ```Add-Migration``` e ```Update-Database```. Deve-se atentar, no arquivo ```appsettings.json``` ao password.

<strong>Packs do NuGet utilizados no projeto:</strong>

<em>● Microsoft.EntityFrameworkCore</em>

<em>● Microsoft.EntityFrameworkCore.Tools</em>

<em>● MySql.EntityFrameworkCore</em>


<strong>Campos da tabela no banco de dados:</strong>

<em>● id</em>

<em>● Nome</em>

<em>● Documento</em>

<em>● Telefone</em>

<em>● Email</em>

<em>● Endereço</em>
