// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    let x = TwitterSnapshot.Camera("A","B","C","D")
    0 // return an integer exit code

