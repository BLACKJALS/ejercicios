namespace Ejercicios {
    public class ServicioRepresentacionBase {
        public List<int> Cocientes { get; set; }
        public List<int> Residuos { get; set; }

        public ServicioRepresentacionBase() {
            Cocientes = new List<int>();
            Residuos = new List<int>();
        }

        public string GeneradorBase(int cantidad, int baseK) {
            Dividir(cantidad, baseK);
            return GenerarBase();
        }

        private void Dividir(int numero, int baseK) {
            if(numero < baseK)
                return;

            var valor = numero / baseK;
            var res = numero % baseK;
            Cocientes.Add(valor);
            Residuos.Add(res);

            if(res == 0)
                return;

            Dividir(valor, baseK);
        }

        private string GenerarBase() {
            var ultimoCociente = Cocientes.LastOrDefault();
            Residuos.Reverse();
            return $"{ultimoCociente}{string.Join("", Residuos)}";
        }
    }
}
