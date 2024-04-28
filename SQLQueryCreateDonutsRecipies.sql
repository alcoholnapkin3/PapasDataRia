CREATE TABLE DonutsRecipies (
	id char(2) primary key,
	name nvarchar(30) unique not null,
	/* три пончика в порции, далее: тесто для первого, второго и третьего пончика соответственно */
	dough_1st char(2) not null references DonutDoughs(id),
	dough_2ns char(2) not null references DonutDoughs(id),
	dough_3rd char(2) not null references DonutDoughs(id),
	/* аналогично */
	shape_1st char(2) not null references DonutShapes(id),
	shape_2nd char(2) not null references DonutShapes(id),
	shape_3rd char(2) not null references DonutShapes(id),

	filling_1st char(2) references DonutFillings(id),
	filling_2nd char(2) references DonutFillings(id),
	filling_3rd char(2) references DonutFillings(id),

	icing_or_powder_1st char(2) not null references DonutIcingsAndPowders(id),
	icing_or_powder_2nd char(2) not null references DonutIcingsAndPowders(id),
	icing_or_powder_3rd char(2) not null references DonutIcingsAndPowders(id),

	sprinkle_or_drizzle_1st char(2) not null references DonutSprinklesAndDrizzles(id),
	sprinkle_or_drizzle_2nd char(2) not null references DonutSprinklesAndDrizzles(id),
	sprinkle_or_drizzle_3rd char(2) not null references DonutSprinklesAndDrizzles(id),

	extra_sprinkle_or_drizzle_1st char(2) references DonutSprinklesAndDrizzles(id),
	extra_sprinkle_or_drizzle_2nd char(2) references DonutSprinklesAndDrizzles(id),
	extra_sprinkle_or_drizzle_3rd char(2) references DonutSprinklesAndDrizzles(id)
	)

INSERT INTO DonutsRecipies values
/*   id    name              dough dough dough shape shape shape fill  fill  fill  icing icing icing drizz drizz drizz extra extra extra */
	('T1', 'Test Recipie 1', 'RE', 'RE', 'PU', 'RI', 'RO', 'RI', NULL, NULL, NULL, 'CH', 'VA', 'SU', 'CA', 'BA', 'CH', 'RA', NULL, NULL),
	('T2', 'Test Recipie 2', 'RE', 'CH', 'CH', 'RO', 'RO', 'RI', 'CH', 'ST', 'CH', 'SU', 'CH', 'ST', 'CA', 'RA', 'BA', 'CH', NULL, NULL),
	('T3', 'Test Recipie 3', 'RE', 'PU', 'RE', 'RI', 'RO', 'FC', NULL, 'BO', 'ST', 'CH', 'SU', 'ST', 'BA', 'CH', 'RA', 'RA', NULL, NULL),
	('T4', 'Test Recipie 4', 'RE', 'RE', 'CH', 'LJ', 'LJ', 'RI', 'BO', 'CH', NULL, 'CH', 'CH', 'SU', 'RA', 'CA', 'CH', NULL, 'CH', NULL)
