//Formale Spezifikation und Verifikation von Programmen

//Calculator und UserInputs, programmiert in C#, in Dafny übersetzt und verifiziert

module Basics {

    // Einfache Addition von zwei Zahlen
    method Add(a: int, b: int) returns (sum: int)
        ensures sum == a + b
        {
            sum := a + b;
        }
    
    method Substract(a: int, b: int) returns (diff: int)
        ensures diff == a - b
        {
            diff := a - b;
        }
    
    method Multiply(a: int, b: int) returns (product: int)
        ensures product == a * b
        {
            product := a * b;
        }
    
    method Divide(a: int, b: int) returns (quotient: int)
        requires b != 0
        ensures quotient == a / b
        {
            quotient := a / b;
        }
}