# 날짜 : 2022/07/19
# 이름 : 박은총
# 내용 : 데이터베이스 관리

#실습하기 3-1
CREATE DATABASE `TigerDB`;
CREATE USER 'tiger'@'%' IDENTIFIED BY '1234';
GRANT ALL PRIVILEGES ON TigerDB.* TO 'tiger'@'%'; # tiger 계정에 TigerDB.*(타이거db의 모든권한)을 주겠다
FLUSH PRIVILEGES;

#실습하기 3-2
SET PASSWORD FOR 'tiger'@'%' = PASSWORD('12345');
DROP USER 'tiger'@'%';

#실습하기 3-3