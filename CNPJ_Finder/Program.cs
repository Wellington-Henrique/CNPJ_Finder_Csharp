using CNPJ_Finder.Entities;
using CNPJ_Finder.Controller;

Enterprise enterprise = new Enterprise();
var json = "";

Console.Write("Entre com o CNPJ: ");
string cnpj = Console.ReadLine().Replace(@"-", "").Replace(@"/", "").Replace(@".", "");

using (var client = new HttpClient())
{
    var endpoint = new Uri($"https://www.receitaws.com.br/v1/cnpj/{cnpj}");
    var result = client.GetAsync(endpoint).Result;
    json = result.Content.ReadAsStringAsync().Result;
    enterprise = Utils.JsonToObject(json);
}


Console.WriteLine(enterprise.ToString());