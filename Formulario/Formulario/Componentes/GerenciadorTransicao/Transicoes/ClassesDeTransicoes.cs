namespace ProjetoFormulario.Componentes.GerenciadorTransicao.Transicoes;

public static class ClassesDeTransicoes
{
    public static class Animate
    {
        public static string EfeitoSlideParaDireita => AdicioneEfeito("slideInRight");
        public static string EfeitoSlideParaEsquerda => AdicioneEfeito("slideInLeft");

        private static string AdicioneEfeito(string efeito) =>
            $"animate__animated animate__{efeito}";
    }
}

