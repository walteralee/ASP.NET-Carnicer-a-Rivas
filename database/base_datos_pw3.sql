-- ===============================
-- Base de datos: Carnicería
-- Motor: SQLite
-- ===============================

DROP TABLE IF EXISTS productos;

CREATE TABLE productos (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    titulo TEXT NOT NULL,
    url_imagen TEXT NOT NULL,
    precio REAL NOT NULL
);
