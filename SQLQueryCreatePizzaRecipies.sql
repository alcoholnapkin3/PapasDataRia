CREATE TABLE PizzaRecipies (
	id char(2) primary key,
	name nvarchar(30) unique not null,
	crust char(2) not null references PizzaCrusts(id),
	sauce char(2) not null references PizzaSauces(id),
	cheese char(2) not null references PizzaCheeses(id),
	topping_1st char(2 ) not null references PizzaToppings(id),
	ammount_1st tinyint not null,
	location_1st char(2) not null references PizzaLocations(id),
	topping_2nd char(2) references PizzaToppings(id),
	ammount_2nd tinyint,
	location_2nd char(2) references PizzaLocations(id),
	topping_3rd char(2) references PizzaToppings(id),
	ammount_3rd tinyint,
	location_3rd char(2) references PizzaLocations(id),
	topping_4th char(2) references PizzaToppings(id),
	ammount_4th tinyint,
	location_4th char(2) references PizzaLocations(id)
	);

INSERT INTO PizzaRecipies (id, name, crust, sauce, cheese, topping_1st, ammount_1st, location_1st, topping_2nd, ammount_2nd, location_2nd) values
	('T1', 'Test recipie 1', 'TR', 'CG', 'PB', 'SA', 4, 'R',  'PE', 4, 'L');
INSERT INTO PizzaRecipies (id, name, crust, sauce, cheese, topping_1st, ammount_1st, location_1st, topping_2nd, ammount_2nd, location_2nd, topping_3rd, ammount_3rd, location_3rd) values
	('T2', 'Test recipie 2', 'GK', 'MA', 'PV', 'PE', 8, 'AO', 'ON', 4, 'T', 'MU', 4, 'AO');
INSERT INTO PizzaRecipies (id, name, crust, sauce, cheese, topping_1st, ammount_1st, location_1st, topping_2nd, ammount_2nd, location_2nd, topping_3rd, ammount_3rd, location_3rd, topping_4th, ammount_4th, location_4th) values
	('T3', 'Test recipie 3', 'TH', 'BF', 'SC', 'MU', 6, 'LB', 'PE', 6, 'L', 'ON', 3, 'TR', 'SA', 8, 'AO');
INSERT INTO PizzaRecipies (id, name, crust, sauce, cheese, topping_1st, ammount_1st, location_1st) values
	('T4', 'Test recipie 4', 'CR', 'RR', 'GP', 'ON', 6, 'T');