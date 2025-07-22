-- Crear la base de datos
CREATE DATABASE Biblioteca1;

-- Seleccionar la base de datos a usar
USE Biblioteca1;

-- Crear la tabla de usuarios
CREATE TABLE usuarios (
    idlector INT PRIMARY KEY,
    apellidos VARCHAR(100),
    nombre VARCHAR(100)
);

-- Insertar registros en la tabla de usuarios
-- Insertar registros en la tabla de usuarios
INSERT INTO usuarios (idlector, apellidos, nombre) VALUES
(1, 'Garc�a', 'Carlos'),
(2, 'P�rez', 'Ana');

-- Crear la tabla de proveedores
CREATE TABLE proveedores (
    nif VARCHAR(20) PRIMARY KEY,  -- nif como clave primaria
    empresa VARCHAR(255),
    direccion VARCHAR(255)
);

-- Insertar registros en la tabla de proveedores
INSERT INTO proveedores (nif, empresa, direccion) VALUES
('A12345678', 'Editorial XYZ', 'Calle Ficticia 123, Madrid'),
('B98765432', 'Librer�a ABC', 'Avenida Libertad 456, Barcelona');


-- Crear la tabla de libros pedidos
CREATE TABLE libros_pedidos (
    id_documento INT PRIMARY KEY,     -- ID �nico del documento
    titulo VARCHAR(255),              -- T�tulo del libro
    autores VARCHAR(255),             -- Autores del libro
    solicitado_por INT,               -- Relaci�n con el idlector de la tabla usuarios
    proveedor VARCHAR(20),            -- Relaci�n con el nif del proveedor
    precio DECIMAL(10, 2),            -- Precio del libro
    FOREIGN KEY (solicitado_por) REFERENCES usuarios(idlector),  -- Relaci�n con la tabla usuarios
    FOREIGN KEY (proveedor) REFERENCES proveedores(nif)          -- Relaci�n con la tabla proveedores
);

-- Insertar registros en la tabla de libros pedidos
INSERT INTO libros_pedidos (id_documento, titulo, autores, solicitado_por, proveedor, precio) VALUES
(1, 'La sombra del viento', 'Carlos Ruiz Zaf�n', 1, 'A12345678', 19.95),
(2, 'Cien a�os de soledad', 'Gabriel Garc�a M�rquez', 2, 'B98765432', 15.50);

SELECT * FROM usuarios;
SELECT * FROM proveedores;
SELECT * FROM libros_pedidos;

