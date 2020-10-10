#if INTERACTIVE
#else
module Literals
#endif

// Some strings:
let message = "Hello
World\n\t!"
let dir = @"c:\projects"

// A byte array:
let bytes = "bytesbytesbytes"B

// Some numeric types:
let xA = 0xFFy
let xB = 0o7777un
let xC = 0b10010UL

// Print the results:
let main() =
    printfn "Message %A" message
    printfn "dir %A" dir
    printfn "bytes %A" bytes
    printfn "xA %A" xA
    printfn "xB %A" xB
    printfn "xC %A" xC

// Call the main function:
main()
