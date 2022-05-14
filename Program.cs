double lado1, lado2, lado3;
            double p; // Semiperímetro
            double area;
            string tipoTriangulo;

            Console.WriteLine("Digite os lados do triângulo desejado.\n");

            Console.Write("Lado 1..: ");
            lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 2..: ");
            lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 3..: ");
            lado3 = Convert.ToDouble(Console.ReadLine());

            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
            {
                Console.WriteLine("Todos os lados devem ser maiores que zero.");
            }
            else
            {
                if (lado1 < (lado2 + lado3) &&
                    lado1 > Math.Abs(lado2 - lado3) &&
                    lado2 < (lado1 + lado3) &&
                    lado2 > Math.Abs(lado1 - lado3) &&
                    lado3 < (lado1 + lado2) &&
                    lado3 > Math.Abs(lado1 - lado2))
                {

                    if (lado1 == lado2 && lado2 == lado3)
                    {
                        tipoTriangulo = "Equilátero";
                    }
                    else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                    {
                        tipoTriangulo = "Escaleno";
                    }
                    else
                    {
                        tipoTriangulo = "Isósceles";
                    }
                    Console.WriteLine($"Triângulo {tipoTriangulo}");

                    p = (lado1 + lado2 + lado3) / 2;
                    area = Math.Sqrt(p * (p - lado1) * (p - lado2) * (p - lado3));

                    Console.WriteLine($"Semiperímetro..: {p}");
                    Console.WriteLine($"Área...........: {area}");
                }
                else
                {
                    Console.WriteLine("Estes lados não formam um triângulo.");
                      }
            }
