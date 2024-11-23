use master;
go

drop database if exists pcwebshop;
go

create database pcwebshop collate Croatian_CI_AS;
go

use pcwebshop;
go

create table kategorija(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null
);

create table proizvodi(
sifra int not null primary key identity(1,1),
naziv varchar(50)not null,
cijena decimal(18,2),
kategorija int not null references kategorija(sifra)
);

create table korisnici(
sifra int not null primary key identity(1,1),
ime varchar(50)not null,
prezime varchar(50)not null,
email varchar(50),
lozinka varchar(100)
);

create table listazelja(
sifra int not null primary key identity(1,1),
naziv varchar(50),
korisnik int not null references korisnici(sifra),
placanje varchar(100)
);

create table stavke(
proizvod int not null references proizvodi(sifra),
lista int not null references listazelja(sifra)
);

insert into kategorija(naziv)
values 
-- procesori dobiva sifru broj 1 za kategoriju
('Procesori (CPU)'),
-- maticne sifra broj 2 itd
('Matične ploče (Motherboards)'),
('Grafičke kartice (GPU)'),
('RAM memorija (RAM)'),
('Pohrana (SSD, HDD, NVMe)'),
('Napajanja (PSU)'),
('Kućišta (Cases)'),
('Hlađenje');

select * from proizvodi;

insert into proizvodi(naziv,cijena,kategorija)
-- dodajem procesore 
values ('Intel i7 9700K',200,1),


-- dodajem matične ploče

('ASUS ROG Strix Z790-E Gaming WiFi',190,2),
('MSI MPG B550 Gaming Edge WiFi',220,2),
('Gigabyte AORUS X570 Master',230,2),
('ASRock B660 Steel Legend',240,2),
('ASUS TUF Gaming B450 Plus',250,2),
('MSI MAG Z690 Tomahawk WiFi',260,2),
('Gigabyte Z590 AORUS Elite',270,2),
('ASUS Prime Z690-A',280,2),
('ASRock Z590 Taichi',290,2),
('MSI MEG X570 Godlike',300,2),
('NVIDIA GeForce RTX 4090',100,3),
('AMD Radeon RX 7900 XTX',110,3),
('NVIDIA GeForce RTX 3080 Ti',120,3),
('AMD Radeon RX 6800 XT',130,3),
('NVIDIA GeForce GTX 1660 Super',140,3),
('AMD Radeon RX 6700 XT',150,3),
('NVIDIA GeForce RTX 3060',160,3),
('AMD Radeon RX 5600 XT',170,3),
('NVIDIA GeForce RTX 4070 Ti',180,3),
('MSI GeForce GTX 1050 Ti',180,3),

-- dodajem RAM memoriju

('Kingston Fury Beast 16GB DDR4 3200MHz', 99.00, 3),
('Corsair Vengeance LPX 16GB DDR4 3200MHz', 120, 3),
('G.SKILL Ripjaws V 16GB DDR4 3600MHz', 120, 3),
('Crucial Ballistix 16GB DDR4 3200MHz', 110, 3),
('ADATA XPG Spectrix D60G 16GB DDR4 3600MHz', 145.65, 3),
('TeamGroup T-Force Delta RGB 16GB DDR4 3200MHz', 120.75, 3),
('Patriot Viper Steel 16GB DDR4 3200MHz', 110.20, 3),
('Samsung Original 16GB DDR4 3200MHz', 119.95, 3),
('HyperX Predator 16GB DDR4 3600MHz', 99.00, 3),
('PNY XLR8 Gaming 16GB DDR4 3200MHz', 90.50, 3),

-- dodajem diskove za pohranu

('Samsung 970 EVO Plus 1TB NVMe SSD', 89.99, 4),
('WD Black SN850X 1TB NVMe SSD', 109.99, 4),
('Seagate Barracuda 2TB HDD 7200RPM', 49.99, 4),
('Crucial MX500 1TB SATA SSD', 69.95, 4),
('Kingston KC3000 1TB NVMe SSD', 94.99, 4),
('SanDisk Extreme Portable 1TB External SSD', 99.99, 4),
('Toshiba X300 4TB HDD 7200RPM', 119.00, 4),
('WD Blue SN570 1TB NVMe SSD', 59.99, 4),
('Seagate FireCuda 530 1TB NVMe SSD', 129.99, 4),
('WD Gold 12TB Enterprise HDD', 349.99, 4),


-- dodajem napajanja

('Corsair RM750e 750W 80+ Gold Modular', 84.99, 5),
('MSI MAG A850GL 850W 80+ Gold Modular', 109.99, 5),
('SilverStone ET750-HG 750W 80+ Gold Semi-Modular', 110.99, 5),
('NZXT C650 650W 80+ Bronze Semi-Modular', 94.99, 5),
('Seasonic FOCUS GM-850 850W 80+ Gold Semi-Modular', 149.99, 5),
('EVGA 600 BQ 600W 80+ Bronze Semi-Modular', 57.21, 5),
('Corsair RM1000x 1000W 80+ Gold Modular', 189.95, 5),
('Corsair HX850 850W 80+ Platinum Modular', 219.99, 5),
('Seasonic Prime TX-750 750W 80+ Titanium Modular', 239.99, 5),
('Corsair AX1600i 1600W 80+ Titanium Modular', 599.99, 5);


-- dodajem kućišta


-- hlađenja

insert into korisnici(ime,prezime,email,lozinka)
values 
-- dodajem korisnike i njihove lozinke

('Ivan', 'Horvat', 'ivan.horvat@example.com', NULL),
('Ana', 'Kovačić', 'ana.kovacic@example.com', NULL),
('Marko', 'Marić', 'marko.maric@example.com', NULL),
('Lucija', 'Barišić', 'lucija.barisic@example.com', NULL),
('Petar', 'Novak', 'petar.novak@example.com', NULL),
('Marija', 'Jurić', 'marija.juric@example.com', NULL),
('Josip', 'Radić', 'josip.radic@example.com', NULL),
('Katarina', 'Bogdan', 'katarina.bogdan@example.com', NULL),
('Filip', 'Pavlović', 'filip.pavlovic@example.com', NULL),
('Matea', 'Lovrić', 'matea.lovric@example.com', NULL),
('Tomislav', 'Kralj', 'tomislav.kralj@example.com', NULL),
('Nikolina', 'Perić', 'nikolina.peric@example.com', NULL),
('Luka', 'Grgić', 'luka.grgic@example.com', NULL),
('Ivana', 'Matić', 'ivana.matic@example.com', NULL),
('Dario', 'Vidović', 'dario.vidovic@example.com', NULL),
('Sara', 'Milić', 'sara.milic@example.com', NULL),
('Matija', 'Šimić', 'matija.simic@example.com', NULL),
('Tina', 'Pavelić', 'tina.pavelic@example.com', NULL),
('Andrej', 'Krstanović', 'andrej.krstanovic@example.com', NULL),
('Martina', 'Kovač', 'martina.kovac@example.com', NULL);

select * from korisnici;

