use bibliotecaG2
DELETE FROM morosos;
DELETE FROM prestamos;
DELETE FROM lectores;
DELETE FROM libros_categorias;
DELETE FROM libros_autores;
DELETE FROM libros;
DELETE FROM autores;
DELETE FROM categorias;
DELETE FROM biblioteca;


DBCC CHECKIDENT ('biblioteca', RESEED, 0);
DBCC CHECKIDENT ('categorias', RESEED, 0);
DBCC CHECKIDENT ('autores', RESEED, 0);
DBCC CHECKIDENT ('lectores', RESEED, 0);
DBCC CHECKIDENT ('prestamos', RESEED, 0);

INSERT INTO biblioteca (nombre, lugar, imagen) VALUES ('Biblioteca Central', 'Ciudad Principal', 'imagen1.jpg');
INSERT INTO biblioteca (nombre, lugar, imagen) VALUES ('Biblioteca del Campus', 'Campus Universitario', 'imagen2.jpg');

INSERT INTO categorias (descripcion) VALUES ('Ficción');
INSERT INTO categorias (descripcion) VALUES ('No ficción');
INSERT INTO categorias (descripcion) VALUES ('Ciencia ficción');

INSERT INTO autores (nombre) VALUES ('J.K. Rowling');
INSERT INTO autores (nombre) VALUES ('George Orwell');
INSERT INTO autores (nombre) VALUES ('Isaac Asimov');

INSERT INTO libros (isbn, titulo, editorial, sinopsis, caratula, cantidad_unidades, prestable) 
VALUES ('9780545010221', 'Harry Potter y la Piedra Filosofal', 'Salamanca Editorial', 'Sinopsis del libro', 'caratula1.jpg', 50, 1);

INSERT INTO libros_categorias (isbn, categoria_id) VALUES ('9780545010221', 1); -- Asocia el libro a la categoría "Ficción"

INSERT INTO libros_autores (isbn, autor_id) VALUES ('9780545010221', 1); -- Asocia el libro con el autor J.K. Rowling

INSERT INTO lectores (nombre, contraseña, telefono, email) VALUES ('Juan Pérez', 'contraseña123', '555-123-4567', 'juan@example.com');
INSERT INTO lectores (nombre, contraseña, telefono, email) VALUES ('María González', 'clave456', '555-987-6543', 'maria@example.com');

INSERT INTO prestamos (carnet, isbn, fecha_prestamo, fecha_devolucion) 
VALUES (1, '9780545010221', '2023-10-20', '2023-11-10');

