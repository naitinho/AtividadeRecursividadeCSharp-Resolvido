namespace ExemploRecursividade;

public static class Mdc
{
    public static int CalculaMdc(int numero1, int numero2)
    {
        if (numero1 == 0)
        {
            return numero2;
        }

        if (numero2 == 0)
        {
            return numero1;
        }

        while (numero2 != 0)
        {
            int resto = numero1 % numero2;

            numero1 = numero2;
            numero2 = resto;
        }

        return numero1;
    }
}
