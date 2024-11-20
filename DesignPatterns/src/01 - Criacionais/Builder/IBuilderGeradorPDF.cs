namespace DesignPatterns.Criacionais.Builder;

public interface IBuilderGeradorPDF
{
    GeradorPDF GetGeradorPDF();
    void SetPageConfiguration();
    void SetMargin();
    void SetHeader();
    void SetFooter();

}