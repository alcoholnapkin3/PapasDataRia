CREATE TABLE SushiRecipies (
	sushi_id char(2) constraint sushi_id_is_pkey primary key,
	sushi_name nvarchar(30) constraint sushi_name_is_unique unique,
	sushi_rice char(2) constraint sushi_rice_not_null not null references SushiRices(sushi_rice_id),
	sushi_wrap char(2) constraint sushi_wrap_not_null not null references SushiWraps(sushi_wrap_id),
	sushi_fipped bit,

	sushi_1st_filling char(2) constraint pizza_filling_not_null not null references SushiFillings(sushi_filling_id),
	sushi_2nd_filling char(2) references SushiFillings(sushi_filling_id),
	sushi_3rd_filling char(2) references SushiFillings(sushi_filling_id),

	sushi_topping char(2) references SushiToppings(sushi_topping_id),
	sushi_shaker char(2) references SushiShakers(sushi_shaker_id),
	sushi_sauce char(2) references SushiSauce(sushi_sauce_id)
	)