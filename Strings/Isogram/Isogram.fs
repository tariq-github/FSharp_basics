open System
module Isogram = 
    let isIsogram (str: string): bool =
        let lower_letters = str.ToLower() |> Seq.filter System.Char.IsLetter |> Seq.toList
        let lower_Letters_distinct = List.distinct lower_letters
        lower_letters = lower_Letters_distinct

//Example
Isogram.isIsogram "lumberjacks"     //true
Isogram.isIsogram "background"      //true
Isogram.isIsogram "downstream"      //true
Isogram.isIsogram "six-year-old"    //true
Isogram.isIsogram "mom"             //False