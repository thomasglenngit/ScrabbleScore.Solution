<h1 align='center'><img width='900' height='450' src='https://upload.wikimedia.org/wikipedia/commons/thumb/6/66/Scrabble_2015.jpg/1200px-Scrabble_2015.jpg'><br>


**<h1 align = 'center'>Scrabble Score**


*<h2 align ='center'>C#/.NET Project for [Epicodus](https://www.epicodus.com/), 2020.07.16.*


## Description
Console application that takes a word and returns the Scrabble score for that word.

| Letter                       | Score |
|------------------------------|-------|
| A, E, I, O, U, L, N, R, S, T |   1   |
| D, G                         |   2   |
| B, C, M, P                   |   3   |
| F, H, V, W, Y                |   4   |
| K                            |   5   |
| J, X                         |   8   |
| Q, Z                         |   10  |


## Specifications
| Spec | Input | Output | Test Result
|:------------|:-----------|:----------------|:-------------|
| The program will accept a string from the user | "Bear" | no output | Passed |
| The program will split the string | "Bear" | "B - e - a - r" | Unnecessary |
| The program will evaluate each letter against a key | "B" | "B : 3" | Passed |
| The program will assign a value to each letter | B E A R | 3 1 1 1 | Passed |
| The program will add the numbers for that word | 3+1+1+1 | 6 | Passed |
| The program will return the score for the word | Bear | 6 points | Passed |



## Known Bugs
* No known bugs.   

## Setup/Installation Requirements
#### View Online
Visit the GitHub Pages by clicking on the following link or by typing it in your web browser <url>

#### View locally

*[.NET Core](https://dotnet.microsoft.com/download/dotnet-core/2.2) is needed to run this application*

To clone this repository from your command line you will need [Git](https://git-scm.com/) installed. 

First navigate in the command line to where you want to clone this repository. 

Then from your command line run:

`$ git clone https://github.com/sarakane/ScrabbleScore.Solution`

Once the repository has been cloned, navigate to the to the application directory and run `$ dotnet build`.

#### Run locally
* To run the program run `$ dotnet run` 

### Edit
* To view and edit the code, open the application in your preferred code editor, such as Visual Studio Code.

## Technologies Used
* Visual Studio Code (code editor)
* C#/.NET

# **❤️Contributors**

[<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/sara-kane.jpeg' width='160px;'/><br /><sub><b>Sara Kane</b></sub>](https://www.linkedin.com/in/sarakaneportland/)<br />

[<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/thomas-glenn.jpeg' width='160px;'/><br /><sub><b>Thomas Glenn</b></sub>](https://www.linkedin.com/in/glennergy/)<br />

<br>

<br>

![alt text][logo]

[logo]: https://img.shields.io/bower/l/bootstrap 'MIT License' Copyright (c) 2020 Sara Kane, Thomas Glenn.
