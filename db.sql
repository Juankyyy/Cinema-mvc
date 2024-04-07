CREATE TABLE Menu (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(100) UNIQUE NOT NULL,
    Image VARCHAR(255) UNIQUE NOT NULL,
    Description VARCHAR(150) UNIQUE NOT NULL,
    Price INT NOT NULL,
    Category VARCHAR(100) NOT NULL
);

CREATE TABLE Movies (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(100) UNIQUE NOT NULL,
    Image VARCHAR(255) UNIQUE NOT NULL,
    Sinopsis VARCHAR(255) UNIQUE NOT NULL,
    Rating VARCHAR(50) NOT NULL,
    Duration VARCHAR(50) NOT NULL,
    Category VARCHAR(100) NOT NULL,
    ReleaseDate VARCHAR(50) NOT NULL
);

SELECT * FROM Menu;
SELECT * FROM Movies;

INSERT INTO Menu (Name, Image, Description, Price, Category)
VALUES ("Combo Clásico", "https://scorecoorp.procinal.com/SCOREIMG/imgpel/test/1581.jpg", "1 Crispeta de 80 Oz, 1 Bebida", 25900, "Combos"),
("Combo Para Mí", "https://scorecoorp.procinal.com/SCOREIMG/imgpel/test/1580.jpg", "1 Perro o 1 Sánduche, 1 Crispeta de 80 Oz, 1 Bebida", 33900, "Combos"),
("Combo Deluxe", "https://scorecoorp.procinal.com/SCOREIMG/imgpel/test/1582.jpg", "1 Crispeta de 200 Oz, Nachos con queso y guacamole, 1 Perro o 1 Sánduche, 1 Choco jumbito 40gr, 2 Bebidas", 61900, "Combos"),
("Botella de Agua", "https://scorecoorp.procinal.com/SCOREIMG/imgpel/test/170.jpg", "Manantial 600ml", 7200, "Bebidas"),
("Chocolatina", "https://scorecoorp.procinal.com/SCOREIMG/imgpel/test/416.jpg", "Jet 30 Grs", 4900, "Snack")

INSERT INTO Movies (Name, Image, Sinopsis, Rating, Duration, Category, ReleaseDate)
VALUES ("Gigantes de Acero", "https://i.postimg.cc/KzbzFZv8/real-steel-international-poster.jpg", "Un promotor de boxeo y su hijo se unen de mala gana para construir y entrenar a un robot peleador que pelee por el campeonato.", "4.5", "2h 7m", "Ciencia Ficción", "2011"),
("Resident Evil 1", "https://i.postimg.cc/KjqvnB71/435760.jpg", "Tras la fuga de un virus, una inteligencia artificial cierra un laboratorio científico secreto, obligando a un grupo de militares a luchar contra mortíferos zombis para poder escapar.", "4.0", "1h 40m", "Terror", "2002"),
("ZombieLand", "https://i.postimg.cc/DfBZk3V7/MV5-BMTU5-MDg0-NTQ1-N15-BMl5-Ban-Bn-Xk-Ft-ZTcw-Mj-A4-Mjg3-Mg-V1-FMjpg-UX1000.jpg", "Después de que un virus transforma a la mayoría de las personas en zombis, los humanos sobrevivientes deben luchar contra los muertos vivientes hambrientos.", "4.1", "1h 28m", "Comedia", "2009"),
("Cars", "https://i.postimg.cc/J4xd5KB6/435900.jpg", "De camino al prestigiado campeonato Copa Pistón, un automóvil de carreras que sólo se preocupa por ganar aprende sobre lo que realmente es importante en la vida de varios vehículos que viven en un pueblo a lo largo de la histórica Ruta 66.", "4.3", "1h 57m", "Infantil", "2006")