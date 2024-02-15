// declare a method and variable name by writing
// let {function name} variable = logic...
let testfunc test= printfn("Hello World! \n")

testfunc()

let test2 name = printfn "Hello %s" name
test2("hello \n")

let array1 = [|1;2;3;4;5;6;7;8;9;10|]

for i in 0 .. array1.Length - 1 do
    printfn "%d\n" array1.[i]

let arrayStr = [|"Sup"; "Hasnain"; "Nabeel"; "Hasin"; "Firdaus"; "Zhong Shan"|]
for x in 0 .. arrayStr.Length - 1 do
    printfn "%s\n" arrayStr.[x]

let printStr name2 = printfn "Printing: %s\n" name2
printStr("Nigeria")