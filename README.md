# PillarForge.Kata.RomanNumerals
Visual Studio 2017 was used in order to create this project. 
Unit tests implemented as MsTest. 
All packages will be restored from Nuget.

Comments:
The last 2 check-ins is a refactoring to make code more readable and less cryptic. It did increase cyclometric complexity but made it easier to understand. I possibly could reduce complexity of the SymbolConverter class by utilizing dependency injection, but feel like this is overkill for this task and will complicate test project as I will have to use mocking.
Also I noticed that one of the requirements is not quite correct: "Only one subtraction can be made per numeral ('XC' is allowed, 'XXC' is not)". After researching a little bit I found out that this is not true for the Roman Numerals rules. But I still implemented it as the exercise stated.
