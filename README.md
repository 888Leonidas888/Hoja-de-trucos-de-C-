# Hoja de Trucos de C# (Cheatsheet)

Este repositorio contiene una hoja de trucos con ejemplos de conceptos fundamentales de C#. El archivo principal es `learning/Program.cs`, que está estructurado con métodos estáticos para cada tema. Este `README` sirve como una guía de referencia rápida con ejemplos de código listos para copiar y pegar.

## Índice

1.  Variables y Tipos de Datos
2.  Constantes
3.  Interpolación y Concatenación de Cadenas
4.  Conversión de Tipos
5.  Operadores Aritméticos
6.  Operadores de Asignación
7.  Operadores Lógicos
8.  Operadores de Comparación
9.  Bucles de Control (for, while, do-while)
10. Control de Flujo en Bucles (break y continue)
11. Estructuras Condicionales (if y switch)
12. Arrays y Listas

---

### 1. Variables y Tipos de Datos

Declaración de variables para almacenar diferentes tipos de datos como texto, números, fechas y valores booleanos.

```csharp
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
```

### 2. Constantes

Valores que no pueden ser modificados después de su declaración. Se definen con la palabra clave `const`.

```csharp
const double PI = 3.14159;
const int DIAS_SEMANA = 7;
Console.WriteLine($"El valor de PI es: {PI}");
Console.WriteLine($"Una semana tiene {DIAS_SEMANA} días.");
```

### 3. Interpolación y Concatenación de Cadenas

Formas de combinar variables y texto. La **interpolación** (`$"{variable}"`) es el método moderno y preferido por su claridad.

```csharp
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
```

### 4. Conversión de Tipos

Convertir un tipo de dato a otro. Es crucial al leer datos del usuario. `TryParse` es la forma más segura de convertir texto a números, ya que evita que el programa se bloquee si la entrada no es válida.

```csharp
Console.Write("Ingresa un número: ");
string entrada = Console.ReadLine() ?? "0";

// Usar int.TryParse para una conversión segura que no lanza excepciones
if (int.TryParse(entrada, out int numeroConvertido))
{
    Console.WriteLine($"La conversión fue exitosa. El número es: {numeroConvertido}");
}
else
{
    Console.WriteLine("Entrada inválida. No se pudo convertir a número.");
}
```

### 5. Operadores Aritméticos

Operaciones matemáticas básicas: `+` (suma), `-` (resta), `*` (multiplicación), `/` (división), `%` (módulo/resto).

```csharp
int a = 20;
int b = 7;

Console.WriteLine($"Suma (a + b): {a + b}");
Console.WriteLine($"Resta (a - b): {a - b}");
Console.WriteLine($"Multiplicación (a * b): {a * b}");
// Es necesario convertir uno de los operandos a double para obtener una división con decimales
Console.WriteLine($"División (a / b): {(double)a / b}");
Console.WriteLine($"Módulo (a % b): {a % b}"); // Resto de la división
```

### 6. Operadores de Asignación

Formas abreviadas de realizar una operación y asignar el resultado: `+=`, `-=`, `*=`, `/=`.

```csharp
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
```

### 7. Operadores Lógicos

Se usan para combinar expresiones booleanas: `&&` (Y lógico), `||` (O lógico), `!` (NO lógico).

```csharp
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
```

### 8. Operadores de Comparación

Para comparar dos valores: `==` (igual), `!=` (diferente), `>` (mayor que), `<` (menor que), `>=` (mayor o igual), `<=` (menor o igual).

```csharp
int puntuacionA = 95;
int puntuacionB = 80;

Console.WriteLine($"Puntuación A: {puntuacionA}, Puntuación B: {puntuacionB}");
Console.WriteLine($"¿Puntuación A > Puntuación B?: {puntuacionA > puntuacionB}");
Console.WriteLine($"¿Puntuación A < Puntuación B?: {puntuacionA < puntuacionB}");
Console.WriteLine($"¿Puntuación A == Puntuación B?: {puntuacionA == puntuacionB}");
Console.WriteLine($"¿Puntuación A != Puntuación B?: {puntuacionA != puntuacionB}");
Console.WriteLine($"¿Puntuación A >= 95?: {puntuacionA >= 95}");
Console.WriteLine($"¿Puntuación B <= 80?: {puntuacionB <= 80}");
```

### 9. Bucles de Control (for, while, do-while)

Estructuras para repetir un bloque de código:
*   `for`: Cuando se conoce el número de iteraciones.
*   `while`: Cuando la iteración depende de una condición que se evalúa al inicio.
*   `do-while`: Similar a `while`, pero garantiza que el bloque se ejecute al menos una vez.

```csharp
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
```

### 10. Control de Flujo en Bucles (break y continue)

Palabras clave para manipular la ejecución de un bucle:
*   `continue`: Omite la iteración actual y salta a la siguiente.
*   `break`: Termina el bucle por completo.

```csharp
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
```

### 11. Estructuras Condicionales (if y switch)

Permiten ejecutar diferentes bloques de código según se cumplan ciertas condiciones.
*   `if`, `else if`, `else`: Ideal para evaluar rangos o condiciones complejas.
*   `switch`: Ideal para evaluar múltiples valores posibles de una sola variable. A partir de C# 7, `switch` puede usar comparaciones de rango.

```csharp
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

// Ejemplo con switch y patrones de comparación
int edad = 17;
Console.WriteLine($"\nEjemplo con 'switch' (Edad: {edad})");
switch (edad)
{
    case >= 65:
        Console.WriteLine("Eres adulto mayor.");
        break;
    case >= 18:
        Console.WriteLine("Eres mayor de edad.");
        break;
    case >= 13:
        Console.WriteLine("Eres un adolescente.");
        break;
    default:
        Console.WriteLine("Eres un niño.");
        break;
}
```

### 12. Arrays y Listas

Colecciones para almacenar múltiples elementos.
*   **Array**: Tiene un tamaño fijo que se define en su creación. Es más rápido pero menos flexible.
*   **Lista (`List<T>`)**: Tiene un tamaño dinámico. Puede añadir o quitar elementos fácilmente, por lo que es más flexible y de uso común.

```csharp
// --- Arrays ---
Console.WriteLine("Ejemplo con Array (tamaño fijo):");
string[] inventario = new string[3];
inventario[0] = "Espada";
inventario[1] = "Escudo";
inventario[2] = "Poción";

foreach (string item in inventario)
{
    Console.WriteLine($"- {item}");
}

// --- Listas ---
Console.WriteLine("\nEjemplo con Lista (tamaño dinámico):");
List<string> misiones = new List<string>();
misiones.Add("Derrotar al dragón");
misiones.Add("Encontrar el tesoro perdido");

misiones.Remove("Encontrar el tesoro perdido"); // Quitar un elemento
misiones.Add("Salvar a la princesa"); // Añadir otro

Console.WriteLine("\nMisiones activas:");
foreach (string mision in misiones)
{
    Console.WriteLine($"- {mision}");
}
Console.WriteLine($"Número de misiones: {misiones.Count}");
```

