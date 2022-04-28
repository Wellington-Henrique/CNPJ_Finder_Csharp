using System;

namespace CNPJ_Finder.Entities
{
    internal class Enterprise
    {
        public IList<Activity>? Atividade_principal { get; set; }
        public string Data_situacao { get; set; } 
        public string Complemento { get; set; } 
        public string Tipo { get; set; } 
        public string Nome { get; set; } 
        public string Uf { get; set; } 
        public string Telefone { get; set; } 
        public string Email { get; set; }
        public IList<Activity>? Atividades_secundarias { get; set; }
        public IList<Partners>? Qsa { get; set; }
        public string Situacao { get; set; } 
        public string Bairro { get; set; } 
        public string Logradouro { get; set; } 
        public string Numero { get; set; } 
        public string Cep { get; set; } 
        public string Municipio { get; set; } 
        public string Porte { get; set; } 
        public string Abertura { get; set; } 
        public string Natureza_juridica { get; set; }
        public string Fantasia { get; set; }
        public string CNPJ { get; set; }
        public string Ultima_atualizacao { get; set; }
        public string Status { get; set; }
        public string Efr { get; set; }
        public string Motivo_situacao { get; set; }
        public string Situacao_especial { get; set; }
        public string Data_situacao_especial { get; set; }
        public double Capital_social { get; set; }

        public Enterprise()
        {
        }

        public override string ToString()
        {
            string principalActivity = string.Join(", \n", Atividade_principal);
            string secundaryActivities = string.Join(", \n", Atividades_secundarias);
            string partners = string.Join(", \n", Qsa);

            return
                $"Nome: {Nome}\n" +
                $"Nome Fantasia: {Fantasia}\n" +
                $"CNPJ: {CNPJ}\n\n" +
                $"\nAtividade Principal:\n{principalActivity}\n" +
                $"\nAtividades Secundárias:\n{secundaryActivities}\n" +
                $"\nAtividades Secundárias:\n{partners}\n" +
                $"\nData situacao: {Data_situacao}\n" +
                $"Complemento: {Complemento}\n" +
                $"Tipo: {Tipo}\n" +
                $"UF: {Uf}\n" +
                $"Telefone: {Telefone}\n" +
                $"E-mail: {Email}\n" +
                $"Situação: {Situacao}\n" +
                $"Bairro: {Bairro}\n" +
                $"Logradouro: {Logradouro}\n" +
                $"Número: {Numero}\n" +
                $"Cep: {Cep}\n" +
                $"Município: {Municipio}\n" +
                $"Porte: {Porte}\n" +
                $"Abertura: {Abertura}\n" +
                $"Natureza Jurídica: {Natureza_juridica}\n" +
                $"Data última atualização: {Ultima_atualizacao}\n" +
                $"Status: {Status}\n" +
                $"efr: {Efr}\n" +
                $"Motivo Situação: {Motivo_situacao}\n" +
                $"Situação Especial: {Situacao_especial}\n" +
                $"Data Situação Especial: {Data_situacao_especial}\n" +
                $"Capital Inicial: {Capital_social.ToString("F2")}";
        }
    }
}