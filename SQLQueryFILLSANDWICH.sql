

INSERT INTO SandwichMeatsAndAlternatives values
	('CB', 'Chicken Breast'),
	('CP', 'Chicken Patty'),
	('VE', 'Veggie Patty'),
	('FI', 'Fish Fillet'),
	('SH', 'Schnitzel'),
	('PO', 'Pork Chop'),
	('CS', 'Country Steak'),
	('EP', 'Eggplant'),
	('CD', 'Cod'),
	('SC', 'Soft Shell Crab');



INSERT INTO SandwichBattersAndBreadings values
	('BE', 'Beer Batter'),
	('PO', 'Papa''s Original Breading'),
	('SC', 'Spicy Cajun Batter'),
	('PC', 'Pretzel Crust Breading'),
	('CP', 'Cheez Puff Breading'),
	('PA', 'Panko Breading'),
	('TE', 'Tempura Batter'),
	('SB', 'Sweet Belgial Batter');


	
INSERT INTO SandwichBuns values
	('CL', 'Classic Bun'),
	('CR', 'Croissant'),
	('SE', 'Sesame Bun'),
	('BM', 'Buttermilk Biscuit'),
	('MU', 'Multigrain Bun'),
	('KO', 'Kaiser Onion Roll'),
	('BA', 'Bagel'),
	('BR', 'Brioche Bun');



INSERT INTO SandwichToppingsAndSauces values
	('P ', 'Patty'),
	('EP', 'Extra Patty'),

	('BA', 'Bacon'),
	('CC', 'Cheddar Cheese'),
	('CS', 'Creamy Cole Slaw'),
	('JA', 'Jalapeños'),
	('ON', 'Onion'),
	('OS', 'Fried Onion Straws'),
	('PI', 'Pickles'),
	('PC', 'Provolone Cheese'),
	('LE', 'Summer Crisp Lettuce'),
	('TO', 'Tomato'),
	('CA', 'Red Cabbage Slaw'),
	('WA', 'Watercress'),
	('BP', 'Banana Peppers'),
	('EG', 'Fried Egg'),
	('GP', 'Grilled Portobello Cap'),
	('RO', 'Pickled Red Onions'),
	('RS', 'Radish Sprouts'),
	('AV', 'Sliced Avocado'),
	('PR', 'Pineapple Ring'),
	('PJ', 'Pepperjack Cheese'),
	
	
	('BQ', 'BBQ Sauce'),
	('BB', 'Blazeberry Sauce'),
	('BU', 'Buffalo Sauce'),
	('HM', 'Honey Mustard Sauce'),
	('MA', 'Marinara Sauce'),
	('MO', 'Mayo'),
	('TE', 'Teriyaki Sauce'),
	('TA', 'Tartar Sauce'),
	('NV', 'Nashville Hot Sauce'),
	('CO', 'Country Gravy'),
	('PP', 'Peri Peri Sauce'),
	('PA', 'Paprikash Sauce'),
	('SB', 'Sticky Bourbon Sauce'),
	('CR', 'Coronation Sauce');


/* далее - факторы, не связанные с рецептом
*/
	
INSERT INTO SlushSizes values
	('S', 'Small Cup'),
	('M', 'Medium Cup'),
	('L', 'Large Cup');


INSERT INTO SlushFlavors values
	('BC', 'Black Cherry Slush'),
	('BR', 'Blue Raspberry Slush'),
	('CS', 'Cream Soda Slush'),
	('LE', 'Lemonade Slush'),
	('SA', 'Sour Apple Slush'),
	('TA', 'Tanderine Slush'),
	('WA', 'Watermelon Slush'),
	('ST', 'Sweet Tea Slush'),
	('RB', 'Root Beer Slush'),
	('PB', 'Purple Burple Slush'),
	('PI', 'Pineapple Slush'),
	('DF', 'Dragonfruit Flush'),
	('BU', 'Bubblegum Slush'),
	('KI', 'Kiwi Slush');
	

INSERT INTO SandwichRecipies values
/*   id    name         	    		meat  batr  extra extra bun   	top1  top2  top3  top4  top5  top6  */
	('BB', 'Bacon Bomb', 				'PO', 'PC', NULL, NULL, 'MU', 	'BA', 'P ', 'GP', 'SB', 'BA', 'CA'),
	('BA', 'Bagel Ablaze', 				'EP', 'SC', NULL, NULL, 'BA', 	'P ', 'BB', 'JA', 'BP', 'LE', NULL),
	('BR', 'Battered Barbecue', 		'PO', 'BE', NULL, NULL, 'BM', 	'P ', 'BQ', 'LE', 'ON', 'BP', 'HM'),
	('BV', 'Big Bavarian', 				'SH', 'PC', NULL, NULL, 'CL', 	'P ', 'PI', 'CA', 'OS', 'ON', 'LE'),
	('BZ', 'Blazin'' Beef', 			'CS', 'SC', NULL, NULL, 'MU', 	'BB', 'JA', 'P ', 'JA', 'BU', 'CC'),
	('BQ', 'Bourbon BBQ Chicken', 		'CB', 'TE', NULL, NULL, 'KO', 	'BQ', 'OS', 'P ', 'SB', 'RO', NULL),
	('BF', 'Breakfast Biscuit',			'CP', 'PC', NULL, NULL, 'BM', 	'P ', 'CC', 'EG', 'BA', 'TO', 'NV'),
	('BC', 'Buffalo Bacon Biscuit',		'CP', 'BE', NULL, NULL, 'BM', 	'P ', 'BA', 'OS', 'ON', 'BU', NULL),
	('CP', 'Cabbage Patch', 			'VE', 'BE', NULL, NULL, 'CR', 	'CA', 'P ', 'LE', 'TO', 'HM', 'CA'),
	('CD', 'Catch of the Day', 			'FI', 'PO', NULL, NULL, 'CL', 	'PI', 'P ', 'CC', 'TA', 'CS', NULL),
/*   id    name         	    		meat  batr  extra extra bun   	top1  top2  top3  top4  top5  top6  */
	('CE', 'Cemita Poblana', 			'SH', 'CP', NULL, NULL, 'SE', 	'AV', 'ON', 'P ', 'PJ', 'JA', 'AV'),
	('CV', 'Cheesy Chivito', 			'CS', 'CP', NULL, NULL, 'CL', 	'P ', 'PC', 'TO', 'BA', 'EG', 'MO'),
	('CH', 'Cheesy Chops', 				'PO', 'CP', NULL, NULL, 'SE', 	'CC', 'P ', 'PC', 'P ', 'CC', 'PP'),
	('CL', 'Cluckeria Classic', 		'CB', 'PO', NULL, NULL, 'CL', 	'PI', 'P ', 'LE', 'MO', 'PI', NULL),
	('CO', 'Coronation Chicken', 		'CB', 'PA', NULL, NULL, 'CR', 	'RS', 'CR', 'P ', 'CR', 'WA', 'TO'),
	('CA', 'Colotette Alla Pizzaiola', 	'SH', 'PO', NULL, NULL, 'MU', 	'MA', 'P ', 'TO', 'ON', 'WA', NULL),
	('BM', 'Crab Banh Mi', 				'SC', 'SB', NULL, NULL, 'BR', 	'P ', 'RO', 'WA', 'RS', 'MO', NULL),
	('CR', 'Crabby Croissant', 			'SC', 'TE', NULL, NULL, 'CR', 	'BB', 'P ', 'PJ', 'PR', 'RO', 'AV'),
	('FM', 'Farmers Market', 			'VE', 'CP', NULL, NULL, 'MU', 	'P ', 'ON', 'CS', 'LE', 'PI', 'TO'),
	('FB', 'Fischbrötchen', 			'FI', 'PC', NULL, NULL, 'KO', 	'PI', 'MO', 'LE', 'P ', 'PI', 'ON'),
/*   id    name         	    		meat  batr  extra extra bun   	top1  top2  top3  top4  top5  top6  */
	('FF', 'Fish Fry', 					'FI', 'BE', NULL, NULL, 'CR', 	'WA', 'TO', 'P ', 'PC', 'MO', NULL),
	('HP', 'Harcsapaprikas', 			'CD', 'BE', NULL, NULL, 'BA', 	'LE', 'P ', 'PA', 'BP', 'PI', 'CA'),
	('HM', 'Honey Mushroom', 			'EP', 'BE', NULL, NULL, 'MU', 	'GP', 'RO', 'P ', 'WA', 'TO', 'HM'),
	('HT', 'Honky Tonk Haddock', 		'FI', 'SC', NULL, NULL, 'BM', 	'CS', 'P ', 'NV', 'PI', 'OS', NULL),
	('JS', 'Jägerschnitzel', 			'SH', 'PA', NULL, NULL, 'MU', 	'GP', 'CO', 'P ', 'GP', 'CO', NULL),
	('KS', 'Katsu Sando', 				'PO', 'PA', NULL, NULL, 'CL', 	'TE', 'P ', 'RS', 'WA', 'TE', NULL),
	('KC', 'Kickin'' Chicken', 			'CB', 'SC', NULL, NULL, 'CR', 	'BQ', 'P ', 'JA', 'BA', 'BQ', 'CC'),
	('LD', 'Luau Delight', 				'PO', 'SB', NULL, NULL, 'BA', 	'PR', 'P ', 'TE', 'GP', 'PR', 'TE'),
	('MM', 'Mighty Marinara', 			'CP', 'PO', NULL, NULL, 'SE', 	'P ', 'PC', 'MA', 'TO', 'BP', 'MA'),
	('NV', 'Nashville Veggie', 			'VE', 'SC', NULL, NULL, 'SE', 	'NV', 'P ', 'LE', 'BP', 'NV', NULL),
/*   id    name         	    		meat  batr  extra extra bun   	top1  top2  top3  top4  top5  top6  */
	('PP', 'Papa''s Paprikash', 		'CB', 'PO', NULL, NULL, 'KO', 	'WA', 'PA', 'P ', 'ON', 'P ', NULL),
	('PU', 'Parmesan Pile-Up', 			'EP', 'PA', NULL, NULL, 'BR', 	'P ', 'P ', 'P ', 'TO', 'PC', 'MA'),
	('PI', 'Peri Pickle', 				'VE', 'PC', NULL, NULL, 'KO', 	'PP', 'P ', 'RO', 'PI', 'BP', 'TA'),
	('RS', 'Rahmschnitzel', 			'SH', 'PO', NULL, NULL, 'CR', 	'CO', 'P ', 'ON', 'CO', 'WA', NULL),
	('SF', 'Seafood Sampler', 			'CD', 'SB', 'SC', 'PA', 'BR', 	'P ', 'TA', 'LE', 'EP', 'CS', 'PP'),
	('SS', 'Southern Steak Stack',		'CS', 'PO', NULL, NULL, 'BM', 	'P ', 'CO', 'P ', 'CO', 'EG', NULL),
	('SK', 'Spicy Skipper', 			'CD', 'TE', NULL, NULL, 'KO', 	'BU', 'OS', 'P ', 'JA', 'RS', NULL),
	('TT', 'Towering Teriyaki', 		'CP', 'SC', NULL, NULL, 'SE', 	'P ', 'ON', 'P ', 'CS', 'P ', 'TE'),
	('TP', 'Trancapecho', 				'CS', 'PA', NULL, NULL, 'BR', 	'P ', 'EG', 'LE', 'TO', 'EG', NULL),
	('WJ', 'Whitefish Jubilee', 		'FI', 'CP', NULL, NULL, 'BA', 	'TA', 'P ', 'CA', 'RO', 'CR', NULL);






















