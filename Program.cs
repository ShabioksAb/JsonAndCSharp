using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace JsonCSharp
{
    public class Materia
    {
        public int p1 { get; set; }
        public int p2 { get; set; }
        public override string ToString()
        {
            return "p1: " + p1 + " p2: " + p2;
        }
    }

    public class Alumno
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public List<Materia> materia { get; set; }
        public override string ToString()
        {
            string moni = "";
            for (int j = 0; j < materia.Count; j++)
            {
                moni = materia[j].ToString();
            }
            return "nombre: " + nombre + "\n" + " Edad:" + edad + "\n" + moni;

        }
        
    }

    class Program
    {

        static void Main(string[] args)
        {
     
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string outputJSON = File.ReadAllText("MyPrimerJson.json");
            var p1 = ser.Deserialize<List<Alumno>>(outputJSON);
            foreach (Alumno p in p1)
            {
                Console.WriteLine(p.ToString());

            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }


}
