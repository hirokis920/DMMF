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
    
    type CustomerId = CustomerId of int
    type OrderId = OrderId of int

    

    //未定義の型はこうする
    type Undifined = exn

    type CostomerInfo = Undifined
    type Order = {
        CostomerInfo: CostomerInfo
    }

    let customerId = CustomerId  42
    let orderId = OrderId  42


[<EntryPoint>]
let main args =

    let customerId = PigLatin.CustomerId  42
    let orderId = PigLatin.OrderId  42
    printfn "%b" (orderId = orderId)

    0