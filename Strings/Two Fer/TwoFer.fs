module TwoFer = 
    let twoFer (input: string option): string = 
        match input with
        | Some(x) -> "One for " + x + ", one for me."
        | None -> "One for you, one for me."

//example

let name = Some("Tariq")
TwoFer.twoFer name

TwoFer.twoFer None