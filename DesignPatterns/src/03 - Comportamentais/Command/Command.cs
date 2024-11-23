using DesignPatterns.Comportamentais.Command.Comandos;

namespace DesignPatterns.Comportamentais.Command;

public class Command
{
    public static void Executar()
    {
        #region Sem Padrão Command
        // var lampadaSala = new Lampada("Lampada da Sala", false);
        
        // lampadaSala.Ligar();
        // lampadaSala.ImprimirObjeto();

        // lampadaSala.Desligar();
        // lampadaSala.ImprimirObjeto();

        // var lampadaQuarto = new Lampada("Lampada do Quarto", false);
        
        // lampadaQuarto.Ligar();
        // lampadaQuarto.ImprimirObjeto();

        // lampadaQuarto.Desligar();
        // lampadaQuarto.ImprimirObjeto();
        
        // var arCondicionado = new ArCondicionado("Ar-condicionado", false, 26);
        
        // arCondicionado.Ligar();
        // arCondicionado.ImprimirObjeto();
        // arCondicionado.SetTemperatura(25);
        // arCondicionado.ImprimirObjeto();
        // arCondicionado.Desligar();
        // arCondicionado.ImprimirObjeto();
        #endregion

        #region Com Padrão Command
        var app = new Aplicativo();
        var lampadaSala = new Lampada("Lampada da Sala", false);
        var lampadaQuarto = new Lampada("Lampada do Quarto", false);
        var arCondicionado = new ArCondicionado("Ar-condicionado", false, 26);

        var ligarLampadaSala = new LigarLampada(lampadaSala);
        var ligarLampadaQuarto = new LigarLampada(lampadaQuarto);
        var desligarLampadaSala = new DesligarLampada(lampadaSala);
        var desligarLampadaQuarto = new DesligarLampada(lampadaQuarto);
        var ligarAr = new LigarArCondicionado(arCondicionado);
        var desligarAr = new DesligarArCondicionado(arCondicionado);
        var mudarTemperatura = new MudarTemperatura(arCondicionado);

        var idLigarLamapadaSala = app.SetComando(ligarLampadaSala);
        var idDesligarLamapadaSala = app.SetComando(desligarLampadaSala);
        var idLigarLamapadaQuarto = app.SetComando(ligarLampadaQuarto);
        var idDesligarLamapadaQuarto = app.SetComando(desligarLampadaQuarto);
        var idLigarAr = app.SetComando(ligarAr);
        var idDesligarAr = app.SetComando(desligarAr);
        var idMudarTemperatura = app.SetComando(mudarTemperatura);

        app.AoPrecionarBotao(idLigarLamapadaSala);
        app.AoPrecionarBotao(idDesligarLamapadaSala);
        app.AoPrecionarBotao(idLigarLamapadaQuarto);
        app.AoPrecionarBotao(idDesligarLamapadaQuarto);
        app.AoPrecionarBotao(idLigarAr);        

        var comando = (MudarTemperatura)app.GetComando(idMudarTemperatura);
        comando.SetTemperatura(25);

        app.AoPrecionarBotao(idMudarTemperatura);
        app.AoPrecionarBotao(idDesligarAr);

        Console.WriteLine("\n## Desfazer Comandos\n");

        app.DuploClick(idDesligarAr);
        app.DuploClick(idMudarTemperatura);
        app.DuploClick(idDesligarLamapadaQuarto);
        app.DuploClick(idLigarLamapadaSala);
        
        #endregion
    }
}