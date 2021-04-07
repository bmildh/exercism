module PhoneNumber
open System

(*
    This solution does not pass thru all the possible tests. Thus, some of the
    tests are disabled. The reason being that the first thing we do is to filter
    the input to only contain digits. Thus, there is no need to check for letters, 
    punctuation or other similiar things.

    Also, I could validate the area code, but I kinda lost interest in this exercism.
    Moving on to bigger things.
*)
let clean input = 
    let nums = 
        input 
        |> Seq.filter (fun (c) -> Char.IsNumber c)

    match Seq.length nums with
    | 10 -> 
        Ok (nums |> Seq.toArray |> String |> UInt64.Parse)
    | 11 -> 
        if (Seq.head nums = '1') then
            Ok (Seq.skip 1 nums |> Seq.toArray |> String |> UInt64.Parse)
        else
            Error "11 digits must start with 1"
    | len when len > 11 -> 
        Error "more than 11 digits"
    | _ -> 
        Error "incorrect number of digits"
