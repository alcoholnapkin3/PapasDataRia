CREATE TABLE RegularCustomers (
	customer_name varchar(20) constraint customer_name_is_pkey primary key,
	fav_pizza_recipie char(2) references PizzaRecipies(pizza_id),
	fav_pizza_bake char(2) references PizzaBakes(pizza_bake_id), 
	fav_pizza_cut char(2) references PizzaCuts(pizza_cut_id), 
	fav_sushi_recipie char(2), 
	/*внешний ключ*/
	fav_bubbletea_flavor char(2), 
	/*внешний ключ*/
	fav_bubbletea_bubbles char(2), 
	/*внешний ключ*/
	fav_donuts_recipie char(2), 
	/*внешний ключ*/
	fav_sandwich_recipie char(2), 
	/*внешний ключ*/
	fav_slush_size char(2), 
	/*внешний ключ*/
	fav_slush_bottom_flavor char(2), 
	/*внешний ключ*/
	fav_slush_top_flavor char(2)
	/*внешний ключ*/
	)
	



