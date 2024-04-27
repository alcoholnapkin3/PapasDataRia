CREATE TABLE PizzaRecipies (
	pizza_id char(2) constraint pizza_id_is_pkey primary key,
	pizza_name nvarchar(30) constraint pizza_name_is_unique unique,
	pizza_crust char(2) constraint pizza_crust_not_null not null references PizzaCrusts(pizza_crust_id),
	pizza_sauce char(2) constraint pizza_sauce_not_null not null references PizzaSauses(pizza_sauce_id),
	pizza_cheese char(2) constraint pizza_cheese_not_null not null references PizzaCheeses(pizza_cheese_id),
	pizza_1st_topping char(2) constraint pizza_topping_not_null not null references PizzaToppings(pizza_topping_id),
	pizza_1st_ammount tinyint constraint pizza_ammount_not_null not null,
	pizza_1st_location char(2) constraint pizza_location_not_null not null references PizzaLocations(pizza_location_id),
	pizza_2nd_topping char(2) references PizzaToppings(pizza_topping_id),
	pizza_2nd_ammount tinyint,
	pizza_2nd_location char(2) references PizzaLocations(pizza_location_id),
	pizza_3rd_topping char(2) references PizzaToppings(pizza_topping_id),
	pizza_3rd_ammount tinyint,
	pizza_3rd_location char(2) references PizzaLocations(pizza_location_id),
	pizza_4th_topping char(2) references PizzaToppings(pizza_topping_id),
	pizza_4th_ammount tinyint,
	pizza_4th_location char(2) references PizzaLocations(pizza_location_id)
	)