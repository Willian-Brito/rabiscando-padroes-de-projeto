namespace DesignPatterns.Criacionais.Builder;

public class Builder
{
    public static void Executar()
    {
        #region Sem Builder

        #region PDF A4
        // Console.WriteLine("\n## Criação do Objeto A4 ##\n");

        // var a4 = new GeradorPDF
        // (
        //     pageOrientation: "portrait",
        //     unit: "mm",
        //     pageSizeX: 210,
        //     pageSizeY: 297,
        //     marginTop: 30,
        //     marginRight: 20,
        //     marginBottom: 30,
        //     marginLeft: 20,
        //     hasHeader: true,
        //     headerHeigh: 15,
        //     hasFooter: true,
        //     footerHeigh: 15,
        //     pageColor: "#ffffff",
        //     encode: "UTF-8"
        // );

        // Console.WriteLine(a4.ToString());
        #endregion

        #region PDF A3
        // Console.WriteLine("\n## Criação do Objeto A3##\n");

        // var a3 = new GeradorPDF
        // (
        //     pageOrientation: "portrait",
        //     unit: "mm",
        //     pageSizeX: 297,
        //     pageSizeY: 420,
        //     marginTop: 60,
        //     marginRight: 40,
        //     marginBottom: 60,
        //     marginLeft: 40,
        //     hasHeader: false,
        //     headerHeigh: 0,
        //     hasFooter: false,
        //     footerHeigh: 0,
        //     pageColor: "#ffffff",
        //     encode: "UTF-8"
        // );

        // Console.WriteLine(a3.ToString());
        #endregion

        #endregion

        #region Com Builder

        #region PDF A4
        Console.WriteLine("\n## Criação do Objeto A4 ##\n");

        GeradorPDF pdf;
        var a4 = new BuilderA4();
        var director = new DirectorGeradorPDF(a4);

        director.CriarGeradorPDF();        
        pdf = a4.GetGeradorPDF();

        Console.WriteLine(pdf.ToString());
        #endregion 

        #region PDF A3
        Console.WriteLine("\n## Criação do Objeto A3##\n");

        var a3 = new BuilderA3();

        director.SetBuilderGeradorPDF(a3);
        director.CriarGeradorPDF();
        pdf = a3.GetGeradorPDF();

        Console.WriteLine(pdf.ToString());
        #endregion

        #endregion
    }
}