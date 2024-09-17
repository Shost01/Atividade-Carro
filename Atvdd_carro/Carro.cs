class Carro
{
    private int ano;
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public int Ano
    {
        get => ano;
        set
        { 
            if(value <1960 || value > 2023)
            {
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
            }
            else
            {
                ano = value;
            }
        }
    }
    public int Qtdportas { get; set; }
    public int velocidade = 0;
    public string DescricaoDetalhada => $"Informações:\nFabricante = {Fabricante}\nModelo = {Modelo}\nAno = {ano}\nPortas = {Qtdportas}";


    public void Acelerar()
    {
        Console.WriteLine("Vrummmm.....");
        if ( velocidade < 100 ) 
        {
            velocidade = velocidade + 5;
        }
    }
    public void Frear()
    {
        Console.WriteLine("Freando....");
        if( velocidade > 0 )
        {
            velocidade = velocidade - 5;    
        }
    }

    public void Buzinar() 
    {
        Console.WriteLine("Bi Bi Biiiiiiiii");
    }
}
