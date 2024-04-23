using System;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            Camaras camara1 = new Camaras("camara_1",1);
            Camaras camara2 = new Camaras("camara_2",2);
            Camaras camara3 = new Camaras("camara_3",2);
            Camaras camara4 = new Camaras("camara_4",5);
            Camaras camara5 = new Camaras("camara_5",13);
            Camaras camara6 = new Camaras("camara_6",2);
            Camaras camara7 = new Camaras("camara_7",9);
            Camaras camara8 = new Camaras("camara_8",15);
            Camaras camara9 = new Camaras("camara_9",19);
            Camaras camara10 = new Camaras("camara_10",12);
            Camaras camara11 = new Camaras("camara_11",20);
            Camaras camara12 = new Camaras("camara_12",0);


            Console.WriteLine(camara1.getPruebadeCamara());
            Thread.Sleep(500);
            Console.WriteLine(camara2.getPruebadeCamara());
            Thread.Sleep(500);
            Console.WriteLine(camara3.getPruebadeCamara());
            Thread.Sleep(500);
            Console.WriteLine(camara4.getPruebadeCamara());
            Thread.Sleep(500);
            Console.WriteLine(camara5.getPruebadeCamara());
            Thread.Sleep(500);
            Console.WriteLine(camara6.getPruebadeCamara());
            Thread.Sleep(500);
            Console.WriteLine(camara7.getPruebadeCamara());
            Thread.Sleep(500);
            Console.WriteLine(camara8.getPruebadeCamara());
            Thread.Sleep(500);
            Console.WriteLine(camara9.getPruebadeCamara());
            Thread.Sleep(500);
            Console.WriteLine(camara10.getPruebadeCamara());
            Thread.Sleep(500);
            Console.WriteLine(camara11.getPruebadeCamara());
            Thread.Sleep(500);
            Console.WriteLine(camara12.getPruebadeCamara());
            Thread.Sleep(500);
        }

   
    
    }

    

        class Camaras
        {
           /* public Camaras()
            {
                nombre = "camara_1";
                pasaje = true;
                prioridad = "normal";
                CantidadPersonas = 0;
                IngresadoAntes = true;

            }*/
            public Camaras(string numero_camara, int Cantidad_Personas)
            {
                nombre = numero_camara;
                pasaje = true;
                prioridad = "normal";
                CantidadPersonas = Cantidad_Personas;
                IngresadoAntes = true;

            }

            public string getPruebadeCamara()
            {
                return "Se encendió la camara, \n"+ nombre + "\nPrioridad: " + prioridad + "\nCantidad de personas: " + CantidadPersonas+ "\nPuede pasar? "+ pasaje + "\nFue ingresado antes? "+IngresadoAntes; 
            }

            
            private string nombre;
            private bool pasaje;
            private string prioridad;
            private int CantidadPersonas;
            private bool IngresadoAntes;
        }
}

