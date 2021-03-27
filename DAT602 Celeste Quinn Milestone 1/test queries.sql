/*
test statements for account
*/
INSERT INTO `account` (username, password, email, admin, locked)
VALUES ('c', 'no', 'x@y.com', 'Y', 'N'), ('test', 'no', 'z@y.com', 'N', 'Y');

SELECT * from `account`;

UPDATE `account`
SET username = 'modified'
WHERE username = 'test';

DELETE FROM `account` WHERE userID=2;
/*
end statements
*/

/*
test statements for character
*/
INSERT INTO `character` (name)
VALUES ('Sin'), ('Jamflex'), ('hannahmontana');

SELECT * from `character`;

UPDATE `character`
SET name = 'Hannah Montana'
WHERE name = 'hannahmontana';

DELETE FROM `character` WHERE name='Jamflex';

UPDATE `character`
SET charID = 2
WHERE charID = 3;
/*
end statements
*/

/*
test statements for item
*/
INSERT INTO `item` (name, description, value)
VALUES ('Sword of a Thousand Truths', 'Capable of killing that which has no life', 1024),
('Staff','An entirely ordinary stick', 5), ('Rock', 'It\'s a rock, you could throw it at someone I suppose', 1);

SELECT description
FROM `item`
WHERE `itemID` = 1;

SELECT * FROM item;

DELETE FROM item WHERE itemID=3;

UPDATE item
SET value = 2
WHERE itemID = 2;
/*
end statements
*/

/*
test statements for map
*/
INSERT INTO `map` (X, Y)
VALUES (10 ,20);

SELECT * FROM map;

UPDATE map
SET X = 1, Y = 1
WHERE mapID = 1;

INSERT INTO `map` (X, Y)
VALUES (1,2), (1,3), (1,4);

DELETE FROM `map` WHERE Y = 4;
/*
end statements
*/

/*
test statements for stats
*/
INSERT INTO `stats` (str, hp, stam, charID)
VALUES (10, 10, 10, 1), (10, 10, 10, 2);

SELECT * FROM stats;

UPDATE stats
SET stam = 20
WHERE charID = 1;

DELETE FROM `stats` WHERE charID = 2;
/*
end statements
*/

/*
test statements tile
*/
INSERT INTO `tile` (itemID, mapID)
VALUES (1, 1), (2, 2), (3, 3);

SELECT * from tile;

UPDATE tile
SET itemID = 2
WHERE mapID = 3;

DELETE FROM tile WHERE tileID = 3;
/*
end statements
*/