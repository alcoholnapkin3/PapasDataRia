CREATE TABLE DonutDoughs (
	donut_dough_id char(2) constraint donut_dough_id_is_pkey primary key,
	donut_dough_name nvarchar(30) constraint donut_dough_name_is_unique unique not null
	/*experiment*/
	);
	
CREATE TABLE DonutShapes (
	donut_shape_id char(2) constraint donut_shape_id_is_pkey primary key,
	donut_shape_name nvarchar(30) constraint donut_shape_name_is_unique unique
	);

CREATE TABLE DonutFillings (
	donut_filling_id char(2) constraint donut_filling_id_is_pkey primary key,
	donut_filling_name nvarchar(30) constraint donut_filling_name_is_unique unique
	);

CREATE TABLE DonutIcingsAndPowders (
	donut_icing_or_powder_id char(2) constraint donut_icing_or_powder_id_is_pkey primary key,
	donut_icing_or_powder_name nvarchar(30) constraint donut_icing_or_powder_name_is_unique unique
	);

CREATE TABLE DonutSprinklesOrDrizzles (
	donut_sprinkle_or_drizzle_id char(2) constraint donut_sprinkle_or_drizzle_id_is_pkey primary key,
	donut_sprinkle_or_drizzle_name nvarchar(30) constraint donut_sprinkle_or_drizzle_name_is_unique unique
	);

/* далее - факторы, не связанные с рецептом
*/
