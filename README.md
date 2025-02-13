# alphang
A simple functional language meant to be immediate and expendable
# Proof of concept and examples
```
package example
	fib := fn n -> n : n in [0,1]
	fib := fn n -> fib(n-2) + fib(n-1)
end_package


package people
	person := struct (name, surname, dob)
	age := fn p!person -> Time.today() - p.dob
end_package


package entry
	factorial := fn n -> 1 : n in [0,1]
	factorial := fn n -> n * factorial(n-1) 

	IO.print(example.fib(12))
	IO.print(factorial(3))
	
	bob := people.person("Bob", "Smith", Time.date("1999-12-1"))
	IO.print(people.age(bob))
	
	# List of squares
	los := for n 1..5 -> n * n
	# [1,4,9,16]
	
	# List of doubled cubes to strings 
	lodc := 1..5 >> (fn x -> x * x * x) >> fn ( x -> x * 2) >> toString
	# ['2','16','54','128']
	
	# Reverse every line in file
	rf := File.read('testfile') >> String.split('\n') >> reverse
	# Write it out to a new file
	outcome := String.join(rf, '\n') >> File.write
end_package
```
