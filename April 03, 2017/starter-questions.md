# Starter Questions

All questions can have more answers that what is listed here.

## CSharp

* What is an interface?
  * A way to have code implement common methods
  * A way to share behavior without forcing a specific class
  * A "blueprint" of how code should work
  * Cannot have any implementation
* What is an example of an interface you have used?
  * IComparer -- for comparing things
  * IEnumerable -- it's how we are able to use `foreach`
* How many interfaces can a class implement?
  * As many as it wants
* How many classes can a class implement from directly?
  * One, and only one direct super class is allowed
  * You can have a "chain" of classes, but only a chain, as in a -> b -> c -> d (etc.)
* Why use an interface?
  * It makes it easier to write reusable code
  * It removes hard constraints on class implementation
  * It allows for specifying common behavior that spans more than one type of class. (for example, eating, iterating, comparing)
* An example of an area where interfaces help are with Databases -- having a common interface makes it easier to build multiple backend classes that can connect and do work in many databases.  This is how ORMs work, and why they are so good at abstracting away the database logic.


## General

* Overall Interfaces can used as a way to achieve what's called "composition over inheritance" -- this is the idea that favoring common behavior (via interfaces) that can be "mixed" in over the direct implementation forced by parent classes
