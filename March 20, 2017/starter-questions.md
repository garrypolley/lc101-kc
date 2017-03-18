# Starter Questions

All questions can have more answers that what is listed here.

## OOP - Object Oriented Programming

* What is `inheritance`?
  * A sub type
  * The ability to take attributes/methods from a parent
  * Think about it like genetic inheritance, it's almost the same for the code
* How many levels of `inheritance` can you have in C#?
  * You can have as much as you want
  * For example: `Animal` -> `Human` -> `American` -> `Missourian` -> `Kansas City Person`
* What levels of access keep a subclass from using a parent class attribute or method?
  * A `private` modifier stops it from being used
  * `internal` has some cases where it would not be accessible from a sub class
    * If you subclass a third party
    * If you subclass outside of a namespace
* What levels of access allow a subclass to use the parent class attribute?
  * `protected` -- this is specifically to make something only accessible to a class and all its child classes
  * `public` -- Anyone can access, therefore subclasses too can access these
* What does `base` do in a subclass constructor?
  * It allows the code to use the super class constructor
  * It allows the sub class constructor to inherit the behavior of the super class constructor
* What does the `virtual` key word do?
  * Sound cool at parties when you use it
  * It allows subclasses to override a method from a parent class
  * For example, this is why we can override the `ToString` method
* What does `base` do for subclass in general?
  * Provides a way to access parent class methods
  * Provides a way to access parent class attributes
  * In general this is how we access specific parts of a parent classes implementation directly
* What does `abstract` do to a class?
  * Makes it so you can't create one directly, think of the `Cat` base example
  * Makes it so you can have shared logic, that requires a subclass to use
  * A lot of the internals of C# use this feature to share code, collections are a good example
* What is `polymorphism`?
  * A fancy word that we'll learn more about later.  :-p
  * For real though, it is a fancy word that simply means, the computer can determine which method to call on an object (Think of the `Cat` and `HouseCat` examples)
* Class diagrams....
  * Used mostly to have a common language when talking about classes and what they have in them
  * Garry has never written one outside of college courses
  * Garry has written hundreds and hundreds of classes... conclusion, class diagrams are not used all that much anymore unless you are building something very complex like C# itself
  * However, it is useful for getting used to classes and how they relate. The terminology used in the diagrams is often used to describe classes when you talk with coworkers

## General
