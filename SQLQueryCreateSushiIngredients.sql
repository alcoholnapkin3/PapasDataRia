CREATE TABLE SushiRices (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);

INSERT INTO SushiRices values
	('BR', 'Brown Rice'),
	('WH', 'White Rice'),
	('SH', 'Shiso Rice'),
	('BL', 'Black Rice');

CREATE TABLE SushiWraps (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);

INSERT INTO SushiWraps values
	('NO', 'Nori'),
	('MS', 'Momoiro Soy Paper'),
	('US', 'Ukoniro Soy Paper');

CREATE TABLE SushiFillings (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);

INSERT INTO SushiFillings values
	('CA', 'Carrot'),
	('SA', 'Salmon'),
	('CU', 'Cucumber Slices'),
	('CR', 'Crab Stick');

CREATE TABLE SushiToppings (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);

INSERT INTO SushiToppings values
	('TU', 'Tuna'),
	('SA', 'Salmon'),
	('MA', 'Mango Slices'),
	('KI', 'Kiwi Slices');

CREATE TABLE SushiShakers (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);

INSERT INTO SushiShakers values
	('TO', 'Tobiko'),
	('BO', 'Bonito Flakes'),
	('SE', 'Sesame Seeds'),
	('TE', 'Tempura Crunch');

CREATE TABLE SushiSauce (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);

INSERT INTO SushiSauce values
	('DU', 'Duck Sauce'),
	('TS', 'General Tso Sauce'),
	('TE', 'Teriyaki Sauce'),
	('WA', 'Wasabi Mayo');

/* далее - факторы, не связанные с рецептом
*/

CREATE TABLE TeaFlavors (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);

INSERT INTO TeaFlavors values
	('AL', 'Almond Tea'),
	('CH', 'Chai Tea'),
	('MA', 'Matcha Tea'),
	('MO', 'Mocha Tea');

CREATE TABLE TeaBubbles (
	id char(2) primary key,
	name nvarchar(30) unique not null
	);

INSERT INTO TeaBubbles values
	('CU', 'Cucumber Bubbles'),
	('LY', 'Lychee Bubbles'),
	('MA', 'Mango Bubbles'),
	('TA', 'Tapioca Pearls');
