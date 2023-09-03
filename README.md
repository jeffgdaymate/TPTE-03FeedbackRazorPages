# TPTE-03FeedbackRazorPages

# Objetivos do Projeto
Este projeto foi desenvolvido com o intuito de criar um sistema de feedbacks simples usando ASP.NET Core e Razor Pages. Aqui estão os principais objetivos e funcionalidades alcançados:

CRUD Completo para Feedbacks: O sistema permite a criação, leitura, atualização e exclusão de feedbacks.

Validação de Dados: Ao inserir ou atualizar feedbacks, o sistema valida os dados para garantir consistência e integridade.

Lista de Feedbacks: Uma página que exibe todos os feedbacks em um formato tabular, tornando mais fácil para os usuários verem e gerenciarem os feedbacks.

Detalhes de Feedback: Possibilidade de ver detalhes de um feedback específico.

Interface do Usuário Intuitiva: A interface do usuário foi desenvolvida para ser simples e fácil de usar. Utiliza Bootstrap para uma apresentação responsiva e amigável.

Arquitetura Baseada em Serviços: O código backend é estruturado de uma forma modular e escalável, usando uma arquitetura baseada em serviços.

Como Rodar o Projeto
Clone o repositório.
Navegue até a pasta raiz do projeto e execute o comando dotnet run.
Abra um navegador e vá para http://localhost:5000 (ou a porta especificada) para acessar a aplicação.
Considerações Finais
Este é um projeto educacional e serve como uma base para entender os conceitos básicos de ASP.NET Core e Razor Pages. Feedbacks e contribuições são sempre bem-vindos!


# Tema Desafio
Tema: Gestão de Feedbacks de Clientes com Minimal API e ASP.NET Razor Pages

Descrição: Desenvolva uma aplicação WEB utilizando a Minimal API do .NET Core que permita o gerenciamento de feedbacks deixados por clientes sobre um serviço ou produto específico. A aplicação deve permitir o cadastro, consulta, atualização e exclusão de feedbacks, integrando-se com ASP.NET Razor Pages. Utilize uma coleção em memória para armazenar os dados temporariamente.

Cada feedback deve ter as seguintes propriedades:

IdFeedback: inteiro;
NomeCliente: string;
EmailCliente: string (opcional);
DataFeedback: DateTime;
Comentário: string;
Avaliação: inteiro (uma escala de 1 a 5, onde 1 é "Muito insatisfeito" e 5 é "Muito satisfeito").
A aplicação deve permitir que os usuários insiram seus feedbacks através de um formulário simples. Além disso, deve ser possível visualizar todos os feedbacks em uma lista, bem como editar ou excluir um feedback específico.
