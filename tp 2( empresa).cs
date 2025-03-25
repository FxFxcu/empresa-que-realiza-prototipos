using System;

namespace EmpresaDeVehiculos
{
    //declaramos las partes del automovil.
    public class vehiculo
    {
        public int prototipo { get; set; }
        public int chasis { get; set; }
        public string color { get; set; }
        public string motor { get; set; }
    
        public void MostrarInfo()
        {
            Console.WriteLine($"prototipo:{prototipo}, chasis:{chasis}, color:{color}, motor:{motor}");
        }
    }
    //declaramos las funciones basicas.
    public class funcionesBasicas
    {
        public void encendido()
        {
            Console.WriteLine("encendido");
        }      

        public void marcha()
        {
            Console.WriteLine("marcha");
        }

        public void Apagar()
        {
            Console.WriteLine("apagado");
        }
    }
    //ahora, declaramos las funciones de movimientos/frenados y arranques.
    public class funcionesdemovimientos
    {
        public void Rotacion()
        {
            private double x, y;

            public Rotacion(double x, double y)
            {
                this.x = x; this.y = y;
            }

            public void girar(double angulo)
            {
                double rad = Math.toRadians(angulo), nx = x * Math.cos(rad) - y * Math.sin(rad);
                y = x * Math.sin(rad) + y * Math.cos(rad); x = nx;
            }
            public String toString()
            {
                return "(" + x + ", " + y + ")";
            }
            public static void main(String[] args)
            {
                System.out.println(new Rotacion(1, 0));
            }

            Console.WriteLine("girando a la izquierda","girando a la derecha");

        }

        public void frenado()
        {
            public class Frenado()
            {
                private double velocidad;

                public Frenado(double velocidad)
                { 
                    this.velocidad = velocidad;
                }

                public void frenar(double reduccion)
                { 
                    velocidad = Math.max(0, velocidad - reduccion);
                }

                public String toString()
                { 
                    return velocidad + " km/h";
                }
            }
        }

        public void retroceso()
        {
            public class Retroceso()
            {
                private double posicion;

                public Retroceso(double posicionInicial)
                {
                    this.posicion = posicionInicial;
                }

                public void retroceder(double distancia)
                {
                    posicion -= distancia;
                }

                public String toString()
                { 
                    return "Posición: " + posicion; 
                }
            }
        }
    }
    //aqui declaramos las funciones de control automatizado del automovil.
    public class control
    {
        public class Espejo
        {
            private int angulo;

            public Espejo(int anguloInicial)
            { 
                this.angulo = anguloInicial; 
            }

            public void ajustarAngulo(int nuevoAngulo)
            { 
                angulo = Math.max(0, Math.min(180, nuevoAngulo));
            }

            public int getAngulo()
            { 
                return angulo; 
            }
        }

        public void parabrisas()
        {
            private boolean activo; 
            private int velocidad; 

            public Parabrisas()
            {
                this.activo = false;
                this.velocidad = 1; l
            }

            public void encenderApagar()
            {
                activo = !activo;
                if (!activo) velocidad = 1; 
            }

            public void ajustarVelocidad(int nuevaVelocidad)
            {
                if (activo && nuevaVelocidad >= 1 && nuevaVelocidad <= 3)
                {
                    velocidad = nuevaVelocidad;
                }
            }

            public String estado()
            {
                return activo("Parabrisas activo");
            }
        
        }
    }
    //creamos una funcion que controla al GPS
    public class gps
    {
        public string ubicacion { get; set; }
        public string partida { get; set; }
        public int origen { get; set; }
        public int destino { get; set; }

        public gps()
        {
            semaforos=destino;
        }

        public void ubicacio()
        {
            ubicacio=punto actual;
        }

        public void origen()
        {
            origen=ubicacio;
        }

        public void destino()
        {
            destino=();
        }
    }

    //creamos una funcion que detecte los semaforos que alla y de informacion de cada uno de ellos

    public class semaforo
    {
        public string color{ get; set; }
        public string ubicacion { get; set; }
        public int cantidad { get; set; }

        public void colores()
        {
            if(color=='rojo')
            {
                Console.WriteLine("El semaforo esta en rojo, frene y espere a que este en verde.");
            }
            else(color=='amarilo')
            {
                Console.WriteLine("El semaforo esta en amarillo, frene/avance lentamente.");
            }
            else(color=='verde')
            {
                Console.WriteLine("El semaforo esta en verde, avance.");
            }
        }

        public void cantidad()
        {
            if(ubicacion=500)
            {
                cantidad++;

                Console.WriteLine("hay un semaforo, tenga precaucion.");
            }
        }
    }
}