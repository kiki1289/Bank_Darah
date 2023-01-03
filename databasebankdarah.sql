
create database Bank_Darah
use Bank_Darah

CREATE TABLE admin(
	username VARCHAR(10) NOT NULL PRIMARY KEY,
	sandi VARCHAR(10) NOT NULL,
	nama VARCHAR(20) NOT NULL,
);

CREATE TABLE pendonor(
	nikPendonor VARCHAR(16) NOT NULL PRIMARY KEY,
	namaPendonor VARCHAR(20) NOT NULL,
	tanggal_lahirPendonor CHAR(10 ) NOT NULL,
	gender VARCHAR(20) NOT NULL,	
	nohp VARCHAR(15) NOT NULL,
	golDar VARCHAR(5) NOT NULL,
	alamat VARCHAR(200) NOT NULL,
	tglDonor CHAR(10) NOT NULL,
	nDonor INT NOT NULL DEFAULT 0,
	username VARCHAR(10) NOT NULL,
	CONSTRAINT FK_ADMIN FOREIGN KEY (username) REFERENCES 
	admin (username)
);
CREATE TABLE penerima(
	nikpenerima VARCHAR(16) NOT NULL PRIMARY KEY,
	namaPenerima VARCHAR(20) NOT NULL,
	tanggalLahirPenerima CHAR(10 ) NOT NULL,
	genderPenerima VARCHAR(10) NOT NULL,
	nohpPenerima VARCHAR(15) NOT NULL,
	golDarPenerima VARCHAR(5) NOT NULL,
	alamatPenerima VARCHAR(200) NOT NULL,
	tglinputdata CHAR(10 ) NOT NULL,
	jmlButuh INT NOT NULL DEFAULT 0,
	username VARCHAR(10) NOT NULL,
	CONSTRAINT FK_ADMIN1 FOREIGN KEY (username) REFERENCES 
	admin (username)
);

CREATE TABLE stokDarah(
	idStokDarah VARCHAR(10) NOT NULL PRIMARY KEY,
	golDarah VARCHAR(10) NOT NULL,
	jumlah INT NOT NULL DEFAULT 0,
);

CREATE TABLE donasi(
	idDonasi VARCHAR(10) NOT NULL PRIMARY KEY,
	tglTerima CHAR(10) NOT NULL,
	nik VARCHAR(10) NOT NULL,
	jumlahTerima INT NOT NULL DEFAULT 0,
	idStokDarah VARCHAR(10) NOT NULL,
	CONSTRAINT FK_STOKDARAH FOREIGN KEY (idStokDarah) REFERENCES 
	stokDarah(idStokDarah),
	nikpenerima VARCHAR(16) NOT NULL,
	CONSTRAINT FK_PENERIMA FOREIGN KEY (nikpenerima) REFERENCES 
	penerima(nikpenerima)
);

CREATE TABLE detailDonasi(
	nikpenerima VARCHAR(16) NOT NULL,
	CONSTRAINT FK_PENERIMA1 FOREIGN KEY (nikpenerima) REFERENCES 
	penerima(nikpenerima),
	idDonasi VARCHAR(10) NOT NULL,
	CONSTRAINT FK_DONASI FOREIGN KEY (idDonasi) REFERENCES 
	donasi(idDonasi)
);

CREATE TABLE kelayakandarah(
	nikPendonor VARCHAR(16) NOT NULL,
	CONSTRAINT FK_PENDONOR FOREIGN KEY (nikPendonor) REFERENCES 
	pendonor(nikPendonor),
	idStokDarah VARCHAR(10) NOT NULL,
	CONSTRAINT FK_STOKDARAH1 FOREIGN KEY (idStokDarah) REFERENCES 
	stokDarah(idStokDarah),
	kelayakan VARCHAR(10) NOT NULL,
);