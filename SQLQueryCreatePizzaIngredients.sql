CREATE TABLE PizzaCrusts (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);

INSERT INTO PizzaCrusts values
	('CR', 'Crispy Crust'),
	('TR', 'Traditional Crust'),
	('TH', 'Thick Crust'),
	('GK', 'Garlic Knot Crust');

CREATE TABLE PizzaSauces (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);

INSERT INTO PizzaSauces values
	('MA', 'Classic Marinara'),
	('RR', 'Rustic Romana'),
	('CG', 'Creamy Garlic Sauce'),
	('BF', 'Buffalo Sauce');

CREATE TABLE PizzaCheeses (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);

INSERT INTO PizzaCheeses values
	('PB', 'Papa''s Cheese Blend'),
	('PV', 'Provolone Cheese'),
	('SC', 'Smoked Cheddar Cheese'),
	('GP', 'Grated Parmesan Cheese');

CREATE TABLE PizzaToppings (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);

INSERT INTO PizzaToppings values
	('MU', 'Mushrooms'),
	('ON', 'Onions'),
	('PE', 'Pepperoni'),
	('SA', 'Sausage');

CREATE TABLE PizzaLocations (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);

INSERT INTO PizzaLocations values
	('AO', 'All Over'),

	('T', 'Top Half'),
	('B', 'Bottom Half'),
	('L', 'Left Half'),
	('R', 'Right Half'),

	('TR', 'Top Right Corner'),
	('TL', 'Top Left Corner'),
	('BR', 'Bottom Right Cornet'),
	('BL', 'Bottom Left Cornet'),

	('LT', 'Left and Top 3/4''s'),
	('LB', 'Left and Bottom 3/4''s'),
	('RT', 'Right and Top 3/4''s'),
	('RB', 'Right and Bottom 3/4''s');



/* далее - факторы, не связанные с рецептом
*/

CREATE TABLE PizzaBakes (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);

INSERT INTO PizzaBakes values
	('L', 'Light-Bake'),
	('R', 'Regular cooking'),
	('WD', 'Well-Done');

CREATE TABLE PizzaCuts (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);

INSERT INTO PizzaCuts values
	('4', '4 Sclices Cut'),
	('6', '6 Slices Cut'),
	('8', '8 Slices Cut'),
	('SQ', 'Cut In Squares');