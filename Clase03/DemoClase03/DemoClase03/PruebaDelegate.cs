using Microsoft.VisualBasic.FileIO;

namespace DemoClase03
{
    public class PruebaDelegate
    {
        public delegate void Del(string message);
        public delegate string DeEnteroAString(int valor);
        public static void DelegateMethod(string message)
        {
            var result = new DeEnteroAString(FuncionRetornarToString);
            Func<int, string> delegateFunc = FuncionRetornarToString;
            var resultado = delegateFunc(23);
            Action<string,int> delegateAction = ejemplo;
            delegateAction(message,3000);
            Template(result, 10);
            Console.WriteLine(message);
            Console.WriteLine("Resultado delegate abreviado func:"+resultado);
        }
        public static void ejemplo(string message,int valor)
        {
            Console.WriteLine("El mensaje  action es:"+message);
            Console.WriteLine("El valor  action es:"+valor);
        }
        public  void FuncionFinal(string valor)
        {
            Del del = DelegateMethod;
            del(valor);
        }
        public static string FuncionRetornarToString(int valor)
        {
            return valor.ToString();
        }
        public static void Template(DeEnteroAString algoritmo,int valor)
        {
            Console.WriteLine("el algoritmo es" + algoritmo(valor));
        }
    }
}
