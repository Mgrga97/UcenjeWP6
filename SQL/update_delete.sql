﻿select * from smjerovi 

update smjerovi set cijena=1100
where sifra=2; --ako mjenjamo po PK tada mjenjamo 1 red

update smjerovi set 
izvodiseod='2024-12-05',
vaucer=0
where sifra=2;

select * from polaznici where sifra=16;

update polaznici set prezime='Franjić' where sifra=16;

select * from polaznici where sifra=16;

-- Unijeti 5 novih smjerova s cijenom

insert into smjerovi (naziv,cijena,izvodiseod,vaucer)
values ('Automehaničar',850,'2024-04-05 14:00',1),
('Slikar',950,'2024-04-05',1),
('Python dev',650,'2024-04-05 14:00',1),
('profi',750,'2024-04-05 14:00',1),
('noob',550,'2024-04-05 14:00',1);

select * from smjerovi;
update smjerovi set cijena = cijena * 0.9;
select * from smjerovi;

-- uvećajte sve cijene za 35%

select * from smjerovi;
update smjerovi set cijena = cijena * 1.35;
select * from smjerovi;
-- smanjite svemu cijenu za 10 eur
select * from smjerovi;
update smjerovi set cijena = cijena - 10;
select * from smjerovi;

-- uvjet vanjskog ključa
update grupe set smjer=8 where sifra=1;

-- DELETE naredba 

select * from smjerovi;
delete from smjerovi where sifra>8;
select * from smjerovi;

select * from grupe; 
update grupe set smjer=1 where sifra=1;

delete grupe where sifra=1;

select * from clanovi;

update clanovi set grupa=2 where grupa=1;
