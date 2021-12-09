namespace Projeto_PI___REALCRED.obj
{
    public class Produto
    {
        String Tipo, PublicoAlvo;
        double Juros;

        public Produto(String atributo1, String atributo2, double atributo3)
        {

            this.Tipo = atributo1;
            this.PublicoAlvo = atributo2;
            this.Juros = atributo3;
        }

        public void imprimir()
        {
            Console.WriteLine("\nTipo do produto: [" + this.Tipo + "]");
            Console.WriteLine("Produto destinado à (target): " + this.PublicoAlvo);
            Console.WriteLine("Taxa de juros mensal (por parcela) " + Math.Round(this.Juros - 1, 2) + " % a.m.");
        }
    }
}