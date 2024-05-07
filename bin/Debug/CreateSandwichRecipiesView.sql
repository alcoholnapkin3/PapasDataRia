CREATE VIEW SandwichRecipiesWithNames AS
SELECT
    sr.id,
    sr.name AS recipe_name,
    mm.name AS meat_or_alternative_name,
    mb.name AS batter_or_breading_name,
    emm.name AS extra_meat_or_alternative_name,
    emb.name AS extra_batter_or_breading_name,
    sb.name AS bun_name,
    ts1.name AS topping_or_sauce_1st_name,
    ts2.name AS topping_or_sauce_2nd_name,
    ts3.name AS topping_or_sauce_3rd_name,
    ts4.name AS topping_or_sauce_4th_name,
    ts5.name AS topping_or_sauce_5th_name,
    ts6.name AS topping_or_sauce_6th_name
FROM
    SandwichRecipies sr
    LEFT JOIN SandwichMeatsAndAlternatives mm ON sr.meat_or_alternative = mm.id
    LEFT JOIN SandwichBattersAndBreadings mb ON sr.batter_or_breading = mb.id
    LEFT JOIN SandwichMeatsAndAlternatives emm ON sr.extra_meat_or_alternative = emm.id
    LEFT JOIN SandwichBattersAndBreadings emb ON sr.extra_batter_or_breading = emb.id
    LEFT JOIN SandwichBuns sb ON sr.bun = sb.id
    LEFT JOIN SandwichToppingsAndSauces ts1 ON sr.topping_or_sauce_1st = ts1.id
    LEFT JOIN SandwichToppingsAndSauces ts2 ON sr.topping_or_sauce_2nd = ts2.id
    LEFT JOIN SandwichToppingsAndSauces ts3 ON sr.topping_or_sauce_3rd = ts3.id
    LEFT JOIN SandwichToppingsAndSauces ts4 ON sr.topping_or_sauce_4th = ts4.id
    LEFT JOIN SandwichToppingsAndSauces ts5 ON sr.topping_or_sauce_5th = ts5.id
    LEFT JOIN SandwichToppingsAndSauces ts6 ON sr.topping_or_sauce_6th = ts6.id;