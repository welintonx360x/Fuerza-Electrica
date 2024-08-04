using System;



        
           

namespace pruebas
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Formula de la fuerzas entre dos cargas");
                Console.WriteLine("La Formula es : F=K*q1*q2/r^2");
                Console.WriteLine("*****************");
                Console.WriteLine("NOta! Se Tomara Como unidad de Conversion de las Cargas q1 y q2 los Nanofalario y que las cargas introducidas seran en valor absoluto");
                Console.WriteLine("*****************");
                Double k, qx1, qx2, r, rx, f, fx, fy, fz;
                Console.WriteLine("ingrese el valor de la primer carga (q1)");
                qx1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el valor de la segunda carga (q2)");
                qx2 = Double.Parse(Console.ReadLine());



                {
                    // k = 9 * 10 ^ 9;
                    //qy1 = qx1*(1*10 ^ V);
                    //qy2 = qx1 * (1 * 10 ^ V);
                    //double v = Math.Pow(fx, -3);
                    //f = k * qy1 * qy2 / rx;

                }
                Console.WriteLine("Ingrese el radio (r)");
                r = Double.Parse(Console.ReadLine());
                rx = r * r;
                Console.WriteLine("*****************");


                k = 9.0;
                f = (k * qx1 * qx2);
                fx = 0.000000001;
                fy = f * fx;
                fz = fy / rx;

                Console.WriteLine();
                Console.WriteLine("****************");
                Console.WriteLine("La carga es de:" + fz);
                Console.WriteLine("****************");

            }
        }
   }

    

