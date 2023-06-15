#Exercise 2
1. Build a function that takes a string
2. The string will only contain the following charecters: (){}[]<>
3. Check if the parentheses in the string are correct
4. it is correct if an opened bracket needs to be closed by its twin closing bracket

* BONUS - assume the string can include text

Tests:
true - ()
true - []
true - {}
true - <>
true - (){}[]
false - (]
false - ([<])
true - ({[<>]})

* [Simon {is} cool <!>]
* [Simon [not} {is} cool <!>]
