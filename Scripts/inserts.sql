use bibliotecaG2
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

-- Inserts para biblioteca
INSERT INTO biblioteca (nombre, lugar, imagen) VALUES
('Biblioteca Nacional', 'Buenos Aires', 'imagen3.jpg'),
('Biblioteca Nacional de España', 'Madrid', 'imagen4.jpg'),
('Bibliothèque nationale de France', 'París', 'imagen5.jpg'),
('Library of Congress', 'Washington, D.C.', 'imagen6.jpg'),
('British Library', 'Londres', 'imagen7.jpg'),
('New York Public Library', 'Nueva York', 'imagen8.jpg'),
('National Library of China', 'Pekín', 'imagen9.jpg'),
('Russian State Library', 'Moscú', 'imagen10.jpg'),
('Library and Archives Canada', 'Ottawa', 'imagen11.jpg'),
('National Library of Australia', 'Canberra', 'imagen12.jpg');

-- Inserts para categorias
INSERT INTO categorias (descripcion) VALUES
('Novela'),
('Historia'),
('Ciencia'),
('Biografía'),
('Poesía'),
('Arte'),
('Tecnología'),
('Filosofía'),
('Economía'),
('Aventura');

-- Inserts para autores
INSERT INTO autores (nombre) VALUES
('Gabriel García Márquez'),
('Jane Austen'),
('Albert Einstein'),
('Leonardo da Vinci'),
('Emily Dickinson'),
('Pablo Picasso'),
('Bill Gates'),
('Sigmund Freud'),
('Adam Smith'),
('Jules Verne');

-- Inserts para libros
INSERT INTO libros (isbn, titulo, editorial, sinopsis, caratula, cantidad_unidades, prestable) VALUES
('1', 'Cien años de soledad', 'Random House', 'La novela cuenta la historia de la familia Buendía en el pueblo ficticio de Macondo.', 'ciendesoledad.jpg', 20, 1),
('2', 'Orgullo y prejuicio', 'Penguin Classics', 'La historia sigue la vida de Elizabeth Bennet y su relación con el apuesto Sr. Darcy.', 'orgulloprejuicio.jpg', 15, 1),
('3', 'Una breve historia del tiempo', 'Bantam Books', 'Exploración del tiempo, el espacio y el universo por el físico teórico Stephen Hawking.', 'brevehistoriat.jpg', 25, 1),
('4', 'El código Leicester', 'Dover Publications', 'El famoso cuaderno de Leonardo da Vinci que trata sobre diversos temas científicos y artísticos.', 'codigoleicester.jpg', 30, 1),
('5', 'Poemas completos de Emily Dickinson', 'Applewood Books', 'Colección completa de los poemas de Emily Dickinson.', 'poemasdickinson.jpg', 10, 1),
('6', 'Picasso: Blue and Rose Periods', 'Taschen', 'Exploración de las etapas azul y rosa en la obra de Pablo Picasso.', 'picassoperiods.jpg', 18, 1),
('7', 'The Road Ahead', 'Viking', 'Libro de Bill Gates sobre el impacto de la tecnología en el futuro.', 'roadahead.jpg', 22, 1),
('8', 'Introducción al psicoanálisis', 'Tomás Cabrera', 'Obra de Sigmund Freud que presenta sus ideas fundamentales sobre el psicoanálisis.', 'psicoanalisis.jpg', 17, 1),
('9', 'La riqueza de las naciones', 'Fondo de Cultura Económica', 'Obra clásica de Adam Smith sobre economía y libre mercado.', 'riquezanasiones.jpg', 28, 1),
('10', 'Veinte mil leguas de viaje submarino', 'Alianza Editorial', 'Aventuras submarinas escritas por el autor francés Jules Verne.', 'veintemilleguas.jpg', 12, 1);

-- Inserts para libros_categorias
INSERT INTO libros_categorias (isbn, categoria_id) VALUES
('1', 1), -- Asocia "Cien años de soledad" a la categoría "Novela"
('2', 1), -- Asocia "Orgullo y prejuicio" a la categoría "Novela"
('3', 3), -- Asocia "Una breve historia del tiempo" a la categoría "Ciencia"
('4', 6), -- Asocia "El código Leicester" a la categoría "Arte"
('5', 5), -- Asocia "Poemas completos de Emily Dickinson" a la categoría "Poesía"
('6', 6), -- Asocia "Picasso: Blue and Rose Periods" a la categoría "Arte"
('7', 7), -- Asocia "The Road Ahead" a la categoría "Tecnología"
('8', 8), -- Asocia "Introducción al psicoanálisis" a la categoría "Filosofía"
('9', 9), -- Asocia "La riqueza de las naciones" a la categoría "Economía"
('10', 10); -- Asocia "Veinte mil leguas de viaje submarino" a la categoría "Aventura"

-- Inserts para libros_autores
INSERT INTO libros_autores (isbn, autor_id) VALUES
('1', 1), -- Asocia "Cien años de soledad" con Gabriel García Márquez
('2', 2), -- Asocia "Orgullo y prejuicio" con Jane Austen
('3', 3), -- Asocia "Una breve historia del tiempo" con Albert Einstein
('4', 4), -- Asocia "El código Leicester" con Leonardo da Vinci
('5', 5), -- Asocia "Poemas completos de Emily Dickinson" con Emily Dickinson
('6', 6), -- Asocia "Picasso: Blue and Rose Periods" con Pablo Picasso
('7', 7), -- Asocia "The Road Ahead" con Bill Gates
('8', 8), -- Asocia "Introducción al psicoanálisis" con Sigmund Freud
('9', 9), -- Asocia "La riqueza de las naciones" con Adam Smith
('10', 10); -- Asocia "Veinte mil leguas de viaje submarino" con Jules Verne

-- Inserts adicionales para lectores
INSERT INTO lectores (nombre, contraseña, telefono, email) VALUES
('Ana Rodríguez', 'pass123', '555-555-5555', 'ana@example.com'),
('Carlos Sánchez', 'contraseña789', '555-111-2222', 'carlos@example.com'),
('Laura Martínez', 'clave1234', '555-333-4444', 'laura@example.com'),
('Miguel López', 'miclave', '555-666-7777', 'miguel@example.com'),
('Isabel Fernández', '123456', '555-888-9999', 'isabel@example.com'),
('Alejandro Gómez', 'alejandro123', '555-999-0000', 'alejandro@example.com'),
('Patricia García', 'contraseña456', '555-444-3333', 'patricia@example.com'),
('Ricardo Pérez', '12345', '555-777-8888', 'ricardo@example.com'),
('Carmen Torres', 'carmenclave', '555-222-1111', 'carmen@example.com'),
('Diego Ramos', 'diegopass', '555-666-3333', 'diego@example.com');

-- Inserts adicionales para prestamos
INSERT INTO prestamos (carnet, isbn, fecha_prestamo, fecha_devolucion) VALUES
(2, '1', '2023-10-22', '2023-11-15'),
(4, '2', '2023-10-25', '2023-11-18'),
(6, '3', '2023-10-28', '2023-11-21'),
(8, '4', '2023-11-01', '2023-11-24'),
(10, '5', '2023-11-04', '2023-11-27');



