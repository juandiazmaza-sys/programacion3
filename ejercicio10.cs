using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios.repaso
{
   
        public class VehiculoElectrico
        {
            public int Bateria { get; private set; } = 100;

            public void Viajar(int km)
            {
                Bateria -= km;
                if (Bateria <= 0)
                {
                    Bateria = 0;
                    Console.WriteLine("¡BATERÍA AGOTADA! Necesitas carga inmediata.");
                }
                else
                {
                    Console.WriteLine($"Viaje de {km}km realizado. Batería: {Bateria}%");
                }
            }
        }

        public class ejercicio10
        {
            public static void ejecutar()
            {
                Console.WriteLine("¡Bienvenido al Control de Vehículos Eléctricos!");
                VehiculoElectrico tesla = new VehiculoElectrico();
                tesla.Viajar(30);
                tesla.Viajar(80);
            }
        }
    }

