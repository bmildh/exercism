module Hamming
open System

let distance (strand1: string) (strand2: string): int option = 
    if(String.length strand1 = String.length strand2) then
        match (strand1, strand2) with
        | ("",_) -> Some(0)
        | (_,"") -> Some(0)
        | (_,_) -> Seq.fold2 (fun acc c1 c2 -> if(c1 <> c2) then acc+1 else acc) 0 strand1 strand2 |> Some
    else
        None

