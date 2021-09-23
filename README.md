# Scrabble Scorer

#### This console application will score words according to Scrabble rules.

#### By Anna Clarke, Erica Marroquin, Scott Hutley

## Technologies Used

* _C#_
* _.Net_
* _MSTest_

## Description

This console app will take a word from the user and display the scrabble score of that word.

## Setup/Installation Requirements

* Clone this repository to your desktop
* Open in text editor
* Make sure you have .Net version 5.0 installed
* In your terminal navigate into Scrabble.Solution/Scrabble/
* run commands $ dotnet run
* follow console instructions to use application and have fun!

## Known Bugs

* _No know issues_

## License

_[MIT](https://opensource.org/licenses/MIT)_

Copywrite(c)2021 Anna Clarke, Erica Marroquin, Scott Hutley

## Contact Information

Anna Clarke: anclarkie@gmail.com

Scott Hutley: scotthutley1@comcast.net

Erica Marroquin: ericamarroquin03@gmail.com

# Specs

* take in a string word as input (must be string.length > 0)
* return an integer score
* we store the scrabble score for each letter as items in a dictionary
* split the input word into an array by character .Split("")
* int score; outside of the loop
* iterate through the array of characters
* inside that loop, find the value that matches the character by key and  add that value to the score
* {
  {"A" : 1},
  {B : 3},
  {C }
}
input.ToLower
dictionary[input]

#### Expected Inputs/Output

0. input = "a"
   output = 1

1. input = "Cat"
   output = 5

2. input = "expectation"
   output = 22

Handle user input edge cases in UI