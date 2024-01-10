# Iron Software Challenge
# Ronnagon Phukahuta

# Installation
1. Clone the repo
   ```sh
   git clone https://github.com/Qaizx/Assignment-Challenge.git
   ```
2. Build
   ```sh
   dotnet build
   ```
3. Run project
   ```sh
   dotnet run
   ```

# Tools
1. Visual studio code

## Extension
1. C#
2. Nuget Package Manager

### Nuget Package Manager - Add package (net8.0)
1. Microsoft.NET.Test.Sdk v.17.9.0-release-23619-01
2. xunit v.2.6.5
3. xunit.runner.visualstudio v.2.5.6

## Config in .csproj
1. Disabled
   ```sh
   <GenerateProgramFile>false</GenerateProgramFile>
   ```

# How to use the project
1. Run this project
2. Enter your sentence
   1. if you forgot '#' in your sentence, this project will throw exception to notice that you forgot to put # in the sentence.
   2. if your sentence have contains characters other than 0-9, *, or #, this project will throw exception to notice that you don't have contain any characters other than 0-9, *, or #.
4. This project will convert your string
   1. The number 1 represents the symbols &, ' and (
   2. The number 2 represents the symbols A, B and C
   3. The number 3 represents the symbols D, E and F
   4. The number 4 represents the symbols G, H and I
   5. The number 5 represents the symbols J, K and L
   6. The number 6 represents the symbols M, N and O
   7. The number 7 represents the symbols P, Q, R and S
   8. The number 8 represents the symbols T, U and V
   9. The number 9 represents the symbols W, X, Y and Z
   10. The number 0 represents the space bar
   11. The letter * represents the meaning of deleting the preceding letter.
   12. The letter # will represent the meaning used to press send data.
       1. The characters behind # will not be converted into any text.
5. If you pressed the same number too much, the project will repeat the command.
   1. "2#"      -> A
   2. "22#"     -> B
   3. "222#"    -> C
   4. "2222#"   -> A
   5. "22222#"  -> B
   6. "222222#" -> C

# Example
1. "2#" -> A
2. "33#" -> E
3. "444#" -> I
4. "7777#" -> S
5. "4433555 555666#" -> HELLO
6. "4433555 5550666#" -> HELL O
7. "4433555 555*666#" -> HELO
