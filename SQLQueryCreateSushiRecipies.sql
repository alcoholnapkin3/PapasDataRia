CREATE TABLE SushiRecipies (
	id char(2) primary key,
	name nvarchar(30) unique not null,
	rice char(2) not null references SushiRices(id),
	wrap char(2) not null references SushiWraps(id),
	flipped bit,

	filling_1st char(2) not null references SushiFillings(id),
	filling_2nd char(2) references SushiFillings(id),
	filling_3rd char(2) references SushiFillings(id),

	topping char(2) references SushiToppings(id),
	shaker char(2) references SushiShakers(id),
	sauce char(2) references SushiSauce(id)
	)

INSERT INTO SushiRecipies values
	('T1', 'Test recipie 1', 'WH', 'NO', 0, 'SA', 'CU', NULL, 'MA', NULL, 'DU'),
	('T2', 'Test recipie 2', 'BR', 'NO', 1, 'CR', 'CU', 'CA', NULL, 'SE', 'TS'),
	('T3', 'Test recipie 3', 'SH', 'US', 1, 'CA', 'SA', NULL, 'SA', NULL, NULL),
	('T4', 'Test recipie 4', 'BL', 'MS', 0, 'SA', NULL, NULL, 'KI', 'TO', 'TE');


