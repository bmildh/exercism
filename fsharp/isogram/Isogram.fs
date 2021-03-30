module Isogram 
open System

// I had add the type annotation here, otherwise there was a type mismatch from the test 
// suite. Could not figure out another way.
let isIsogram (str:string) =

    let rec recIsIsogram input =

        match input with
        | [] -> true
        | ' '::tail  -> recIsIsogram tail
        | '-':: tail -> recIsIsogram tail
        | head::tail ->
            match (List.contains head tail) with
            | true -> false
            | false -> recIsIsogram tail

    str
    |> Seq.toList
    |> List.map Char.ToLower
    |> recIsIsogram
             