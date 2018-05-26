# BikeRentApp
Rent a bike challenge on .net platform

the class diagram is on the project root.(png format)

### Design 

I implement three interfaces. One of them to Separate the logic of cost based on each type of rent (IRentCostStrategy).
The other interfaces to set responsibility to create and identify each of type of family. (IRentType, IRentTypeFamily)

all rent types has customer associate.

all rent types has bikes associate.

The set of classes has the minimal logic and the properties to generate the automated test.

The rent by hour, day and week obey to the same interface, while de promotion for family rental is separate, allowing adding more than one item (array of bikes in this case)

### Test Unit

The TestProject2 contains the test methods that cover the ninety one percent of code.
To display the coverage report open de index.html file of Coverga.Report folder.

I run the automated test using dotcover plugin for visual studio 2010.
(http://www.jetbrains.com/dotcover/?fromProduct)

#### Platform
-Visual studio 2010 over windows7 virtualized
-W7 sp1
-DotCover Unit Test Runner and Code Coverage Tool



















