CREATE TABLE DonutsRecipies (
	donuts_id char(2) constraint donuts_id_is_pkey primary key,
	donuts_name nvarchar(30) constraint donuts_name_is_unique unique,

	donut1_dough char(2) constraint donut1_dough_not_null not null references DonutDoughs(donut_dough_id),
	donut2_dough char(2) constraint donut2_dough_not_null not null references DonutDoughs(donut_dough_id),
	donut3_dough char(2) constraint donut3_dough_not_null not null references DonutDoughs(donut_dough_id),

	donut1_shape char(2) constraint donut1_shape_not_null not null references DonutShapes(donut_shape_id),
	donut2_shape char(2) constraint donut2_shape_not_null not null references DonutShapes(donut_shape_id),
	donut3_shape char(2) constraint donut3_shape_not_null not null references DonutShapes(donut_shape_id),

	donut1_filling char(2) references DonutFillings(donut_filling_id),
	donut2_filling char(2) references DonutFillings(donut_filling_id),
	donut3_filling char(2) references DonutFillings(donut_filling_id),

	donut1_icing_or_powder char(2) constraint donut1_icing_or_powder_not_null not null references DonutIcingsAndPowders(donut_icing_or_powder_id),
	donut2_icing_or_powder char(2) constraint donut2_icing_or_powder_not_null not null references DonutIcingsAndPowders(donut_icing_or_powder_id),
	donut3_icing_or_powder char(2) constraint donut3_icing_or_powder_not_null not null references DonutIcingsAndPowders(donut_icing_or_powder_id),

	donut1_1st_sprinkle_or_drizzle char(2) constraint donut1_1st_sprinkle_or_drizzle_not_null not null references DonutSprinklesOrDrizzles(donut_sprinkle_or_drizzle_id),
	donut2_1st_sprinkle_or_drizzle char(2) constraint donut2_1st_sprinkle_or_drizzle_not_null not null references DonutSprinklesOrDrizzles(donut_sprinkle_or_drizzle_id),
	donut3_1st_sprinkle_or_drizzle char(2) constraint donut3_1st_sprinkle_or_drizzle_not_null not null references DonutSprinklesOrDrizzles(donut_sprinkle_or_drizzle_id),

	donut1_2nd_sprinkle_or_drizzle char(2) references DonutSprinklesOrDrizzles(donut_sprinkle_or_drizzle_id),
	donut2_2nd_sprinkle_or_drizzle char(2) references DonutSprinklesOrDrizzles(donut_sprinkle_or_drizzle_id),
	donut3_2nd_sprinkle_or_drizzle char(2) references DonutSprinklesOrDrizzles(donut_sprinkle_or_drizzle_id)
	)