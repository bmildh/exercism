module Pangram
open System

let alphabet = "abcdefghijklmnopqrstuvwxyz" 

// This uses Set's, a very nice feature of the language. 
let isPangram (input: string): bool = 
    let alphabet = "abcdefghijklmnopqrstuvwxyz" 
    input 
    |> Seq.toList
    |> List.map Char.ToLower
    |> Set.ofList
    |> Set.intersect (Set.ofList (Seq.toList alphabet))  
    |> Set.count
    |> function
        | 26 -> true
        | _  -> false