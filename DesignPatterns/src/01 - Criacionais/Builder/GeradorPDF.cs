namespace DesignPatterns.Criacionais.Builder;

public class GeradorPDF
{
    public string PageOrientation { get; set; } = "portrait";
    public string Unit { get; set; } = "mm";
    public int PageSizeX { get; set; } = 210;
    public int PageSizeY { get; set; } = 297;
    public int MarginTop { get; set; } = 30;
    public int MarginRight { get; set; } = 20;
    public int MarginBottom { get; set; } = 30;
    public int MarginLeft { get; set; } = 20;
    public bool HasHeader { get; set; } = false;
    public int HeaderHeigh { get; set; } = 0;
    public bool HasFooter { get; set; } = false;
    public int FooterHeigh { get; set; } = 0;
    public string PageColor { get; set; } = "#ffffff";
    public string Encode { get; set; } = "UTF-8";

    public string ToString()
    {
        var saida = "";

        saida += $"pageOrientation: {PageOrientation}\n";
        saida += $"unit: {Unit}\n";
        saida += $"PageSizeX: {PageSizeX}mm\n";
        saida += $"PageSizeY: {PageSizeY}mm\n";
        saida += $"maginTop: {MarginTop}mm\n";
        saida += $"maginRight: {MarginRight}mm\n";
        saida += $"maginBottom: {MarginBottom}mm\n";
        saida += $"maginLeft: {MarginLeft}mm\n";
        saida += HasHeader ? "hasHeader: Sim\n" : "hasHeader: Não\n";
        saida += $"headerHeigh: {HeaderHeigh}mm\n";
        saida += HasFooter ? "hasFooter: Sim\n" : "hasFooter: Não\n";
        saida += $"footerHeigh: {FooterHeigh}mm\n";
        saida += $"pageColor: {PageColor}\n";
        saida += $"encode: {Encode}\n";

        return saida;
    }
}