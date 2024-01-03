USE master;

-- Intenta eliminar la base de datos si existe
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'bibliotecaG2')
BEGIN
    ALTER DATABASE bibliotecaG2 SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE bibliotecaG2;
END
GO -- Agrega un GO aquí para separar los lotes

-- Crea la base de datos
CREATE DATABASE bibliotecaG2;
GO -- Agrega otro GO aquí

-- Cambia al contexto de la nueva base de datos
USE bibliotecaG2;
GO -- Agrega otro GO aquí

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
    );


    CREATE TABLE libros_categorias (
        isbn VARCHAR(13) not null,
        categoria_id INT not null,
        FOREIGN KEY (isbn) REFERENCES libros (isbn),
        FOREIGN KEY (categoria_id) REFERENCES categorias (categoria_id)
    );


    CREATE TABLE libros_autores (
        isbn VARCHAR(13) not null,
        autor_id INT not null,
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

    ALTER TABLE libros_categorias
    ADD CONSTRAINT PK_LibrosCategorias PRIMARY KEY (isbn, categoria_id);


    ALTER TABLE libros_autores
    ADD CONSTRAINT PK_LibrosAutores PRIMARY KEY (isbn, autor_id);
