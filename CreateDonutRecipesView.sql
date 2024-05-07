CREATE VIEW DonutRecipiesWithNames AS
SELECT
    dr.id,
    dr.name AS RecipeName,
    dd1.name AS Dough1,
    dd2.name AS Dough2,
    dd3.name AS Dough3,
    ds1.name AS Shape1,
    ds2.name AS Shape2,
    ds3.name AS Shape3,
    df1.name AS Filling1,
    df2.name AS Filling2,
    df3.name AS Filling3,
    dip1.name AS IcingOrPowder1,
    dip2.name AS IcingOrPowder2,
    dip3.name AS IcingOrPowder3,
    dsd1.name AS SprinkleOrDrizzle1,
    dsd2.name AS SprinkleOrDrizzle2,
    dsd3.name AS SprinkleOrDrizzle3,
    dsd4.name AS ExtraSprinkleOrDrizzle1,
    dsd5.name AS ExtraSprinkleOrDrizzle2,
    dsd6.name AS ExtraSprinkleOrDrizzle3
FROM
    DonutsRecipies dr
    LEFT JOIN DonutDoughs dd1 ON dr.dough_1st = dd1.id
    LEFT JOIN DonutDoughs dd2 ON dr.dough_2ns = dd2.id
    LEFT JOIN DonutDoughs dd3 ON dr.dough_3rd = dd3.id
    LEFT JOIN DonutShapes ds1 ON dr.shape_1st = ds1.id
    LEFT JOIN DonutShapes ds2 ON dr.shape_2nd = ds2.id
    LEFT JOIN DonutShapes ds3 ON dr.shape_3rd = ds3.id
    LEFT JOIN DonutFillings df1 ON dr.filling_1st = df1.id
    LEFT JOIN DonutFillings df2 ON dr.filling_2nd = df2.id
    LEFT JOIN DonutFillings df3 ON dr.filling_3rd = df3.id
    LEFT JOIN DonutIcingsAndPowders dip1 ON dr.icing_or_powder_1st = dip1.id
    LEFT JOIN DonutIcingsAndPowders dip2 ON dr.icing_or_powder_2nd = dip2.id
    LEFT JOIN DonutIcingsAndPowders dip3 ON dr.icing_or_powder_3rd = dip3.id
    LEFT JOIN DonutSprinklesAndDrizzles dsd1 ON dr.sprinkle_or_drizzle_1st = dsd1.id
    LEFT JOIN DonutSprinklesAndDrizzles dsd2 ON dr.sprinkle_or_drizzle_2nd = dsd2.id
    LEFT JOIN DonutSprinklesAndDrizzles dsd3 ON dr.sprinkle_or_drizzle_3rd = dsd3.id
    LEFT JOIN DonutSprinklesAndDrizzles dsd4 ON dr.extra_sprinkle_or_drizzle_1st = dsd4.id
    LEFT JOIN DonutSprinklesAndDrizzles dsd5 ON dr.extra_sprinkle_or_drizzle_2nd = dsd5.id
    LEFT JOIN DonutSprinklesAndDrizzles dsd6 ON dr.extra_sprinkle_or_drizzle_3rd = dsd6.id;