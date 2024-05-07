
INSERT INTO PizzaCrusts values
	('CR', 'Crispy Crust'),
	('TR', 'Traditional Crust'),
	('TH', 'Thick Crust'),
	('GK', 'Garlic Knot Crust');

INSERT INTO PizzaSauces values
	('MA', 'Classic Marinara'),
	('RR', 'Rustic Romana'),
	('CG', 'Creamy Garlic Sauce'),
	('BF', 'Buffalo Sauce'),
	('BQ', 'BBQ Sauce'),
	('OO', 'Olive Oil');

INSERT INTO PizzaCheeses values
	('PB', 'Papa''s Cheese Blend'),
	('PV', 'Provolone Cheese'),
	('SC', 'Smoked Cheddar Cheese'),
	('GP', 'Grated Parmesan Cheese');

INSERT INTO PizzaToppings values
	('AC', 'Asiago Cheese'),
	('AH', 'Artichoke hearts'),
	('AN', 'Anchovies'),
	('BA', 'Bacon Slices'),
	('BP', 'Banana Peppers'),
	('BO', 'Black Olives'),
	('BL', 'Basil Leaves'),
	('BR', 'Broccoli'),
	('CH', 'Chicken Strips'),
	('CA', 'Capicole'),
	('CS', 'Cajun Shrimp'),
	('GB', 'Ground Beef'),
	('GP', 'Green Peppers'),
	('GA', 'Fresh Garlic'),
	('GO', 'Gorgonzola Cheese'),
	('HA', 'Ham'),
	('JA', 'Jalapeños'),
	('MU', 'Mushrooms'),
	('ME', 'Meatballs'),
	('ON', 'Onions'),
	('PE', 'Pepperoni'),
	('PR', 'Prosciutto'),
	('PC', 'Pepperjack Cheese'),
	('PS', 'Philly Steak'),
	('PI', 'Pineapple'),
	('PP', 'Pulled Pork'),
	('PM', 'Portobello Mushrooms'),
	('PO', 'Pimento Olives'),
	('RP', 'Red Peppers'),
	('SA', 'Sausage'),
	('SP', 'Spinach Leaves'),
	('SL', 'Salami'),
	('SS', 'Smoked Salmon'),
	('TO', 'Tomato Slices');


INSERT INTO PizzaLocations values
	('AO', 'All Over'),

	('T', 'Top Half'),
	('B', 'Bottom Half'),
	('L', 'Left Half'),
	('R', 'Right Half'),

	('TR', 'Top Right Corner'),
	('TL', 'Top Left Corner'),
	('BR', 'Bottom Right Corner'),
	('BL', 'Bottom Left Corner'),

	('LT', 'Left and Top 3/4''s'),
	('LB', 'Left and Bottom 3/4''s'),
	('RT', 'Right and Top 3/4''s'),
	('RB', 'Right and Bottom 3/4''s');


/* далее - факторы, не связанные с рецептом
*/


INSERT INTO PizzaBakes values
	('L', 'Light-Bake'),
	('R', 'Regular cooking'),
	('WD', 'Well-Done');


INSERT INTO PizzaCuts values
	('4', '4 Sclices Cut'),
	('6', '6 Slices Cut'),
	('8', '8 Slices Cut'),
	('SQ', 'Cut In Squares');
	
	
INSERT INTO PizzaRecipies values
/*   id    name                     crust sauce chese tpng amm loc   tpng amm loc   tpng amm loc   tpng amm loc*/
	('BC', 'Bacon Cheeseburger', 	'TH', 'BQ', 'SC', 'GB', 8, 'AO', 'BA', 8, 'AO', NULL, 0, NULL, NULL, 0, NULL),
	('CA', 'Chicken Cacciatore',	'TR', 'MA', 'PV', 'MU', 8, 'AO', 'CH', 8, 'AO', 'GP', 8, 'AO', 'ON', 8, 'AO'),
	('CS', 'Chicken Caesar',		'CR', 'CG', 'GP', 'CH', 8, 'AO', 'SP', 8, 'AO', NULL, 0, NULL, NULL, 0, NULL),
	('CL', 'Chicken Club',			'TR', 'CG', 'PV', 'TO', 4, 'AO', 'CH', 8, 'AO', 'SP', 8, 'AO', 'BA', 4, 'AO'),
	('CQ', 'Creamy Quiche',			'TH', 'CG', 'SC', 'GO', 8, 'AO', 'BR', 6, 'L',  'TO', 6, 'R',  NULL, 0, NULL),
	('CF', 'The Californian',		'CR', 'BQ', 'PV', 'ON', 8, 'AO', 'CH', 8, 'AO', 'PI', 8, 'AO', NULL, 0, NULL),
	('FC', 'Buffalo Chicken',		'TR', 'BF', 'PV', 'GO', 4, 'AO', 'CH', 8, 'AO', NULL, 0, NULL, NULL, 0, NULL),
	('FG', 'Buffalo Grinder',		'TH', 'BF', 'PV', 'HA', 6, 'T',  'PR', 6, 'B',  'BA', 4, 'T',  'BP', 4, 'B' ),
	('FF', 'Fishy Fruit',			'TH', 'CG', 'PB', 'AN', 8, 'AO', 'PI', 6, 'T',  'PO', 6, 'B',  NULL, 0, NULL),
	('FJ', 'Fugazza Con Jamón',		'TR', 'OO', 'PV', 'ON', 8, 'AO', 'PR', 8, 'AO', NULL, 0, NULL, NULL, 0, NULL),
	('GF', 'Garlic Fury',			'GK', 'CG', 'SC', 'GA', 8, 'AO', 'PO', 6, 'B',  'AH', 6, 'T',  NULL, 0, NULL),
	('GG', 'Green Grove',			'TR', 'OO', 'PB', 'SP', 6, 'T',  'BL', 6, 'B',  'GP', 4, 'AO', 'BR', 8, 'AO'),
	('HA', 'Hawaiian',				'TH', 'MA', 'PV', 'PI', 6, 'T',  'HA', 6, 'B',  NULL, 0, NULL, NULL, 0, NULL),
	('4M', 'Level 4 Meltdown',		'GK', 'BF', 'SC', 'PC', 6, 'L',  'AC', 6, 'R',  'GO', 8, 'AO', NULL, 0, NULL),
	('LL', 'Lomi-Lomi Bruschetta',	'CR', 'OO', 'GP', 'SS', 6, 'T',  'TO', 3, 'BL', 'AH', 3, 'BR', 'ON', 4, 'AO'),
	('LF', 'Flamin'' Fungi',		'CR', 'BF', 'SC', 'PC', 6, 'T',  'BO', 6, 'B',  'MU', 8, 'AO', NULL, 0, NULL),
	('MA', 'Meat Amore',			'TR', 'MA', 'PV', 'PE', 8, 'AO', 'SA', 8, 'AO', 'GB', 8, 'AO', 'BA', 8, 'AO'),
	('ME', 'The Meateor',			'TR', 'BF', 'PB', 'GB', 6, 'L',  'PR', 6, 'R',  'HA', 4, 'AO', 'SA', 8, 'AO'),
	('MU', 'The Muffuletta',		'TH', 'OO', 'PV', 'SL', 8, 'AO', 'HA', 4, 'AO', 'BO', 6, 'L',  'PO', 6, 'R' ),
	('MR', 'Pizza Margherita',		'CR', 'RR', 'PV', 'TO', 8, 'AO', 'BL', 8, 'AO', NULL, 0, NULL, NULL, 0, NULL),
	('NE', 'Neptune''s Feast',		'GK', 'RR', 'PV', 'AN', 6, 'LB', 'SS', 6, 'RB', 'CS', 4, 'T',  NULL, 0, NULL),
	('OB', 'Olive Bellissimo',		'CR', 'CG', 'PB', 'BO', 8, 'AO', 'MU', 8, 'AO', 'SP', 8, 'AO', NULL, 0, NULL),
	('PB', 'Peppered Bacon',		'CR', 'MA', 'PB', 'BA', 8, 'AO', 'BP', 6, 'L',  'GP', 6, 'R',  NULL, 0, NULL),
	('PC', 'Philly Cheese Steak',	'CR', 'CG', 'PV', 'PS', 8, 'AO', 'GP', 6, 'T',  'MU', 6, 'B',  NULL, 0, NULL),
	('PR', 'Portallini Rustico',	'TR', 'RR', 'PV', 'AN', 3, 'TL', 'GA', 3, 'TR', 'CA', 4, 'B',  'ME', 4, 'AO'),
	('QS', 'Quattro Stagioni',		'GK', 'MA', 'PB', 'AH', 3, 'TL', 'PR', 4, 'TR', 'PM', 3, 'BR', 'BL', 4, 'BL'),
	('RQ', 'Romano Quartet Pizza',	'TH', 'RR', 'PB', 'GP', 4, 'TL', 'MU', 4, 'TR', 'PE', 4, 'BR', 'SA', 4, 'BL'),
	('RG', 'Rustic Garden',			'TR', 'RR', 'PB', 'BO', 6, 'L',  'MU', 6, 'R',  'GP', 4, 'T',  'ON', 4, 'B' ),
	('SR', 'Salsiccia Rustica',		'CR', 'RR', 'PV', 'TO', 8, 'AO', 'MU', 8, 'AO', 'SA', 8, 'AO', NULL, 0, NULL),
	('SG', 'Seaside Gumbo',			'CR', 'OO', 'SC', 'RP', 8, 'AO', 'SA', 6, 'T',  'CS', 6, 'B',  NULL, 0, NULL),
	('SC', 'Shrimp Scorcher',		'TR', 'BF', 'GP', 'AC', 6, 'L',  'RP', 6, 'R',  'CS', 8, 'AO', NULL, 0, NULL),
	('SZ', 'Sirloin Sizzler',		'TR', 'BQ', 'PB', 'PS', 6, 'T',  'GB', 6, 'B',  'JA', 8, 'AO', NULL, 0, NULL),
	('SM', 'Spicy Meatball',		'CR', 'RR', 'GP', 'PC', 8, 'AO', 'RP', 6, 'L',  'ME', 8, 'AO', NULL, 0, NULL),
	('ST', 'Surt and Turf',			'CR', 'BQ', 'GP', 'PS', 6, 'L',  'SS', 4, 'R',  'AC', 8, 'AO', NULL, 0, NULL),
	('SH', 'The Smokehouse',		'TR', 'BQ', 'SC', 'PP', 8, 'AO', 'BA', 8, 'AO', 'ON', 4, 'AO', NULL, 0, NULL),
	('TT', 'Tastyville Trio',		'TR', 'MA', 'PB', 'PE', 8, 'AO', 'MU', 8, 'AO', 'SA', 8, 'AO', NULL, 0, NULL),
	('TB', 'The BST',				'TH', 'OO', 'GP', 'BA', 6, 'T',  'SP', 6, 'B',  'TO', 4, 'AO', NULL, 0, NULL),
	('DE', 'The Denver',			'CR', 'MA', 'PV', 'RP', 6, 'L',  'GP', 6, 'R',  'HA', 6, 'B',  'ON', 4, 'T' ),
	('WF', 'The Wildfire',			'CR', 'BF', 'PB', 'PC', 6, 'L',  'CA', 6, 'R',  'JA', 4, 'T',  'BP', 4, 'B' ),
	('WO', 'The Works',				'TR', 'RR', 'PB', 'PE', 8, 'AO', 'BO', 8, 'AO', 'BP', 8, 'AO', 'ON', 4, 'AO');
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
