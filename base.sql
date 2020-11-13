USE boxCatering;

CREATE TABLE users(
	ID_USER INT IDENTITY(1,1) PRIMARY KEY,
	USER_LOGIN VARCHAR(50),
	USER_PASSWORD VARCHAR(50),
	USER_EMAIL VARCHAR(100),
	IS_ADMIN BIT
)

CREATE TABLE customers(
	ID_CUSTOMER INT IDENTITY(1,1) PRIMARY KEY,
	CUSTOMER_NAME VARCHAR(50),
	CUSTOMER_SURNAME VARCHAR(50),
	CUSTOMER_EMAIL VARCHAR(100),
	CUSTOMER_ADDRESS VARCHAR(100),
	CUSTOMER_POSTCODE INT,
	CUSTOMER_CITY VARCHAR(50),
	CUSTOMER_PHONE INT
)

CREATE TABLE cards(
	ID_CARD INT IDENTITY(1,1) PRIMARY KEY,
	CARD_NUMBER BIGINT,
	CARD_EXPDATE INT,
	CARD_CCV INT
)

CREATE TABLE diets(
	ID_DIET INT IDENTITY(1,1) PRIMARY KEY,
	DIET_NAME VARCHAR(50),	
	DIET_CALORIES INT,
	DIET_COST INT,
	DIET_DESC VARCHAR(150),
)


CREATE TABLE orders(
	ID_ORDER INT IDENTITY(1,1) PRIMARY KEY,
	ID_CUSTOMER INT,
	ID_DIET INT,
	ID_CARD INT
)

select * from dbo.users where USER_LOGIN = 'user1' AND USER_PASSWORD = 'user2fe'
select * from dbo.customers where ID_CUSTOMER = '24'
select * from dbo.customers
select * from dbo.cards
select * from dbo.diets
select * from dbo.orders

INSERT INTO dbo.users VALUES ('Luasek','zaq1@WSX','email@gmail.com','1')
INSERT INTO dbo.customers VALUES ('£ukasz','Wolsza','lukasz@gmail.com','Warszawska 2','00100','Warszawa','123456789')
INSERT INTO dbo.customers VALUES ('£ukasz','Wolsza','lukasz@gmail.com','Warszawska 2','00100','Warszawa','123456789')

SELECT SCOPE_IDENTITY();

INSERT INTO dbo.cards VALUES ('1111','1111','11132')
INSERT INTO dbo.diets VALUES
	('2000kcal Diet','2000','300','A balanced diet which include 2000kcal'),
	('2500kcal Diet','2500','350','A balanced diet which include 2500kcal'),
	('3000kcal Diet','3000','400','A balanced diet which include 3000kcal'),
	('Vegan Diet','2700','360','A diet for vegans, doesnt contain animal products and meat'),
	('Keto Diet','2300','350','A keto diet is based on protein, fat and small amount of carbs'),
	('Vegatarian Diet','2500','300','A diet which doesnt contain meat')