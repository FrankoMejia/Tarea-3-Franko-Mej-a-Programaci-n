using System;

namespace Tercera_TareaFrankoMejia
{
    class Program
    {
        static void Main(string[] args) // Franko Mejía, C.I: 30.077.625
        {                       
            string datos = "";
            double peso = 0.0;
            int actividadPerro = 0;
            double edad = 0.0;
            int opcion = 0;
            string mascota = "";

            do{

              System.Console.WriteLine("\n Bienvenido al Programa de Nutrición de tu mascota! \n");
              System.Console.WriteLine("Necesitamos los datos de tu Canino para saber cuánto alimento debe ingerir al día"); 
              System.Console.WriteLine("¿Cuál es su nombre?");
              mascota = Console.ReadLine();

                                
                System.Console.WriteLine("Muy bien, ahora necesitamos conocer la edad de "+ mascota);
                System.Console.WriteLine("¿Cuál es su edad? En años");
                edad = Convert.ToDouble(datos = Console.ReadLine());
                 

                System.Console.WriteLine("¿Cuál es el peso de {0}?", mascota);
                peso = Convert.ToDouble(datos = Console.ReadLine());

             do{       

                 System.Console.WriteLine("¿Cómo considera la actividad física de {0}?", mascota);
                 System.Console.WriteLine("1 - Actividad Alta");
                 System.Console.WriteLine("2 - Actividad Normal");
                 System.Console.WriteLine("3 - Actividad Baja");

                 actividadPerro = Convert.ToInt32(datos = Console.ReadLine());
                 Console.WriteLine("En resumen, según la consulta, {0} tiene {1} año/s y pesa {2} kg \nPor lo tanto,", mascota, edad, peso);

                 if(peso > 5 && peso < 15) //Adulto medio (Menor a 7 años)
                {
                    if ( edad <= 7 && edad > 1.6 )// Edad y peso en valores correctos.
                    {
                        switch (actividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 280 Y 332 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 182 y 250 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 70 y 140 gramos de alimento.");
                            break;
                        default:
                            Console.WriteLine("\nError!, ingrese un valor estimado entre 1 y 3");
                            break;}
                    }
                    else if (edad <= 1.6 && edad > 0.0  )//Dieta debido a que está obeso para su edad, ajustar dependiendo de su actividad física.
                    {
                        switch (actividadPerro) { // Si presenta este peso a esta edad, puede estar en sobrepeso.
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 100 y 132 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 68 y 100 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 35 y 68 gramos.");
                            break;
                        default:
                            Console.WriteLine("\nError!, ingrese un valor estimado entre 1, 2 y 3");
                            break;
                        }
                    }     
                }
                else if (peso > 0.6 && peso <= 5) // Cachorro (Recien nacido / 6 meses)
                {
                    if(edad > 0.3 && edad <= 0.6) // Valores de peso y edad normales.
                    {
                        switch (actividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 75 y 150 gramos de alimento.");//**********
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 68 y 100 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 50 y 68 gramos de alimento.");
                            break;
                        default:
                            Console.WriteLine("\nError!, ingrese un valor estimado entre 1, 2 y 3");
                            break;}
                    }                  
                    else if (edad > 0.6 && edad <= 1.6) //Cachorro Medio (adolescente) con bajo peso
                    {
                        switch (actividadPerro) { //Debe comer más porque está en la adolescencia canina y pesa poco, ajusta el alimento dependiendo de la actividad física que realice.
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 120 y 165 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 100 y 120 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 75 y 100 gramos de alimento.");
                            break;
                        default:
                            Console.WriteLine("\nError!, ingrese un valor estimado entre 1, 2 y 3");
                            break;
                        }
                    }
                 }
                 else if (peso >= 15 && peso <= 65) // Adulto senior (Mayor a 7 años)
                 {
                    if(edad > 7 && edad <= 20) //Valores de peso y edad normales.
                    {          
                        switch (actividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 660 y 720 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 590 y 660 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 410 y 500 gramos de alimento.");
                            break;
                        default:
                            Console.WriteLine("\nError!, ingrese un valor estimado entre 1, 2 y 3");
                            break;
                        }             
                    }
                    else if(edad < 7 && edad > 1.6) //Si no es adulto y tiene mas de 15kg, probablemente tenga sobrepeso dependiendo de la raza.
                    {
                        switch (actividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 310 y 410 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 310 y 260 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 200 y 260 gramos de alimento.");
                            break;
                        default:
                            Console.WriteLine("\nError!, ingrese un valor estimado entre 1, 2 y 3");
                            break;
                        }
                    }
                }
                else if(peso > 65)//Condiciones adicionales
                {
                    if(edad <= 20 && edad >= 0){ //Dieta de adulto para adelgazar

                        switch (actividadPerro) {
                        case 1:
                        case 2:
                        case 3:
                            Console.WriteLine("El perro debe adelgazar porque está en niveles de obesidad peligrosos para su salud \n Debe ingerir entre 335 y 460 gramos de alimentos rico en carbohidratos al dia");
                            break;
                        default:
                            Console.WriteLine("\nError!, ingrese un valor estimado entre 1, 2 y 3");
                            break;}                        
                    }
                    else if(edad > 20)
                    {
                        switch (actividadPerro) {
                        case 1:
                        case 2:
                        case 3:
                            Console.WriteLine("Un perro no puede vivir más de 20 años");
                            break;
                        default:
                            Console.WriteLine("\nError!, ingrese un valor estimado entre 1, 2 y 3");
                            break;}   
                    }
                }    
                if (edad >= 0)
                {
                    if(peso > 0)
                    {
                        if(edad <= 20)
                        {
                            if(peso > 65)
                            {
                                switch (actividadPerro) {
                                case 1:
                                case 2:
                                case 3:
                                    Console.WriteLine("El perro debe adelgazar porque está en niveles de obesidad peligrosos para su salud \n Debe ingerir entre 335 y 460 gramos de alimentos rico en carbohidratos al dia");
                                    break;
                                default:
                                    Console.WriteLine("\nError!, ingrese un valor estimado entre 1, 2 y 3");
                                    break;}                                        
                            }                            
                        }
                        else{
                            switch (actividadPerro) {
                            case 1:
                            case 2:
                            case 3:
                                Console.WriteLine("Un perro no puede vivir más de 20 años");
                                break;
                            default:
                                Console.WriteLine("\nError!, ingrese un valor estimado entre 1, 2 y 3");
                                break;}        
                        }
                    }
                    else{
                        switch (actividadPerro) {
                        case 1:
                        case 2:
                        case 3:
                            Console.WriteLine("Un perro no puede tener peso negativo");
                            break;
                        default:
                            Console.WriteLine("\nError!, ingrese un valor estimado entre 1, 2 y 3");
                            break;}        
                    }                     
                }
                else                {
                        switch (actividadPerro) {
                        case 1:
                        case 2:
                        case 3:
                            Console.WriteLine("Ya no hay nada que hacer, el perro murió hace 8 años Juan :/");
                            break;
                        default:
                            Console.WriteLine("\nError!, ingrese un valor estimado entre 1, 2 y 3");
                            break;}  
                }          
                
                              

                }while(!(actividadPerro >= 1 && actividadPerro <= 4));

                System.Console.WriteLine("\nSi quiere consultar nuevamente, presione 1 \n Por el contrario presione 0 para finalizar");
                opcion = Convert.ToInt32(Console.ReadLine());
                
                Console.Clear();

            }while (opcion != 0);
                
            Console.ReadKey();               
        }
    }
}