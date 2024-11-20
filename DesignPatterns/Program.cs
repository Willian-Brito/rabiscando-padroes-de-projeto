using DesignPatterns.Comportamentais.Observer;
using DesignPatterns.Comportamentais.State;
using DesignPatterns.Comportamentais.Strategy;
using DesignPatterns.Comportamentais.TemplateMethod;
using DesignPatterns.Criacionais.FactoryMethod;
using DesignPatterns.Estruturais.Adapter;
using DesignPatterns.Estruturais.Decorator;
using DesignPatterns.Estruturais.Facade;

while (true)
{
    Console.Clear();
    Console.WriteLine("Escolha a operação:");
    Console.WriteLine("------------------------");
    Console.WriteLine("Padrões Criacionais");
    Console.WriteLine("------------------------");
    Console.WriteLine("1 - Abstract Factory");
    Console.WriteLine("2 - Factory Method");
    Console.WriteLine("3 - Singleton");
    Console.WriteLine("4 - Builder");
    Console.WriteLine("5 - Prototype");
    Console.WriteLine("------------------------");
    Console.WriteLine("Padrões Estruturais");
    Console.WriteLine("------------------------");
    Console.WriteLine("6 - Adapter");
    Console.WriteLine("7 - Bridge");
    Console.WriteLine("8 - Composite");
    Console.WriteLine("9 - Decorator");
    Console.WriteLine("10 - Facade");
    Console.WriteLine("11 - Flyweight");
    Console.WriteLine("12 - Proxy");
    Console.WriteLine("------------------------");
    Console.WriteLine("Padrões Comportamentais");
    Console.WriteLine("------------------------");
    Console.WriteLine("13 - Chain of Responsability");
    Console.WriteLine("14 - Command");
    Console.WriteLine("15 - Interpreter");
    Console.WriteLine("16 - Iterator");
    Console.WriteLine("17 - Mediator");
    Console.WriteLine("18 - Memento");
    Console.WriteLine("19 - Observer");
    Console.WriteLine("20 - State");
    Console.WriteLine("21 - Strategy");
    Console.WriteLine("22 - Template Method");
    Console.WriteLine("23 - Visitor");
    Console.WriteLine("------------------------");

    var opcao = Console.ReadLine();

    Console.WriteLine("");
    Console.WriteLine("------------------------");
    Console.WriteLine("");

    switch (opcao)
    {
        #region 01 - Padrões Criacionais
        // case "1":
        //     AbstractFactory.Executar();
        //     break;
        case "2":
            FactoryMethod.Executar();
            break;
        // case "3":
        //     Singleton.Executar();
        //     break;
        // case "4":
        //     Builder.Executar();
        //     break;
        // case "5":
        //     Prototype.Executar();
        //     break;
        #endregion

        #region 02 - Padrões Estruturais
        case "6":
            Adapter.Executar();
            break;
        // case "7":
        //     Bridge.Executar();
        //     break;
        // case "8":
        //     Composite.Executar();
        //     break;
        case "9":
            Decorator.Executar();
            break;
        case "10":
            Facade.Executar();
            break;
        // case "11":
        //     Flyweight.Executar();
        //     break;
        // case "12":
        //     Proxy.Executar();
        //     break;
        #endregion

        #region 03 - Padrões Comportamentais
        // case "13":
        //     ChainOfResposability.Executar();
        //     break;
        // case "14":
        //     Command.Executar();
        //     break;            
        // case "15":
        //     Interpreter.Executar();
        //     break;
        // case "16":
        //     Iterator.Executar();
        //     break;
        // case "17":
        //     Mediator.Executar();
        //     break;
        // case "18":
        //     Memento.Executar();
        //     break;
        case "19":
            Observer.Executar();
            break;
        case "20":
            State.Executar();
            break;
        case "21":
            Strategy.Executar();
            break;
        case "22":
            TemplatMethod.Executar();
            break;
        // case "23":
        //     Visitor.Executar();
        //     break;
        #endregion
    }

    Console.ReadKey();
}