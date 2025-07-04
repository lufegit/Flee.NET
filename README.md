# Flee (.NET 8.0 and .NET Framework 4.7.2)

Fast Lightweight Expression Evaluator

This project is a modern C# port of the original Flee library by Eugene Ciloci.  
Ported from VB.NET to C# by [Luis Festas](https://github.com/lufegit/).

---

## Project Description

Flee is an expression parser and evaluator for the .NET ecosystem. It allows you to compute the value of string expressions such as `sqrt(a^2 + b^2)` at runtime. It uses a custom compiler, strongly-typed expression language, and lightweight code generation to compile expressions directly to IL, providing extremely fast evaluation performance.

---

## Features

- Fast and efficient expression evaluation
- Small, lightweight library
- Compiles expressions to IL using a custom compiler and the `DynamicMethod` class
- Garbage-collects generated expressions and IL when no longer used
- Does not create dynamic assemblies that remain in memory
- Backed by a comprehensive suite of unit tests
- Culture-sensitive decimal point handling
- Fine-grained control over which types an expression can use
- Supports all arithmetic operations including the power (`^`) operator
- Supports string, char, boolean, and floating-point literals
- Supports 32/64-bit, signed/unsigned, and hex integer literals
- Includes a true conditional operator
- Supports short-circuited logical operations
- Supports arithmetic, comparison, implicit, and explicit overloaded operators
- Variables of any type can be dynamically defined and used in expressions
- CalculationEngine: Reference other expressions and recalculate in natural order
- Expressions can index arrays and collections, access fields and properties, and call functions on various types
- Generated IL can be saved to an assembly and viewed with a disassembler

---

## Target Frameworks

- .NET Framework 4.7.2
- .NET 8.0

---

## Examples

See the [Examples](https://github.com/lufegit/Flee.NET/wiki/Examples) in the Wiki to learn how to create and evaluate expressions.

---

## License

Flee is licensed under the GNU Lesser General Public License v2.1 (LGPL).

This means that as long as you dynamically link (i.e., add a reference) to the officially released assemblies, you can use it in commercial and non-commercial applications.  
See the `LICENSE` file in this repository for details.

---

## Dependencies

The library uses the Grammatica parser generator to handle formula parsing.  
Grammatica is also licensed under the LGPL: http://grammatica.percederberg.net/

Unit tests are built with NUnit.

---

## Kudos

Special thanks to Eugene Ciloci, who first developed this amazingly useful expression evaluator.
