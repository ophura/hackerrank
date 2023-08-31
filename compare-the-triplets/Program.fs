let rate (x: int list) (y: int list) =
    Seq.fold2 (fun (z, w) a b ->
        match compare a b with
        | 1 -> (z + 1, w)
        | -1 -> (z, w + 1)
        | _ -> (z, w)
    ) (0, 0) x y
