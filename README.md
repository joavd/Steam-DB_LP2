# Steam Database from CSV file

Project made for LP2 class using Windows Forms (*C#*). It reads a .csv file that
contains data from games available on Steam (`games.csv`).

## Who did this project?

* [__Alejandro Urcera__](https://github.com/aurceramartins)
  * a21703818

* [__João Duarte__](https://github.com/JoaoAlexandreDuarte)
  * a21702097

## Git repository

We worked in a private repository that will be available publicly in this
[link](https://github.com/JoaoAlexandreDuarte/Steam-DB_LP2) after the deadline.

## Task distribution

Both persons contributed to the project equally, sharing tasks and doing pair
programming, but below, there's a summary of eachs contributions:

* __Alejandro Urcera__
  * Code;
  * Program Tests;
  * Diagram and Fluxogram;
  * Report;
  * Commentary and Documentation;

* __João Duarte__
  * Code;
  * Program Tests;
  * Report;
  * Commentary and Documentation;
  * Sandcastle Documentation;

## Our solution

### Architecture

The program was made with Windows Forms for a more appealing way to show data
and interact with it. It was made using the most recent topics taught in LP2,
such as Patterns, I/O, Lambda Expressions and *LINQ*, as well as all the
previous things we learned so far.

At launch, the program shows a dialog that asks for the file we want to read,
validating it and passing it to the main form.

On loading the main form, it parses all the data from the file, by reading every
line and creating a `Game` object, which gets saved to an `ICollection<Game>`,
more specifically an `HashSet<Game>` that serves as our "database", and is
displayed fully to the user. We chose an `HashSet<>` together with with
`structs` to prevent duplicate games getting into the *database*;

Then we can filter the *database* using *LINQ*, getting games that match our
criteria or see more detailed info about a specific game we wish.

### UML Diagram

<p align="center">
  <img src="UML.jpg" alt="UML Diagram"/>
</p>

### Fluxogram

<p align="center">
  <img src="Fluxogram.jpg" alt="Fluxogram"/>
</p>

## Conclusions

With this project we consolidated the medium/advanced C# concepts that were
taught in class by using them in a "real" program. We also learned to use
Windows Forms in order to make an application that could be used more directly
and with a better design than the console/command line.

## References

* Whitaker, R. B. (2016). **The C# Player's Guide**
    (3rd Edition). Starbound Software.
* Albahari, J. (2017). **C# 7.0 in a Nutshell**.
    O’Reilly Media.
* Kelly, C. (2016). **Steam Game Data**. Retrieved
    from <https://data.world/craigkelly/steam-game-data>.
* Freeman, E., Robson, E., Bates, B., & Sierra, K.
    (2004). **Head First Design Patterns**. O'Reilly Media.
* Dorsey, T. (2017). **Doing Visual Studio and .NET
    Code Documentation Right**. Visual Studio Magazine. Retrieved from
    <https://visualstudiomagazine.com/articles/2017/02/21/vs-dotnet-code-documentation-tools-roundup.aspx>.
