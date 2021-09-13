using Lab.Tp2.Exceptions;

namespace Lab.Tp2
{
    public class Logic
    {
        public void EjercicioTres(int numero)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            array[7] = numero;
        }

        public void EjercicioCuatro()
        {
            throw new CustomException();
        }
    }
}
