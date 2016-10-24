module ServiceFabricDemo.Program

open System
open System.Fabric
open System.Threading
open Microsoft.ServiceFabric.Actors.Runtime

[<EntryPoint>]
let main argv = 
    use fabricRuntime = ActorRuntime.RegisterActorAsync<Cat>()
    Thread.Sleep(Timeout.Infinite)
    0