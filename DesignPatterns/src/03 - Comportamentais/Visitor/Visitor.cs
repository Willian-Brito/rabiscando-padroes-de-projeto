namespace DesignPatterns.Comportamentais.Visitor;

public class Visitor
{
    public static void Executar()
    {
        var supermercado = new Supermercado("Supermercado Esquina");

        var departamento1 = new Departamento("Alimentação Básico");
        var arroz = new Produto("Arroz 5 Kg", 18, 30);
        var macarrao = new Produto("Macarrão", 3.20M, 15);

        departamento1.AddProduto(arroz);
        departamento1.AddProduto(macarrao);

        var departamento2 = new Departamento("Higiêne");
        var papelHigienico = new Produto("Papel Higiênico", 11, 35);
        var sabonete = new Produto("Sabonete", 1.20M, 10);

        departamento2.AddProduto(papelHigienico);
        departamento2.AddProduto(sabonete);

        supermercado.AddDepartamento(departamento1);
        supermercado.AddDepartamento(departamento2);

        var lucratividade = new Lucratividade();
        var lucratividadeSupermercado = supermercado.Aceitar(lucratividade);
        Console.WriteLine($"Lucratividade Supermercado: R$ {lucratividadeSupermercado}");

        var lucratividadeDepartamento1 = departamento1.Aceitar(lucratividade);
        Console.WriteLine($"\n\nLucratividade Departamento 1: R$ {lucratividadeDepartamento1}");

        var lucratividadeArroz = arroz.Aceitar(lucratividade);
        Console.WriteLine($"\n\nLucratividade Arroz: R$ {lucratividadeArroz}");

        var lucratividadeMacarrao = macarrao.Aceitar(lucratividade);
        Console.WriteLine($"\n\nLucratividade Macarrão: R$ {lucratividadeMacarrao}");

        var lucratividadeDepartamento2 = departamento2.Aceitar(lucratividade);
        Console.WriteLine($"\n\nLucratividade Departamento 2: R$ {lucratividadeDepartamento2}");

        var lucratividadePapelHigienico = papelHigienico.Aceitar(lucratividade);
        Console.WriteLine($"\n\nLucratividade Papel Higiênico: R$ {lucratividadePapelHigienico}");

        var lucratividadeSabonete = sabonete.Aceitar(lucratividade);
        Console.WriteLine($"\n\nLucratividade Sabonete: R$ {lucratividadeSabonete}");
    }
}