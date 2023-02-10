using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability
{
    public class operaciones : Variables
    {
        public void suma()
        {
            Console.WriteLine("Digite el nombre de la operacion");
            Console.WriteLine("Suma");
            Console.WriteLine("Resta");
            Console.WriteLine("Multiplicacion");
            Console.WriteLine("Division");

            operacion = Console.ReadLine();
            Console.WriteLine("Digite la primera cantidad");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite la segunda cantidad");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            if (operacion == "Suma")
            {
                resultado = numero1 + numero2;
                Console.WriteLine("El resultado de la suma es:" + resultado);
                Console.ReadLine();
            }

            if (operacion == "Resta")
            {
                resultado = numero1 - numero2;
                Console.WriteLine("El resultado de la resta es:" + resultado);
                Console.ReadLine();
            }

            if (operacion == "Multiplicacion")
            {
                resultado = numero1 * numero2;
                Console.WriteLine("El resultado de la multiplicacion es:" + resultado);
                Console.ReadLine();
            }

            if (operacion == "Division")
            {
                resultado = numero1 / numero2;
                Console.WriteLine("El resultado de la division es:" + resultado);
                Console.ReadLine();
            }
        }

    }
}
