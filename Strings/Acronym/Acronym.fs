open System
module Acronym = 
    let abbreviate (phrase: string): string = 
        phrase.Split ([|' '; '_'; '-'; ','|], StringSplitOptions.RemoveEmptyEntries)   // Split the string by space, dash, or underscore
        |> Seq.map Seq.head                     // Take just the head of each entry(first char of string)
        |> Seq.toArray                          // Convert seq to array
        |> String                               // Convert array to string
        |> fun x -> x.ToUpper()                 //function to convert eac char into upper-case

//Example 
Acronym.abbreviate "Three Letter Acronyms"
Acronym.abbreviate "Three_Letter-Acronyms"
