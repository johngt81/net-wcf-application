// See https://aka.ms/new-console-template for more information
using ServiceReference1;

Console.WriteLine("Hello, World!");
ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

CompositeType compositeType = new CompositeType
{
    BoolValue = true,
    StringValue = "HOLA PRUEA"
};
var result = client.GetDataUsingDataContractAsync(compositeType).Result;
Console.WriteLine("BoolValue: " + result.BoolValue); 
Console.WriteLine("StringValue: " + result.StringValue);

var hello = client.HelloAsync().Result;
Console.WriteLine(hello);