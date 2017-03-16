# Restaurant planning

A file for planning our restaurant and related classes.

See studio for details: http://education.launchcode.org/skills-back-end-csharp/studios/restaurant-menu/

## Objects

### Restaurant

* Name -- `string`
* Address -- `string`
* Phone -- `int`
* Description -- `string`
* History -- `string`
* CreatedDate -- `DateTime`
* UpdatedDate -- `DateTime`

### Menu

* `Restaurant` - `Restaurant`
* `Items` -- `List<MenuItems>`
* Legend -- `Dictionary<string, string>`
* CreatedDate -- `DateTime`
* UpdatedDate -- `DateTime`

### Menu Items

* price -- `decimal`/`double`
* description -- `string`
* category -- `string`  (e.g. appetizer, main course, or dessert)
* type -- `string`
* status -- `string`
* legendKeys -- `List<string>`
* CreatedDate -- `DateTime`
* UpdatedDate -- `DateTime`

