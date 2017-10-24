module FableP5Demo

open Fable.Core
open Fable.Import

//approximate https://p5js.org/get-started/ in instance mode
let sketch  = 
    new System.Func<obj,unit>(
        fun o ->
            let x = 100.0;
            let y = 100.0;
            let p = o |> unbox<p5>
            p.setup <- fun() -> p.createCanvas(700.0, 410.0) |> ignore

            p.draw <- fun() ->
                
                if p.mouseIsPressed |> unbox<bool> then
                    p.fill(0.0 |> U4.Case1)
                else
                    p.fill(255.0 |> U4.Case1)
                p.rect(p.mouseX |> unbox<float>, p.mouseY |> unbox<float>, 50.0,50.0)
                |> ignore
            ()
    )

let myp5 = p5(sketch);