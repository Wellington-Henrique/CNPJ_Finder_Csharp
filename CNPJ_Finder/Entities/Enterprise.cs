using System;

namespace CNPJ_Finder.Entities
{
    internal class Enterprise
    {
        public string CNPJ { get; set; }
        public string Fantasia { get; set; }
        public double Capital_social { get; set; }

        public Enterprise()
        {
        }

        public override string ToString()
        {
            return $" CNPJ: {CNPJ}, \n Nome Fantasia: {Fantasia}, \n Capital Inicial: {Capital_social.ToString("F2")}";
        }
    }
}