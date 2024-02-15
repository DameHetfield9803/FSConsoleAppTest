let sign num =
    if num > 0 then "It is positive."
    elif num < 0 then "It is negative."
    else "0"

let main() =
     printfn"Sign 5 %s" sign 5
main()