using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Partie_10_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serializer();
            Deserializer();
            Console.ReadKey();
        }
        static void Serializer()
        {
            Stream stream = File.Create(@"C:\Users\ISSAM\Desktop\Web Cote Serveur\cours\exircice de cours\Partie 10 Serialization\etudiat.txt");
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, new Etudiant() { numins = 1, nom = "boutissante", prenom = "issam" });
            stream.Close();
            Console.WriteLine("serialization a ete termine");
        }
        static void Deserializer()
        {
            Stream stream = File.OpenRead(@"C:\Users\ISSAM\Desktop\Web Cote Serveur\cours\exircice de cours\Partie 10 Serialization\etudiat.txt");
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Etudiant etudiant=(Etudiant)binaryFormatter.Deserialize(stream);
            Console.WriteLine(etudiant);

        }
    }
}
