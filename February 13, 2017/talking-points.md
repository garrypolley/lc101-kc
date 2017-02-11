# Talking points

## Beofre Class

* Plugin back TV
* Start Youtube live

## Start of Class

* You'll be given some time in class to work on your current assignments
* Class may start late on March 2nd -- not sure to announce this or not, we shall see
* Mention doing the preference for Unit 3 -- C# or JavaScript

## Lecture

* Cover stuff form TF groups
* Mention we have a lot of code to cover tonight
* _FOLLOW_ along with what I am doing as best you can -- there is no studio
* Cover authenticated vs non-authenticated routes
  * Create that route list
* Mention that we know we are going to have people login, so we should create a User model
* Show `password` on the user model and explain why that's terrible
* Use `pw_hash` on the user model for reals
* Go over the hashutils file -- hand code this, it'll be a lot of work
  * show it working in the terminal
* Setup cookies at first -- `set_secure_cookie` `get_secure_cookie`
* Then setup the `login_user` `logout_user` -- don't create the routes yet, just set the cookie and show it happening
  * Make small edit to Index route to show it happening
* Create the register handler and route -- also the template for it.
  * Create template first, as usual
  * Go over parts that the `post` would then need to handle
* Create login
* Create logout
* Now add the initialize bit to the main controller/handler

## End of Class

* Be sure to do assignments
* Be sure to fill out your preferences
