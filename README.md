# Repeat-Counter

#### Mvc C# exercise, 02/09/2018

#### By **Justin Lardani**

## Description

Repeat-Counter is a web application built with C# Asp Net Core MVC framework. Users can input both a word and a sentence. In response, the user will be told how many times that word appears inside of the sentence they inputted.

## Setup/Installation Requirements

* Clone this repository to your desktop.
* Navigate to the cloned directory in a terminal capable of running dotnet commands.
* Run the command >dotnet add package Microsoft.AspNetCore.StaticFiles -v 1.1.3.
* Run the command >dotnet restore.
* Run the command >dotnet run.
* Navigate to localhost:5000 in your browser.

## Specifications

###Program finds first index within sentence that is equal to the first character in the input word
* _Example Input: word: "t"; sentence: "want"_
* _Example Output: 3_
* _This input will ensure that the program can iterate through a word and find the index of a matching character_

### Program finds all indexes within sentence that are equal to the first character in the input word
* _Example Input: word: "tree" and sentence: "I want coffee today."_
* _Example Output: List<int> {5, 14}_
* _This input will ensure that the program correctly searches for the first letter of a word_

###Program identifies whether a substring is equal to the input word
* _Example Input: "apple" and "the apple".Substring(4, 5)_
* _Example Output: false_
* _This input will ensure that the program can correctly find substrings within a sentence and compare it to an input word_

###Program counts the number of substrings within the sentence that are equal to the input word
* _Example Input: word: "cat"; sentence: "cats are larger than caterpillars."_
* _Example Output: 2_
* _This input will ensure that the program can find more than one instance of the word within the sentence_

###Program counts the number of whole word copies of an input word that exist within a sentence
* _Example Input: word: "cat"; sentence: "Cats are larger than caterpillars."_
* _Example Output: 1;
* _This input will ensure that the program can differentiate between full-word matches and matches that are only parts of larger words._

## Known Bugs

No known bugs at this time.

## Support and contact details

If you have suggestions for how to help us make any additions, or if you have other feedback, please feel free to contact Justin at jlardani93@gmail.com. All feedback is welcome.

## Technologies Used

* C# .Net Core MVC
* Razor
* Javascript
* Jquery
* HTML
* Bootstrap
* CSS


### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **Justin Lardani**
