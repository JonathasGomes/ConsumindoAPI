using Newtonsoft.Json;
using System.Net;
using ViaCep;

var viacep = new Cep();

viacep.ConsultarCEP();

var cep = viacep.GetCeps();


Console.WriteLine(cep.Localidade);
Console.WriteLine(cep.Complemento);
Console.WriteLine(cep.Bairro);
Console.WriteLine(cep.Uf);
Console.WriteLine(cep.Ibge);
Console.WriteLine(cep.Gia);
