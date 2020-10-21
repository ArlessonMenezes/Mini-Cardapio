namespace ModificadorDeParametros
{
    class Cardapio
    {
        public string Name { get; set; }
        public double Price { get; set; }

      public Cardapio()
        {
            
        }

        public void ValorQte(double qte)
        {
            Price *= qte;
        }
    }
}
