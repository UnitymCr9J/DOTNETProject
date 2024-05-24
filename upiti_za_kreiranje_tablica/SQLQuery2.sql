CREATE TABLE psi(id INT IDENTITY PRIMARY KEY, ime NVARCHAR(40) NOT NULL, 
                 pasmina NVARCHAR(30) NOT NULL, 
				 vrsta NVARCHAR(25) NOT NULL,
				 cijena FLOAT NOT NULL,
				 drzava_id INT,
				 CONSTRAINT fk_drzava FOREIGN KEY(drzava_id) REFERENCES drzave(id))