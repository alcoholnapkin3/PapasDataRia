CREATE VIEW PizzaRecipiesWithNames AS
SELECT
    pr.id,
    pr.name AS RecipieName,
    c.name AS Crust,
    s.name AS Sauce,
    ch.name AS Cheese,
    t1.name AS Topping_1st,
    pr.ammount_1st,
    l1.name AS Location_1st,
    t2.name AS Topping_2nd,
    pr.ammount_2nd,
    l2.name AS location_2nd,
    t3.name AS topping_3rd,
    pr.ammount_3rd,
    l3.name AS location_3rd,
    t4.name AS topping_4th,
    pr.ammount_4th,
    l4.name AS location_4th
FROM
    PizzaRecipies pr
    LEFT JOIN PizzaCrusts c ON pr.crust = c.id
    LEFT JOIN PizzaSauces s ON pr.sauce = s.id
    LEFT JOIN PizzaCheeses ch ON pr.cheese = ch.id
    LEFT JOIN PizzaToppings t1 ON pr.topping_1st = t1.id
    LEFT JOIN PizzaLocations l1 ON pr.location_1st = l1.id
    LEFT JOIN PizzaToppings t2 ON pr.topping_2nd = t2.id
    LEFT JOIN PizzaLocations l2 ON pr.location_2nd = l2.id
    LEFT JOIN PizzaToppings t3 ON pr.topping_3rd = t3.id
    LEFT JOIN PizzaLocations l3 ON pr.location_3rd = l3.id
    LEFT JOIN PizzaToppings t4 ON pr.topping_4th = t4.id
    LEFT JOIN PizzaLocations l4 ON pr.location_4th = l4.id;