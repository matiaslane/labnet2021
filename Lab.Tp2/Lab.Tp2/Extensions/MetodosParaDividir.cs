namespace Lab.Tp2.Extensions
{
    public static class MetodosParaDividir
    {
        public static void DividirPorCero(this int numero)
        {
            var resultado = numero / 0;
        }

        public static decimal Dividir(this decimal numero, decimal numero1)
        {
            decimal resultado;
            return resultado = numero / numero1;
        }
    }
}
