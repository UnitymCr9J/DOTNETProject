CREATE TABLE macke(id INT IDENTITY PRIMARY KEY,
                   ime NVARCHAR(40) NOT NULL,
				   cijena FLOAT NOT NULL,
				   drzava_id INT,
				   CONSTRAINT fk_podrijetlo FOREIGN KEY(drzava_id) REFERENCES drzave(id))