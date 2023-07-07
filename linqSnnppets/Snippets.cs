using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace linqSnnppets
{
    public class Snippets
    {
        static public void BasicLinq()
        {
            string[] cars =
            {
                "W Golf",
                "W California",
                "Audi A3",
                "Audi A5",
                "Fiat Punto",
                "Seat Ibiza",
                "Seat Leon"
            };
            //SELECT * of cars (select all cars)
            var carList = from car in cars select car;
            foreach (var car in carList)
            {
                Console.WriteLine(car);
            }

            //SELECT WHERE car is Audi (select only audis)
            var audiList = from car in cars where car.Contains("Audi") select car;


            foreach (var audi in audiList)
            {
                Console.WriteLine(audi);
            }




        }

        //ejempls con numeros
        static public void LinqNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //cada numero multiplicado por 3, despues actualizamos y obtenemos todos los numeros menos el 9 y finalmente los ordenamos

            var numberListProcessed = from number in numbers.Select(num => num * 3)
                             .Where(num => num != 9)
                             .OrderBy(num => num)
                                      select number;

        }
        static public void SearchElements()
        {
            List<string> textList = new List<string>
            {
                "a",
                "bx",
                "c",
                "d",
                "e",
                "cj",
                "f"
            };
            //1. encontrar el primer elemento
            var first = textList.First();
            //2. primer elemento que sea c
            var cText = textList.First(text => text.Equals("c"));
            //3. primer elemento  que contenga z o valor por defecto
            var primerElementoZoPorDefecto = textList.FirstOrDefault(cText => cText.Contains(""));
            //4. ultimo elemento  que contenga z o valor por defecto
            var ultimooPorDefecto = textList.LastOrDefault(cText => cText.Contains("z"));
            //5.valores unicos
            var unicosText = textList.Single();
            var unicosTextDefault = textList.SingleOrDefault();

            int[] evenNumbers = { 0, 2, 4, 6, 8 };
            int[] otrosEvenNumbers = { 0, 2, 6, };
            //obtener {4,8}
            var myNumbers = evenNumbers.Except(otrosEvenNumbers);//{4,8}


            var Empresas = new[]
            {
                new Empresa()
                {
                    Id = 1,
                    Name="Empresa 1",
                   Empleados =new []
                {
                 new Empleado()
                {
                    Id = 2,
                    Nombre="Pedro",
                    Email="pedro@hotmail.com",
                    Salario=3000
                },
                  new Empleado()
                {
                    Id = 3,
                    Nombre="Jr Martin",
                    Email="martin@hotmail.com",
                    Salario=3000
                },
                   new Empleado()
                {
                    Id = 4,
                    Nombre="Nancy",
                    Email="Nancy@hotmail.com",
                    Salario=3000
                }
            }
} };
        }
    }
}




