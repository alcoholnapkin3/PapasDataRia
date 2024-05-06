CREATE VIEW RegularCustomersWithNames AS
SELECT
    rc.customer_name,
    pr.name AS fav_pizza_recipie_name,
    pb.name AS fav_pizza_bake_name,
    pc.name AS fav_pizza_cut_name,
    sr.name AS fav_sushi_recipie_name,
    tf.name AS fav_bubbletea_flavor_name,
    tb.name AS fav_bubbletea_bubbles_name,
    dr.name AS fav_donuts_recipie_name,
    swr.name AS fav_sandwich_recipie_name,
    ss.name AS fav_slush_size_name,
    sf1.name AS fav_slush_bottom_flavor_name,
    sf2.name AS fav_slush_top_flavor_name
FROM
    RegularCustomers rc
    LEFT JOIN PizzaRecipies pr ON rc.fav_pizza_recipie = pr.id
    LEFT JOIN PizzaBakes pb ON rc.fav_pizza_bake = pb.id
    LEFT JOIN PizzaCuts pc ON rc.fav_pizza_cut = pc.id
    LEFT JOIN SushiRecipies sr ON rc.fav_sushi_recipie = sr.id
    LEFT JOIN TeaFlavors tf ON rc.fav_bubbletea_flavor = tf.id
    LEFT JOIN TeaBubbles tb ON rc.fav_bubbletea_bubbles = tb.id
    LEFT JOIN DonutsRecipies dr ON rc.fav_donuts_recipie = dr.id
    LEFT JOIN SandwichRecipies swr ON rc.fav_sandwich_recipie = swr.id
    LEFT JOIN SlushSizes ss ON rc.fav_slush_size = ss.id
    LEFT JOIN SlushFlavors sf1 ON rc.fav_slush_bottom_flavor = sf1.id
    LEFT JOIN SlushFlavors sf2 ON rc.fav_slush_top_flavor = sf2.id;
