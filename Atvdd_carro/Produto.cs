﻿class Produto
{
    private double preco;
    private int estoque;
    public string Marca { get; set; }
    public string Nome { get; set; }
    public double Preco
    {
        get => preco;
        set
        {
            if (value > 0)
            {
                preco = value;
            }
            else
            {
                preco = 10;
            }
        }
    }

    public int Estoque
    {
        get => estoque;
        set
        {
            if (value > 0)
            {
                estoque = value;
            }
            else
            {
                estoque = 0;
            }
        }
    }


    public string DescricaoDetalhadaP => $"Informações:\nMarca = {Marca}\nNome = {Nome}\nPreço = {Preco}\nEstoque = {Estoque}";
}
