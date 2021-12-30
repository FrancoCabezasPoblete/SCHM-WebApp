CREATE TABLE Experto (
    IDExperto int NOT NULL PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(255) NOT NULL,
    Apellido VARCHAR(255) NOT NULL,
    Correo VARCHAR(255) NOT NULL,
    Contraseña VARCHAR(255) NOT NULL
);

CREATE TABLE Solicitud (
    IDFormulario int NOT NULL PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(255) NOT NULL,
    Apellido VARCHAR(255) NOT NULL,
    Correo VARCHAR(255) NOT NULL,
    Solicitud VARCHAR(max) NOT NULL,
    Fecha DATETIME NOT NULL,
    Estado TINYINT NOT NULL
);

CREATE TABLE Expediente (
    IDExpediente int NOT NULL PRIMARY KEY IDENTITY(1,1),
    Fecha DATETIME NOT NULL,
    Titulo VARCHAR(255) NOT NULL,
    Fuente VARCHAR(255) NOT NULL,
    Autor VARCHAR(255) NOT NULL,
    Descripcion VARCHAR(max),
    Archivo VARBINARY(max),
    IDExperto int FOREIGN KEY REFERENCES Experto(IDExperto)
);

INSERT INTO Experto (Nombre, Apellido, Correo, Contraseña) VALUES ('Paulina','Vega','PaulinaVega@Rivera.cl','UWU');