using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios.Entity.Project
{
    internal class Project02Entity
    {
        [System.Serializable]
        public class Client
        {
            public string name { get; set; }
            public string cpf { get; set; }
        }
    }
}
