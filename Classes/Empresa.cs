namespace Projeto_PI___REALCRED.Classes
{

    public class Empresa
    {
        String Missao, Visao, Valores, QuemSomos;
        public Empresa()
        {
            this.Missao = "Exercer consultoria em T.I. com excelência em qualidade, além de transparência e pontualidade, \n apresentando soluções viáveis e acessíveis nas mais diversas áreas de atuação da empresa que envolvem tecnologia para agregar valor à instituição.";
            this.Visao = "Ser refêrencia regional como empresa prestadora de serviços na área de tecnologia da informação, \n com serviços de excelência e qualidade total, praticando preços competitivos e com comprometimento perante a sociedade.";
            this.Valores = "Ética, Respeito, Sustentabilidade, Inovação Constante, Melhoramento Contínuo e Comprometimento.";
            this.QuemSomos = "Uma empresa de consultoria que integra as mais diversas áreas do saber humano às inovações tecnológicas do mundo contemporâneo.";
        }

        public Empresa(String atributo1, String atributo2, String atributo3, String atributo4)
        {
            this.QuemSomos = atributo1;
            this.Missao = atributo2;
            this.Visao = atributo3;
            this.Valores = atributo4;
        }

        public String getMissao()
        {
            return Missao;
        }

        public string getQuemSomos()
        {
            return QuemSomos;
        }

        public string getVisao()
        {
            return Visao;
        }

        public string getValores()
        {
            return Valores;
        }
    }


}