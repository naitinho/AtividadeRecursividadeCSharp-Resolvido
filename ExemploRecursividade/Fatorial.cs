namespace ExemploRecursividade;

public static class Fatorial
{
    public static int CalculaFatorial(int numero, int resultado = 1)
    {
        {
            
            
          for (int n = 1; n <= numero; n++){
            resultado  *= n;
            
          }
        }
        
        return resultado;
    }
}
