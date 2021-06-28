drop database if exists game;
create database game;
use game;

DROP PROCEDURE IF EXISTS createGameData;
delimiter //
CREATE PROCEDURE createGameData()
BEGIN
 CREATE TABLE `account` (
	  `userID` int NOT NULL AUTO_INCREMENT,
	  `username` varchar(20) DEFAULT NULL,
	  `password` varchar(50) DEFAULT NULL,
      `email` varchar(50) DEFAULT NULL,
      `status` varchar(10) DEFAULT "Offline",
      `admin` varchar(1) DEFAULT 'N',
      `locked` varchar(1) DEFAULT 'N',
      `attempts` int DEFAULT 0,
      `itemID` int DEFAULT NULL,
      `x` int DEFAULT 0,
      `y` int DEFAULT 0,
	  PRIMARY KEY (`userID`),
      UNIQUE (`username`, `email`)
	) ;

 CREATE TABLE `item` (
    `itemID` int NOT NULL AUTO_INCREMENT,
    `name` varchar(30) DEFAULT NULL,
    `description` varchar(250) DEFAULT NULL,
    `value` int DEFAULT NULL,
    `userID` int,
    PRIMARY KEY (`itemID`),
    FOREIGN KEY(`userID`) REFERENCES `account`(`userID`)
    ) ;
		
    
 CREATE TABLE `tile` (
    `tileID` int NOT NULL AUTO_INCREMENT,
    `itemID` int DEFAULT NULL,
    `x` int DEFAULT NULL,
    `y` int DEFAULT NULL,
    PRIMARY KEY (`tileID`),
    FOREIGN KEY (`itemID`) REFERENCES `item` (`itemID`)
    ) ;
    INSERT INTO `tile`(x, y)
    VALUES 
		(1,1), 
		(1,2),
		(1,3),
		(1,4),
		(1,5),
		(2,1), 
		(2,2),
		(2,3),
		(2,4),
		(2,5),
		(3,1), 
		(3,2),
		(3,3),
		(3,4),
		(3,5),
		(4,1), 
		(4,2),
		(4,3),
		(4,4),
		(4,5),
		(5,1), 
		(5,2),
		(5,3),
		(5,4),
		(5,5)
  ;
    
 CREATE TABLE `stats` (
    `userID` int DEFAULT NULL,
    `str` int DEFAULT NULL,
    `hp` int DEFAULT NULL,
    `stam` int DEFAULT NULL,
    `build` varchar(10) DEFAULT NULL,
    FOREIGN KEY (`userID`) REFERENCES `account` (`userID`)
    ) ;
	
 CREATE TABLE `character_type` (
	`build` varchar(10),
	`str` int DEFAULT NULL,
    `hp` int DEFAULT NULL,
    `stam` int DEFAULT NULL,
    PRIMARY KEY (`build`)
    ) ;
    INSERT INTO `character_type` (`build`,`str`,`hp`,`stam`) 
    VALUES ('Berserker',50,20,20), -- Berserker type
           ('Ninja',20,20,50),     -- Ninja type
           ('Tank',20,100,20);   -- Tank type
	ALTER TABLE `stats`
    ADD FOREIGN KEY (`build`) REFERENCES `character_type` (`build`);
 
END //
delimiter ;

call createGameData();
-- creates the game database tables

DROP procedure if exists   `addCheckedUser`;
DROP procedure if exists  AddUser;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddUser`(in pUsername varchar(20), in pPassword varchar(50))
    DETERMINISTIC
    COMMENT 'A procedure to create a new account'
BEGIN
 INSERT INTO account(username,password)
 VALUES (pUsername, pPassword);
 SELECT "addedUsername" as MESSAGE;
END$$
DELIMITER ;


SELECT * FROM account;
-- adds a new user then displays it using the procedure we just created

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addCheckedUser`(in pUsername varchar(20), in pPassword varchar(50))
    DETERMINISTIC
    COMMENT 'A procedure to check if the username is taken and if not then create account with it'
BEGIN
    DECLARE auserID  VARCHAR(255);
    
    SELECT userID 
	FROM `account`
    WHERE username = pUsername
    into auserID;
    
    IF auserID IS NULL THEN
		-- INSERT
        CALL AddUser(pUsername, pPassword);
		SELECT 'Success (added user name and password)' as Success, pUsername as Username;
	ELSE
		SELECT 'Failed name taken' as Success;
	END IF;
    
END$$
DELIMITER ;

-- procedure checks if an entered username and password already exists, if it does, displays error. if it does not exist, creates it

-- TESTING
-- CALL addCheckedUser('Phot', '123124');
-- CALL addCheckedUser('Todd', '123123');
    
-- DROP procedure if exists createChar;
-- DELIMITER $$
-- CREATE DEFINER=`root`@`localhost` PROCEDURE createChar(in cName varchar(20), in cUserID int)
--     DETERMINISTIC
--     COMMENT 'A procedure to create a new character on the account that was last created'
-- BEGIN
--  SELECT @last := LAST_INSERT_ID();
--  INSERT INTO `character`(name, userID) VALUES
--   (cName, @last);
--   
--   UPDATE account
--   SET charID=userID;
-- END$$
-- DELIMITER ;

-- uses lastinsertID from the last account that was created, to provide the foreign key linking tables.
-- deprecating this procedure for now but leaving it in incase referencing or anything is needed


DROP procedure if exists DelAcc;
	DELIMITER $$
	CREATE DEFINER=`root`@`localhost` PROCEDURE DelAcc(in aUserID int)
		DETERMINISTIC
		COMMENT 'A procedure to delete an account'
BEGIN
	DELETE FROM account WHERE userID = aUserID;
    SELECT 'account deleted' as Message;
END$$
DELIMITER ;


DROP procedure if exists ShowPlayers;
	DELIMITER $$
	CREATE DEFINER=`root`@`localhost` PROCEDURE ShowPlayers()
		DETERMINISTIC
		COMMENT 'A procedure to display a list of player\'s statuses'
BEGIN
		SELECT SUM(IF(status = 'Online', 1, 0)) AS 'Online Players' FROM account;
		SELECT SUM(IF(status = 'Offline', 1, 0)) AS 'Offline Players' FROM account;
		-- SELECT username, IF(status = "Online", "Online", "Offline") AS 'Player Status'
        -- FROM account;
		-- SELECT username AS 'Online Players' FROM account WHERE status = 'Online';
END$$
DELIMITER ;


DROP procedure if exists pickClass;
	DELIMITER $$
	CREATE DEFINER=`root`@`localhost` PROCEDURE pickClass(in pUserID int, in pBuild varchar(10) )
		DETERMINISTIC
		COMMENT 'A procedure that chooses from a stat template for the player'
BEGIN
	SELECT `build` ,`str`, `hp` ,`stam`
    INTO 
         @build, @str, @hp, @stam
	FROM `character_type`
    WHERE
           `build` = pBuild;
     
	IF NOT EXISTS (
				   SELECT * 
				   FROM Account 
				    WHERE `userID` IN (SELECT `userID` FROM `stats` WHERE `userID` = pUserID)
                    -- looking if the userid in account is in stats as the parameter we write when calling
				   ) THEN
		INSERT INTO `stats`(`userID`,`build` ,`str`, `hp` ,`stam`)
		VALUE (pUserID,@build,@str,@hp,@stam);
        SELECT "Build chosen" AS Message;
-- 	ELSE
--         UPDATE `stats`
--         SET `build` = @build ,
--             `str` = @str,
--             `hp` = @hp ,
--             `stam` = @stam
-- 		WHERE
--             `userID` = pUserID;
--               updates stats using same proc, useful for levelling up ?
	END IF;
           
END$$
DELIMITER ;


-- what needs to happen here =>
-- before entering game
-- get loggedin userID
-- 	if account.userID doesnt exist in stats tables then
--     display builds
--     if click build1 then load build1 > proc1
--     else if click build2 then load build2 > proc2
--     else if click build3 then load build3 > proc3
--     else display alert "please select a build"


DROP procedure if exists Move;
	DELIMITER $$
	CREATE DEFINER=`root`@`localhost` PROCEDURE Move(in dUserID int, in pX int, in pY int)
		DETERMINISTIC
		COMMENT 'A procedure to move player'
BEGIN

	IF NOT EXISTS (
				   SELECT * 
				   FROM Account 
				    WHERE pX = `x` AND pY = `y`
				   ) THEN
		UPDATE `account`
		SET `x` = pX,
			`y` = pY
        WHERE `userID` = dUserID;
        SELECT "User moved" AS Message;
	ELSE
		SELECT "This tile is occupied, choose another location" AS Message;
	END IF;
        
END$$
DELIMITER ;


DROP procedure if exists EditAcc;
	DELIMITER $$
	CREATE DEFINER=`root`@`localhost` PROCEDURE EditAcc(in eUserID int, in field varchar(50), in param varchar(50))
		DETERMINISTIC
		COMMENT 'A procedure to edit the details on a user\'s account'
BEGIN
		IF (field = 'username') THEN
			UPDATE `account`
            SET `username` = param
            WHERE `userID` = eUserID;
            SELECT "Updated username" AS Message;
		ELSEIF (field = 'password') THEN
			UPDATE `account`
            SET `password` = param
            WHERE `userID` = eUserID;
            SELECT "Updated password" AS Message;
		ELSEIF (field = 'email') THEN
			UPDATE `account`
            SET `email` = param
            WHERE `userID` = eUserID;
            SELECT "Updated email" AS Message;
		ELSEIF (field = 'admin') THEN
			UPDATE `account`
            SET `admin` = param
            WHERE `userID` = eUserID;
            SELECT "Updated admin status" AS Message;
		ELSEIF (field = 'locked') THEN
			UPDATE `account`
            SET `locked` = param
            WHERE `userID` = eUserID;
            SELECT "Updated locked status" AS Message;
		ELSEIF (field = 'attempts') THEN
			UPDATE `account`
            SET `attempts` = param
            WHERE `userID` = eUserID;
            SELECT "Updated attempts status" AS Message;
		ELSEIF (field = 'status') THEN
			UPDATE `account`
            SET `status` = param
            WHERE `userID` = eUserID;
            SELECT "Updated online status" AS Message;
		ELSE 
			SELECT "Please enter valid parameters" as Message;
		END IF;
END$$
DELIMITER ;

drop procedure if exists checkUser;
delimiter $$
create procedure checkUser(in pName varchar(20))
begin
    declare proposedUID int default null;
  
	select `userID` 
	from 
		`account`
	where 
		 `username` = pName
	 into proposedUID;
     
     if proposedUID is NULL then
         select 'No user exists' as 'Message', -1 as `ID`;
	 else
		select 'User already in database' as 'Message', proposedUID as `ID`;
	 end if;
     
end $$
delimiter ;

DELIMITER $$
CREATE PROCEDURE LockOut(In pName varchar(20))
BEGIN
  UPDATE account
  SET locked = 'Y'
  WHERE 
     username = pName;
     
END$$

CREATE PROCEDURE CheckLogin(In pName varchar(20), in pPass varchar(50))
BEGIN

    SELECT locked
    FROM account
    WHERE 
         username = pName
	INTO @IsLocked;
    
    IF @IsLocked = 'Y' THEN
      SELECT 'This account is LOCKED, email celeste.quinn@live.nmit.ac.nz' as `Message`;
    ELSE
    
		SELECT userID
		FROM account
		WHERE
				username = pName AND 
				password = pPass
		INTO @Result;

		IF @Result IS NULL THEN
		  UPDATE account
		  SET attempts = attempts + 1
		  WHERE username = pName;
		  
		  SELECT attempts 
		  FROM account
		  WHERE username = pName
		  INTO @AttemptCount;
		  
		  If @AttemptCount >= 5 THEN
		  
			Call LockOut(pName);
			SELECT 'Is Locked OUT' AS `Message`;
		  ELSE
			 SELECT 'BAD LOGIN' as `Message`;
		  END IF;
		  
		  
		ELSE
			UPDATE account
            SET attempts = 0
            WHERE
               username = pName;
               
            SELECT 'Successful LOGIN' as `Message`;
		END IF;
   END IF;
END$$

SELECT * FROM stats;	
-- Call AddUser('celeste', 'no')
-- Call CheckLogin('celeste', 'no')

-- Call delAcc(2);

-- this should work like
-- call editAcc(1, 'username', 'hannah')
-- ID that you want to change the record of > field you want to change > what you want to update it to