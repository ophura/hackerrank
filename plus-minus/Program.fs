let plminus (input: int list) =
    let positives = input |> Seq.filter (fun x -> x > 0) |> Seq.length |> float
    let negatives = input |> Seq.filter (fun x -> x < 0) |> Seq.length |> float
    let neutrals = input |> Seq.filter (fun x -> x = 0) |> Seq.length |> float

    positives / float input.Length |> printfn "%f"
    negatives / float input.Length |> printfn "%f"
    neutrals / float input.Length |> printfn "%f"
