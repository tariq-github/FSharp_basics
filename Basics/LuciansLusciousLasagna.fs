module LuciansLusciousLasagna =
    // TODO: define the 'expectedMinutesInOven' binding
    let expectedMinutesInOven = 40

    // TODO: define the 'remainingMinutesInOven' function
    let remainingMinutesInOven actualMinutes = expectedMinutesInOven - actualMinutes 

    // TODO: define the 'preparationTimeInMinutes' function
    let preparationTimeInMinutes numberOfLayer = numberOfLayer * 2

    // TODO: define the 'elapsedTimeInMinutes' function
    let elapsedTimeInMinutes numberOfLayer numberOfMinutes = (preparationTimeInMinutes numberOfLayer) + numberOfMinutes


// Example 
let testRemainingTime = remainingMinutesInOven 30
printfn "Remaining time in the oven after 30 Minutes: %i minutes." test_remaining_time

let testPreparationTime = preparationTimeInMinutes 10
printfn "Preparation time for 10 layers: %i minutes." testPreparationTime

let testElapsedTime = elapsedTimeInMinutes 10 30
printfn "Elapsed time for after 30 minutes and 10 layers: %i minutes." testElapsedTime