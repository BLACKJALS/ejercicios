
using Ejercicios;

Console.WriteLine("Ejercicio árboles");

var arbol = new Arbol();
var nodoArbol1 = arbol.InsertarNodo(4, null);
arbol.ProcesarNodo(nodoArbol1);
arbol.ConsultarPeso(nodoArbol1);
Console.WriteLine("Árbol 1:");
Console.WriteLine($"El peso total del arbol es: {arbol.PesoTotal}");
Console.WriteLine($"Total de nodos es: {arbol.CantidadNodos}");
Console.WriteLine($"El promedio es: {arbol.PesoTotal / arbol.CantidadNodos}");
Console.WriteLine("");


var arbol2 = new Arbol();
var nodoArbol2 = arbol2.InsertarNodo(4, null);
arbol2.InsertarNodo(2, nodoArbol2);
arbol2.InsertarNodo(1, nodoArbol2);
arbol2.ProcesarNodo(nodoArbol2);
arbol2.ConsultarPeso(nodoArbol2);
Console.WriteLine("Árbol 2:");
Console.WriteLine($"El peso total del arbol es: {arbol2.PesoTotal}");
Console.WriteLine($"Total de nodos es: {arbol2.CantidadNodos}");
Console.WriteLine($"El promedio es: {arbol2.PesoTotal / arbol2.CantidadNodos}");
Console.WriteLine("");


var arbol3 = new Arbol();
var nodoArbol3 = arbol3.InsertarNodo(4, null);
arbol3.InsertarNodo(1, nodoArbol3);
arbol3.InsertarNodo(2, nodoArbol3);
var n = arbol3.InsertarNodo(5, nodoArbol3);

arbol3.InsertarNodo(3, nodoArbol3.Descendiente.Semejante);
arbol3.InsertarNodo(1, n);
arbol3.InsertarNodo(4, n);
arbol3.ProcesarNodo(nodoArbol3);
arbol3.ConsultarPeso(nodoArbol3);
Console.WriteLine("Árbol 3:");
Console.WriteLine($"El peso total del arbol es: {arbol3.PesoTotal}");
Console.WriteLine($"Total de nodos es: {arbol3.CantidadNodos}");
Console.WriteLine($"El promedio es: {arbol3.PesoTotal / arbol3.CantidadNodos}");
Console.WriteLine("");
