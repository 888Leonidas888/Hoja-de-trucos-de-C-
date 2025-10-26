/// <summary>
/// Hoja de Trucos (Cheatsheet) de C#
/// Este archivo contiene ejemplos de conceptos básicos de C#.
/// Cada concepto está encapsulado en un método estático para mayor claridad y se ejecuta al iniciar el programa.
/// </summary>
class CSharpCheatsheet
{
    public static void Main(string[] args)
    {
        MostrarVariablesYTiposDeDatos();
        MostrarConstantes();
        MostrarInterpolacionDeCadenas();
        // MostrarConversionDeTipos(); // Este método requiere entrada del usuario. Descomentar para probarlo manualmente.
        MostrarOperadoresAritmeticos();
        MostrarOperadoresDeAsignacion();
        MostrarOperadoresLogicos();
        MostrarOperadoresDeComparacion();
        MostrarBucles();
        MostrarBreakYContinue();
        MostrarCondicionalesYSwitch();
        MostrarArraysYListas();
    }

    /// <summary>
    /// Demuestra la declaración y uso de variables de distintos tipos.
    /// </summary>
    public static void MostrarVariablesYTiposDeDatos()
    {
        Console.WriteLine("--- Variables y Tipos de Datos ---");

        // Cadenas de texto
        string nombreUsuario = "Ana";
        string ocupacion = "Desarrolladora";
        char inicial = 'A';

        // Números
        int edad = 28;
        double salarioAnual = 65000.50; // Para decimales de doble precisión
        decimal presupuestoProyecto = 125000.75m; // Para valores monetarios de alta precisión
        float porcentajeComision = 5.5f; // Para decimales de precisión simple

        // Objetos
        DateTime fechaContratacion = new DateTime(2023, 5, 10);

        // Booleanos
        bool esActivo = true;
        bool tieneSeguro = true;

        Console.WriteLine($"Nombre: {nombreUsuario} ({inicial})");
        Console.WriteLine($"Ocupación: {ocupacion}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Salario Anual: {salarioAnual:C}"); // Formato de moneda
        Console.WriteLine($"Presupuesto del Proyecto: {presupuestoProyecto:C}");
        Console.WriteLine($"Comisión: {porcentajeComision}%");
        Console.WriteLine($"Fecha de Contratación: {fechaContratacion:D}"); // Formato de fecha larga
        Console.WriteLine($"Empleado Activo: {esActivo}");
        Console.WriteLine($"Tiene Seguro: {tieneSeguro}");
        Console.WriteLine();
    }

    /// <summary>
    /// Demuestra el uso de constantes.
    /// </summary>
    public static void MostrarConstantes()
    {
        Console.WriteLine("--- Constantes ---");
        const double PI = 3.14159;
        const int DIAS_SEMANA = 7;
        Console.WriteLine($"El valor de PI es: {PI}");
        Console.WriteLine($"Una semana tiene {DIAS_SEMANA} días.");
        Console.WriteLine();
    }

    /// <summary>
    /// Muestra diferentes formas de construir cadenas de texto.
    /// </summary>
    public static void MostrarInterpolacionDeCadenas()
    {
        Console.WriteLine("--- Interpolación y Concatenación de Cadenas ---");
        string sistemaSolar = "Sistema Solar";
        string planeta = "Marte";
        int lunas = 2;

        // 1. Interpolación de cadenas (método preferido)
        string mensajeInterpolado = $"En nuestro {sistemaSolar}, el planeta {planeta} tiene {lunas} lunas.";
        Console.WriteLine($"Interpolación: {mensajeInterpolado}");

        // 2. Concatenación con +
        string mensajeConcatenado = "En nuestro " + sistemaSolar + ", el planeta " + planeta + " tiene " + lunas + " lunas.";
        Console.WriteLine($"Concatenación: {mensajeConcatenado}");

        // 3. string.Format
        string mensajeFormateado = string.Format("En nuestro {0}, el planeta {1} tiene {2} lunas.", sistemaSolar, planeta, lunas);
        Console.WriteLine($"string.Format: {mensajeFormateado}");
        Console.WriteLine();
    }

    /// <summary>
    /// Demuestra cómo convertir tipos de datos, especialmente desde la entrada del usuario.
    /// </summary>
    public static void MostrarConversionDeTipos()
    {
        Console.WriteLine("--- Conversión de Tipos (con entrada de usuario) ---");
        Console.Write("Ingresa el primer número: ");
        string entrada1 = Console.ReadLine() ?? "0";

        Console.Write("Ingresa el segundo número: ");
        string entrada2 = Console.ReadLine() ?? "0";

        // Usar int.TryParse para una conversión segura que no lanza excepciones
        if (int.TryParse(entrada1, out int num1) && int.TryParse(entrada2, out int num2))
        {
            int suma = num1 + num2;
            Console.WriteLine($"La suma de {num1} y {num2} es: {suma}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingresa solo números enteros.");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Muestra los operadores aritméticos básicos.
    /// </summary>
    public static void MostrarOperadoresAritmeticos()
    {
        Console.WriteLine("--- Operadores Aritméticos ---");
        int a = 20;
        int b = 7;

        Console.WriteLine($"Suma (a + b): {a + b}");
        Console.WriteLine($"Resta (a - b): {a - b}");
        Console.WriteLine($"Multiplicación (a * b): {a * b}");
        // Es necesario convertir uno de los operandos a double para obtener una división con decimales
        Console.WriteLine($"División (a / b): {(double)a / b}");
        Console.WriteLine($"Módulo (a % b): {a % b}"); // Resto de la división
        Console.WriteLine();
    }

    /// <summary>
    /// Muestra los operadores de asignación compuestos.
    /// </summary>
    public static void MostrarOperadoresDeAsignacion()
    {
        Console.WriteLine("--- Operadores de Asignación ---");
        int valor = 10;
        Console.WriteLine($"Valor inicial: {valor}");
        valor += 5; // valor = valor + 5
        Console.WriteLine($"Después de += 5: {valor}");
        valor -= 3; // valor = valor - 3
        Console.WriteLine($"Después de -= 3: {valor}");
        valor *= 2; // valor = valor * 2
        Console.WriteLine($"Después de *= 2: {valor}");
        valor /= 4; // valor = valor / 4
        Console.WriteLine($"Después de /= 4: {valor}");
        Console.WriteLine();
    }

    /// <summary>
    /// Muestra los operadores lógicos AND, OR, y NOT.
    /// </summary>
    public static void MostrarOperadoresLogicos()
    {
        Console.WriteLine("--- Operadores Lógicos ---");
        bool tieneBuenCredito = true;
        bool tieneIngresosAltos = false;

        // AND (&&): Ambas condiciones deben ser verdaderas
        bool esAptoParaPrestamoPremium = tieneBuenCredito && tieneIngresosAltos;
        Console.WriteLine($"¿Apto para préstamo premium? (AND): {esAptoParaPrestamoPremium}");

        // OR (||): Al menos una condición debe ser verdadera
        bool esAptoParaPrestamoBasico = tieneBuenCredito || tieneIngresosAltos;
        Console.WriteLine($"¿Apto para préstamo básico? (OR): {esAptoParaPrestamoBasico}");

        // NOT (!): Invierte el valor booleano
        bool noTieneBuenCredito = !tieneBuenCredito;
        Console.WriteLine($"¿No tiene buen crédito? (NOT): {noTieneBuenCredito}");
        Console.WriteLine();
    }

    /// <summary>
    /// Muestra los operadores para comparar valores.
    /// </summary>
    public static void MostrarOperadoresDeComparacion()
    {
        Console.WriteLine("--- Operadores de Comparación ---");
        int puntuacionA = 95;
        int puntuacionB = 80;

        Console.WriteLine($"Puntuación A: {puntuacionA}, Puntuación B: {puntuacionB}");
        Console.WriteLine($"¿Puntuación A > Puntuación B?: {puntuacionA > puntuacionB}");
        Console.WriteLine($"¿Puntuación A < Puntuación B?: {puntuacionA < puntuacionB}");
        Console.WriteLine($"¿Puntuación A == Puntuación B?: {puntuacionA == puntuacionB}");
        Console.WriteLine($"¿Puntuación A != Puntuación B?: {puntuacionA != puntuacionB}");
        Console.WriteLine($"¿Puntuación A >= 95?: {puntuacionA >= 95}");
        Console.WriteLine($"¿Puntuación B <= 80?: {puntuacionB <= 80}");
        Console.WriteLine();
    }

    /// <summary>
    /// Demuestra los bucles for, while y do-while.
    /// </summary>
    public static void MostrarBucles()
    {
        Console.WriteLine("--- Bucles de Control ---");

        Console.WriteLine("Bucle for (cuenta del 1 al 3):");
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Iteración número: {i}");
        }

        Console.WriteLine("\nBucle while (mientras el nivel de energía sea > 0):");
        int nivelEnergia = 3;
        while (nivelEnergia > 0)
        {
            Console.WriteLine($"Nivel de energía: {nivelEnergia}");
            nivelEnergia--; // Decremento
        }

        Console.WriteLine("\nBucle do-while (se ejecuta al menos una vez):");
        int intentos = 0;
        do
        {
            intentos++;
            Console.WriteLine($"Intento de conexión número: {intentos}");
        } while (intentos < 1); // La condición es falsa, pero el bloque se ejecuta una vez.
        Console.WriteLine();
    }

    /// <summary>
    /// Demuestra el uso de las palabras clave break y continue en bucles.
    /// </summary>
    public static void MostrarBreakYContinue()
    {
        Console.WriteLine("--- Bucles con break y continue ---");

        Console.WriteLine("Uso de 'continue' para saltar números pares:");
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                continue; // Salta a la siguiente iteración si el número es par.
            }
            Console.Write(i + " "); // Solo se ejecuta para números impares.
        }

        Console.WriteLine("\n\nUso de 'break' para detener el bucle si se encuentra un número:");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine($"\nSe encontró el número 5. ¡Saliendo del bucle!");
                break; // Termina el bucle por completo.
            }
            Console.WriteLine($"Buscando... el número actual es {i}");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Demuestra las estructuras condicionales if, else if, else y switch.
    /// </summary>
    public static void MostrarCondicionalesYSwitch()
    {
        Console.WriteLine("--- Estructuras Condicionales (if/else y switch) ---");

        // Ejemplo con if, else if, else
        int temperatura = 25;
        Console.WriteLine($"\nEjemplo con 'if' (Temperatura: {temperatura}°C)");
        if (temperatura > 30)
        {
            Console.WriteLine("Hace mucho calor. ¡Mantente hidratado!");
        }
        else if (temperatura >= 20 && temperatura <= 30)
        {
            Console.WriteLine("El clima es agradable y templado.");
        }
        else
        {
            Console.WriteLine("Hace frío. Considera llevar un abrigo.");
        }

        // Ejemplo con switch
        int edad = 17;
        Console.WriteLine($"\nEjemplo con 'switch' (Edad: {edad})");
        switch (edad)
        {
            case >= 65:
                Console.WriteLine("Eres adulto mayor, cuida esa reuma");
                break;
            case >= 18:
                Console.WriteLine("Eres mayor de edad, ahora busca un trabajo y paga tus deudas");
                break;
            case >= 13:
                Console.WriteLine("Eres un adolescente rebelde y osado");
                break;
            case >= 0:
                Console.WriteLine("Eres un niño disfruta tu infancia.");
                break;
            default:
                Console.WriteLine("Edad no válida.");
                break;
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Demuestra el uso de colecciones: Arrays (tamaño fijo) y Listas (tamaño dinámico).
    /// </summary>
    public static void MostrarArraysYListas()
    {
        Console.WriteLine("--- Arrays y Listas ---");

        // --- Arrays ---
        // Colección de tamaño fijo. Se debe especificar su tamaño al crearlo.
        Console.WriteLine("\nEjemplo con Array (tamaño fijo):");
        string[] inventario = new string[3]; // Se crea un array para 3 elementos.
        inventario[0] = "Espada";
        inventario[1] = "Escudo";
        inventario[2] = "Poción";
        // inventario[3] = "Casco"; // Esto daría un error (IndexOutOfRangeException) porque el array solo tiene 3 espacios.

        Console.WriteLine("Contenido del inventario (Array):");
        // Se recorre con un bucle 'for' o 'foreach'.
        foreach (string item in inventario)
        {
            Console.WriteLine($"- {item}");
        }
        Console.WriteLine($"El segundo objeto en el inventario es: {inventario[1]}");


        // --- Listas ---
        // Colección de tamaño dinámico. Puede crecer o encogerse según sea necesario.
        // Es más flexible y generalmente preferida sobre los arrays.
        Console.WriteLine("\nEjemplo con Lista (tamaño dinámico):");
        List<string> misiones = new List<string>(); // Se crea una lista vacía.

        // Añadir elementos
        misiones.Add("Derrotar al dragón");
        misiones.Add("Encontrar el tesoro perdido");
        misiones.Add("Salvar a la princesa");

        Console.WriteLine("\nMisiones activas (Lista):");
        foreach (string mision in misiones)
        {
            Console.WriteLine($"- {mision}");
        }

        // Quitar un elemento
        misiones.Remove("Salvar a la princesa");
        Console.WriteLine("\nMisiones después de completar una:");
        Console.WriteLine($"- {misiones[0]}");
        Console.WriteLine($"- {misiones[1]}");
        Console.WriteLine($"Número de misiones restantes: {misiones.Count}");
        Console.WriteLine();
    }
}