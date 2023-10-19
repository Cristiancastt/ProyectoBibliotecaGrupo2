IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = 'biblioteca')
BEGIN
    DROP DATABASE biblioteca;
END

CREATE DATABASE biblioteca;
USE biblioteca;

CREATE TABLE biblioteca (
    biblioteca_id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    lugar VARCHAR(255),
    imagen VARCHAR(255)
);


CREATE TABLE categorias (
    categoria_id INT IDENTITY(1,1) PRIMARY KEY,
    descripcion VARCHAR(255) NOT NULL
);


CREATE TABLE autores (
    autor_id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL
);


CREATE TABLE libros (
    isbn VARCHAR(13) PRIMARY KEY,
    titulo VARCHAR(255) NOT NULL,
    editorial VARCHAR(255),
    sinopsis TEXT,
    caratula VARCHAR(255),
    cantidad_unidades INT NOT NULL,
    prestable BIT NOT NULL,
    biblioteca_id INT,
    FOREIGN KEY (biblioteca_id) REFERENCES biblioteca (biblioteca_id)
);


CREATE TABLE libros_categorias (
    isbn VARCHAR(13),
    categoria_id INT,
    FOREIGN KEY (isbn) REFERENCES libros (isbn),
    FOREIGN KEY (categoria_id) REFERENCES categorias (categoria_id)
);


CREATE TABLE libros_autores (
    isbn VARCHAR(13),
    autor_id INT,
    FOREIGN KEY (isbn) REFERENCES libros (isbn),
    FOREIGN KEY (autor_id) REFERENCES autores (autor_id)
);


CREATE TABLE lectores (
    carnet INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    contraseña VARCHAR(255) NOT NULL,
    telefono VARCHAR(15),
    email VARCHAR(255)
);


CREATE TABLE prestamos (
    prestamo_id INT IDENTITY(1,1) PRIMARY KEY,
    carnet INT,
    isbn VARCHAR(13),
    fecha_prestamo DATE NOT NULL,
    fecha_devolucion DATE,
    FOREIGN KEY (carnet) REFERENCES lectores (carnet),
    FOREIGN KEY (isbn) REFERENCES libros (isbn)
);


CREATE TABLE morosos (
    carnet INT,
    isbn VARCHAR(13),
    fecha_devolucion_esperada DATE,
    FOREIGN KEY (carnet) REFERENCES lectores (carnet),
    FOREIGN KEY (isbn) REFERENCES libros (isbn)
);
