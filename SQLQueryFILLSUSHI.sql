
INSERT INTO SushiRices values
	('BR', 'Brown Rice'),
	('WH', 'White Rice'),
	('SH', 'Shiso Rice'),
	('BL', 'Black Rice');


INSERT INTO SushiWraps values
	('NO', 'Nori'),
	('MS', 'Momoiro Soy Paper'),
	('US', 'Ukoniro Soy Paper');
/* SushiVinegar? */

INSERT INTO SushiFillings values
	('AV', 'Avocado'),
	('CA', 'Carrot'),
	('CR', 'Crab Stick'),
	('CC', 'Cream Cheese'),
	('CU', 'Cucumber Slices'),
	('SA', 'Salmon'),
	('SP', 'Snow Peas'),
	('TU', 'Tuna'),
	('LO', 'Lobster'),
	('TO', 'Tofu'),
	('UN', 'Unagi'),
	('JA', 'Jalapeños'),
	('GO', 'Green Onions'),
	('WA', 'Wagyu'),
	('SM', 'Shiitake Mushrooms'),
	('TE', 'Shrimp Tempura'),
	('TA', 'Tamago'),
	('OC', 'Octopus'),
	('YT', 'Yellowtail'),
	('RS', 'Radish Sprouts'),
	('AG', 'Asparagus'),
	('FC', 'Fried Calamari');


INSERT INTO SushiToppings values
	('AV', 'Avocado'),
	('MA', 'Mango Slices'),
	('PR', 'Prawn'),
	('SB', 'Saba'),
	('SA', 'Salmon'),
	('TU', 'Tuna'),
	('KI', 'Kiwi Slices'),
	('WA', 'Wagyu'),
	('YT', 'Yellowtail'),
	('SY', 'Sayori');
	

INSERT INTO SushiShakers values
	('TO', 'Tobiko'),
	('BO', 'Bonito Flakes'),
	('SE', 'Sesame Seeds'),
	('TE', 'Tempura Crunch'),
	('FK', 'Furikake');


INSERT INTO SushiSauce values
	('DU', 'Duck Sauce'),
	('TS', 'General Tso Sauce'),
	('GM', 'Ginger Miso Sauce'),
	('TE', 'Teriyaki Sauce'),
	('WA', 'Wasabi Mayo'),
	('YY', 'Yum Yum Sauce'),
	('YK', 'Yuzu Kosho'),
	('TO', 'Tonkatsu Sauce'),
	('HI', 'Hibachi Sauce'),
	('SR', 'Sriracha'),
	('PO', 'Ponzu');

/* далее - факторы, не связанные с рецептом
*/


INSERT INTO TeaFlavors values
	('AL', 'Almond Tea'),
	('BL', 'Black Tea'),
	('MA', 'Matcha Tea'),
	('MO', 'Mocha Tea'),
	('SB', 'Strawberry Tea'),
	('BB', 'Blueberry Tea'),
	('PC', 'Piña Colada Tea'),
	('TR', 'Tangerine Tea'),
	('TA', 'Taro Tea'),
	('HD', 'Honeydew Tea'),
	('CH', 'Chocolate Tea');


INSERT INTO TeaBubbles values
	('BS', 'Butterscotch Bubbles'),
	('CU', 'Cucumber Bubbles'),
	('LY', 'Lychee Bubbles'),
	('MA', 'Mango Bubbles'),
	('TA', 'Tapioca Pearls'),
	('WM', 'Watermelon Bubbles'),
	('CH', 'Cherry Bubbles'),
	('PP', 'Pawpaw Bubbles'),
	('SP', 'Sugarplum Bubbles'),
	('CC', 'Cotton Candy Bubbles'),
	('KI', 'Kiwi Bubbles'),
	('HB', 'Huckleberry Bubbles');
	
	

INSERT INTO SushiRecipies values
/*                         		RICE  WRAP  FL FILL1 FILL2 FILL3 TOPP  SHAK  SAUCE*/
	('CF', 'California Roll',	'WH', 'NO', 1, 'AV', 'CR', 'CU', NULL, 'SE', NULL),
	('CP', 'Caterpillar Roll',	'SH', 'NO', 1, 'CU', 'UN', NULL, 'AV', 'SE', NULL),
	('CC', 'Cool Calamari',		'BL', 'US', 1, 'CU', 'FC', NULL, NULL, NULL, 'DU'),
	('CZ', 'Crazy Crustacean',	'SH', 'NO', 1, 'CR', 'LO', NULL, NULL, NULL, 'PO'),
	('CB', 'Crunchy Crab',		'WH', 'US', 1, 'CR', 'CU', NULL, NULL, 'TE', NULL),
	('CR', 'Crunchy Roll',		'BL', 'NO', 0, 'TE', 'YT', NULL, NULL, 'TE', NULL),
	('FT', 'Flying Tofu',		'BR', 'MS', 1, 'GO', 'TO', NULL, NULL, 'TO', NULL),
	('GS', 'Ginger Shrimp',		'BR', 'US', 0, 'TO', 'TE', NULL, NULL, NULL, 'GM'),
	('GE', 'Grumpe Eel',		'WH', 'NO', 1, 'UN', 'CR', NULL, NULL, NULL, 'TE'),
	('KD', 'Kiwi Daikon',		'BR', 'MS', 1, 'AG', 'RS', NULL, 'KI', NULL, 'HI'),
/*                         		RICE  WRAP  FL FILL1 FILL2 FILL3 TOPP  SHAK  SAUCE*/
	('KK', 'Kiwi Kosho',		'BR', 'US', 1, 'SP', 'TO', NULL, 'KI', NULL, 'YK'),
	('KR', 'Kraken Roll',		'WH', 'MS', 1, 'OC', 'TO', NULL, 'SY', NULL, 'YY'),
	('LL', 'Lava Lobster',		'WH', 'NO', 0, 'JA', 'LO', NULL, NULL, NULL, 'YK'),
	('MM', 'Momo Mango',		'WH', 'MS', 0, 'CA', 'CC', NULL, 'MA', NULL, 'GM'),
	('NH', 'Negi Hamachi',		'WH', 'NO', 0, 'YT', 'GO', NULL, 'YT', 'FK', NULL),
	('OR', 'Orange Roll',		'BR', 'NO', 1, 'LO', 'CA', NULL, 'PR', NULL, 'DU'),
	('PH', 'Philly Roll',		'WH', 'NO', 1, 'SA', 'CC', 'AV', NULL, NULL, 'YY'),
	('PX', 'Phoenix Roll',		'BL', 'US', 0, 'UN', 'CR', NULL, 'PR', 'TO', 'HI'),
	('RA', 'Radley Roll',		'SH', 'US', 0, 'RS', 'TU', NULL, NULL, 'TO', NULL),
	('RM', 'Roly Mackerel',		'BR', 'NO', 1, 'TA', 'TU', NULL, NULL, NULL, 'TS'),
/*                         		RICE  WRAP  FL FILL1 FILL2 FILL3 TOPP  SHAK  SAUCE*/
	('SL', 'Salmon Sampler',	'SH', 'MS', 0, 'SA', 'SM', NULL, 'SA', NULL, 'WA'),
	('SA', 'Searing Salmon',	'SH', 'US', 1, 'JA', 'SA', NULL, NULL, 'FK', NULL),
	('SC', 'Sesame Cephalopod',	'SH', 'US', 0, 'CA', 'OC', NULL, NULL, 'SE', NULL),
	('SS', 'Sesame Shrooms',	'BL', 'MS', 0, 'SM', 'TU', NULL, NULL, 'SE', NULL),
	('SP', 'Shrimpy Sprout',	'WH', 'MS', 0, 'RS', 'TE', NULL, NULL, NULL, 'YK'),
	('SB', 'Smothered Beef',	'BR', 'NO', 0, 'WA', 'SM', NULL, 'WA', 'TO', NULL),
	('SQ', 'Spicy Squid',		'BR', 'MS', 0, 'JA', 'FC', NULL, NULL, NULL, 'SR'),
	('SE', 'Steak & Eggs',		'SH', 'MS', 1, 'WA', 'TA', NULL, NULL, NULL, 'SR'),
	('SH', 'Sunshine Roll',		'WH', 'US', 0, 'TA', 'UN', NULL, 'SB', NULL, 'TO'),
	('ST', 'Surf & Turf',		'WH', 'US', 1, 'LO', 'WA', NULL, NULL, NULL, 'TS'),
/*                         		RICE  WRAP  FL FILL1 FILL2 FILL3 TOPP  SHAK  SAUCE*/
	('TM', 'Tako Maki',			'SH', 'US', 1, 'OC', 'RS', NULL, NULL, 'BO', NULL),
	('TE', 'Tempura Teriyaki',	'BR', 'US', 0, 'TE', 'SP', NULL, NULL, NULL, 'TE'),
	('AJ', 'The Amberjack',		'BL', 'MS', 1, 'AV', 'YT', NULL, NULL, 'BO', NULL),
	('BQ', 'Tofu BBQ',			'BR', 'NO', 0, 'TO', 'SA', NULL, NULL, 'TO', NULL),
	('TT', 'Tuna Tuna Tempura',	'WH', 'NO', 0, 'TU', 'AG', NULL, 'TU', 'TE', NULL),
	('UM', 'Unagi Maki',		'BR', 'NO', 0, 'UN', 'SP', NULL, NULL, 'BO', NULL),
	('VE', 'Veggie Roll',		'BR', 'MS', 0, 'CC', 'AG', 'CU', NULL, 'FK', 'PO'),
	('WW', 'Wasabi Wagyu',		'BR', 'NO', 1, 'SP', 'WA', NULL, NULL, NULL, 'WA'),
	('YY', 'Yum Yum Yellowtail','SH', 'MS', 0, 'YT', 'CC', NULL, NULL, NULL, 'YY'),
	('YO', 'Yummy Onion',		'WH', 'MS', 1, 'TU', 'GO', NULL, NULL, NULL, 'YY');

	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
