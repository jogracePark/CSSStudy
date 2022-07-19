# 날짜 : 2022/07/19
# 이름 : 박은총
# 내용 : SQL 확인문제

CREATE TABLE `tbl_member`(
	`memberID` VARCHAR(10) PRIMARY KEY,
	`memberName` VARCHAR(10) NOT NULL,
	`memberHp` CHAR(13) UNIQUE DEFAULT NULL,
	`memberAge` INT DEFAULT NULL,
	`memberAddr` CHAR(20) DEFAULT NULL
);

CREATE TABLE `tbl_product`(
	`productCode` INT AUTO_INCREMENT PRIMARY key,
	`productName` VARCHAR(10) NOT null,
	`price` INT NOT null,
	`amount` INT NOT NULL DEFAULT 0,
	`company` VARCHAR(10) DEFAULT NULL,
	`makeDate` DATE DEFAULT NULL
);

INSERT INTO `tbl_member` VALUES('p101','김유신','010-1234-1001',25,'신라');
INSERT INTO `tbl_member` VALUES('p102','김춘추','010-1234-1002',23,'신라');
INSERT INTO `tbl_member` VALUES('p103','장보고',NULL,31,'통일신라');
INSERT INTO `tbl_member` VALUES('p104','강감찬',NULL,NULL,'고려');
INSERT INTO `tbl_member` VALUES('p105','이순신','010-1234-1005',50,NULL);


INSERT INTO `tbl_product` VALUES(NULL,'냉장고', 800,10,'LG','2022-01-06');
INSERT INTO `tbl_product` VALUES(NULL,'노트북', 1200,20,'삼성','2022-01-06');
INSERT INTO `tbl_product` VALUES(NULL,'TV', 1400,6,'LG','2022-01-06');
INSERT INTO `tbl_product` VALUES(NULL,'세탁기', 1000,8,'LG','2022-01-06');
INSERT INTO `tbl_product` VALUES(NULL,'컴퓨터', 1100,0,NULL,NULL);
INSERT INTO `tbl_product` VALUES(NULL,'휴대폰', 900,102,'삼성','2022-01-06');

SELECT `memberName` FROM `tbl_member`;
SELECT `memberName`, `memberHp` FROM `tbl_member`;
SELECT * FROM `tbl_member` WHERE `memberID` = 'p102';
SELECT * FROM `tbl_member` WHERE `memberID` = 'p104' OR `memberID` = 'p105';
SELECT * FROM `tbl_member` WHERE `memberAddr` = '신라';
SELECT * FROM `tbl_member` WHERE `memberAge` = '30';
SELECT * FROM `tbl_member` WHERE `memberHp` IS NULL;
UPDATE `tbl_member` SET `memberAge` = 42 WHERE `memberID` = 'p104';
DELETE FROM `tbl_member` WHERE `memberID` = 'p103';
SELECT * FROM `tbl_member`;

SELECT `productName` FROM `tbl_product`;
SELECT `productName`, `price` FROM `tbl_product`;
SELECT * FROM `tbl_product` WHERE `company` = 'LG';
SELECT * FROM `tbl_product` WHERE `company` = '삼성';
UPDATE `tbl_product` SET `company` = '삼성', `makeDate` = '2021-01-01' WHERE `memberID` = 'p104';
SELECT * FROM `tbl_product`;