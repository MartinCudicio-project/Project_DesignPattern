Monopoly_game Project Design Pattern
Jean-Louis Delebecque
Martin Cudicio

Pull master.
If you have problems the Monopoly_game.csproj it is sometimes filled with lines maybe because of git, you have to remove them if there is a problem from this file. thank you for your understanding.

We have realized almost all the features of the real monopoly (all types of boxes except community and luck which have effects that do not vary like the real cards), all the possibilities of double to dice throws, the pressure, the houses on the properties. A console display of the tray and submenus integrated in the controls.

The course of the game:

The game starts, the board is created in hard initialization (enter by hand, no need to make a factory at this stage of the game).
Then we create the players. And each turn we launch a command and then according to the type of boxes we create the right type of command.
We create the invokeur who will execute the commands.

Particularity:
- DiceCommand implements the player's index finger directly on the board.
- A command type table has been added in the hand, it could have been replaced by a variable in each BOX (box)


Our design patterns are:

1)singleton for the game class because it is necessarily unique.
For this reason we created an instance in the class and put the constructor in private. As a result, you can only access the instance through these properties and you cannot create a second one. 

2)Factory:
We thought about it for the different boxes, but it's only at the initialization of the game, and then for a better implementation of the design pattern command we decided to create a factory for commands and invokers.
This factory is very useful in the course of the game to be structured and save lines, moreover thanks to the factory an invoker can execute all subtypes of commands and interwidth according to the types of boxes.

3)Command pattern: each action is represented by an object, applies to a receiver (often a player or a square) and is invoked by an invoker.
You will see the Dice class which is a good representation of the command pattern, resulting from the command interface with 3 sub-functions -> to launch dice, events, prison. Only one invoker can execute any of these commands.
I let the dice commanders be isolated from the others to get a model and because they are not called at the same time.
There are therefore the invoke and commands for the dice (Comamand Interface)
And invoke them and the commands for the boxes (BoXCommand) created by a factory


4)MVC : In our case, the (view) is therefore the Menu, and the broard_view function
            the (model) is our list of Boxes
            the (controller) is composed by BoxInvoker BoxCommand, etc...

Conclusion:

We use creationnal pattern factory to manage and avoid repetition on command creation.
Singleton for security.
Command pattern to have a more understable structure, to easily create other function and to epure code in the main.
Finally MVC allow us to separate view from the rest to reduce confusion.
