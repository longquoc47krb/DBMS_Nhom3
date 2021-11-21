CREATE TABLE Customer
(
  Customer_Name VARCHAR(50) NOT NULL,
  PhoneNumber VARCHAR(50) NOT NULL,
  ID_customer INT NOT NULL,
  VIP INT NULL,
  PRIMARY KEY (ID_customer)
);

CREATE TABLE Staff
(
  username VARCHAR(50) NOT NULL,
  password VARCHAR(50) NOT NULL,
  Name_Staff VARCHAR(50) NOT NULL,
  Phone VARCHAR(50) NOT NULL,
  Address VARCHAR(50) NOT NULL,
  Posision VARCHAR(50) NOT NULL,
  Gender VARCHAR(50) NOT NULL,
  PRIMARY KEY (username)
);

CREATE TABLE CongTySX
(
  ID_company INT NOT NULL,
  Company_name VARCHAR(50) NOT NULL,
  address VARCHAR(50) NOT NULL,
  PRIMARY KEY (ID_company)
);

CREATE TABLE Product
(
  Name_product VARCHAR(50) NOT NULL,
  ID_product INT NOT NULL,
  Price INT NOT NULL,
  ID_company INT NOT NULL,
  warranty_month INT NULL,
  PRIMARY KEY (ID_product),
  FOREIGN KEY (ID_company) REFERENCES CongTySX(ID_company)
);

CREATE TABLE Transactions
(
  ID_transaction INT NOT NULL,
  Total_price INT NOT NULL,
  Dates  DATE NOT NULL,
  ID_customer INT NOT NULL,
  username VARCHAR(50) NOT NULL,
  PRIMARY KEY (ID_transaction),
  FOREIGN KEY (ID_customer) REFERENCES Customer(ID_customer),
  FOREIGN KEY (username) REFERENCES Staff(username)
);

CREATE TABLE Transaction_Details
(
  quantity INT NOT NULL,
  ID_transaction INT NOT NULL,
  ID_product INT NOT NULL,
  PRIMARY KEY (ID_transaction, ID_product),
  FOREIGN KEY (ID_transaction) REFERENCES Transactions(ID_transaction),
  FOREIGN KEY (ID_product) REFERENCES Product(ID_product)
);