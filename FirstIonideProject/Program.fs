// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

module PigLatin =
    let toPigLatin (word: string) =
        let isVowel (c: char) =
            match c with
            | 'a' | 'e' | 'i' | 'o' | 'u'
            | 'A' | 'E' | 'I' | 'O' | 'U' -> true
            |_ -> false
        
        if isVowel word[0] then
            word + "yay"
        else
            word[1..] + string word[0] + "ay"
    
    type CostomerId = CostomerId of Int
    type OrderId = OrderId of Int

    let costomerId = CostomerId of 42
    let orderId = OrderId of 42

    type Order = {
        CostomerInfo: CostomerInfo
        ...
    }

    //未定義の型はこうする
    type Undifined = exn

    type CostomerInfo = Undifined

    type PlaceOrderEvents = {
        AknowledgementSent : AknowledgementSent
        ...
    }

    

    // OR型
    type ProductCode = 
    | Widget of WidgetCode
    | Gizmo of GizmoCode

        
[<EntryPoint>]
let main args =
    for arg in args do
        let newArg = PigLatin.toPigLatin arg
        printfn "%s in Pig Latin is: %s" arg newArg

    0