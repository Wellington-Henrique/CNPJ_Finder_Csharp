using System.Text;

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
            StringBuilder result = new StringBuilder();

            result.Append($"Nome: {Nome}\n");
            result.Append($"Nome Fantasia: {Fantasia}\n");
            result.Append($"CNPJ: {CNPJ}\t");
            result.Append($"Situação: {Situacao}\t");
            result.Append($"Porte: {Porte} \t");
            result.Append($"Abertura: {Abertura}\n");
            result.Append($"Natureza Jurídica: {Natureza_juridica}\n");
            result.Append($"\nAtividade Principal:\n{principalActivity}\n");
            result.Append($"\nAtividades Secundárias:\n{secundaryActivities}\n");
            result.Append($"\nSócios:\n{partners}\n");
            result.Append($"\nData situacao: {Data_situacao}\n");
            result.Append($"Endereço: {Tipo} { Logradouro}, {Numero}, {Bairro}, {Municipio}/{Uf} -  {Cep}\n");
            result.Append($"Telefone: {Telefone}\n");
            result.Append($"E-mail: {Email}\n");
            result.Append($"Data última atualização: {Ultima_atualizacao}\n");
            result.Append($"Status: {Status}\n");
            result.Append($"efr: {Efr}\n");
            result.Append($"Motivo Situação: {Motivo_situacao}\n");
            result.Append($"Situação Especial: {Situacao_especial}\n");
            result.Append($"Data Situação Especial: {Data_situacao_especial}\n");
            result.Append($"Capital Inicial: R$ {Capital_social.ToString("F2")}");

            return result.ToString();    
        }
    }
}