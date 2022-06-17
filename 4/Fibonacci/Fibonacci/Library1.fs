namespace Fibonacci
module hola =
    let temp = "Hola pues"

module fibo =
    let rec recu n = 
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
                recu(n - 1) + recu(n - 2) + recu(n - 3)
    let fiboProgre n =
        match n with 
        | 0 -> 0
        | n -> 
            let mutable farlast = 0
            let mutable last = 0
            let mutable next = 1
            for i in 1 .. (n - 1) do
                let temp = farlast + last + next
                farlast <- last
                last <- next
                next <- temp
            next
type Class1() = 
    member this.X = "F#"
