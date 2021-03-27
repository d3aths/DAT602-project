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
      `admin` varchar(1) DEFAULT 'N',
      `locked` varchar(1) DEFAULT 'Y',
	  PRIMARY KEY (`userID`),
      UNIQUE (`username`, `email`)
	) ;

CREATE TABLE `item` (
    `itemID` int NOT NULL AUTO_INCREMENT,
    `name` varchar(30) DEFAULT NULL,
    `description` varchar(250) DEFAULT NULL,
    `value` int DEFAULT NULL,
    PRIMARY KEY (`itemID`)
    ) ;

CREATE TABLE `character` (
	  `charID` int NOT NULL AUTO_INCREMENT,
	  `name` varchar(20) DEFAULT NULL,
	  `userID` int DEFAULT NULL,
      `itemID` int DEFAULT NULL,
	  PRIMARY KEY (`charID`),
	  FOREIGN KEY (`userID`) REFERENCES `account` (`userID`),
      FOREIGN KEY (`itemID`) REFERENCES `item` (`itemID`),
      UNIQUE (`name`)
	) ;
    
CREATE TABLE `map` (
    `mapID` int NOT NULL AUTO_INCREMENT,
    `X` int DEFAULT NULL,
    `Y` int DEFAULT NULL,
    PRIMARY KEY (`mapID`)
    ) ;
    
CREATE TABLE `tile` (
    `tileID` int NOT NULL AUTO_INCREMENT,
    `itemID` int DEFAULT NULL,
    `mapID` int DEFAULT NULL,
    PRIMARY KEY (`tileID`),
    FOREIGN KEY (`itemID`) REFERENCES `item` (`itemID`) ,
    FOREIGN KEY (`mapID`) REFERENCES `map` (`mapID`) 
    ) ;
    
CREATE TABLE `stats` (
    `charID` int DEFAULT NULL,
    `str` int DEFAULT NULL,
    `hp` int DEFAULT NULL,
    `stam` int DEFAULT NULL,
    FOREIGN KEY (`charID`) REFERENCES `character` (`charID`)
    ) ;
END //
delimiter ;

call createGameData();