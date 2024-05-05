




CREATE TABLE RegularCustomers (
	customer_name varchar(20) primary key,
	fav_pizza_recipie char(2) references PizzaRecipies(id),
	fav_pizza_bake char(2) references PizzaBakes(id), 
	fav_pizza_cut char(2) references PizzaCuts(id), 
	fav_sushi_recipie char(2) references SushiRecipies(id),
	fav_bubbletea_flavor char(2) references TeaFlavors(id),
	fav_bubbletea_bubbles char(2) references TeaBubbles(id),
	fav_donuts_recipie char(2) references DonutsRecipies(id),
	fav_sandwich_recipie char(2) references SandwichRecipies(id),
	fav_slush_size char(2) references SlushSizes(id),
	fav_slush_bottom_flavor char(2) references SlushFlavors(id),
	fav_slush_top_flavor char(2) references SlushFlavors(id)
	);

INSERT INTO RegularCustomers values
/*   name   pizza bake  cut   sushi flavr bubbl donut sandw size bottm top  */
	('Joe', 'T1', 'R',  '4',  'T4', 'MO', 'LY', 'T2', 'T3', 'S', 'WA', 'PI' ),
	('Moe', 'T2', 'L',  '6',  'T3', 'AL', 'TA', 'T4', 'T1', 'M', 'BU', 'PI' ),
	('Doe', 'T3', 'R',  'SQ', 'T2', 'MA', 'CU', 'T1', 'T4', 'L', 'PI', 'WA' ),
	('Woe', 'T4', 'WD', '8',  'T1', 'CH', 'MA', 'T3', 'T2', 'M', 'BR', 'BR' )


	



