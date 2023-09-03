namespace ExemploRecursividade
{
    public static class Multipl
    {
        public static int MultiplicacaoPorSoma(int numero, int vezes)
        {
            if (vezes == 0){
                return 0;
                }

            else if (vezes == 1){
                return numero;
                }

            else{
                return numero + MultiplicacaoPorSoma(numero, vezes - 1);
            }
        }
    }
}
