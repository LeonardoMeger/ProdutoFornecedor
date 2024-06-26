# ProdutoFornecedor

Este é um projeto web MVC desenvolvido com C#,.NET 6 e Entity Framework Core para demonstrar boas práticas de desenvolvimento web para o teste tecnico.

Pré-requisitos
Certifique-se de ter o seguinte software instalados:

.NET 6 SDK
Visual Studio Code ou Visual Studio 2019+
SQL Server Express Edition

Configuração
Clone o repositório: Primeiro, clone este repositório para sua máquina local usando Git.
git clone https://github.com/seu_usuario/ProdutoFornecedor.git
Navegue até o diretório do projeto:
cd ProdutoFornecedor

Certifique se os seguintes pacotes estao instalado no nuget package
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design 
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.SqlServer

Configurar o banco de dados: Este projeto usa o Entity Framework Core para interagir com o banco de dados SQL Server.
Você precisará cofigurar o arquivo appsettings.json do projeto com as suas configurações do banco de dadoslocal.
Exemplo de appsettings.json:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=SEU_SERVIDOR;Database=NOME_DO_BANCO;User Id=USUARIO;Password=SENHA;"
  }
}
Execute as migrations para criar as tabelas no banco de dados local
Add-Migration InitialCreate -Context ProductSupplierDbContext
Update-Database -Context ProductSupplierDbContext

Execute o projeto e certifique que ele abrira na sequinte url https://localhost:7277
