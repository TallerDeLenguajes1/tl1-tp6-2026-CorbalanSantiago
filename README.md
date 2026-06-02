# Preguntas sobre String en C#

## 1. ¿String es valor o referencia?
Es un tipo por referencia, string es un alias de System.String que es una clase.

## 2. Secuencias de escape:
- `\n` → salto de línea
- `\t` → tabulación
- `\\` → barra invertida
- `\"` → comillas dobles
- `\r` → retorno de carro
- `\0` → carácter nulo

## 3. ¿Qué hace @ y $ antes de una cadena?
- `@` hace que el string sea literal, ignora las secuencias de escape. Ejemplo: `string ruta = @"C:\Users\Santi\Desktop";`
- `$` permite interpolación, se puede meter variables adentro del texto. Ejemplo: `string mensaje = $"Hola {nombre}, tenés {edad} años";`
