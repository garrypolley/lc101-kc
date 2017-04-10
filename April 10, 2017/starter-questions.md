# Starter Questions

All questions can have more answers that what is listed here.

## Database/ORM

* What was the foreign key in the Cheese table?
  * The category, Specifically CategoryId
* What types of relationships have we learned about thus far?
  * Single (no relationship to other objects)
  * One-to-Many (e.g. one object o many of another, many cheeses to one category)
  * Many-to-Many (e.g. many objects related to many other back and forth, many cheese to many menus)
* Many-to-Many what exactly does it mean?
  * It requires 3 tables (one for each object, and one to combine the two objects together in many ways)
  * It allows us to have as many relationships as we want (e.g. cheddar cheese belongs to 6 menus, and those menus all ove other cheeses)

## Code Specific

* How do we go about setting up the many-to-many relationship?
  * We create three models
  * We link them inside a special method in our `dbContext` class
* What do we need to do each time we change our models?
  * Update our migrations
  * Specifically `dotnet ef migrations add MyNewOne`
  * Then `dotnet ef database update`
* What is used to determine if data that is sent via POST is correct?
  * `ModelState.IsValid` -- handle built-in that tells you if your action has valid data

## General
