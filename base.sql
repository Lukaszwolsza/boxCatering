USE boxCatering;

CREATE TABLE users(
	ID_USER INT IDENTITY(1,1) PRIMARY KEY,
	USER_LOGIN VARCHAR(50),
	USER_PASSWORD VARCHAR(50),
	USER_EMAIL VARCHAR(100),
	IS_ADMIN BIT
)

select * from dbo.users where USER_LOGIN = 'user1' AND USER_PASSWORD = 'user2fe'

INSERT INTO dbo.users VALUES ('Luasek','zaq1@WSX','email@gmail.com','1')