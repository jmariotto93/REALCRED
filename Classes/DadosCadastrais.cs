namespace Projeto_PI___REALCRED.Classes
{
    public class DadosCadastrais
    {
        private string rua="";
        private string numero="";
        private string bairro="";
        private string cidade="";
        private string estado="";


        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public string ImprimirDadosCadastrais()
        {
            return $"Rua: {rua} Número: {numero} Bairro: {bairro} Cidade: {cidade} Estado: {estado} ";
        }


    }
}