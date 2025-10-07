            double m, cm, Km;

            Console.Write("Entre com a medida (em metros): ");
            m = Convert.ToDouble(Console.ReadLine());

            cm = m * 100;
            Km = m / 1000;

            Console.WriteLine("--- Equivalencia ---");
            Console.WriteLine($"{cm}cm ");
            Console.WriteLine($"{m} m ");
            Console.WriteLine($"{Km} km");


