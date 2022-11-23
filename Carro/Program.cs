namespace Carro
{



    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            c.tanque = 50;
            c.Marca = "VW";
            c.setProprietario("Ricardo Frohlich da Silva");
            c.setChassi("2345¨&*WERTYUIO");
            Console.WriteLine(c.Marca+" "+c.getProprietario()+" "+c.getChassi());
        }
    }
}