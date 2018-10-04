using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Escribe un programa que te calcule la largura de un string.

            Console.WriteLine("Escribe una frase.");
            String largura;
            largura = Console.ReadLine();
            Console.WriteLine(largura.Length);

            Console.ReadLine();

            ////Escribe un programa que te calcule el total de palabras que hay en un string.


            int palabras = 1;

            Console.WriteLine("Escribe una frase");
            string frasee;
            frasee = Console.ReadLine();

            for (int i = 0; i < frasee.Length; i++)
            {
                if (frasee[i] == ' ')
                {
                    palabras++;
                }
            }
            Console.WriteLine("La frase " + frasee + " contiene " + palabras + " palabras");
            Console.ReadLine();

            ////Escribe un programa que copia un string a otro string.

            Console.WriteLine("Escribe un texto a copiar");
            string copia;
            copia = Console.ReadLine();
            string b;
            b = string.Copy(copia);
            Console.WriteLine(b);


            Console.ReadLine();


            //Escribe un programa que nos cuente el número de vocales en un string.


            int vocales = 0;

            Console.WriteLine("Escribe una palabra");
            string palabra;
            palabra = Console.ReadLine();

            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] == 'a' || palabra[i] == 'e' || palabra[i] == 'i' || palabra[i] == 'o' || palabra[i] == 'u')
                {
                    //vocales = vocales + 1;
                    //vocales += 1;
                    vocales++;
                }

            }
            Console.WriteLine("La palabra " + palabra + " tiene " + vocales + " vocales");

            Console.ReadLine();


            ////Escribe un programa que devuelva un string en minúsculas en mayúsculas y al revés.

            Console.WriteLine("Escribe un palabro");
            string palabro;
            palabro = Console.ReadLine();

            Console.WriteLine(palabro.ToUpper());
            Console.WriteLine(palabro.ToLower());

            Console.ReadLine();


            //Escribe un programa que evalúe si un string contiene la letra ‘r’.


            Console.WriteLine("Escribe una palabra");
            string texto;
            texto = Console.ReadLine();


            if (texto.Contains('r'))
            {
                Console.WriteLine("La palabra tiene la letra r");
            }
            else
            {
                Console.WriteLine("La palabra no tiene la letra r");
            }


            Console.ReadLine();




            //Escribe un programa el que dada una frase sacará su carácter central. Nota:
            //a-Si la largura de la frase es par deberá sacar los dos caracteres centrales correspondientes.
            //b-Si es impar deberá sacar su único carácter central.

            Console.WriteLine("Escribe una frase");
            string frase;
            frase = Console.ReadLine();

            if (frase.Length % 2 == 0)
            {
                Console.WriteLine("Los caracteres centrales son " + frase[frase.Length / 2 - 1] + " y " + frase[frase.Length / 2]);
            }
            else
            {
                Console.WriteLine("El caracter central es " + frase[frase.Length / 2]);
            }
            Console.ReadLine();



            //Escribe un programa el cual analizará si la contraseña introducida es correcta o no. Para que la contraseña sea correcta deberá cumplir estas directivas:
            //a-Debe tener 8 caracteres como mínimo.
            //b-La contraseña deberá contener números.
            //c-Deberá contener al menos dos dígitos. 

            Console.WriteLine("Escribe una contraseña con 8 carateres o más, con al menos un numero y minimo 2 letras");
            string pass;
            bool correcto = false;
            int dos = 0;
            pass = Console.ReadLine();

            if (pass.Length >= 8)
            {
                for (int i = 0; i < pass.Length; i++)
                {
                    if (Char.IsDigit(pass[i]) == true)
                    {
                        dos++;

                        if (dos >= 2)
                        {
                            correcto = true;
                        }


                    }


                }

            }
            if (correcto == false)
            {
                Console.WriteLine("Contraseña erronea");
            }
            if (correcto == true)
            {
                Console.WriteLine("La contraseña es correcta");
            }
            Console.ReadLine();

            /////////////////////////////////////////////////////FORMA ARRATE//////////////////////////////////////////////////

            string contraseña;
            bool corrector = false;
            int contador = 0;

            do
            {
                Console.WriteLine("Introduce una contraseña");
                contraseña = Console.ReadLine();
                //Evaluamos la largura de la contraseña
                if (contraseña.Length >= 8)
                {
                    //Bucle para analizar la contraseña letra a letra
                    for (int i = 0; i < contraseña.Length; i++)

                    {
                        //evaluamos caracter a caracter si es digito
                        if (Char.IsDigit(contraseña[i]) == true)
                        {
                            contador++;
                            //Evaluamos con el contador que hayamos escrito dos o mas digitos
                            if (contador >= 2)
                            {
                                corrector = true;
                            }


                        }


                    }

                }
            }
            while (corrector == false);
            Console.WriteLine("La contraseña es correcta");
            Console.ReadLine();


            //Escribe un programa que al meter tres números por teclado identifique el mínimo y el máximo(usa el método correspondiente).

            int num1, num2, num3;

            Console.WriteLine("Escribe un numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe un numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe un numero");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("el " + num1 + " es el mayor");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("el " + num2 + " es el mayor");
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                Console.WriteLine("el " + num3 + " es el mayor");
            }
            Console.ReadLine();

            //Escribe un programa que muestre la fecha de hoy.

            DateTime hoy = DateTime.Today;
            Console.WriteLine(hoy.ToString("D"));

            Console.ReadLine();


        }
    }
}
