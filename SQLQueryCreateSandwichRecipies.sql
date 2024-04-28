CREATE TABLE SandwichRecipies (
	id char(2) primary key,
	name nvarchar(30) unique not null,

	meat_or_alternative char(2) not null references SandwichMeatsAndAlternatives(id),
	batter_or_breading char(2) not null references SandwichBattersAndBreadings(id),
	
	extra_meat_or_alternative char(2) references SandwichMeatsAndAlternatives(id),
	extra_batter_or_breading char(2) references SandwichBattersAndBreadings(id),
	
	bun char(2) not null references SandwichBuns(id),

	topping_or_sauce_1st char(2) not null references SandwichToppingsAndSauces(id),
	topping_or_sauce_2nd char(2) not null references SandwichToppingsAndSauces(id),
	topping_or_sauce_3rd char(2) not null references SandwichToppingsAndSauces(id),
	topping_or_sauce_4th char(2) not null references SandwichToppingsAndSauces(id),
	topping_or_sauce_5th char(2) not null references SandwichToppingsAndSauces(id),
	topping_or_sauce_6th char(2) references SandwichToppingsAndSauces(id)
	);

INSERT INTO SandwichRecipies values
/*   id    name              meat  batr  extra extra bun   top1  top2  top3  top4  top5  top6  */
	('T1', 'Test Recipie 1', 'CH', 'SP', NULL, NULL, 'MU', 'P',  'BQ', 'PI', 'TO', 'ON', NULL);

INSERT INTO SandwichRecipies values
	('T2', 'Test Recipie 2', 'VE', 'PR', NULL, NULL, 'KO', 'PI', 'P',  'HM', 'ON', 'TO', 'BA');

INSERT INTO SandwichRecipies values
	('T3', 'Test Recipie 3', 'PO', 'BE', NULL, NULL, 'CL', 'MA', 'P',  'BA', 'P',  'TO', 'P' );

INSERT INTO SandwichRecipies values
	('T4', 'Test Recipie 4', 'FI', 'PO', 'CH', 'PO', 'SE', 'P',  'MA', 'ON', 'EP', 'HM', NULL)
