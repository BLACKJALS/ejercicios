namespace Ejercicios {
    public class Arbol {
        public Nodo Raiz { get; set; }
        public Nodo Creacion { get; set; }
        public int PesoTotal = 0;
        public int CantidadNodos = 0;
        public int i = 0;

        public Arbol() {
            Raiz = new Nodo(); 
        }

        public Nodo InsertarNodo(int peso, Nodo nodo) {
            if (nodo == null) {
                Raiz = new Nodo();
                Raiz.Peso = peso;
                Raiz.Descendiente = null;
                Raiz.Semejante = null;
                return Raiz;
            }

            if (nodo.Descendiente == null) {
                var tmp = new Nodo();
                tmp.Peso = peso;
                tmp.Padre = nodo;
                nodo.Descendiente = tmp;
                return tmp;
            } else {
                Creacion = nodo.Descendiente;
                while (Creacion.Semejante != null) {
                    Creacion = Creacion.Semejante;
                }

                var tmp = new Nodo();
                tmp.Peso = peso;
                tmp.Padre = nodo;
                Creacion.Semejante = tmp;
                return tmp;
            }
        }

        public void ProcesarNodo(Nodo nodo) {
            if(nodo == null)
                return;

            for(int n = 0; n < i; n++)
                //Console.Write(" ");

            //Console.WriteLine(nodo.Peso);
            if(nodo.Descendiente != null) {
                i++;
                ProcesarNodo(nodo.Descendiente);
                i--;
            }

            if(nodo.Semejante != null) {
                ProcesarNodo(nodo.Semejante);
            }
        }


        public void ConsultarPeso(Nodo nodo) {
            if (nodo == null)
                return;

            if (nodo.Procesado)
                ConsultarPeso(nodo.Padre);

            PesoTotal += nodo.Peso;
            CantidadNodos += 1;
            nodo.Procesado = true;
            if (nodo.Descendiente != null) {
                ConsultarPeso(nodo.Descendiente);
            }

            if (nodo.Semejante != null) {
                ConsultarPeso(nodo.Semejante);
            }
        }


        public int ConsultarNivel(int total, Nodo nodo) {
            if (nodo == null)
                return 0;

            while(nodo.Descendiente != null) {
                total += 1;
                nodo = nodo.Descendiente;
                ConsultarNivel(total, nodo.Descendiente);
            }
                
            return total;
        }
    }

    public class Nodo {
        public Nodo() {
            Peso = 0;
            Nivel = 0;
            Descendiente = null;
            Semejante = null;
            Padre = null;
            Procesado = false;
        }

        public int Peso { get; set; }
        public int Nivel { get; set; }
        public bool Procesado { get; set; }
        public Nodo Padre { get; set; }
        public Nodo Descendiente { get; set; }
        public Nodo Semejante { get; set; }
    }
}
