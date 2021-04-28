INSERT INTO PRODUCT(ID_PRODUCT, nameProduct, priceProduct, storageProduct, lastModifiet, productActive, deleteProduct)
VALUES	(100,'moto', 6.999, 5, '2000-03-30', 0, 0),
		(101,'montacarga', 12.999, 5, '2001-03-30', 0, 0),
		(102,'bicicleta', 3.999, 7, '2000-12-31', 1, 0),
		(103,'cuatrimoto', 13.999, 7, '2000-12-31', 1, 0),
		(104,'camioneta', 33.999, 7, '2000-12-31', 1, 0),
		(105,'bus', 63.999, 7, '2000-12-31', 1, 0)

INSERT INTO CLIENT(ID_CLIENT, firstNameClient, lastNameCLient, dateBirth, numberPhone, emailAddress, lastModifiet, deleteClient)
VALUES  (10989607,'Carlos', 'Pabon', '1980-12-31', '100', 'cliente@gmail.com', '2000-03-30', 0),
		(10989698,'Daniel', 'Jaimes', '1980-12-31', '101', 'cliente2@gmail.com', '2000-12-31', 0)


INSERT INTO INVOICE(ID_INVOICE, FK_ID_CLIENT, saleDate, comments, lastModifiet, deleteInvoice)
VALUES  (9999, 10989607, '1998-03-30', 'Factura 1 creada con exito', '1998-03-30', 0),
		(9998, 10989607,'1999-03-30', 'Factura 2 creada con exito', '1999-03-30', 0),
		(9997, 10989698,'2000-03-30', 'Factura 3 creada con exito', '2000-03-30', 0),
		(9996, 10989698,'2000-12-31', 'Factura 4 creada con exito', '2000-12-31', 0)

INSERT INTO SALE(FK_ID_PRODUCT, FK_ID_INVOICE)
VALUES  (101, 9997),
		(102, 9997),
		(103, 9996),
		(104, 9999)





