DELETE FROM morosos;
DELETE FROM prestamos;
DELETE FROM lectores;
DELETE FROM libros_categorias;
DELETE FROM libros_autores;
DELETE FROM libros;
DELETE FROM autores;
DELETE FROM categorias;
DELETE FROM biblioteca;

INSERT INTO biblioteca (nombre, lugar, imagen) VALUES
    ('Biblioteca A', 'Ciudad A', 'imagen1.jpg');



INSERT INTO categorias (descripcion) VALUES
    ('Ficción'),
    ('No ficción'),
    ('Historia'),
    ('Ciencia'),
    ('Misterio');

INSERT INTO autores (nombre) VALUES
    ('Autor 1'),
    ('Autor 2'),
    ('Autor 3'),
    ('Autor 4'),
    ('Autor 5');


INSERT INTO libros (isbn, titulo, editorial, sinopsis, caratula, cantidad_unidades, prestable, biblioteca_id) VALUES
    ('ISBN-123456', 'Libro 1', 'Editorial A', 'Sinopsis del Libro 1', 'caratula1.jpg', 10, 1, 1),
    ('ISBN-234567', 'Libro 2', 'Editorial B', 'Sinopsis del Libro 2', 'caratula2.jpg', 8, 1, 1),
    ('ISBN-345678', 'Libro 3', 'Editorial C', 'Sinopsis del Libro 3', 'caratula3.jpg', 12, 1, 2),
    ('ISBN-456789', 'Libro 4', 'Editorial D', 'Sinopsis del Libro 4', 'caratula4.jpg', 7, 1, 2),
    ('ISBN-567890', 'Libro 5', 'Editorial E', 'Sinopsis del Libro 5', 'caratula5.jpg', 15, 1, 3);

INSERT INTO libros_categorias (isbn, categoria_id) VALUES
    ('ISBN-123456', 1),
    ('ISBN-234567', 2),
    ('ISBN-345678', 1),
    ('ISBN-456789', 3),
    ('ISBN-567890', 2);


INSERT INTO libros_autores (isbn, autor_id) VALUES
    ('ISBN-123456', 1),
    ('ISBN-234567', 2),
    ('ISBN-345678', 3),
    ('ISBN-456789', 4),
    ('ISBN-567890', 5);


INSERT INTO lectores (nombre, contraseña, telefono, email) VALUES
    ('Lector 1', 'contraseña1', '123-456-7890', 'lector1@example.com'),
    ('Lector 2', 'contraseña2', '987-654-3210', 'lector2@example.com'),
    ('Lector 3', 'contraseña3', '555-555-5555', 'lector3@example.com'),
    ('Lector 4', 'contraseña4', '111-222-3333', 'lector4@example.com'),
    ('Lector 5', 'contraseña5', '999-888-7777', 'lector5@example.com');


INSERT INTO prestamos (carnet, isbn, fecha_prestamo, fecha_devolucion) VALUES
    (1, 'ISBN-123456', '2023-01-15', '2023-01-30'),
    (2, 'ISBN-234567', '2023-02-10', '2023-02-25'),
    (3, 'ISBN-345678', '2023-03-05', '2023-03-20'),
    (4, 'ISBN-456789', '2023-04-15', '2023-04-30'),
    (5, 'ISBN-567890', '2023-05-10', '2023-05-25');


INSERT INTO morosos (carnet, isbn, fecha_devolucion_esperada) VALUES
    (1, 'ISBN-123456', '2023-01-30'),
    (2, 'ISBN-234567', '2023-02-25'),
    (3, 'ISBN-345678', '2023-03-20'),
    (4, 'ISBN-456789', '2023-04-30'),
    (5, 'ISBN-567890', '2023-05-25');
