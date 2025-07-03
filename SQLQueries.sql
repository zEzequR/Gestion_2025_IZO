CREATE TABLE Usuarios(
id_usuario INT PRIMARY KEY,
usuario nvarchar(20),
psw int
);

CREATE TABLE Proveedores(
id_proveedor INT PRIMARY KEY,
razon_social NVARCHAR(60)
);

CREATE TABLE items(
id_items INT PRIMARY KEY,
descipcion NVARCHAR(60),
precio DECIMAL(18,2),
stock DECIMAL(18,2),
id_proveedor INT FOREIGN KEY REFERENCES Proveedores(id_proveedor)
);

--CARGA USUARIOS
INSERT INTO Usuarios(id_usuario, usuario, psw)
Values(1, 'admin', 123), (2, 'Ventas', 456);
--CARGA PROVEEDORES
INSERT INTO Proveedores(id_proveedor, razon_social)
Values(1, 'Sancor'), (2, 'La Serenísima');
--CARGA ITEMS
INSERT INTO items(id_items, descipcion, precio, stock, id_proveedor)
Values(1, 'Dulce de leche', 5000, 10, 1), (2, 'Manteca', 3000, 10, 1), (3, 'Dulce de leche', 4500, 10, 2);

select * from Usuarios
select * from Proveedores
select * from items

--ACTUALIZAR REGISTROS
UPDATE items
SET precio = 3000 WHERE id_items = 2

--BORRAR REGISTROS

DELETE Proveedores WHERE id_proveedor

--SELECT TABLA [PERSONALIZADA]
CREATE VIEW vw_items_prod
AS
SELECT descipcion, precio, stock, razon_social from items
INNER JOIN Proveedores on items.id_proveedor = Proveedores.id_proveedor

SELECT * FROM vw_items_prod

--PROCEDIMIENTOS ALMACENADOS
-MUESTRA DATOS DE LAS 2 TABLAS
CREATE PROCEDURE spu_items_prov
AS
SELECT descipcion, precio, stock, razon_social from items
INNER JOIN Proveedores on items.id_proveedor = Proveedores.id_proveedor

EXECUTE spu_items_prov


--SP CARGA DE DATOS
CREATE PROCEDURE spu_alta_prov
@id_proveedor INT,
@razon_social NVARCHAR(60)
AS
INSERT INTO Proveedores
VALUES(@id_proveedor, @razon_social)


EXECUTE spu_alta_prov 3, 'Ilolay'

--SP ELIMINAR REGISTROS
CREATE PROCEDURE spu_baja_prov
@id_proveedor INT
AS
DELETE FROM Proveedores WHERE id_proveedor = @id_proveedor

EXECUTE spu_baja_prov 3

--ACTUALIZAR PROV

CREATE PROCEDURE spu_cambiar_precio
@id_item INT,
@precio DECIMAL(18,2)
AS
UPDATE items SET precio = @precio WHERE id_items = @id_item

EXECUTE spu_cambiar_precio 2, 3000

SELECT * FROM items

CREATE PROCEDURE spu_mostrar_prov
AS
SELECT * FROM Proveedores

CREATE PROCEDURE spu_mostrar_items
AS
SELECT * FROM items

EXEC spu_mostrar_items

SELECT * FROM Proveedores

CREATE PROCEDURE spu_cambiar_prov
@idprov INT,
@rzn_social NVARCHAR(60)
AS
UPDATE Proveedores SET razon_social = @rzn_social WHERE id_proveedor = @idprov