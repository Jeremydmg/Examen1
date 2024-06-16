-- Tabla Usuario
CREATE TABLE Usuario (
    id_usuario INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(100),
    email VARCHAR(100) UNIQUE,
    puntos_reciclaje INT
);

-- Tabla MaterialReciclabe 
CREATE TABLE MaterialReciclable (
    id_material INT PRIMARY KEY AUTO_INCREMENT,
    tipo_material VARCHAR(100),
    descripcion TEXT
);

-- Tabla Registro Reciclaje
CREATE TABLE RegistroReciclaje (
    id_registro INT PRIMARY KEY AUTO_INCREMENT,
    id_usuario INT,
    id_material INT,
    cantidad DECIMAL(10, 2),
    fecha DATE,
    FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario),
    FOREIGN KEY (id_material) REFERENCES MaterialReciclable(id_material)
);

