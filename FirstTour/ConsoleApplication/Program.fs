// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let add x y = x + y

[<EntryPoint>]
let main argv =
    add 2 3 |> printfn "%d"
    0
