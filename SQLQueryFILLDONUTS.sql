
INSERT INTO DonutDoughs values
	('CH', 'Chocolate Cake'),
	('RE', 'Regular Dough'),
	('PU', 'Pumpkin Cake'),
	('RV', 'Red Velvet Cake'),
	('BB', 'Blueberry Cake');



INSERT INTO DonutShapes values
	('RI', 'Ring Shape'),
	('RO', 'Round Shape'),
	('LJ', 'Long John Shape'),
	('FC', 'French Cruller'),
	('RL', 'Roll Shape');


		
INSERT INTO DonutFillings values
	('BO', 'Boston Cream'),
	('ST', 'Strawberry Jelly'),
	('CH', 'Chocolate Mousse'),
	('CD', 'Cookie Dough Cream'),
	('WH', 'Whipped Cream'),
	('BE', 'Blueberry Custard'),
	('BK', 'Blackberry Jelly'),
	('LE', 'Lemon Chiffon');


	
INSERT INTO DonutIcingsAndPowders values
	('BN', 'Blue Nimbus Icing'),
	('CH', 'Chocolate Icing'),
	('CG', 'Clear Glaze'),
	('SU', 'Powdered Sugar'),
	('ST', 'Strawberry Icing'),
	('VA', 'Vanilla Icing'),
	('RR', 'Red Rose Icing'),
	('CI', 'Cinnamon Sugar'),
	('AP', 'Apricot Icing');


	
INSERT INTO DonutSprinklesAndDrizzles values
	('CC', 'Chocolate Chips'),
	('CO', 'Cosmin Coconut'),
	('RA', 'Rainbow Sprinkles'),
	('MM', 'Mini Mallows'),
	('CB', 'Creameo Bits'),
	('CP', 'Crushed Peanuts'),
	('RB', 'Raspberry Bark'),
	('RC', 'Rock Candy'),
	('PI', 'Pistachios'),
	('BM', 'Blue Moon Drizzle'),
	('ST', 'Strawberry Drizzle'),
	('VA', 'Vanilla Drizzle'),
	('CH', 'Chocolate Drizzle'),
	('DR', 'Dreamsicle Drizzle'),
	('CA', 'Caramel Drizzle'),
	('SP', 'Sugarplum Drizzle'),
	('BA', 'Banana Drizzle'),
	('NE', 'Neapolitan Drizzle');




INSERT INTO DonutsRecipies values
/*   id    name             		dough dough dough 	shape shape shape 	fill  fill  fill  	icing icing icing 	drizz drizz drizz 	extra extra extra */
	('AA', 'Anytime Autumn', 		'PU', 'PU', 'PU', 	'RO', 'RO', 'RO', 	'BO', 'CH', 'BO', 	'CH', 'CG', 'CH', 	'VA', 'CH', 'VA', 	NULL, 'CC', NULL),
	('BE', 'Berry Berliners', 		'BB', 'CH', 'BB', 	'RL', 'RO', 'RL', 	'BK', 'BE', 'BK', 	'CI', 'RR', 'CI', 	'SP', 'CO', 'SP', 	NULL, NULL, NULL),
	('BZ', 'Blue Bonanza',	 		'BB', 'BB', 'BB', 	'RL', 'RI', 'RL', 	'BE', 'BE', 'BE', 	'BN', 'CG', 'BN', 	'RC', 'BM', 'RC', 	NULL, 'RC', NULL),
	('BA', 'Blueberry Bash', 		'BB', 'BB', 'BB', 	'LJ', 'FC', 'LJ', 	'CH', 'BE', 'CH', 	'CI', 'CH', 'CI', 	'CB', 'CH', 'CB', 	NULL, NULL, NULL),
	('BO', 'Bosox Box', 			'RV', 'RV', 'RV', 	'FC', 'LJ', 'FC', 	'BO', 'BO', 'BO', 	'VA', 'CG', 'VA', 	'CC', 'VA', 'CC', 	NULL, NULL, NULL),
	('BC', 'Boston Creameos', 		'CH', 'PU', 'CH', 	'RO', 'RI', 'RO', 	'BO', 'CH', 'BO', 	'CH', 'SU', 'CH', 	'CB', 'CB', 'CB', 	NULL, NULL, NULL),
	('CL', 'Choco-Lantern', 		'PU', 'CH', 'PU', 	'RI', 'LJ', 'RI', 	'CH', 'ST', 'CH', 	'SU', 'VA', 'SU', 	'DR', 'RA', 'DR', 	NULL, NULL, NULL),
	('CE', 'Chocolate Éclair', 		'CH', 'CH', 'CH', 	'LJ', 'LJ', 'LJ', 	NULL, 'BO', NULL, 	'CG', 'SU', 'CG', 	'DR', 'CC', 'DR', 	'MM', NULL, 'MM'),
	('CS', 'Cinnaberry Slammer', 	'BB', 'RV', 'BB', 	'FC', 'RO', 'FC', 	'CD', NULL, 'CD', 	'ST', 'CI', 'ST', 	'CH', 'CA', 'CH', 	NULL, 'CC', NULL),
	('CC', 'Cookies and Creameos', 	'RE', 'CH', 'RE', 	'FC', 'FC', 'FC', 	'CD', 'CD', 'CD', 	'CH', 'CG', 'CH', 	'CB', 'CC', 'CB', 	NULL, NULL, NULL),
/*   id    name             		dough dough dough 	shape shape shape 	fill  fill  fill  	icing icing icing 	drizz drizz drizz 	extra extra extra */
	('CP', 'Cosmic Pumpkin', 		'RE', 'PU', 'RE', 	'LJ', 'RO', 'LJ', 	'CH', NULL, 'CH', 	'BN', 'SU', 'BN', 	'CO', 'BM', 'CO', 	NULL, 'CO', NULL),
	('CU', 'Cumulus Crullers', 		'RE', 'BB', 'RE', 	'FC', 'FC', 'FC', 	'BE', 'BE', 'BE', 	'BN', 'SU', 'BN', 	'RA', 'BM', 'RA', 	NULL, NULL, NULL),
	('CT', 'Cupid''s Catch',	 	'RV', 'RE', 'RV', 	'LJ', 'FC', 'LJ', 	'ST', 'ST', 'ST', 	'ST', 'RR', 'ST', 	'SP', 'SP', 'SP', 	NULL, NULL, NULL),
	('DB', 'Death By Chocolate', 	'CH', 'CH', 'CH', 	'RI', 'RO', 'RI', 	'CH', 'CH', 'CH', 	'CH', 'CH', 'CH', 	'CH', 'CH', 'CH', 	'CC', 'CC', 'CC'),
	('DJ', 'Donut Jubilee', 		'RV', 'RE', 'BB', 	'RI', 'LJ', 'RI', 	'ST', 'WH', 'ST', 	'VA', 'RR', 'VA', 	'BM', 'MM', 'BM', 	NULL, NULL, NULL),
	('D1', 'Donuts 101', 			'PU', 'RE', 'PU', 	'LJ', 'RI', 'LJ', 	NULL, 'BO', NULL, 	'VA', 'ST', 'VA', 	'BM', 'CC', 'BM', 	'RA', NULL, 'RA'),
	('DC', 'Double Crullernut', 	'CH', 'RV', 'CH', 	'FC', 'RO', 'FC', 	'ST', 'CH', 'ST', 	'RR', 'CH', 'RR', 	'CP', 'ST', 'CP', 	NULL, NULL, NULL),
	('DT', 'Doughberry Twists', 	'CH', 'RE', 'CH', 	'FC', 'FC', 'FC', 	'BO', 'ST', 'BO', 	'ST', 'SU', 'ST', 	'CB', 'RA', 'CB', 	NULL, NULL, NULL),
	('DM', 'Dream Machine', 		'RE', 'PU', 'RE', 	'LJ', 'RL', 'LJ', 	'WH', 'BO', 'WH', 	'AP', 'VA', 'AP', 	'MM', 'DR', 'MM', 	NULL, NULL, NULL),
	('DD', 'Drizzle Dones', 		'RE', 'CH', 'RE', 	'RI', 'RI', 'RI', 	NULL, NULL, NULL, 	'CG', 'VA', 'CG', 	'VA', 'BM', 'VA', 	'ST', 'CH', 'ST'),
/*   id    name             		dough dough dough 	shape shape shape 	fill  fill  fill  	icing icing icing 	drizz drizz drizz 	extra extra extra */
	('DS', 'Dynamite Sticks', 		'PU', 'RV', 'PU', 	'LJ', 'LJ', 'LJ', 	'CD', 'CD', 'CD', 	'RR', 'AP', 'RR', 	'DR', 'BA', 'DR', 	NULL, NULL, NULL),
	('FC', 'Fairground Fry Cakes', 	'CH', 'CH', 'CH', 	'RL', 'FC', 'RL', 	'LE', 'LE', 'LE', 	'CG', 'SU', 'CG', 	'NE', 'BA', 'NE', 	'PI', 'PI', 'PI'),
	('FF', 'Fryer Feast', 			'CH', 'RE', 'CH', 	'RI', 'RO', 'RI', 	'ST', NULL, 'ST', 	'ST', 'CG', 'ST', 	'MM', 'VA', 'MM', 	NULL, 'CO', NULL),
	('GB', 'Gourdberry Batch', 		'PU', 'BB', 'PU', 	'LJ', 'RO', 'LJ', 	'CD', 'WH', 'CD', 	'CH', 'CI', 'CH', 	'CP', 'CB', 'CP', 	NULL, NULL, NULL),
	('J2', 'Jellyroll 20X6', 		'RE', 'BB', 'RE', 	'RL', 'RL', 'RL', 	'BK', 'ST', 'BK', 	'ST', 'VA', 'ST', 	'ST', 'SP', 'ST', 	'RA', 'RB', 'RA'),
	('JD', 'Johnny Donutseed', 		'RE', 'RV', 'RE', 	'LJ', 'LJ', 'LJ', 	'BO', 'CH', 'BO', 	'RR', 'VA', 'RR', 	'CA', 'CB', 'CA', 	NULL, NULL, NULL),
	('JL', 'Johnny Longberry', 		'RE', 'CH', 'RE', 	'LJ', 'LJ', 'LJ', 	'ST', 'ST', 'ST', 	'ST', 'CG', 'ST', 	'CC', 'ST', 'CC', 	NULL, NULL, NULL),
	('MM', 'Moon Mist', 			'BB', 'PU', 'BB', 	'RO', 'RI', 'RO', 	NULL, 'WH', NULL, 	'BN', 'BN', 'BN', 	'DR', 'BM', 'DR', 	'CO', 'CO', 'CO'),
	('NT', 'Neapoliuan Trio', 		'RE', 'RV', 'RE', 	'RO', 'RO', 'RO', 	'BO', 'ST', 'CH', 	'VA', 'ST', 'CH', 	'ST', 'CH', 'VA', 	NULL, NULL, NULL),
	('PP', 'Powder Point', 			'CH', 'RE', 'CH', 	'RO', 'LJ', 'RO', 	'BO', 'CH', 'BO', 	'SU', 'SU', 'SU', 	'VA', 'MM', 'VA', 	NULL, NULL, NULL),
/*   id    name             		dough dough dough 	shape shape shape 	fill  fill  fill  	icing icing icing 	drizz drizz drizz 	extra extra extra */
	('RH', 'Red Harvester', 		'RV', 'PU', 'RV', 	'RI', 'RI', 'RI', 	NULL, 'BO', NULL, 	'CH', 'SU', 'CH', 	'CA', 'CH', 'CA', 	'CP', NULL, 'CP'),
	('RL', 'Rings of Love', 		'RV', 'RV', 'RV', 	'RI', 'FC', 'RI', 	'CH', 'ST', 'CH', 	'ST', 'VA', 'ST', 	'RB', 'ST', 'RB', 	NULL, NULL, NULL),
	('RR', 'Rosey Ringers', 		'RE', 'CH', 'RE', 	'FC', 'RI', 'FC', 	NULL, 'CH', NULL, 	'RR', 'RR', 'RR', 	'VA', 'CO', 'VA', 	'CC', NULL, 'CC'),
	('VS', 'So Very Strawberry', 	'RE', 'RE', 'RE', 	'RI', 'LJ', 'RI', 	'ST', 'ST', 'ST', 	'ST', 'ST', 'ST', 	'ST', 'ST', 'ST', 	NULL, NULL, NULL),
	('SS', 'Sprinkle Squasher', 	'PU', 'RE', 'PU', 	'RI', 'RO', 'RI', 	'CH', NULL, 'CH', 	'RR', 'VA', 'RR', 	'RA', 'CA', 'RA', 	NULL, 'MM', NULL),
	('SP', 'Sprinkler', 			'CH', 'CH', 'CH', 	'RO', 'RI', 'RO', 	'BO', NULL, 'BO', 	'BN', 'SU', 'BN', 	'RA', 'BM', 'RA', 	NULL, 'RA', NULL),
	('SC', 'Super Cinnabuns', 		'RE', 'RE', 'RE', 	'RL', 'RL', 'RL', 	'BO', 'CD', 'BO', 	'CI', 'CI', 'CI', 	'VA', 'CP', 'VA', 	NULL, NULL, NULL),
	('TT', 'Triple Treat', 			'CH', 'PU', 'CH', 	'RO', 'FC', 'RO', 	'ST', NULL, 'ST', 	'RR', 'CH', 'RR', 	'CO', 'DR', 'CO', 	NULL, 'MM', NULL),
	('WM', 'Wildberry Medley', 		'BB', 'RE', 'BB', 	'FC', 'RL', 'FC', 	'BK', NULL, 'BK', 	'AP', 'BN', 'AP', 	'SP', 'CA', 'SP', 	NULL, 'RB', NULL),
	('ZF', 'Zero Fills Zeor Frills','RE', 'RE', 'RE', 	'RI', 'RI', 'RI', 	NULL, NULL, NULL, 	'CG', 'CG', 'CG', 	'VA', 'VA', 'VA', 	NULL, NULL, NULL);

	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
