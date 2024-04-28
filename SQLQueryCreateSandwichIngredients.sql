CREATE TABLE SandwichMeatsAndAlternatives (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);

INSERT INTO SandwichMeatsAndAlternatives values
	('CH', 'Chicken Patty'),
	('VE', 'Veggie Patty'),
	('FI', 'Fish Fillet'),
	('PO', 'Pork Chop');

CREATE TABLE SandwichBattersAndBreadings (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);
	
INSERT INTO SandwichBattersAndBreadings values
	('BE', 'Beer Batter'),
	('PO', 'Papa''s Original Breading'),
	('SP', 'Spicy Cajun Batter'),
	('PR', 'Pretzel Crust Breading');

CREATE TABLE SandwichBuns (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);
	
INSERT INTO SandwichBuns values
	('CL', 'Classic Bun'),
	('SE', 'Sesame Bun'),
	('MU', 'Multigrain Bun'),
	('KO', 'Kaiser Onion Roll');

CREATE TABLE SandwichToppingsAndSauces (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);

INSERT INTO SandwichToppingsAndSauces values
	('P', 'Patty'),
	('EP', 'Extra Patty'),

	('BA', 'Bacon'),
	('ON', 'Onion'),
	('PI', 'Pickles'),
	('TO', 'Tomato'),
	
	('BQ', 'BBQ Sauce'),
	('HM', 'Honey Mustard Sauce'),
	('MA', 'Marinara Sauce'),
	('MO', 'Mayo');


/* далее - факторы, не связанные с рецептом
*/

CREATE TABLE SlushSizes (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);
	
INSERT INTO SlushSizes values
	('S', 'Small Cup'),
	('M', 'Medium Cup'),
	('L', 'Large Cup');


CREATE TABLE SlushFlavors (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);
	
INSERT INTO SlushFlavors values
	('BR', 'Blue Raspberry Slush'),
	('WA', 'Watermelon Slush'),
	('PI', 'Pineapple Slush'),
	('BU', 'Bubblegum Slush');
