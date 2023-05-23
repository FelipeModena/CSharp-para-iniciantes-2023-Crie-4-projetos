using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using static lista_de_exercicios.Entity.Project.Project02Entity;

namespace lista_de_exercicios.Model.Project
{
    internal class Project02 : Interface.IProject
    {
        public string projectDbFolder = "project02DB";
        public string testProjectFile = "testeProject02.txt";
        public string projectDbFileBinary = "project02Clients.dat";
        ArrayList testFunctionsOrder = new ArrayList() { "1", "2", 2,2,5 };

        public List<Client> clients = new List<Client>();

        public int Menu()
        {
            int option=-1;
            LoadClientFromDb();



            while (option!=5)
            {
                Console.WriteLine("Sistema do cliente");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar clientes");
                Console.WriteLine("4 - Excluir cliente");
                Console.WriteLine("5 - Sair");

                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddClient();
                        break;
                    case 2:
                        ListClients();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        SaveClientToDb();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
           

            return option;
        }

        private void AddClient()
        {
            Client client = new Client();
            client.name = "Cliente";
            client.cpf = "123456789";

            Console.WriteLine("Digite o nome do cliente: ");
            //client.name = Console.ReadLine();

            this.clients.Add(client);

            SaveClientToDb();

            Console.WriteLine("Cliente cadastrado com sucesso!");

        }

        private void SaveClientToDb()
        {
            string path = this.projectDbFolder + '/' + this.projectDbFileBinary;

            if (CheckFolderExists())
            {
                FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                binaryFormatter.Serialize(fileStream, this.clients);

                fileStream.Close();
            }
        }

        private void LoadClientFromDb()
        {
            string path = this.projectDbFolder + '/' + this.projectDbFileBinary;
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);

            try
            {
                if (CheckFolderExists())
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();

                    this.clients = (List<Client>)binaryFormatter.Deserialize(fileStream);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao carregar clientes do banco de dados: " + e.Message);
                clients = new List<Client>();
            }
            
            fileStream.Close();
        }

        private void ListClients()
        {
            foreach (var item in clients)
            {
                Console.WriteLine(item.name + " " + item.cpf);
            }
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
