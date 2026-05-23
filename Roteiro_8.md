# Roteiro 8

Roteiro de implementação (passo a passo) 

Parte A - Preparando o ambiente e o projeto 

1. Criar um projeto Console App em C#. 

2. Executar o projeto vazio para confirmar que o ambiente está funcional. 

3. Identificar onde ficará o código principal (arquivo com o ponto de entrada). 

Parte B - Construindo a classe base Animal 

4. Criar uma classe chamada Animal. 

5. Adicionar uma propriedade pública chamada Nome: 

 tipo string; 

 com get; e set;. 

6. Adicionar um método público chamado Comer(): 

 retorno void; 

 deve escrever uma frase no console contendo o Nome; 

 usar interpolação de string com $”...”. 

7. Adicionar um método público chamado FazerSom(): 

 retorno void; 

 deve ser marcado com virtual; 

 deve escrever um texto de som genérico. 

Verificação 1 

 O projeto compila com a classe Animal criada. 

 A classe contém Nome, Comer() e virtual FazerSom(). 

Parte C - Construindo a classe derivada Cachorro 

8. Criar uma classe chamada Cachorro que herde de Animal. 

9. Adicionar um método público chamado AbanarRabo(): 

 retorno void; 

 deve escrever uma frase no console contendo o Nome. 

10. Sobrescrever o método FazerSom() em Cachorro: 

 usar override; 

 imprimir um som característico. 

Verificação 2 

 O projeto compila com as duas classes. 

 Cachorro possui AbanarRabo() e override FazerSom(). 

Parte D - Criando animal1 e testando o comportamento da classe base 

11. No programa principal, criar uma variável chamada animal1 do tipo Animal, 

instanciando Animal. 

12. Atribuir um valor para animal1.Nome. 

13. Chamar animal1.FazerSom() e observar a saída. 

Verificação 3 

 A saída corresponde ao som genérico, pois o objeto é realmente um Animal. 

Parte E - Criando animal2 como Animal, mas instanciando Cachorro (polimorfismo) 

14. Criar uma variável chamada animal2 do tipo Animal, instanciando Cachorro. 

15. Atribuir um valor para animal2.Nome. 

16. Chamar animal2.FazerSom() e observar a saída. 

Verificação 4 

 A chamada deve executar o override de Cachorro, pois o tipo real do objeto é 

Cachorro. 

Parte F = Entendendo o erro: por que animal2.AbanarRabo() não compila 

17. Escrever (e comentar) uma linha chamando animal2.AbanarRabo(). 

18. Compilar e observar o erro de compilação. 

19. Explicar no relatório: 

 a variável é do tipo Animal; 

 Animal não declara AbanarRabo(); 

 o compilador valida pela informação do tipo da variável (tipo estático). 

Parte G - Fazendo o casting para acessar o método específico 

20. Substituir a chamada inválida por uma chamada que faça casting explícito para 

Cachorro: 

 converter animal2 para Cachorro; 

 chamar AbanarRabo() no resultado. 

21. Executar e observar a saída. 

22. No relatório, explicar: 

 o cast funciona porque o objeto real foi criado como Cachorro; 

 se o objeto real não fosse um Cachorro, ocorreria erro em tempo de execução. 

Parte H - Chamando um método que existe na base 

23. Chamar animal2.Comer() e observar que funciona sem cast. 

24. Explicar no relatório: 

 Comer() pertence à classe base, então está disponível na referência do tipo Animal. 

Desafios de aprimoramento (para aumentar a nota) 

Escolher ao menos dois: 

1. Usar is para verificar o tipo antes do cast 

• verificar se animal2 é Cachorro; 

• apenas então chamar AbanarRabo(). 

2. Usar o operador as e checar null 

 converter com as; 

 chamar AbanarRabo() apenas se a conversão não resultar em null. 

3. Adicionar uma nova classe derivada 

 por exemplo, Gato : Animal; 

 sobrescrever FazerSom() com um som diferente; 

 instanciar como Animal animal3 = new Gato(); e comparar saídas. 

4. Demonstrar polimorfismo com coleção 

 criar uma List<Animal>; 

 inserir Animal, Cachorro e (se existir) Gato; 

 percorrer com foreach chamando FazerSom() 

 

Este roteiro é excelente para desmistificar a diferença entre o tipo da variável (tipo estático) e o tipo do objeto real (tipo dinâmico). Essa distinção é a chave para entender como o C# gerencia a memória e a visibilidade de métodos. 

Para os Desafios de Aprimoramento, implementarei as Opções 1 (Uso do is) e Opção 3 (Nova classe Gato), que ajudam a evitar erros de execução ao lidar com conversões de tipo. 

 
 

Partes B e C - Estrutura de Classes 

Aqui estabelecemos a base e a especialização. Note o uso de virtual e override. 

C# 

 

using System; 
using System.Collections.Generic; 
 

// --- PARTE B: Classe Base --- 
public class Animal 
{ 
    public string Nome { get; set; } = "Animal"; 
 

public void Comer() 
    { 
        Console.WriteLine($"{Nome} está comendo... 🍎"); 
    } 
 

public virtual void FazerSom() 
    { 
        Console.WriteLine("O animal faz um som genérico: ---"); 
    } 
} 
 

// --- PARTE C: Classe Derivada --- 
public class Cachorro : Animal 
{ 
    public void AbanarRabo() 
    { 
        Console.WriteLine($"{Nome} abanou o rabo! 🐕"); 
    } 
 

public override void FazerSom() 
    { 
        Console.WriteLine($"{Nome} diz: Au Au! 🐾"); 
    } 
} 
 

// --- DESAFIO 3: Nova Classe Derivada --- 
public class Gato : Animal 
{ 
    public override void FazerSom() 
    { 
        Console.WriteLine($"{Nome} diz: Miau! 🐱"); 
    } 
} 
 

 
 

Partes D a H - Testes e Polimorfismo no Main 

Aqui exploramos o comportamento das referências e o processo de casting. 

C# 

 

class Program 
{ 
    static void Main() 
    { 
        Console.WriteLine("=== DEMONSTRAÇÃO DE POLIMORFISMO E CASTING ===\n"); 
 

// --- PARTE D: Objeto Animal --- 
        Animal animal1 = new Animal(); 
        animal1.Nome = "Criatura"; 
        animal1.FazerSom(); // Saída: Som genérico 
 

// --- PARTE E: Polimorfismo (Cachorro em referência de Animal) --- 
        Animal animal2 = new Cachorro(); 
        animal2.Nome = "Rex"; 
        animal2.FazerSom(); // Saída: Au Au! (O override prevalece) 
 

// --- PARTE F: O Erro de Compilação --- 
        // animal2.AbanarRabo();  
        // ERRO: 'Animal' não contém uma definição para 'AbanarRabo'. 
        // Explicação: O compilador olha para o tipo da VARIÁVEL (Animal) para validar o que pode ser chamado. 
 

// --- PARTE G e H: Casting e Membros da Base --- 
        Console.WriteLine("\n--- Acessando Métodos Específicos ---"); 
         
        // Chamada direta da base (Funciona sem cast) 
        animal2.Comer();  
 

// Casting explícito (Conversão) 
        ((Cachorro)animal2).AbanarRabo(); 
 

// --- DESAFIO 1: Casting Seguro com 'is' --- 
        if (animal2 is Cachorro cao) 
        { 
            Console.WriteLine("[Seguro] Confirmado: animal2 é um cachorro."); 
            cao.AbanarRabo(); 
        } 
 

// --- DESAFIO 3: Comparação com Gato --- 
        Animal animal3 = new Gato { Nome = "Luna" }; 
        Console.WriteLine("\n--- Comparação de Sons ---"); 
        animal2.FazerSom(); 
        animal3.FazerSom(); 
 

Console.WriteLine("\nPressione ENTER para finalizar."); 
        Console.ReadLine(); 
    } 
} 
 

 
 

Registro para o Relatório (Explicações Técnicas) 

1. Por que animal2.AbanarRabo() falha na compilação? 

O C# é uma linguagem de tipagem estática. Quando você declara Animal animal2, o compilador garante que você só possa chamar métodos que existam na classe Animal. Como AbanarRabo é exclusivo da classe Cachorro, o compilador "não o enxerga" através dessa referência, mesmo que o objeto na memória seja um cachorro. 

2. O papel do Casting (Partes G e H) 

O Casting é a forma de dizer ao compilador: "Eu sei que este Animal é, na verdade, um Cachorro, por favor, mude a lente pela qual o vemos". 

Casting Direto (Cachorro)animal2: É rápido, mas perigoso. Se animal2 fosse um Gato, o programa travaria com uma InvalidCastException. 

Casting com is: É a prática moderna e segura. Ele verifica o tipo e já cria uma variável temporária (cao) se a verificação for verdadeira. 

3. Polimorfismo vs. Referência 

A saída de animal2.FazerSom() mostra o som do cachorro porque o método foi marcado como virtual na base. No C#, métodos virtuais são resolvidos em tempo de execução (late binding). O computador olha para o objeto real na memória e vê que ele tem uma versão mais específica (override) daquele método. 

 
 

Checklist de Verificação 

[x] animal1 exibe som genérico. 

[x] animal2 exibe som de cachorro (mesmo sendo do tipo Animal). 

[x] O erro de compilação foi identificado e explicado. 

[x] O cast foi realizado com sucesso. 

[x] O uso de is garante que o programa não quebre ao testar tipos diferentes.
