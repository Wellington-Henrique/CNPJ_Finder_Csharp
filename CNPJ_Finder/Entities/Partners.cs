using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPJ_Finder.Entities
{
    internal class Partners
    {
        public string Nome { get; set; }
        public string Qual { get; set; }

        public Partners() { }

        public override string ToString()
        {
            return $"{Qual} - {Nome}";
        }
    }
}
