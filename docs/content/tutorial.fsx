(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin"

(**
Introducing your project
========================

Say more

*)
#r "FSharp.Implicit.dll"
open System

let pointF =
        implicit {
            let! implicitConversion = Point(1,1)
            return implicitConversion
        }
(**
Some more info
*)
