using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_3
{
    class Computadora
    {
        int Capa_Dis;
        int Espa_Dis;
        bool Encendido;
        public Computadora ()
        {

        }
        public Computadora(int capa_Dis, int espa_Dis, bool encendido)
        {
            this.Capa_Dis = capa_Dis;
            Espa_Dis = espa_Dis;
            this.Encendido = encendido;
        }

        public int Capa_Dis1 { get => Capa_Dis; set => Capa_Dis = value; }
        public int Espa_Dis1 { get => Espa_Dis; set => Espa_Dis = value; }
        public bool Encendido1 { get => this.Encendido; set => this.Encendido = value; }

        public void PEncendido()
        {
            if (this.Encendido )
            {
                Console.WriteLine("Binvenidos..");
            }
            else
            {
                this.Encendido = true;
                Console.WriteLine("la conputadora no esta encendidad....");
            }
        }

        public void Pagado()
        {
            Console.WriteLine("de P para apagar la compuradora: ");
            char x = char.Parse(Console.ReadLine());
            if (x == 'p' || x == 'P')
            {
                this.Encendido = false;
                Console.WriteLine("la computadora se ha apagado...");
 
            }
            else
            {
                this.Encendido = true;
                Console.WriteLine("la computadora esta encendidad...");
            }
        }
        public void Añadir(int dato)
        {
            if (this.Encendido)
            {
                if (dato <= this.Capa_Dis)
                {
                    this.Espa_Dis = this.Capa_Dis - dato;
                    Console.WriteLine("La capacidad del disco se a reducido {0}",Espa_Dis);
                }
                else
                {
                    Console.WriteLine("No hay suficiente espacio en el disco...");
                }
            }
            else
            {
                Console.WriteLine("La computadora esta Apagada...");
            }
        }
        public void Eliminar(int dato)
        {
            if (this.Encendido)
            {
                if (dato <= this.Capa_Dis)
                {
                    this.Capa_Dis= this.Espa_Dis + dato;
                    Console.WriteLine("La dato se ha eliminado la capacidad de disco aumento {0}",Capa_Dis); 
                }
                else
                {
                    Console.WriteLine("no se eli,imo el dato...");
                }
            }
            else
            {
                Console.WriteLine("La computadora esta Apagada...");
            }
        }


            


    }
}