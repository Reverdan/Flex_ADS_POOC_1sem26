# Roteiro 1

Etapa 1 - Primeira saída no console (top-level statements) 

1. No arquivo principal (por exemplo, Program.cs), escrever uma primeira linha usando 

Console.WriteLine para imprimir uma saudação. 

2. Executar (F5 ou Ctrl+F5) e confirmar que a mensagem aparece. 

Checkpoint: o console deve exibir uma frase simples de boas-vindas. 

 

1. O Código 

No seu arquivo Program.cs, você não precisa de static void Main. Basta digitar a instrução diretamente: 

C# 

 

Console.WriteLine("Olá, mundo! Este é o meu primeiro programa em C#."); 
 

2. Execução 

F5: Inicia a depuração (Debug). Útil para quando você quer usar breakpoints e analisar o código linha a linha. 

Ctrl + F5: Executa sem depurar. Geralmente é mais rápido e mantém a janela do console aberta após o término para você ver o resultado. 

3. O que acontece por trás das câmeras? 

Mesmo que você não veja, o compilador do C# é "camarada" e envolve sua linha de código em uma classe e um método principal automaticamente durante a compilação. 

 

Etapa 2 - Tipos, inferência com var e interpolação de strings 

1. Declarar uma variável inteira (por exemplo, um ano) com int. 

2. Declarar uma variável de texto com var (o compilador infere string). 

3. Imprimir uma frase usando interpolação: $”...”, inserindo as duas variáveis no texto. 

Checkpoint: o console deve mostrar um texto com o nome e o ano. 

 

Essa é uma das partes mais legais do C#: entender como a linguagem evoluiu para ser produtiva. A inferência de tipos e a interpolação tornam o código muito mais legível. 

Aqui está o código para a sua Etapa 2: 

 

// 1. Declarando uma variável inteira explicitamente 

int anoAtual = 2026; 

 

// 2. Declarando uma variável de texto com inferência (var) 

// O compilador entende que "Gemini" é uma string 

var nomeDesenvolvedor = "Gemini"; 

 

// 3. Imprimindo com interpolação de strings ($"") 

Console.WriteLine($"Olá! Eu sou o {nomeDesenvolvedor} e estamos no ano de {anoAtual}."); 

 
 

O que você precisa saber sobre esses conceitos: 

var não é "dinâmico": Diferente do JavaScript, no C# o var é fortemente tipado. Uma vez que você atribuiu um texto a ele, você não pode tentar colocar um número nessa mesma variável depois. O compilador apenas "adivinha" o tipo para você não precisar escrever string duas vezes. 

Interpolação ($): É muito superior à antiga concatenação ("Texto " + variavel). Além de ficar visualmente mais limpo, o C# resolve isso de forma muito performática por baixo dos panos. 

 
 

Checkpoint: Ao executar, o console deve exibir algo como: 

Olá! Eu sou o Gemini e estamos no ano de 2026. 

 

Etapa 3 - Nullabilidade, ?? e ??= 

1. Declarar uma variável string? inicializada com null. 

2. Criar uma segunda variável (por exemplo, exibir) usando o operador ??, definindo um 

texto padrão caso a primeira seja nula. 

3. Imprimir exibir. 

4. Usar o operador ??= para atribuir um valor à variável string? apenas se ela ainda 

estiver nula. 

5. Imprimir a variável novamente para verificar que agora possui um texto. 

Checkpoint: uma das linhas deve imprimir o texto padrão (quando ainda era null), e 

outra linha deve imprimir o valor atribuído depois. 

 

Essa etapa é fundamental para escrever códigos robustos em C#. Lidar com null (a ausência de valor) de forma segura evita o famoso erro NullReferenceException, o pesadelo de muitos desenvolvedores. 

Aqui está a implementação seguindo seus requisitos: 

C# 

 

// 1. Declarando uma variável string que "aceita" nulo (string?) 
string? nomeUsuario = null; 
 

// 2. Usando o operador de coalescência nula (??) 
// Se nomeUsuario for null, a variável 'exibir' recebe "Convidado" 
string exibir = nomeUsuario ?? "Convidado"; 
 

// 3. Imprimindo (deve aparecer "Convidado") 
Console.WriteLine($"Status atual: {exibir}"); 
 

// 4. Usando o operador de atribuição de coalescência nula (??=) 
// "Só atribua 'C# Developer' se nomeUsuario ainda for null" 
nomeUsuario ??= "C# Developer"; 
 

// 5. Imprimindo a variável original para verificar a mudança 
Console.WriteLine($"Nome após atribuição: {nomeUsuario}"); 
 

 
 

Entendendo os Operadores de "Açúcar Sintático" 

O C# utiliza esses operadores para simplificar verificações que antigamente exigiriam vários if e else. 

Operador 

Nome 

O que faz? 

? 

Nullability 

Avisa ao compilador: "Ei, esta variável pode ficar vazia, tome cuidado". 

?? 

Coalescência Nula 

Fornece um "plano B". Se o lado esquerdo for nulo, use o lado direito. 

??= 

Atribuição Nula 

Só coloca um valor na gaveta se a gaveta estiver vazia. 

Exportar para as Planilhas 

 
 

Checkpoint: 1. A primeira saída no console deve ser: Status atual: Convidado 2. A segunda saída deve ser: Nome após atribuição: C# Developer 

 

Etapa 4 - switch como expressão com pattern matching 

1. Declarar uma variável do tipo object? recebendo um valor (por exemplo, um número 

inteiro). 

2. Criar uma variável string chamada, por exemplo, descricao, cujo valor seja definido 

por um switch como expressão. 

3. Incluir, no switch, pelo menos estes casos: 

 null 

 um padrão para int com uma condição when (por exemplo, “maior que 100”) 

 um padrão para string, usando o tamanho do texto 

 um caso “padrão” (_) 

4. Imprimir descricao. 

Checkpoint: ao usar um inteiro maior que 100, a descrição deve cair no caso correspondente. 

 

Essa etapa mostra como o C# se tornou uma linguagem extremamente poderosa para processamento de dados. O switch como expressão (introduzido no C# 8) é muito mais conciso que o switch tradicional, pois ele retorna um valor diretamente. 

Aqui está o código implementando a lógica de Pattern Matching: 

C# 

 

// 1. Declarando uma variável object? (pode ser qualquer coisa: int, string, null...) 
object? entrada = 150;  
 

// 2 & 3. Switch como expressão com Pattern Matching 
string descricao = entrada switch 
{ 
    null => "O valor é nulo.", 
     
    int n when n > 100 => $"É um número inteiro alto: {n}.", 
     
    int n => $"É um número inteiro comum: {n}.", 
     
    string s => $"É um texto com {s.Length} caracteres.", 
     
    _ => "Tipo de dado desconhecido." // Caso padrão (discard) 
}; 
 

// 4. Imprimir o resultado 
Console.WriteLine(descricao); 
 

 
 

O que há de novo aqui? 

Sintaxe de Expressão: Usamos => em vez de case: e break;. É muito mais limpo. 

Cláusula when: Permite adicionar filtros extras (guardas) ao padrão. O caso só combina se o tipo for int e a condição for verdadeira. 

O Descarte (_): Atua como o antigo default. É obrigatório se os outros casos não cobrirem todas as possibilidades (o compilador vai te avisar se faltar algo!). 

Ordem importa: O C# testa os casos de cima para baixo. Se você colocasse o int n antes do int n when n > 100, o número 150 entraria no primeiro e nunca chegaria na regra do "maior que 100". 

 
 

Checkpoint: Como definimos entrada = 150, o console deve exibir: 

É um número inteiro alto: 150. 

 

Etapa 5 - Função local static e expressão de corpo (expression-bodied) 

1. Criar uma função local (no mesmo arquivo), com retorno decimal, recebendo: 

 um preço (decimal) 

 uma taxa opcional com valor padrão (por exemplo, 0.12m) 

2. Implementar a função com sintaxe de expressão de corpo (usando =>). 

3. Chamar a função passando um preço e imprimir o resultado. 

Checkpoint: o resultado deve refletir o preço somado da taxa (a formatação do decimal 

pode variar conforme a cultura do sistema). 

 

Essa etapa é excelente para entender como o C# moderno permite escrever métodos de forma extremamente enxuta. As funções locais são ótimas para organizar lógica que só faz sentido dentro de um contexto específico, e a sintaxe expression-bodied (corpo de expressão) elimina a necessidade de chaves {} e da palavra return. 

Aqui está a implementação da Etapa 5: 

C# 

 

// 1 & 2. Criando a função local static com expressão de corpo (=>) 
// O 'm' após o número indica que o valor é do tipo decimal 
static decimal CalcularPrecoFinal(decimal preco, decimal taxa = 0.12m) => preco + (preco * taxa); 
 

// 3. Chamando a função e imprimindo o resultado 
decimal valorProduto = 100.00m; 
decimal resultado = CalcularPrecoFinal(valorProduto); 
 

Console.WriteLine($"Preço original: {valorProduto:C}"); 
Console.WriteLine($"Preço com taxa padrão (12%): {resultado:C}"); 
 

// Testando com uma taxa personalizada (ex: 20%) 
Console.WriteLine($"Preço com taxa de 20%: {CalcularPrecoFinal(valorProduto, 0.20m):C}"); 
 

 
 

Por que usar static em funções locais? 

Desde o C# 8, podemos marcar funções locais como static. Isso garante que a função não acesse acidentalmente variáveis declaradas fora dela (no escopo superior), o que ajuda na performance (evita alocações desnecessárias) e na clareza do código, pois você sabe que tudo o que a função usa está vindo apenas dos parâmetros. 

O que é o :C no WriteLine? 

É um formatador de string para Currency (Moeda). Ele automaticamente coloca o símbolo da moeda (R$, $, etc.) e as casas decimais baseadas na configuração do seu Windows/Linux. 

 
 

Checkpoint: Se você usou 100.00 como preço, o console deve exibir algo próximo a: Preço com taxa padrão (12%): R$ 112,00 (ou $ 112.00 dependendo do idioma). 

 

Etapa 6 - record e with-expression (cópia com alteração) 

1. Declarar um record chamado Produto, com três componentes (por exemplo: Id, Nome, 

Preco). 

2. Criar uma instância p1 com valores iniciais. 

3. Criar p2 a partir de p1 usando with, alterando apenas o preço. 

4. Imprimir p2 no console. 

Checkpoint: a impressão do record deve mostrar os campos do produto (o formato exato 

da impressão pode variar). 

 

Essa etapa introduz um dos recursos mais poderosos e elegantes do C# moderno: os Records. Eles são perfeitos para representar dados, pois oferecem imutabilidade por padrão e uma sintaxe muito enxuta. 

Aqui está a implementação da Etapa 6: 

C# 

 

// 1. Declarando o record (Sintaxe Posicional) 
// Isso cria automaticamente propriedades, construtor e suporte a comparação por valor 
public record Produto(int Id, string Nome, decimal Preco); 
 

// 2. Criando a instância inicial p1 
var p1 = new Produto(1, "Notebook Gamer", 4500.00m); 
 

// 3. Criando p2 a partir de p1 usando a expressão 'with' 
// p2 será uma cópia de p1, mas com o Preco alterado 
var p2 = p1 with { Preco = 4200.00m }; 
 

// 4. Imprimindo p2 no console 
Console.WriteLine("Produto Original (p1): " + p1); 
Console.WriteLine("Produto com Desconto (p2): " + p2); 
 

 
 

Por que usar Records e with? 

Imutabilidade: Por padrão, um record posicional usa propriedades init. Isso significa que, após criado, você não pode simplesmente fazer p1.Preco = 10;. Isso evita efeitos colaterais indesejados no seu código. 

A Expressão with: Como o objeto é imutável, o with é a forma oficial de "editar" algo. Ele cria uma nova instância copiando todos os valores da antiga, exceto os que você especificar nas chaves. 

Impressão Amigável: Diferente de uma class comum (que imprimiria apenas o nome do tipo no console), o record tem um ToString() sobrescrito automaticamente que mostra todos os nomes e valores das propriedades. 

 
 

Checkpoint: O console deve exibir algo como: 

Produto com Desconto (p2): Produto { Id = 1, Nome = Notebook Gamer, Preco = 4200.00 } 

 

Etapa 7 - Classe com propriedade e o token contextual field (C# 14) 

1. Declarar uma classe Config com uma propriedade Tema do tipo string. 

2. Implementar o set da propriedade com validação: 

 se receber null, lançar ArgumentNullException 

 caso contrário, atribuir ao backing field usando o token contextual field 

3. Criar um objeto Config, atribuir um tema válido e imprimir o valor. 

4. (Teste extra recomendado) tentar atribuir null e observar a exceção. 

Base conceitual do token field: ele permite acessar o backing field gerado pelo compilador 

dentro do accessor. 

 

 

Esta etapa nos leva ao que há de mais moderno na linguagem. O token contextual field (introduzido no C# 13/14) resolve um problema antigo: a necessidade de declarar manualmente um campo privado (backing field) sempre que precisávamos adicionar uma simples validação no set. 

Aqui está a implementação da Etapa 7: 

C# 

 

// 1. Declarando a classe Config 
public class Config 
{ 
    // 2. Usando o token contextual 'field' para validação 
    public string Tema 
    { 
        get => field ?? "Padrão"; // Opcional: retorna um padrão se field for nulo 
        set 
        { 
            // Validação: se o valor recebido (value) for null, lançamos exceção 
            if (value is null)  
                throw new ArgumentNullException(nameof(value), "O tema não pode ser nulo!"); 
 

// Atribuição direta ao backing field gerado automaticamente 
            field = value;  
        } 
    } 
} 
 

// 3. Criando o objeto e testando 
var minhaConfig = new Config(); 
 

try  
{ 
    minhaConfig.Tema = "Dark Mode"; // Atribuição válida 
    Console.WriteLine($"Configuração aplicada: {minhaConfig.Tema}"); 
 

// 4. Teste extra: tentando atribuir null 
    Console.WriteLine("Tentando atribuir null..."); 
    minhaConfig.Tema = null!;  
} 
catch (ArgumentNullException ex) 
{ 
    Console.WriteLine($"Erro capturado: {ex.ParamName} - {ex.Message}"); 
} 
 

 
 

Por que o token field é importante? 

Antes do C# 13/14, se você quisesse validar um set, era obrigado a escrever assim: 

C# 

 

private string _tema; // Precisava criar isso manualmente 
public string Tema  
{  
    get => _tema;  
    set => _tema = value ?? throw new ArgumentException();  
} 
 

Com o field, o compilador ainda cria o campo privado para você "por baixo dos panos", mas permite que você a acesse pelo nome reservado field dentro da propriedade. Isso mantém o código limpo como uma Auto-Property, mas com o poder de uma propriedade completa. 

 
 

Checkpoint: 1. Ao rodar com "Dark Mode", o console deve imprimir o valor corretamente. 2. Ao tentar o null, o bloco catch deve exibir a mensagem de erro, impedindo que o programa quebre inesperadamente. 

 

Etapa 8 - Classe Cliente e atribuição condicional com ?. no destino (C# 14) 

1. Declarar uma classe Cliente com uma propriedade Total do tipo decimal. 

2. Declarar uma variável Cliente? e inicializar com uma instância. 

3. Usar uma linha com atribuição composta no formato: 

 cliente?.Total += ...; 

4. Imprimir cliente?.Total. 

Esse uso (com ?. no lado esquerdo da atribuição) faz parte da proposta de null-conditional 

assignment em C# 14. 

Checkpoint: se cliente for null, a linha não deve lançar exceção; se houver instância, o 

total deve ser incrementado. 

 

Essa etapa final aborda uma das melhorias de "qualidade de vida" mais solicitadas pelos desenvolvedores C#. Até as versões recentes, o operador ?. (null-conditional) só podia ser usado para ler valores ou chamar métodos. Tentar atribuir um valor a algo que poderia ser nulo exigia um if (cliente != null). 

Com o C# 14, a atribuição condicional estende essa segurança para o lado esquerdo da operação. 

Aqui está a implementação da Etapa 8: 

C# 

 

// 1. Declarando a classe Cliente 
public class Cliente 
{ 
    public decimal Total { get; set; } 
} 
 

// 2. Inicializando uma instância (pode ser nula ou não) 
Cliente? meuCliente = new Cliente { Total = 100.00m }; 
 

// 3. Atribuição composta com null-conditional assignment (C# 14) 
// Se meuCliente for null, esta linha simplesmente não faz nada. 
// Se não for null, ela soma 50 ao Total. 
meuCliente?.Total += 50.00m; 
 

// 4. Imprimindo o resultado com segurança 
Console.WriteLine($"Total do cliente: {meuCliente?.Total}"); 
 

// --- Teste de Segurança --- 
Cliente? clienteNulo = null; 
// No C# 14, isso não quebra o programa! 
clienteNulo?.Total += 100.00m;  
Console.WriteLine("O código continuou executando sem erros após o cliente nulo."); 
 

 
 

A Revolução da Atribuição Condicional 

Antes do C# 14, o código acima resultaria em um erro de compilação: "The left-hand side of an assignment must be a variable, property or indexer". Você era obrigado a escrever: 

C# 

 

if (meuCliente != null)  
{ 
    meuCliente.Total += 50.00m; 
} 
 

Agora, o código fica muito mais linear e expressivo. É o que chamamos de "Null-Safe Assignment". 

 
 

Resumo da sua Jornada (Etapas 1 a 8) 

Você passou por um "intensivão" que cobriu mais de 5 anos de evolução da linguagem: 

Top-level statements: Simplicidade inicial. 

Interpolação e var: Produtividade na escrita. 

Nullability (??, ??=): Segurança contra nulos. 

Pattern Matching: Poder de decisão conciso. 

Expression-bodied members: Código enxuto. 

Records e with: Imutabilidade e manipulação de dados. 

Token field: Validação moderna em propriedades. 

Null-conditional assignment: Atribuições seguras e elegantes. 

 
 

Checkpoint Final: Ao rodar o código, você verá Total do cliente: 150.00. Se mudar para null, verá que o programa ignora a soma e segue viagem sem travar.
