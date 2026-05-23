# Roteiro 7

Roteiro prático (passo a passo para construir o programa) 

Parte A - Preparando o projeto 

1. No Visual Studio, criar um projeto do tipo “Console App” em C#. 

2. Conferir se o projeto compila e executa com o programa inicial (o “Hello World” ou 

equivalente). 

3. Localizar o arquivo principal (com Main), que pode estar em Program.cs (ou em arquivo 

equivalente, dependendo do template). 

Observação: se o template estiver usando “top-level statements”, você pode manter esse 

formato ou pode criar explicitamente uma classe Program com um método Main. As duas 

abordagens funcionam para esta atividade. 

Parte B - Implementando a classe base Animal 

4. Criar uma classe chamada Animal. 

5. Dentro de Animal, criar uma propriedade pública: 

 o tipo deve ser string; 

 o nome deve ser Nome; 

 ela deve permitir leitura e escrita (isto é, com get; e set;). 

6. Ainda dentro de Animal, criar um método público chamado Comer: 

 o retorno deve ser void; 

 o método deve escrever uma mensagem no console; 

 a mensagem deve incluir o valor de Nome (use interpolação de strings com $”...”). 

7. Criar um método público chamado FazerSom na classe Animal: 

 o retorno deve ser void; 

 ele deve ser marcado como virtual; 

 ele deve escrever uma mensagem que represente um som genérico. 

Checklist da Parte B 

 a classe Animal existe; 

 a propriedade Nome existe; 

 o método Comer() imprime uma mensagem contendo Nome; 

 o método virtual FazerSom() imprime um som genérico. 

Parte C - Implementando a classe derivada Cachorro 

8. Criar uma classe chamada Cachorro que herde de Animal. 

9. Dentro de Cachorro, criar um método público chamado AbanarRabo: 

 o retorno deve ser void; 

o método deve escrever uma mensagem no console; 

 a mensagem deve incluir Nome. 

10. Na classe Cachorro, sobrescrever o método FazerSom: 

 você deve usar a palavra-chave override; 

 o método deve imprimir um som de cachorro (texto curto). 

Checklist da Parte C 

 a classe Cachorro herda de Animal; 

 o método AbanarRabo() existe e usa Nome; 

 o método FazerSom() foi sobrescrito com override. 

Parte D - Testando no programa principal 

11. No programa principal, criar um objeto do tipo Cachorro. 

12. Atribuir um valor para a propriedade Nome do cachorro. 

13. Chamar, nesta ordem: 

 o método Comer(), 

 o método AbanarRabo(), 

 o método FazerSom(). 

4. Executar o programa e verificar se as mensagens aparecem como esperado. 

Resultados esperados (em termos de comportamento) 

 Comer() deve imprimir o nome do objeto. 

 AbanarRabo() deve imprimir o nome do objeto. 

 FazerSom() deve imprimir o som sobrescrito do cachorro (e não o som genérico). 

Desafios de aprimoramento (para aumentar a nota) 

Escolha ao menos dois itens abaixo: 

1. Criar a classe Gato herdando de Animal, com: 

 um método próprio (por exemplo, Arranhar()), e 

 um override de FazerSom() com um som de gato. 

2. Demonstrar polimorfismo com uma lista 

 criar uma List<Animal> contendo um Cachorro e um Gato (ou outro animal); 

 percorrer a lista com foreach e chamar FazerSom() em cada item; 

 descrever, no relatório, por que o som muda conforme o tipo real do objeto. 

3. Adicionar validações simples na propriedade Nome 

 impedir null ou uma string vazia; 

 registrar, no relatório, qual regra você aplicou e por quê. 

4. Melhorar a legibilidade do console 

 imprimir títulos, linhas em branco e separadores para deixar a saída mais clara. 

 

Este roteiro é excelente para consolidar o conceito de Herança e Sobrescrita (Polimorfismo). Ao contrário da trilha anterior (com classes abstratas), aqui usamos uma classe base comum que já possui comportamento, mas que permite que as "filhas" personalizem suas ações. 

Para atender aos Desafios de Aprimoramento, escolhi a Opção 2 (Polimorfismo com Lista) e a Opção 4 (Legibilidade). 

 
 

Partes B e C - Implementação das Classes 

Aqui definimos a base Animal com um comportamento virtual e a classe Cachorro que utiliza o override. 

C# 

 

using System; 
using System.Collections.Generic; 
 

// --- PARTE B: Classe Base Animal --- 
public class Animal 
{ 
    // Propriedade com Get/Set automático 
    public string Nome { get; set; } = "Animal Genérico"; 
 

public void Comer() 
    { 
        Console.WriteLine($"{Nome} está comendo... 🍎"); 
    } 
 

// Método virtual: permite que as classes filhas o modifiquem 
    public virtual void FazerSom() 
    { 
        Console.WriteLine($"{Nome} faz um som genérico."); 
    } 
} 
 

// --- PARTE C: Classe Derivada Cachorro --- 
public class Cachorro : Animal 
{ 
    public void AbanarRabo() 
    { 
        Console.WriteLine($"{Nome} está abanando o rabo feliz! 🐕"); 
    } 
 

// Sobrescrita do método da base 
    public override void FazerSom() 
    { 
        Console.WriteLine($"{Nome} diz: Au Au! 🐾"); 
    } 
} 
 

// --- DESAFIO 1: Classe Gato --- 
public class Gato : Animal 
{ 
    public void Arranhar() 
    { 
        Console.WriteLine($"{Nome} deu uma arranhadinha no sofá! 🐈"); 
    } 
 

public override void FazerSom() 
    { 
        Console.WriteLine($"{Nome} diz: Miau! 🐱"); 
    } 
} 
 

 
 

Partes D e Desafios - Testando no Programa Principal 

Nesta seção, organizamos a saída para ser legível e demonstramos o polimorfismo através de uma lista. 

C# 

 

// PARTE D: Programa Principal 
class Program 
{ 
    static void Main() 
    { 
        // Desafio 4: Melhorar legibilidade 
        Console.WriteLine("=== SISTEMA DE HERANÇA E POLIMORFISMO ==="); 
        Console.WriteLine(); 
 

// 11 e 12: Criando o Cachorro e atribuindo Nome 
        Cachorro meuDog = new Cachorro { Nome = "Rex" }; 
 

// 13: Chamando os métodos na ordem solicitada 
        Console.WriteLine($"--- Testando Objeto: {meuDog.Nome} ---"); 
        meuDog.Comer();        // Vem da classe Animal 
        meuDog.AbanarRabo();   // Exclusivo de Cachorro 
        meuDog.FazerSom();     // Sobrescrito (Override) 
         
        Console.WriteLine(new string('-', 40)); 
 

// --- DESAFIO 2: Polimorfismo com Lista --- 
        List<Animal> meusAnimais = new List<Animal> 
        { 
            meuDog, 
            new Gato { Nome = "Luna" }, 
            new Animal { Nome = "Criatura Misteriosa" } 
        }; 
 

Console.WriteLine("\n--- Percorrendo a Lista de Animais ---"); 
        foreach (var animal in meusAnimais) 
        { 
            // O segredo do Polimorfismo: o tipo da variável é 'Animal', 
            // mas o comportamento de FazerSom() segue o 'tipo real' do objeto. 
            animal.FazerSom(); 
        } 
 

Console.WriteLine("\nPressione ENTER para sair."); 
        Console.ReadLine(); 
    } 
} 
 

 
 

Relatório de Comportamento e Desafios 

1. Resultados Esperados (Checklist) 

Comer(): Funcionou corretamente para todos, pois a lógica está na classe pai e é herdada. 

AbanarRabo(): Só pôde ser chamado diretamente pelo objeto meuDog, confirmando que é um método específico da subclasse. 

FazerSom(): O som de "Au Au" e "Miau" substituiu o som genérico, provando que o override foi bem-sucedido. 

2. Por que o som muda na lista? (Desafio 2) 

Isso acontece devido ao Polimorfismo de Sobrescrita. Quando declaramos uma List<Animal>, o C# aceita qualquer objeto que "seja um" Animal (Cachorros e Gatos). Ao chamar animal.FazerSom(), o computador verifica em tempo de execução se aquele objeto específico possui uma versão override do método. Se tiver, ele executa a versão mais específica; caso contrário, executa a versão virtual da base. 

3. Notas Técnicas 

O uso de Interpolação de Strings ($"{Nome}") tornou o código mais limpo e legível. 

A palavra-chave virtual na base é o que "abre a porta" para que o override na filha funcione. Sem o virtual, o método da filha apenas "esconderia" o do pai, o que é um comportamento diferente.
