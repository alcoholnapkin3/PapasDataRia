CREATE TABLE DonutDoughs (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);
	
INSERT INTO DonutDoughs values
	('CH', 'Chocolate Cake'),
	('RE', 'Regular Dough'),
	('PU', 'Pumpkin Cake'),
	('RV', 'Red Velvet Cake');

CREATE TABLE DonutShapes (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);
	
INSERT INTO DonutShapes values
	('RI', 'Ring Shape'),
	('RO', 'Round Shape'),
	('LJ', 'Long John Shape'),
	('FC', 'French Cruller Shape');

CREATE TABLE DonutFillings (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);
		
INSERT INTO DonutFillings values
	('BO', 'Boston Cream'),
	('ST', 'Strawberry Jelly'),
	('CH', 'Chocolate Mousse'),
	('BL', 'Blueberry Custard');

CREATE TABLE DonutIcingsAndPowders (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);
	
INSERT INTO DonutIcingsAndPowders values
	('CH', 'Chocolate Icing'),
	('ST', 'Strawberry Icing'),
	('VA', 'Vanilla Icing'),
	('SU', 'Powdered Sugar');

CREATE TABLE DonutSprinklesAndDrizzles (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);
	
INSERT INTO DonutSprinklesAndDrizzles values
	('CH', 'Chocolate Chips'),
	('RA', 'Rainbow Sprinkles'),
	('CA', 'Caramel Drizzle'),
	('BA', 'Banana Drizzle')

/* далее - факторы, не связанные с рецептом
*/

/* *их нет для пончиков
*/
