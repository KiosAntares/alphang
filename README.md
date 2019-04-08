# alphang
A simple non pure functional language based on streams and contexts

# Proof of concept and examples

Declares the square 'function', and prints the insterted number squared until the user inputs a one.
```
square: base  // Declares a model named square, with an argument named base
start         // Model begins
  << base * base // Puts the base multiplied by the base into the output context
end           // Model ends


entry:        // Defines entry point
start         
  1 >> input  // Makes a new variable 'input' with the number 1 inside of it
  input = 0 ? // checks if condition is true
  start       
    >> input  // Gets value from input context and puts its value into the variable 'input'
    input >> square >> squared // applies the square function to the input variable and puts the return value into 'squared'
    << squared // Outputs squared
  loop         // Loops if condition is true
end
```
