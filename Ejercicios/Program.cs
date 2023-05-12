
using Ejercicios;

Console.WriteLine("Ejercicio árboles");

var arbol = new Arbol();
var nodoArbol1 = arbol.InsertarNodo(4, null);
arbol.ProcesarNodo(nodoArbol1);


var arbol2 = new Arbol();
var nodoArbol2 = arbol2.InsertarNodo(4, null);
arbol2.InsertarNodo(2, nodoArbol2);
arbol2.InsertarNodo(1, nodoArbol2);
arbol2.ProcesarNodo(nodoArbol2);


var arbol3 = new Arbol();
var nodoArbol3 = arbol3.InsertarNodo(4, null);
arbol3.InsertarNodo(1, nodoArbol3);
arbol3.InsertarNodo(2, nodoArbol3);
var n = arbol3.InsertarNodo(5, nodoArbol3);

arbol3.InsertarNodo(3, nodoArbol3.Descendiente.Semejante);
arbol3.InsertarNodo(1, n);
arbol3.InsertarNodo(4, n);
//arbol3.InsertarNodo(1, n);

arbol3.ProcesarNodo(nodoArbol3);
