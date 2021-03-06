using CNPJ_Finder.Entities;
using CNPJ_Finder.Controllers;

Enterprise enterprise = new Enterprise();
var json = "";
char searchMore = 'y';

while(searchMore.Equals('y'))
{
    Console.Clear();
    Console.Write("Entre com o CNPJ: ");
    string cnpj = Console.ReadLine().Replace(@"-", "").Replace(@"/", "").Replace(@".", "");

    using (var client = new HttpClient())
    {
        var endpoint = new Uri($"https://www.receitaws.com.br/v1/cnpj/{cnpj}");
        var result = client.GetAsync(endpoint).Result;
        json = result.Content.ReadAsStringAsync().Result;
        enterprise = Utils.JsonToObject(json);
    }
    
    Console.WriteLine();

    if (enterprise.Status == "ERROR")
        Console.WriteLine("CNPJ não encontrado!");
    else
        Console.WriteLine(enterprise.ToString());

    Console.WriteLine();
    Console.Write("Deseja consultar um novo CNPJ (Y/n)? ");
    searchMore = char.Parse(Console.ReadLine().ToLower());
}




        
