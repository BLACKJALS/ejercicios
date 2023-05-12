
using Ejercicios;

var numero = 287;
var baseK = 4;
var representacionSvc = new ServicioRepresentacionBase();
var res = representacionSvc.GeneradorBase(numero, baseK);
Console.WriteLine($"La representación en base k ({baseK}), del número {numero} es: {res}");

