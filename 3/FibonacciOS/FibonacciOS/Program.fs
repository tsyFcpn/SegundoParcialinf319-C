// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System
let rec fib1 n = 
    match n with
    | 1 -> 
        1 
    | 2 -> 
        1
    | 3 ->
        2
    | 0 -> 
        0
    | n -> 
        fib1(n - 1) + fib1(n - 2) + fib1(n - 3)

let forLoop(n) =
    for i in 1 .. n do
        printf"%i" (fib1(i))
        printfn ""

let fibOS f n = 
    f(n)

[<EntryPoint>]
let main argv = 
    let msg = Console.WriteLine("Ingrese n: ")
    let n = Console.ReadLine()|> int
    fibOS forLoop n
    let temp = Console.ReadKey()
    0 // devolver un código de salida entero
