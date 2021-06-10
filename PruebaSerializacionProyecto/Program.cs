﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaSerializacionProyecto
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Sistema sistema = new Sistema();

            if (File.Exists("sistema.bin"))
            {
                Stream flujo = File.OpenRead("sistema.bin");
                BinaryFormatter deserializar = new BinaryFormatter();
                sistema = (Sistema)deserializar.Deserialize(flujo);
                flujo.Close();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormInicio(sistema));


            Stream flujo2 = File.Create("sistema.bin");
            BinaryFormatter serializar = new BinaryFormatter();
            serializar.Serialize(flujo2, sistema);
            flujo2.Close();

        }
    }
}
