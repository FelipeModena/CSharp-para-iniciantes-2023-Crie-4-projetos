using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios.Model.Project
{
    internal class Project02 : Interface.IProject
    {
        public string projectDbFolder = "project02DB";
        public string testProjectFile = "testeProject01.txt";
        ArrayList testFunctionsOrder = new ArrayList() { "1", "2", 2,2,5 };

        public int Menu()
        {
            //FileWriter("teste.txt");
            FileTestProject();
            return 0;
        }

        private bool CheckFolderExists()
        {
            bool exists = Directory.Exists(this.projectDbFolder);
            if (!exists) Directory.CreateDirectory(this.projectDbFolder);

            return exists;
        }
        private void FileWriter(string fileName)
        {
            string path = this.projectDbFolder+'/'+fileName;

            if (CheckFolderExists())
            {
                StreamWriter writer = new StreamWriter(path);

                writer.WriteLine("Hello Worldsadsadsadsad!");
                writer.Close();
            }
        }

        private void FileTestProject()
        {
            string path = this.projectDbFolder + '/' + this.testProjectFile;

            if (CheckFolderExists())
            {
                FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
                BinaryFormatter binaryFormatter = new BinaryFormatter();

;                foreach (var item in testFunctionsOrder)
                {
                    binaryFormatter.Serialize(fileStream, item);

                }
                fileStream.Close();

                 List<string> listaArquivo = (List<string>) binaryFormatter.Deserialize(fileStream);
    
                 foreach (var item in listaArquivo)
                {
                     Console.WriteLine(item);
                 }
            }
        }
    }
}
