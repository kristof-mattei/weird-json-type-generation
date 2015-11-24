open FSharp.Data


type Test = JsonProvider<"test.json">

[<EntryPoint>]
let main argv = 

    let loaded = Test.Load "test.json"

    let result = loaded.A234 // Where's my '1'?
    // let result = loaded.A1234 // this one doesn't compile

    printfn "%s" result
    
    0 
