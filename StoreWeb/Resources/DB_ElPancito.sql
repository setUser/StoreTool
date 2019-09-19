CREATE DATABASE IF NOT EXISTS DB_ElPancito;


CREATE TABLE db_elpancito.Productos_ElPancito
( CodigoProducto INT
(8) NOT NULL , CategoriaProducto VARCHAR
(50) NOT NULL , NombreProducto VARCHAR
(50) NOT NULL , PrecioProducto DECIMAL
(8,2) NOT NULL , UltimaModificacionProducto TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP );


INSERT INTO Productos_ElPancito
(CodigoProducto, CategoriaProducto, NombreProducto, PrecioProducto, UltimaModificacionProducto) VALUES
(101, 'Panes', 'Cachitos', 0.2, '2019-05-07 18:03:50'),
(102, 'Panes', 'Enrollados', 0.2, '2019-05-07 18:03:50'),
(103, 'Panes', 'Pan De Dulce', 0.18, '2019-05-07 18:03:50'),
(104, 'Panes', 'Pan De Ambato', 0.2, '2019-05-07 18:03:50'),
(105, 'Panes', 'Pan Popular', 0.16, '2019-05-07 18:03:50'),
(106, 'Panes', 'Palanqueta', 1.1, '2019-05-07 18:03:50'),
(107, 'Panes', 'Pan De Agua', 0.18, '2019-05-07 18:03:50'),
(108, 'Panes', 'Pan Bizcocho', 0.2, '2019-05-07 18:03:50'),
(109, 'Panes', 'Gusanito', 0.15, '2019-05-07 18:03:50'),
(110, 'Panes', 'Rosita', 0.15, '2019-05-07 18:03:50'),
(111, 'Panes', 'Pan De Dulce', 0.18, '2019-05-07 18:03:50'),
(112, 'Panes', 'Pan De Piña', 0.3, '2019-05-07 18:03:50'),
(113, 'Panes', 'Pan De Guayaba', 0.3, '2019-05-07 18:03:50'),
(114, 'Panes', 'Pan De Chocolate', 0.3, '2019-05-07 18:03:50'),
(115, 'Panes', 'Trenza De Dulce Pequeña', 0.5, '2019-05-07 18:03:50'),
(116, 'Panes', 'Trenza De Dulce Grande', 1, '2019-05-07 18:03:50'),
(117, 'Panes', 'Reventado', 0.15, '2019-05-07 18:03:50'),
(118, 'Panes', 'Empanadas', 0.3, '2019-05-07 18:03:50'),
(119, 'Panes', 'Integral', 0.2, '2019-05-07 18:03:50'),
(120, 'Panes', 'Injerto', 0.15, '2019-05-07 18:03:50'),
(121, 'Panes', 'Pan De Leche', 0.3, '2019-05-07 18:03:50'),
(122, 'Panes', 'Pan De Maiz', 0.2, '2019-05-07 18:03:50'),
(123, 'Panes', 'Molde De Dulce', 1.25, '2019-05-07 18:03:50'),
(124, 'Panes', 'Molde Integral', 1.3, '2019-05-07 18:03:50'),
(125, 'Panes', 'Crossaint', 0, '2019-05-07 18:03:50'),
(126, 'Panes', 'Brioche', 0, '2019-05-07 18:03:50'),
(127, 'Panes', 'Pan De Rodillas De Cristo', 0.2, '2019-05-07 18:03:50'),
(128, 'Panes', 'Rollo De Canela', 0.15, '2019-05-07 18:03:50'),
(201, 'Reposteria', 'Orejas', 0.3, '2019-05-07 18:03:50'),
(202, 'Reposteria', 'Mil Hojas', 1.25, '2019-05-07 18:03:50'),
(203, 'Reposteria', 'Caritas', 0.2, '2019-05-07 18:03:50'),
(204, 'Reposteria', 'Cabezas', 1, '2019-05-07 18:03:50'),
(205, 'Reposteria', 'Bizcochos De Sal', 1, '2019-05-07 18:03:50'),
(206, 'Reposteria', 'Alfajores', 0.5, '2019-05-07 18:03:50'),
(207, 'Reposteria', 'Bastones', 0.3, '2019-05-07 18:03:50'),
(208, 'Reposteria', 'Enrollado De Piña En Hojaldre', 0.75, '2019-05-07 18:03:50'),
(209, 'Reposteria', 'Galletas De Glasse', 0.3, '2019-05-07 18:03:50'),
(210, 'Reposteria', 'Torta De Platano', 0.5, '2019-05-07 18:03:50'),
(211, 'Reposteria', 'Torta Frutal', 10, '2019-05-07 18:03:50'),
(212, 'Reposteria', 'Torta Chocolate', 10, '2019-05-07 18:03:50'),
(213, 'Reposteria', 'Tres Leches', 1.25, '2019-05-07 18:03:50'),
(214, 'Reposteria', 'Moncaibas', 0.2, '2019-05-07 18:03:50'),
(215, 'Reposteria', 'Masapanes', 0.15, '2019-05-07 18:03:50'),
(301, 'Bebidas', 'Jugo Pulp', 0.25, '2019-05-07 18:03:50'),
(302, 'Bebidas', 'Guitig Grande', 1.1, '2019-05-07 18:03:50'),
(303, 'Bebidas', 'Guitig', 0.6, '2019-05-07 18:03:50'),
(304, 'Bebidas', 'Frutaris', 0.25, '2019-05-07 18:03:50'),
(305, 'Bebidas', 'Gatorade', 1, '2019-05-07 18:03:50'),
(306, 'Bebidas', 'Gatarode Boquilla', 1.25, '2019-05-07 18:03:50'),
(307, 'Bebidas', 'Coca Cola Pequeña', 0.5, '2019-05-07 18:03:50'),
(308, 'Bebidas', 'Cocacola Grande', 1.1, '2019-05-07 18:03:50'),
(309, 'Bebidas', 'Cocacola Mediana', 1, '2019-05-07 18:03:50'),
(310, 'Bebidas', 'V220', 1, '2019-05-07 18:03:50'),
(311, 'Bebidas', 'Redbull', 2.5, '2019-05-07 18:03:50'),
(312, 'Bebidas', 'Monster', 3, '2019-05-07 18:03:50'),
(313, 'Bebidas', 'Jugo Del Valle', 0.35, '2019-05-07 18:03:50'),
(314, 'Bebidas', 'Fuzetea', 0.3, '2019-05-07 18:03:50'),
(315, 'Bebidas', 'Fanta', 0.5, '2019-05-07 18:03:50'),
(316, 'Bebidas', 'Inca', 0.5, '2019-05-07 18:03:50'),
(317, 'Bebidas', 'Fiora', 0.5, '2019-05-07 18:03:50'),
(318, 'Bebidas', 'Sprite', 0.5, '2019-05-07 18:03:50'),
(319, 'Bebidas', 'Dasani', 0.6, '2019-05-07 18:03:50'),
(320, 'Bebidas', 'Huesitos', 0.25, '2019-05-07 18:03:50'),
(321, 'Bebidas', 'Tesalia', 0.4, '2019-05-07 18:03:50'),
(322, 'Bebidas', 'Sunny', 0.7, '2019-05-07 18:03:50'),
(401, 'Leche', 'Vita Azul', 0.8, '2019-05-07 18:03:50'),
(402, 'Leche', 'Vita Roja', 0.8, '2019-05-07 18:03:50'),
(403, 'Leche', 'Vita Azul 1100 Ml', 0.88, '2019-05-07 18:03:50'),
(404, 'Leche', 'Vita Roja 110 Ml', 0.88, '2019-05-07 18:03:50'),
(405, 'Leche', 'Vita Amarilla', 0.95, '2019-05-07 18:03:50'),
(406, 'Leche', 'Avena En Funda Grande', 1, '2019-05-07 18:03:50'),
(407, 'Leche', 'Avena Con Leche Funda Grande', 1, '2019-05-07 18:03:50'),
(408, 'Leche', 'Rey Leche', 0.99, '2019-05-07 18:03:50'),
(409, 'Leche', 'Andina', 0.95, '2019-05-07 18:03:50'),
(410, 'Leche', 'Yogurt Lenutrit', 1.2, '2019-05-07 18:03:50'),
(411, 'Leche', 'Yougurt Kiosko', 1.3, '2019-05-07 18:03:50'),
(412, 'Leche', 'Yougurt Zuzu', 0.1, '2019-05-07 18:03:50'),
(413, 'Leche', 'Yogurt Rey', 0.35, '2019-05-07 18:03:50'),
(414, 'Leche', 'Yogurt Miraflores', 0.28, '2019-05-07 18:03:50'),
(415, 'Leche', 'Vita Chocolatada En Funda Pequeña', 0.35, '2019-05-07 18:03:50'),
(416, 'Leche', 'Avena Vita Pequeña En Funda', 0.35, '2019-05-07 18:03:50'),
(417, 'Leche', 'Leche Toni', 0.8, '2019-05-07 18:03:50'),
(418, 'Leche', 'La Lechera Azul', 1.39, '2019-05-07 18:03:50'),
(419, 'Leche', 'La Lechera Roja', 1.49, '2019-05-07 18:03:50'),
(420, 'Leche', 'Nesquik', 0, '2019-05-07 18:03:50'),
(421, 'Leche', 'Ricacao', 0, '2019-05-07 18:03:50'),
(422, 'Leche', 'Yogu Yogu', 0, '2019-05-07 18:03:50'),
(423, 'Leche', 'Yougurt Kioskio Con Cereal', 0, '2019-05-07 18:03:50'),
(424, 'Leche', 'Yougurt Con Bolitas', 0, '2019-05-07 18:03:50'),
(425, 'Leche', 'Regeneris', 0, '2019-05-07 18:03:50'),
(501, 'Quesos', 'Johana', 2, '2019-05-07 18:03:50'),
(502, 'Quesos', 'Queso Pequeño', 0.6, '2019-05-07 18:03:50'),
(503, 'Quesos', 'Queso San Luis', 3.42, '2019-05-07 18:03:50'),
(504, 'Quesos', 'Queso Zuzu', 3.48, '2019-05-07 18:03:50'),
(505, 'Quesos', 'Queso Inlac', 2.69, '2019-05-07 18:03:50'),
(601, 'Otros', 'Nescafe Pequeño', 0.25, '2019-05-07 18:03:50'),
(602, 'Otros', 'Nescafe Grande', 1, '2019-05-07 18:03:50'),
(603, 'Otros', 'Cacao En Polvo', 1, '2019-05-07 18:03:50'),
(604, 'Otros', 'Mayonesa', 0.5, '2019-05-07 18:03:50'),
(605, 'Otros', 'Salsa De Tomate', 0.5, '2019-05-07 18:03:50'),
(606, 'Otros', 'Sazona Todo', 0.5, '2019-05-07 18:03:50'),
(607, 'Otros', 'Cubito Maggi', 0.3, '2019-05-07 18:03:50'),
(608, 'Otros', 'Cereales De Lonchera', 0, '2019-05-07 18:03:50'),
(609, 'Otros', 'Galletas Maria', 0, '2019-05-07 18:03:50'),
(610, 'Otros', 'Galletas Ricas', 0, '2019-05-07 18:03:50'),
(611, 'Otros', 'Kitkat', 0.5, '2019-05-07 18:03:50'),
(612, 'Otros', 'Galak De Tubito', 0.25, '2019-05-07 18:03:50'),
(613, 'Otros', 'Tango Clasico', 0.3, '2019-05-07 18:03:50'),
(614, 'Otros', 'Tango Bombon', 0.05, '2019-05-07 18:03:50'),
(615, 'Otros', 'Kinder Joy', 1.12, '2019-05-07 18:03:50'),
(616, 'Otros', 'Galletas Amor De Lonchera', 0.25, '2019-05-07 18:03:50'),
(617, 'Otros', 'Galletas Amor Mediana', 1, '2019-05-07 18:03:50'),
(618, 'Otros', 'Galletas De Coco', 0.2, '2019-05-07 18:03:50'),
(619, 'Otros', 'Huevos', 1, '2019-05-07 18:03:50'),
(620, 'Otros', 'Fosforos', 0.1, '2019-05-07 18:03:50'),
(621, 'Otros', 'Cubeta De Huevos', 2.7, '2019-05-07 18:03:50');