CREATE TABLE PizzaCrusts (
	pizza_crust_id char(2) constraint pizza_crust_id_is_pkey primary key,
	pizza_crust_name nvarchar(30) constraint pizza_crust_name_is_unique unique
	/*experiment*/
	);

CREATE TABLE PizzaSauses (
	pizza_sauce_id char(2) constraint pizza_sauce_id_is_pkey primary key,
	pizza_sauce_name nvarchar(30) constraint pizza_sauce_name_is_unique unique
	);

CREATE TABLE PizzaCheeses (
	pizza_cheese_id char(2) constraint pizza_cheese_id_is_pkey primary key,
	pizza_cheese_name nvarchar(30) constraint pizza_cheese_name_is_unique unique
	);

CREATE TABLE PizzaToppings (
	pizza_topping_id char(2) constraint pizza_topping_id_is_pkey primary key,
	pizza_topping_name nvarchar(30) constraint pizza_topping_name_is_unique unique
	);

CREATE TABLE PizzaLocations (
	pizza_location_id char(2) constraint pizza_location_id_is_pkey primary key,
	pizza_location_name nvarchar(30) constraint pizza_location_name_is_unique unique
	);

/* далее - факторы, не связанные с рецептом
*/


CREATE TABLE PizzaBakes (
	pizza_bake_id char(2) constraint pizza_bake_id_is_pkey primary key,
	pizza_bake_name nvarchar(30) constraint pizza_bake_name_is_unique unique
	);

CREATE TABLE PizzaCuts (
	pizza_cut_id char(2) constraint pizza_cut_id_is_pkey primary key,
	pizza_cut_name nvarchar(30) constraint pizza_cut_name_is_unique unique
	);
