CREATE TABLE SushiRices (
	sushi_rice_id char(2) constraint sushi_rice_id_is_pkey primary key,
	sushi_rice_name nvarchar(30) constraint sushi_rice_name_is_unique unique not null
	/*experiment*/
	);

CREATE TABLE SushiWraps (
	sushi_wrap_id char(2) constraint sushi_wrap_id_is_pkey primary key,
	sushi_wrap_name nvarchar(30) constraint sushi_wrap_name_is_unique unique
	);

CREATE TABLE SushiFillings (
	sushi_filling_id char(2) constraint sushi_filling_id_is_pkey primary key,
	sushi_filling_name nvarchar(30) constraint sushi_filling_name_is_unique unique
	);

CREATE TABLE SushiToppings (
	sushi_topping_id char(2) constraint sushi_topping_id_is_pkey primary key,
	sushi_topping_name nvarchar(30) constraint sushi_topping_name_is_unique unique
	);

CREATE TABLE SushiShakers (
	sushi_shaker_id char(2) constraint sushi_shaker_id_is_pkey primary key,
	sushi_shaker_name nvarchar(30) constraint sushi_shaker_name_is_unique unique
	);

CREATE TABLE SushiSauce (
	sushi_sauce_id char(2) constraint sushi_sauce_id_is_pkey primary key,
	sushi_sauce_name nvarchar(30) constraint sushi_sauce_name_is_unique unique
	);
/* далее - факторы, не связанные с рецептом
*/

CREATE TABLE BubbleteaFlavors (
	bubbletea_flavor_id char(2) constraint bubbletea_flavor_id_is_pkey primary key,
	bubbletea_flavor_name nvarchar(30) constraint bubbletea_flavor_name_is_unique unique
	);

CREATE TABLE BubbleteaBubblesKinds (
	bubbletea_bubbles_id char(2) constraint bubbletea_bubbles_id_is_pkey primary key,
	bubbletea_bubbles_name nvarchar(30) constraint bubbletea_bubbles_name_is_unique unique
	);
