# Roadmap — C# / .NET

> Trilha adaptativa. Marcadores representam **evidências de prática**, não domínio definitivo. O estado detalhado da sessão está em [progress.md](progress.md); as diretrizes em [MENTORSHIP.md](MENTORSHIP.md).

## 01 — Fundamentos de C# (em andamento)

### Sintaxe e tipos
- [x] Declaração de variáveis, atribuições e `int` em exercícios
- [x] Operadores aritméticos e de comparação em exercícios
- [x] Escopo de variáveis em laços e condicionais
- [ ] Revisar `double`, `decimal`, `bool`, `string` e conversões
- [ ] Overflow, limites numéricos e nulidade

### Fluxo de controle
- [x] `if` / `else` e comparação `=` versus `==`
- [x] `for`: índices, condições, incrementos, acumulação
- [x] `while` — contagem regressiva de 10 a 1 executada e validada
- [ ] `do-while` e revisão de condições de parada para entradas inesperadas
- [ ] `break` e `continue` — **próxima prática**
- [ ] `switch` e expressões `switch`

### Arrays e coleções
- [x] Arrays, `Length` e acesso por índice
- [x] Percurso por saltos, soma e maior valor
- [x] Casos de borda: array vazio e números negativos
- [ ] `List<T>`
- [ ] `Dictionary<TKey, TValue>`
- [ ] `HashSet<T>`

### Métodos e decomposição
- [ ] Declaração de métodos, parâmetros, retornos e escopo
- [ ] Separação de responsabilidades e leitura do fluxo entre métodos
- [ ] Sobrecarga de métodos

### Diagnóstico, testes e análise
- [x] Distinguir erros de compilação e exceções em execução
- [x] Diagnosticar `CS0029`, `CS0165` e `IndexOutOfRangeException`
- [x] Breakpoints, Locals, Step Over (F10), Step Into (F11) e Continue (F5) — prática introdutória
- [x] Investigar um defeito de cálculo de desconto e localizar sobrescrita indevida
- [ ] Retomar debugging com casos mais complexos, call stack e tratamento de exceções
- [x] Noções de O(1) e O(n), incluindo espaço auxiliar constante
- [ ] Testes automatizados básicos e regressão

**Critério de saída:** implementar pequenos programas sem solução pronta, justificar condições, laços e estruturas de dados, testar casos-limite e investigar defeitos com método. Revisitar fundamentos já praticados em contextos novos.

## 02 — Orientação a objetos
Classes, construtores, encapsulamento, interfaces, composição, herança, polimorfismo, generics e SOLID. **Pendente.**

## 03 — C# moderno
LINQ, lambdas, delegates, eventos, nullable reference types, records, pattern matching, async/await, concorrência e memória. **Pendente.**

## 04 — .NET e ASP.NET Core
Estrutura de soluções, HTTP, REST, APIs, middleware, DI, configuração, validação, logging, autenticação e autorização. **Pendente.**

## 05 — Dados
SQL, modelagem, índices, transações, SQL Server e Entity Framework Core. **Pendente.**

## 06 — Qualidade
xUnit, testes de integração, mocks, refatoração, revisão de código e TDD. **Pendente.**

## 07 — Arquitetura
Padrões, Clean Architecture, DDD, CQRS, mensageria, cache, segurança e desempenho quando justificados por problemas reais. **Pendente.**

## 08 — Infraestrutura
Git/GitHub, Docker, CI/CD, Azure, deploy e observabilidade. **Pendente como trilha estruturada; Git já é usado nos estudos.**

## 09 — Mercado
Portfólio, entrevistas técnicas, algoritmos, system design e preparação para oportunidades remotas internacionais. **Pendente como trilha estruturada.**

## Projeto principal
**Atlas API:** ainda não iniciado. Começará simples e crescerá conforme os conceitos forem demonstrados na prática.

**Última atualização:** 2026-11-20.
