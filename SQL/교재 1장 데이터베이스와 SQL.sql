# 날짜 : 2022/07/18
# 이름 : 박은총
# 내용 : 교재 1장 데이터베이스와 SQl:

CREATE TABLE `sample21` 
(
	`no` INT,
	`name` VARCHAR(10),
	birthday CHAR(10),
	`address` VARCHAR(100)
);

INSERT INTO `sample21` VALUES (1,'박용준' , '19776-0-18', '대구광역시 수성구');
INSERT INTO `sample21` VALUES (2,'박용준' , null, '대구광역시 수성구');
INSERT INTO `sample21` VALUES(3,'홍길동' , NULL, '서울특별시 마포구구');