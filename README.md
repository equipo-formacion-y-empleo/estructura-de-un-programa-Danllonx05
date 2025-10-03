[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/gynsRPSl)
# Estructura de un Programa - Ejercicios Prácticos

Este repositorio contiene ejercicios prácticos para practicar los conceptos fundamentales de programación en C# utilizando .NET 9.

## Instrucciones Generales

Cada ejercicio está en su propia carpeta con un proyecto de C# independiente. Para completar los ejercicios:

1. Navega a la carpeta del ejercicio que quieres resolver
2. Implementa las funciones requeridas en el archivo principal `.cs`
3. Ejecuta el ejercicio con `dotnet run [argumentos]` desde la carpeta del ejercicio
4. Lee las instrucciones específicas en el README.md de cada ejercicio

## Lista de Ejercicios Disponibles

- **Exercise01_HelloWorld** - Funciones básicas
- **Exercise02_VariablesScope** - Variables globales 
- **Exercise03_BasicDataTypes** - Tipos de datos fundamentales y tamaños en memoria
- **Exercise04_TypeConversions** - Conversiones de tipos implícitas y explícitas
- **Exercise05a_TriangleArea** - Cálculos geométricos básicos
- **Exercise05b_TemperatureConverter** - Conversión de temperaturas
- **Exercise05c_Average** - Cálculo de promedio de tres números
- **Exercise05d_Hypotenuse** - Cálculo de hipotenusa usando teorema de Pitágoras
- **Exercise05e_BMI** - Calculadora de índice de masa corporal
- **Exercise05f_Distance** - Cálculo de distancia entre dos puntos
- **Exercise06a_IsEven** - Verificador de números pares
- **Exercise06b_IsAdult** - Verificador de mayoría de edad
- **Exercise06c_AreDifferent** - Verificador de números diferentes
- **Exercise06d_IsNotNegative** - Verificador de números no negativos
- **Exercise06e_EqualGroups** - Verificador de divisibilidad en grupos
- **Exercise07a_CanDrive** - Verificador de permiso para conducir
- **Exercise07b_IsInRange** - Verificador de rango numérico
- **Exercise07c_IsWorkingAge** - Verificador de edad laboral
- **Exercise07d_IsLeapYear** - Verificador de año bisiesto
- **Exercise08_BankingSimulator** - Funciones de operaciones bancarias secuenciales
- **Exercise11_RestaurantBill** - Calculadora con impuestos y propinas
- **Exercise12_CurrencyConverter** - Conversión de monedas con función reutilizable
- **Exercise13_GeometricShapes** - Cálculos de áreas para múltiples figuras geométricas

## Cómo Ejecutar

Cada ejercicio se ejecuta con argumentos específicos:

```powershell
# Navegar al ejercicio
cd ExerciseXX_NombreEjercicio

# Ejecutar con argumentos (ejemplo)
dotnet run valor1 valor2 valor3


Consulta el README.md de cada ejercicio para ver ejemplos específicos de ejecución.

## Evaluación Automática

Este proyecto incluye un script de evaluación automática que verificará:
- Que el código compile correctamente
- Que produzca la salida esperada con diferentes valores de entrada
- Que las funciones estén correctamente implementadas

Para ejecutar todas las pruebas:
```powershell
.\Test-Exercises.ps1
```

Para probar un ejercicio específico:
```powershell
.\Test-Exercises.ps1 -ExerciseName "Exercise01_HelloWorld"
```

## Estructura del Proyecto

Cada ejercicio sigue esta estructura:
```
ExerciseXX_NombreEjercicio/
├── XX-NombreEjercicio.csproj
├── XX-NombreEjercicio.cs
└── README.md
```

## Notas

- Todos los proyectos están configurados para .NET 9
- Los ejercicios pueden ser ejecutados independientemente
- Las funciones deben implementarse reemplazando `throw new NotImplementedException()`
- Consulta el README.md de cada ejercicio para ejemplos específicos

