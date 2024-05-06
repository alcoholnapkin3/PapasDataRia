CREATE VIEW SushiRecipiesWithNames AS
SELECT
    sr.id,
    sr.name AS recipe_name,
    ri.name AS rice_name,
    wr.name AS wrap_name,
    sr.flipped,
    f1.name AS filling_1st_name,
    f2.name AS filling_2nd_name,
    f3.name AS filling_3rd_name,
    t.name AS topping_name,
    sh.name AS shaker_name,
    sa.name AS sauce_name
FROM
    SushiRecipies sr
    LEFT JOIN SushiRices ri ON sr.rice = ri.id
    LEFT JOIN SushiWraps wr ON sr.wrap = wr.id
    LEFT JOIN SushiFillings f1 ON sr.filling_1st = f1.id
    LEFT JOIN SushiFillings f2 ON sr.filling_2nd = f2.id
    LEFT JOIN SushiFillings f3 ON sr.filling_3rd = f3.id
    LEFT JOIN SushiToppings t ON sr.topping = t.id
    LEFT JOIN SushiShakers sh ON sr.shaker = sh.id
    LEFT JOIN SushiSauce sa ON sr.sauce = sa.id;