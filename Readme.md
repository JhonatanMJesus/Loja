# 🛒 Loja - Sistema de E-commerce

Sistema completo de gerenciamento de e-commerce desenvolvido em ASP.NET Core 8 MVC com Entity Framework Core e MySQL, implementando padrão CRUD para todas as entidades do domínio.

## 📋 Sobre o Projeto

Aplicação web robusta para gestão de loja virtual, permitindo controle completo de produtos, categorias, usuários, compras e itens. Desenvolvido seguindo os princípios SOLID e padrões de arquitetura MVC, com foco em manutenibilidade e escalabilidade.

## ✨ Funcionalidades

- ✅ **Gestão de Produtos**: CRUD completo com categorização
- ✅ **Categorias**: Organização hierárquica de produtos
- ✅ **Usuários**: Cadastro e gerenciamento de clientes
- ✅ **Compras**: Registro e acompanhamento de pedidos
- ✅ **Itens**: Controle de quantidades e relacionamento produto-compra
- ✅ **Produto-Categoria**: Tabela associativa para relacionamento N:N
- ✅ **Interface Responsiva**: Bootstrap 5 para design adaptativo
- ✅ **Validações**: Client-side e Server-side com Data Annotations

## 🛠️ Tecnologias Utilizadas

### Backend
- **Framework**: ASP.NET Core 8.0
- **ORM**: Entity Framework Core 8.0.13
- **Banco de Dados**: MySQL 8.0 (via Pomelo.EntityFrameworkCore.MySql 8.0.3)
- **Padrão**: MVC (Model-View-Controller)

### Frontend
- **Framework CSS**: Bootstrap 5
- **Template Engine**: Razor Pages
- **Validação**: jQuery Validation & Unobtrusive

### Ferramentas de Desenvolvimento
- **IDE**: Visual Studio 2022 / Visual Studio Code
- **Scaffolding**: Microsoft.VisualStudio.Web.CodeGeneration.Design 8.0.7
- **Migrations**: Entity Framework Core Tools

## 📁 Estrutura do Projeto
```
Loja/
├── Controllers/          # Controladores MVC
│   ├── CategoriasController.cs
│   ├── ComprasController.cs
│   ├── HomeController.cs
│   ├── ItensController.cs
│   ├── ProdutoCategoriasController.cs
│   ├── ProdutoesController.cs
│   └── UsuariosController.cs
├── Models/              # Modelos de domínio
│   ├── Categoria.cs
│   ├── Compra.cs
│   ├── Itens.cs
│   ├── Produto.cs
│   ├── ProdutoCategoria.cs
│   └── Usuario.cs
├── Views/               # Views Razor
│   ├── Categorias/
│   ├── Compras/
│   ├── Home/
│   ├── Itens/
│   ├── ProdutoCategorias/
│   ├── Produtoes/
│   ├── Usuarios/
│   └── Shared/
├── Data/                # Contexto do banco de dados
│   └── ApplicationDbContext.cs
├── Migrations/          # Migrações do EF Core
├── wwwroot/            # Arquivos estáticos (CSS, JS, imagens)
├── appsettings.json    # Configurações da aplicação
└── Program.cs          # Ponto de entrada da aplicação
```

## 🗃️ Modelo de Dados

### Entidades Principais

**Usuario**
- Id (PK)
- Nome_usuario
- Email

**Produto**
- Id (PK)
- Nome_produto
- Descricao_produto
- Preco
- Fk_id_categoria (FK)

**Categoria**
- Id (PK)
- Descritivo
- Fk_id_produto (FK)

**Compra**
- Id (PK)
- Data_compra
- Fk_id_usuario (FK)
- Fk_id_item (FK)

**Itens**
- Id (PK)
- Quantidade
- Fk_id_compra (FK)
- Fk_id_produto (FK)

**ProdutoCategoria** (Tabela Associativa)
- Id (PK)
- Fk_id_produto (FK)
- Fk_id_categoria (FK)

## 🚀 Como Executar

### Pré-requisitos

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [MySQL Server 8.0+](https://dev.mysql.com/downloads/mysql/)
- Visual Studio 2022 ou Visual Studio Code

### Passo a Passo

1. **Clone o repositório**
```bash
git clone https://github.com/seu-usuario/loja.git
cd loja
```

2. **Configure a string de conexão**

Edite o arquivo `appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=bilinhostore;User=root;Password=sua_senha;"
  }
}
```

3. **Restaure os pacotes NuGet**
```bash
dotnet restore
```

4. **Execute as migrações**
```bash
dotnet ef database update
```

5. **Execute a aplicação**
```bash
dotnet run
```

6. **Acesse no navegador**
```
https://localhost:7113
ou
http://localhost:5225
```

## 🔧 Comandos Úteis

### Entity Framework Core
```bash
# Criar nova migração
dotnet ef migrations add NomeDaMigracao

# Aplicar migrações pendentes
dotnet ef database update

# Reverter última migração
dotnet ef migrations remove

# Ver lista de migrações
dotnet ef migrations list

# Gerar script SQL
dotnet ef migrations script
```

### Scaffolding de Controllers
```bash
# Criar controller com views
dotnet aspnet-codegenerator controller -name NomeController -m ModelName -dc ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
```

## 📦 Dependências
```xml




```

## 🏗️ Arquitetura

### Padrão MVC

- **Models**: Entidades de domínio e lógica de negócio
- **Views**: Interface do usuário (Razor Pages)
- **Controllers**: Lógica de controle e roteamento

### Code First Approach

O projeto utiliza Entity Framework Core Code First, onde:
- Models definem a estrutura do banco
- Migrations gerenciam alterações do schema
- DbContext gerencia o acesso aos dados

### Relacionamentos

- **1:N** - Usuario → Compra
- **1:N** - Produto → Categoria
- **1:N** - Compra → Itens
- **N:N** - Produto ↔ Categoria (via ProdutoCategoria)

## 🎨 Interface

A aplicação utiliza:
- **Bootstrap 5** para design responsivo
- **Razor Syntax** para renderização dinâmica
- **jQuery Validation** para validação de formulários
- **Layout Master** (_Layout.cshtml) para consistência visual

## 📝 Validações

### Server-Side
- Data Annotations nos Models
- ModelState.IsValid nos Controllers
- Tratamento de exceções DbUpdateConcurrencyException

### Client-Side
- jQuery Validation
- jQuery Unobtrusive Validation
- Mensagens de erro em tempo real

## 🔒 Segurança

- ✅ ValidateAntiForgeryToken para proteção CSRF
- ✅ Bind attributes para prevenir over-posting
- ✅ Queries parametrizadas via EF Core (proteção SQL Injection)

## 🐛 Tratamento de Erros

- Página de erro customizada (_Error.cshtml)
- Logs estruturados via ILogger
- Exception handling nos controllers
- Validação de nulos (Id?)

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.