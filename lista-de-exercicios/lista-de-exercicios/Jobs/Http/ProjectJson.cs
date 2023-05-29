using lista_de_exercicios.Model.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios.Jobs.Project
{
    internal class ProjectJson
    {
        public ProjectJson()
        {

            try
            {
                var requisicaoWeb = WebRequest.CreateHttp("https://jsonplaceholder.typicode.com/todos");
                requisicaoWeb.Method = "GET";
                var response = requisicaoWeb.GetResponse();

                using (response)
                {
                    var streamDados = response.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);
                    object objResponse = reader.ReadToEnd();


                    List<Todos> todos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Todos>>(objResponse.ToString());


                    foreach (var item in todos)
                    {
                        item.Print();
                    }
                    streamDados.Close();
                    response.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
