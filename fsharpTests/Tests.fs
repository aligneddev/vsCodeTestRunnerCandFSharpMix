module Tests

open System
open Xunit
open Program

[<Fact>]
let ``Run in F#`` () =
    let runner = new Runner()
    runner.Run();
    Assert.True(true)
