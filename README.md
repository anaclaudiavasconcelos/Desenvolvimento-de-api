# Atividade Back-End — API da Plataforma de Jogos

Atividade concluída!



## 🎯 Objetivo

Nesta atividade, você atuará como desenvolvedor(a) Back-End responsável pela criação da API RESTful que alimentará o front-end de uma plataforma de jogos. Seu objetivo é estruturar as rotas, implementar as operações CRUD para todas as entidades do sistema e integrar a aplicação a um banco de dados utilizando ORM (*Object-Relational Mapping*).

## 📁 Repositório base e guia HTTP

Faça um fork deste repositório para desenvolver sua solução:

🔗 [Repositório base no GitHub](https://github.com/ElHopperCBR/PlataformadeJogos)

Consulte o guia para conferir as rotas, localizar as chamadas HTTP no front-end e ver os campos esperados:

📘 [Abrir o Guia de API e requisições HTTP](Guia-API.html)

O front-end está configurado inicialmente para acessar `http://localhost:5212`. Se sua API utilizar outra porta ou endereço, ajuste o `BaseAddress` em `PlataformadeJogos/Form1.cs`.

## 📌 Requisitos da aplicação

Implemente endpoints e regras de negócio para as seguintes entidades:

### Jogos (`jogos`)

- Cadastrar um jogo.
- Editar um jogo existente.
- Listar e explorar jogos; implemente filtros ou busca, se possível.
- Buscar um jogo pelo ID.
- Excluir um jogo.

### Categorias de jogos (`categorias`)

- Cadastrar uma categoria.
- Editar uma categoria existente.
- Listar e explorar categorias.
- Buscar uma categoria pelo ID.
- Excluir uma categoria.

### Estúdios de desenvolvimento (`estudios`)

- Cadastrar um estúdio.
- Editar um estúdio existente.
- Listar e explorar estúdios.
- Buscar um estúdio pelo ID.
- Excluir um estúdio.

### Usuários da plataforma (`usuarios`)

- Cadastrar um usuário.
- Editar o perfil de um usuário.
- Listar e explorar usuários.
- Buscar um usuário pelo ID.
- Excluir um usuário.

## 🛠️ Requisitos técnicos

- **Arquitetura:** API RESTful com respostas em JSON.
- **Persistência:** integrar a aplicação a um banco de dados usando ORM. Exemplos: Entity Framework, Prisma, TypeORM, Sequelize, Hibernate ou equivalente à tecnologia utilizada pela turma.
- **Validação e erros:** validar os dados recebidos e retornar status HTTP adequados, como `200 OK`, `201 Created`, `204 No Content`, `400 Bad Request`, `404 Not Found` e `500 Internal Server Error`.
- **Relacionamentos:** respeitar as relações entre as entidades. Por exemplo, um jogo pertence a uma categoria e a um estúdio.
- **Segurança:** não retornar senhas nas respostas da API; armazene credenciais de forma segura conforme a tecnologia adotada.

## 🔌 Contrato inicial das rotas

O front-end espera os seguintes caminhos e métodos:

| Recurso | Listar | Buscar por ID | Cadastrar | Editar | Excluir |
|---|---|---|---|---|---|
| Jogos | `GET /api/jogos` | `GET /api/jogos/{id}` | `POST /api/jogos` | `PUT /api/jogos/{id}` | `DELETE /api/jogos/{id}` |
| Categorias | `GET /api/categorias` | `GET /api/categorias/{id}` | `POST /api/categorias` | `PUT /api/categorias/{id}` | `DELETE /api/categorias/{id}` |
| Estúdios | `GET /api/estudios` | `GET /api/estudios/{id}` | `POST /api/estudios` | `PUT /api/estudios/{id}` | `DELETE /api/estudios/{id}` |
| Usuários | `GET /api/usuarios` | `GET /api/usuarios/{id}` | `POST /api/usuarios` | `PUT /api/usuarios/{id}` | `DELETE /api/usuarios/{id}` |

Os campos enviados pelo front-end são:

- **Jogo:** `nome`, `descricao`, `preco`, `categoriaId`, `estudioId`.
- **Categoria:** `nome`, `descricao`.
- **Estúdio:** `nome`, `pais`.
- **Usuário:** `nome`, `email`, `senha` (a senha é enviada no cadastro; não a inclua nas respostas de consulta).

Para a listagem, o front-end aceita uma lista JSON ou um objeto com a lista na propriedade `data`. Consulte o [guia HTTP](Guia-API.html) para exemplos e links de teste. Os links para `localhost` abrem rotas GET; POST, PUT e DELETE devem ser exercitados pelo front-end ou por uma ferramenta de requisições HTTP.

## 📦 Orientações para entrega

1. Faça um **fork** do repositório base no GitHub.
2. Desenvolva sua API no repositório criado a partir do fork.
3. Configure o banco de dados e as variáveis de ambiente necessárias.
4. Preencha este README com as instruções reais para executar sua solução, incluindo configuração do banco, migrações e inicialização da API.
5. Confira se o projeto contém um arquivo `.env.example` com os nomes das variáveis necessárias e valores de exemplo não confidenciais. **Não envie senhas ou segredos reais ao GitHub.**
6. Submeta no Google Classroom o link do seu repositório público no GitHub.

## ▶️ Como executar localmente

Como cada aluno poderá escolher uma linguagem, ORM e banco de dados diferentes, complete os passos abaixo com os comandos correspondentes à sua implementação:

1. Clone seu repositório e entre na pasta da API.
2. Copie `.env.example` para `.env` e configure os dados locais do banco.
3. Instale ou restaure as dependências do projeto.
4. Execute as migrações do ORM para criar/atualizar o banco de dados.
5. Inicie a API e confirme o endereço e a porta utilizados.
6. Inicie o front-end e, se necessário, atualize o `BaseAddress` em `Form1.cs`.

> **Aluno(a):** substitua esta orientação pelos comandos exatos da sua tecnologia, incluindo os comandos para instalar dependências, executar migrações e iniciar a API.

### Variáveis de ambiente

Crie e mantenha um `.env.example` compatível com a tecnologia e o banco escolhidos. Exemplo genérico (adapte os nomes ao projeto):

```dotenv
PORT=5212
DB_HOST=localhost
DB_PORT=5432
DB_NAME=plataforma_jogos
DB_USER=usuario_local
DB_PASSWORD=senha_local
```

Documente no README o significado de cada variável. Use valores fictícios no `.env.example`; mantenha credenciais reais apenas no arquivo `.env` local e não o envie ao GitHub.

### Migrações do banco de dados

Informe aqui o comando utilizado para criar e aplicar as migrações do seu ORM e explique como configurar o banco antes de executá-lo. Exemplo de instrução a preencher:

```text
[comando de criação/aplicação das migrações do ORM]
```
