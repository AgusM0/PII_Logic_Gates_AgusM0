// See https://aka.ms/new-console-template for more information

using LogicGates;

Input A = new Input("A", false);
Input B = new Input("B", false);
Input C = new Input("C", true);

List<Input> lista = new List<Input>{A, B, C};

GarageGate g = new GarageGate(); 
bool resultado = g.LogicResult(lista);
Console.WriteLine(resultado);