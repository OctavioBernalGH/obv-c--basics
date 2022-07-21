using System;

namespace ProgramacionCsharp
{   
    class Programa
    {
        static void main(String []args)
        {
            // Trabajando con variables
            String mensaje = "Hola mundo";
            int numeroGrande = 2147483647;
            uint largeNumber = 2147483648;
            float piFloat = 3.1415f;
            double piDouble = 3.1415;
            decimal miCuenta = 15.53486M;
            Console.WriteLine(numeroGrande + " entero");
            Console.WriteLine(largeNumber + " uInteger");
            Console.WriteLine(piFloat + " numero PI flotante");
            Console.WriteLine(piDouble + "numero PI double");
            Console.WriteLine(miCuenta + " numero decimal");
            Console.WriteLine(mensaje);
            Console.WriteLine("El mensaje creado en string es {0}", mensaje);

            // Trabajando con operaciones
            int divisionEnteros = 25 / 2;
            double divisionDecimales = 25.00 / 2.00;
            int modulo = 24 % 6;
            int iterador = 0;
            iterador++;
            Console.WriteLine("La división de núm enteros es: {0}", divisionEnteros);
            Console.WriteLine("La división de núm decimales es: {0}", divisionDecimales);
            Console.WriteLine("El módulo de 24 % 6 es: {0}", modulo);
            Console.WriteLine("Iterador: {0}", iterador);

            // Trabajando con cadenas
            char inicialNombre = 'O';
            char inicialApellido = 'B';
            char backspace = '\b';
            char tab = '\t';
            char enter = '\n';
            char letrasHexadecimal = '\u004f';
            Console.WriteLine("La inicial de mi nombre es: " + inicialNombre + tab + " y la inicial apellido " + inicialApellido + enter);
            Console.Write("La inicial de mi nombre en hexadecimal es: " + letrasHexadecimal);

            // Trabajando con la consola
            String nombreConsola = "";
            String apellidoConsola = "";
            String edad = "";
            Console.WriteLine("Ingrese su nombre: ");
            nombreConsola = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            apellidoConsola = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            edad = Console.ReadLine();
            Console.WriteLine("****************************");
            Console.WriteLine("Nombre: {0}", nombreConsola);
            Console.WriteLine("Apellido: {0}", apellidoConsola);
            Console.WriteLine("Edad: {0}", edad);
            Console.WriteLine("****************************");

            // Trabajando con Booleanos
            bool estaLloviendo = false;
            bool estaSoleado = true;
            Console.WriteLine("Está lloviendo ? {0}", estaLloviendo);
            Console.WriteLine("Hace soleado ? {0}", estaSoleado);
            bool esMayor = 10 > 3;
            Console.Write("Es mayor 10 > 3 ? {0}", esMayor);
            int miEdad = 29;
            Console.WriteLine("Que edad tienes ? ");
            if(miEdad > 18){
                Console.WriteLine("Tienes {0} años, eres mayor de edad, adelante...", miEdad);
            } 
            else
            {
                Console.WriteLine("Eres menor de edad vete a casa.");    
            }

            // Trabajando con bucles
            int contadorDoWhile = 1;
            do {
                Console.WriteLine("Vuelta número : " + contadorDoWhile);
                contadorDoWhile++;
            } while (contadorDoWhile < 5);
            
            for(int x = 0; x <= 5; x++){
                Console.WriteLine("Bucle for num: " + x);
            }
    	    
            String [] matrizPaises = {"España", "Francia", "Italiza", "Rumanía"};
            for(int i = 0; i < matrizPaises.Length; i++){
                Console.WriteLine(matrizPaises[i]);
            }

            // Trabajando con métodos en C#
            double radioA = 5.60;
            double radioB = 7.80;
            double radioC = 9.30;
            double areaA = 0;
            double areaB = 0;
            double areaC = 0;
            
            calcularAreaCirculo(radioA);
            calcularAreaCirculo(radioB);
            calcularAreaCirculo(radioC);

        }

    // Funciones fuera del main llamadas en el principal
    public static void calcularAreaCirculo(double radio)
      {
        double pi = 3.14159;
        double area = 0;
        area = pi * radio * radio;
        imprimirMensaje(area);
      }

    public static void imprimirMensaje(double area)
      {
        string mensajeGeneral = "El area es: ";
        Console.WriteLine(mensajeGeneral + area);
      } 
    }
}