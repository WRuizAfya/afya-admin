# Afya Admin — Dashboard com Blazor WebAssembly e MudBlazor

## Identificação

| | |
|---|---|
| **Aluno(a)** | Wenceslau Ruiz Juarez |
| **Matrícula** | ------ |
| **Faculdade** | Afya São Lucas Campus 2 |
| **Curso** | Ciencias da computação |
| **Disciplina** |Programação para Sistemas WEB |
| **Professor(a)** | Liluyoud Cury Lacerda|
| **Semestre** | 2026.2 |

## Objetivo do projeto

Explique com suas palavras o objetivo do projeto e o que a página faz (2 a 4 parágrafos).

## Tecnologias utilizadas

- .NET 10 / Blazor WebAssembly
- MudBlazor 9
- (outras que você usou)

## Como executar

Passo a passo para outra pessoa clonar e rodar o projeto:

```bash
git clone https://github.com/WRuizAfya/afya-admin.git
cd afya-admin
dotnet watch
```

Informe também a versão do .NET SDK necessária.

## Telas

### Tema claro
![Dashboard — tema claro](docs/prints/tema-claro.png)

### Tema escuro
![Dashboard — tema escuro](docs/prints/tema-escuro.png)

### Versão mobile
![Dashboard — celular](docs/prints/mobile.png)

### HTML gerado (DevTools)
![Inspeção do HTML no DevTools](docs/prints/devtools.png)

Explique em poucas linhas o que o print do DevTools mostra: qual componente você inspecionou, qual HTML ele gerou e quais classes apareceram.

## Estrutura do projeto

Mostre a árvore de pastas e arquivos e explique em uma linha o papel de cada pasta (`Components`, `Data`, `Layout`, `Pages`, `wwwroot`).

## Componentes criados

| Componente | Responsabilidade | Parâmetros que recebe |
|---|---|---|
| `CabecalhoPagina` | Exibe o título da página, subtítulo e uma área flexível para botões de ação. | • `Titulo` (`string`, obrigatório)<br>• `Subtitulo` (`string?`)<br>• `Acoes` (`RenderFragment?`) |
| `SeletorPeriodo` | Menu suspenso para seleção do intervalo de tempo (suporta `@bind-Valor`). | • `Opcoes` (`IReadOnlyList<string>`, obrigatório)<br>• `Valor` (`string`)<br>• `ValorChanged` (`EventCallback<string>`) |
| `DashboardCard` | Contêiner padronizado (card branco com sombra) que organiza título, subtítulo, ações, menu de opções e conteúdo. | • `Titulo` (`string`, obrigatório)<br>• `Subtitulo` (`string?`)<br>• `Acoes` (`RenderFragment?`)<br>• `Menu` (`RenderFragment?`)<br>• `ChildContent` (`RenderFragment?`) |
| `KpiCard` | Exibe indicador de desempenho com ícone pastel, valor, variação com tendência e mini gráfico de linha (*sparkline*). | • `Kpi` (`Kpi`, obrigatório) |
| `GraficoReceita` | Renderiza o gráfico comparativo **Receita x Meta** ao longo dos meses com legenda personalizada. | • `Meses` (`string[]`, obrigatório)<br>• `Receita` (`double[]`, obrigatório)<br>• `Meta` (`double[]`, obrigatório) |
| `GraficoDistribuicaoClientes` | Exibe gráfico de rosca (*donut chart*) por segmento de cliente com valor total centralizado e legenda customizada. | • `Total` (`int`, obrigatório)<br>• `Segmentos` (`IReadOnlyList<SegmentoCliente>`, obrigatório) |
| `PerformanceProjetos` | Exibe lista de projetos com barra de progresso linear, percentual e tarefas concluídas. | • `Projetos` (`IReadOnlyList<ProjetoPerformance>`, obrigatório) |
| `AtividadesRecentes` | Exibe feed de atividades contendo ícone de evento, avatares com iniciais, detalhes e horário. | • `Atividades` (`IReadOnlyList<Atividade>`, obrigatório) |
| `ProjetosRecentes` | Exibe tabela responsiva (`MudTable`) contendo status colorido (*chips*), progresso, prazo e menu de ações. | • `Projetos` (`IReadOnlyList<ProjetoRecente>`, obrigatório) |

## O que aprendi

Responda **com suas próprias palavras** (um parágrafo curto por pergunta):

1. Como uma aplicação Blazor WebAssembly inicia no navegador? Qual é o papel do `index.html`, da `<div id="app">` e do `Program.cs`?
2. Qual é a diferença entre um **Layout**, uma **Page** e um **Component** neste projeto? Dê um exemplo de cada.
3. O que é um `RenderFragment` e como o `DashboardCard` usa esse recurso para ser reutilizado por vários cards?
4. Como funciona o `@bind-Valor` no `SeletorPeriodo`? Qual é o papel do `ValorChanged`?
5. Por que os dados ficam na pasta `Data`, separados dos componentes? Que vantagem isso traz se, no futuro, os dados vierem de uma API?
6. Como o `MudGrid` com `xs`, `sm` e `lg` faz os cards de KPI se reorganizarem em telas de tamanhos diferentes?
7. Como foi possível estilizar a página inteira sem escrever CSS? Explique o papel do tema (`MudTheme`) e das classes utilitárias.
8. Por que o namespace do projeto é `afya_admin` e não `afya-admin`?

## Dificuldades e soluções

Descreva pelo menos **dois problemas** que você enfrentou durante o desenvolvimento e como resolveu cada um.

## Melhorias futuras (opcional)

O que você implementaria a seguir? Se fez algum dos desafios da seção 20 do tutorial, descreva aqui.
