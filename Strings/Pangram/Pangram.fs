module Pangram = 
    let alphabet = {'a'..'z'} |> Set.ofSeq

    let isPangram (input: string): bool = 
        input.ToLower() 
            |> Set.ofSeq 
            |> Set.isSubset alphabet

// Example 
let example_pangram = "The quick brown fox jumps over the lazy dog."
Pangram.isPangram example_pangram