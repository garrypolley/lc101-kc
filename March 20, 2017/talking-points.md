# Talking points

## Before Class

* Start Youtube live

## Start of Class

* Entire class, we will be moving spaces in April -- We will give you as much notice as we can on location, time will be the same
* Mention assignment due Thursday for TechJobs MVC
* Tom is your instructor for Next Monday

## Lecture

* Cover stuff form TF groups
* Talk about `Object` and show the source code: https://github.com/dotnet`/corert/blob/master/src/System.Private.CoreLib/src/System/Object.cs#L81-L115
* Go over the view-override first
  * Show the overriding of the `View` method
  * Show how it's set in all the other methods
  * Show how the Razor Templates look
* Show what the program does
  * We create a Restaurant
  * We then make a menu
  * Add items to the menu -- Generator doesn't doo that much, show it if there is time
  * Print out the menu
* Talk about the relationship of our entities
  * Restaurant had a Menu
  * Menu has many MenuItems
  * All of them "is a" `BaseClass`
* Go over the `BaseClass` class
* Show that it has the `Updated`, `Created`, and `Id` built in
  * Note how it uses a `Guid`
  * Bring up the `UTC` that is used, and why it is enforced
  * Mention `Identity` is mostly for debugging and knowing the internals of our Objects
  * Cover `UpdateMade` later, when we are doing stuff with our objects
* Start on Restaurant Class
  * Subclasses `BaseClass`
  * Show the attributes/methods/properties
  * Show how it uses the `UpdateMade`
  * Show them a Stackoverflow exception
  * Show the constructors
  * Show add Menu
  * Mention the remove menus -- they are not used right now
  * Show the `ToString` and what it's doing
* Go over the `Menu` class, it's small
  * Note how `ToString` is fairly complex, we'll talk about this _after_ we cover `MenuItem`
* Go over the `MenuItem` class
  * Note the static `Categories` and `Types` -- this ensures we have valid data, in real life we would use Enumeration types, if they want to google that
  * Didn't do the `UpdateMade` because I wanted to avoid code clutter
  * Talk about access modifiers
  * Note the requirements on `Type` and `Category`
* Go back to `Menu.ToString` and now cover the formatting

## End of Class
