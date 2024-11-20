namespace DesignPatterns.Criacionais.Builder;

public class DirectorGeradorPDF
{
    private IBuilderGeradorPDF BuilderGeradorPDF;

    public DirectorGeradorPDF(IBuilderGeradorPDF builderGeradorPDF)
    {
        BuilderGeradorPDF = builderGeradorPDF;
    }

    public void SetBuilderGeradorPDF(IBuilderGeradorPDF builderGeradorPDF)
    {
        BuilderGeradorPDF = builderGeradorPDF;
    }

    public void CriarGeradorPDF()
    {
        BuilderGeradorPDF.SetPageConfiguration();
        BuilderGeradorPDF.SetMargin();
        BuilderGeradorPDF.SetHeader();
        BuilderGeradorPDF.SetFooter();
    }

    public void CriarGeradorPdfSemHeader()
    {
        BuilderGeradorPDF.SetPageConfiguration();
        BuilderGeradorPDF.SetMargin();        
        BuilderGeradorPDF.SetFooter();
    }

    public void CriarGeradorPdfSemHeaderSemFooter()
    {
        BuilderGeradorPDF.SetPageConfiguration();
        BuilderGeradorPDF.SetMargin();        
    }
}