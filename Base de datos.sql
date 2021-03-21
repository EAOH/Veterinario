/*Creacion de Secuencia para codigos*/
drop sequence Codigos;
create  sequence Codigos start with 11 increment by 1;
/*Creacion de Tablas *'

/*Usuario*/
drop table Usuarios;
create table Usuarios (
usu_Usuario varchar2 (50) primary key,
usu_Nombre1 varchar2 (50) not null,
usu_Nombre2 varchar2 (50) not null,
usu_Apellido1 varchar2 (50) not null,
usu_Apellido2 varchar2 (50) not null,
usu_Tel varchar2 (10) not null,
usu_Direccion varchar2 (200) not null,
usu_Contraseña varchar2 (50) not null,
usu_Tipo varchar2 (20) check (usu_Tipo in ('Administrador','Atencion al cliente')) not null
);
/*Auditoria*/
drop table Auditorias;
create table Auditorias(
usu_Usuario varchar2 (50),
aud_Proceso varchar2(10) check (aud_Proceso in ('Creo','Elimino')) not null,
aud_FechaHora date,
aud_Tabla varchar2 (10) check (aud_Tabla in ('Pacientes','Médicos','Dueños', 'Citas')) not null,
primary key (usu_Usuario,aud_FechaHora)
);

/*Especie*/
drop table Especies;
create table Especies(
esp_CodigoE int  primary key,
esp_Especie varchar2 (50) unique not null,
esp_Familia varchar2 (10) check (esp_Familia in ('Anfibios','Aves','Roedores','Felinos','Peces','Canes','Reptiles','Bóvinos','Equinos','Quélidos')) not null
);

/*Raza*/
drop table Razas;
create table Razas(
raz_CodigoR int  primary key,
raz_Raza varchar2 (50) unique not null,
esp_CodigoE int not null,
foreign key (esp_CodigoE) references Especies (esp_CodigoE)
);


/*Enfermedad*/
drop table Enfermedades;
create table Enfermedades(
enf_CodigoE int  primary key,
enf_Enfermedad varchar2 (50) unique not null
);

/*Enfermedades por raza*/
drop table EnfermedadxRaza;
create table EnfermedadxRaza(
enf_CodigoE int,
raz_CodigoR int,
primary key (enf_CodigoE,raz_CodigoR),
foreign key (enf_CodigoE) references Enfermedades (enf_CodigoE) on delete cascade,
foreign key (raz_CodigoR) references Razas (raz_CodigoR) on delete cascade
);

/*Medicinas*/
drop table Medicinas;
create table Medicinas (
med_CodigoMe int primary key,
med_Nombre varchar2 (50) unique not null,
med_Dosis varchar2 (50) not null,
med_Intervalo varchar2 (50) not null
);

/*Medicinas*Enfermedad*/
drop table MedicinaxEnfermedad;
create table MedicinaxEnfermedad(
med_CodigoMe int,
enf_CodigoE int,
primary key (enf_CodigoE,med_CodigoMe),
foreign key (enf_CodigoE) references Enfermedades (enf_CodigoE) on delete cascade,
foreign key (med_CodigoMe) references Medicinas (med_CodigoMe) on delete cascade
);

/*Turnos*/
drop table Turnos;
create table Turnos (
tur_CodigoT int primary key,
tur_HoraI date not null,
tur_HoraF date not null,
tur_Tipo varchar2 (10) check (tur_Tipo in ('Matutino','Vespertino','Nocturno')) not null
);

/*Medicos*/
drop table Médicos;
create table Médicos(
med_CodigoM int primary key,
med_Nombre1 Varchar2 (50) not null,
med_Nombre2 varchar2 (50) not null,
med_Apellido1 varchar2 (50) not null,
med_Apellido2 varchar2 (50) not null,
med_Direccion varchar2 (200) not null,
med_Emergencia varchar2 (2) check (med_Emergencia in ('Si','No')) not null,
med_Ingreso date not null
);

/*Tel_Medico*/
drop table Tel_Médico;
create table Tel_Médico (
med_CodigoM int,
teme_Tel varchar2 (10),
primary key (med_CodigoM,teme_Tel),
foreign key (med_CodigoM) references Médicos (med_CodigoM) on delete cascade
);

/*Turno*Médico*/
drop table TurnoxMédico;
create table TurnoxMédico (
med_CodigoM int,
tume_Fecha date,
tur_CodigoT int,
primary key (med_CodigoM,tume_Fecha,tur_CodigoT),
foreign key (med_CodigoM) references Médicos (med_CodigoM) on delete cascade,
foreign key (tur_CodigoT) references Turnos (tur_CodigoT) on delete cascade
);

/*Dueños*/
drop table Dueños;
create table Dueños (
due_CodigoD int primary key,
due_Nombre1 varchar2 (50) not null,
due_Nombre2 varchar2 (50) not null,
due_Apellido1 varchar2 (50) not null,
due_Apellido2 varchar2 (50) not null,
due_Identificacion varchar2 (20) unique not null,
due_Direccion varchar2 (200) not null
);

/*Tel del dueño*/
drop table Tel_Dueño;
create table Tel_Dueño (
due_CodigoD int,
tedu_Tel varchar2 (10),
primary key (due_CodigoD,tedu_Tel),
foreign key (due_CodigoD) references Dueños (due_CodigoD) on delete cascade
);

/*Pacientes*/
drop table Pacientes;
create table Pacientes (
pac_CodigoP int primary key,
pac_NombreP varchar2 (50) not null,
raz_CodigoR int not null,
due_CodigoD int not null,
med_CodigoM int not null,
pac_FotoP blob,
pac_Fecha date not null,
foreign key (raz_CodigoR) references Razas (raz_CodigoR),
foreign key (due_CodigoD) references Dueños (due_CodigoD),
foreign key (med_CodigoM) references Médicos (med_CodigoM)
);

/*Cirugias*/
drop table Cirugias;
create table Cirugias (
cir_CodigoC int primary key,
cir_Duracion varchar2(50) not null,
cir_Descripcion varchar2 (100) unique not null,
cir_Riesgo varchar2 (5) check (cir_Riesgo in ('Alto','Medio','Bajo')) not null,
cir_Nombre varchar2 (50) unique not null,
cir_Anestesía varchar2 (2) check (cir_Anestesía in ('Si','No')) not null
);

/*Citas*/
drop table Citas;
create table Citas (
cit_CodigoC int primary key,
cit_Calendarizado date,
pac_CodigoP int,
cir_CodigoC int,
cit_Hecha date not null,
cit_Descripcion varchar2(100) not null,
foreign key (pac_CodigoP) references Pacientes (pac_CodigoP),
foreign key (cir_CodigoC) references Cirugias (cir_CodigoC)
);

/*Reporte*/
drop table Reporte;
create table Reporte(
rep_Secuencia int,
rep_MesH varchar2(50) not null,
rep_FechaH date,
due_CodigoD int not null,
pac_CodigoP int not null,
esp_CodigoE int not null,
cit_CodigoC int not null,
med_CodigoM int not null,
primary key (rep_Secuencia,rep_FechaH)
);

/*Fecha*/
drop  table Fecha;
create table Fecha (
Fec_Codigo integer primary key,
Fec_FechaHora date not null
);
select *from Fecha;


/*Llenado de tablas *'

/*Usuario*/

create or replace procedure Llenar  is
begin
/*Usuario*/
insert into Usuarios values('EAOH','Elio','Alexandro','Ortega','Hernandez','95044358','Barrio el bosque','Alexandro1998','Administrador');
insert into Usuarios values('AA','Aldo','Safon','Trias','Andurai','96591228','La keneddy','AA','Atencion al cliente');
insert into Usuarios values('AP','Alejandra','Daniela','Paola','Izaguirrez','97228891','La keneddy','AP','Administrador');
insert into Usuarios values('DV','Daniela','Alejandra','Valladares','barahoha','96591228','La keneddy','DV','Atencion al cliente');
insert into Usuarios values('AM','Amy','Mia','Mendoza','Barahoha','96591228','La keneddy','AM','Administrador');
insert into Usuarios values('MA','Mirro','Angel','Klifa','Posada','96591228','La keneddy','MA','Atencion al cliente');
insert into Usuarios values('AR','Angela','Rafaela','Sevilla','Posada','96591228','La keneddy','AR','Administrador');
insert into Usuarios values('A','Ani','Dayana','Alvarado','Diaz','96591228','La keneddy','A','Atencion al cliente');
insert into Usuarios values('AU','Anssony','Anthony','Uriel','Medrano','96591228','La keneddy','AU','Administrador');
insert into Usuarios values('AO','Anthony','Joel','Osorio','Medrano','96591228','La keneddy','AO','Administrador');
/*Especie*/
insert into Especies values (1,'A','Anfibios');
insert into Especies values (2,'B','Aves');
insert into Especies values (3,'C','Roedores');
insert into Especies values (4,'D','Felinos');
insert into Especies values (5,'E','Peces');
insert into Especies values (6,'F','Canes');
insert into Especies values (7,'G','Reptiles');
insert into Especies values (8,'H','Bóvinos');
insert into Especies values (9,'I','Equinos');
insert into Especies values (10,'J','Quélidos');
/*Raza*/
insert into Razas values (1,'A',1);
insert into Razas values (2,'B',2);
insert into Razas values (3,'C',3);
insert into Razas values (4,'D',4);
insert into Razas values (5,'E',5);
insert into Razas values (6,'F',6);
insert into Razas values (7,'G',7);
insert into Razas values (8,'H',8);
insert into Razas values (9,'I',9);
insert into Razas values (10,'J',10);
/*Enfermedad*/
insert into Enfermedades values (1,'A');
insert into Enfermedades values (2,'B');
insert into Enfermedades values (3,'C');
insert into Enfermedades values (4,'D');
insert into Enfermedades values (5,'E');
insert into Enfermedades values (6,'F');
insert into Enfermedades values (7,'G');
insert into Enfermedades values (8,'H');
insert into Enfermedades values (9,'I');
insert into Enfermedades values (10,'J');
/*Enfermedades por raza*/
insert into EnfermedadxRaza values (1,1);
insert into EnfermedadxRaza values (2,2);
insert into EnfermedadxRaza values (3,3);
insert into EnfermedadxRaza values (4,4);
insert into EnfermedadxRaza values (5,5);
insert into EnfermedadxRaza values (6,6);
insert into EnfermedadxRaza values (7,7);
insert into EnfermedadxRaza values (8,8);
insert into EnfermedadxRaza values (9,9);
insert into EnfermedadxRaza values (10,10);
/*Medicinas*/
insert into Medicinas values (1,'ANTI A','20CC','12hr');
insert into Medicinas values (2,'ANTI B','20CC','12hr');
insert into Medicinas values (3,'ANTI C','20CC','12hr');
insert into Medicinas values (4,'ANTI D','20CC','12hr');
insert into Medicinas values (5,'ANTI E','20CC','12hr');
insert into Medicinas values (6,'ANTI F','20CC','12hr');
insert into Medicinas values (7,'ANTI G','20CC','12hr');
insert into Medicinas values (8,'ANTI H','20CC','12hr');
insert into Medicinas values (9,'ANTI I','20CC','12hr');
insert into Medicinas values (10,'ANTI J','20CC','12hr');
/*Medicinas*Enfermedad*/
insert into MedicinaxEnfermedad values (1,1);
insert into MedicinaxEnfermedad values (2,2);
insert into MedicinaxEnfermedad values (3,3);
insert into MedicinaxEnfermedad values (4,4);
insert into MedicinaxEnfermedad values (5,5);
insert into MedicinaxEnfermedad values (6,6);
insert into MedicinaxEnfermedad values (7,7);
insert into MedicinaxEnfermedad values (8,8);
insert into MedicinaxEnfermedad values (9,9);
insert into MedicinaxEnfermedad values (10,10);
/*Turnos*/
insert into Turnos values (1,to_date('09:00:00','hh24:mi:ss'),to_date('11:00:00','hh24:mi:ss'),'Matutino');
insert into Turnos values (2,to_date('09:00:00','hh24:mi:ss'),to_date('12:00:00','hh24:mi:ss'),'Matutino');
insert into Turnos values (3,to_date('11:00:00','hh24:mi:ss'),to_date('12:00:00','hh24:mi:ss'),'Matutino');
insert into Turnos values (4,to_date('12:00:00','hh24:mi:ss'),to_date('17:00:00','hh24:mi:ss'),'Vespertino');
insert into Turnos values (5,to_date('11:00:00','hh24:mi:ss'),to_date('18:00:00','hh24:mi:ss'),'Vespertino');
insert into Turnos values (6,to_date('1:00:00','hh24:mi:ss'),to_date('19:00:00','hh24:mi:ss'),'Vespertino');
insert into Turnos values (7,to_date('19:00:00','hh24:mi:ss'),to_date('20:00:00','hh24:mi:ss'),'Nocturno');
insert into Turnos values (8,to_date('20:00:00','hh24:mi:ss'),to_date('21:00:00','hh24:mi:ss'),'Nocturno');
insert into Turnos values (9,to_date('21:00:00','hh24:mi:ss'),to_date('22:00:00','hh24:mi:ss'),'Nocturno');
insert into Turnos values (10,to_date('00:00:00','hh24:mi:ss'),to_date('12:00:00','hh24:mi:ss'),'Matutino');
/*Medicos*/
insert into Médicos values(50,'Alejandra','Daniela','Paola','Izaguirrez','La keneddy','Si',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
insert into Médicos values(2,'Daniela','Alejandra','Valladares','barahoha','La keneddy','Si',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
insert into Médicos values(3,'Amy','Mia','Mendoza','Barahoha','La keneddy','Si',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
insert into Médicos values(4,'Mirro','Angel','Klifa','Posada','La keneddy','Si',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
insert into Médicos values(5,'Angela','Rafaela','Sevilla','Posada','La keneddy','Si',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
insert into Médicos values(6,'Ani','Dayana','Alvarado','Diaz','La keneddy','No',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
insert into Médicos values(7,'Anssony','Anthony','Uriel','Medrano','La keneddy','No',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
insert into Médicos values(8,'Anthony','Joel','Osorio','Medrano','La keneddy','No',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
insert into Médicos values(9,'Harold','Reñery','Ortega','Hernandez','La keneddy','No',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
insert into Médicos values(10,'Lucila','Maria','Ortega','Hernandez','La keneddy','No',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
/*Tel_Medico*/
insert into Tel_Médico values (1,'1');
insert into Tel_Médico values (2,'2');
insert into Tel_Médico values (3,'3');
insert into Tel_Médico values (4,'4');
insert into Tel_Médico values (5,'5');
insert into Tel_Médico values (6,'6');
insert into Tel_Médico values (7,'7');
insert into Tel_Médico values (8,'8');
insert into Tel_Médico values (9,'9');
insert into Tel_Médico values (10,'10');
/*Turno*Médico*/
select * from Médicos
insert into TurnoxMédico values (1,to_date(sysdate,'dd/mm/yy'),1);
insert into TurnoxMédico values (2,to_date(sysdate,'dd/mm/yy'),2);
insert into TurnoxMédico values (3,to_date(sysdate,'dd/mm/yy'),3);
insert into TurnoxMédico values (4,to_date(sysdate,'dd/mm/yy'),4);
insert into TurnoxMédico values (5,to_date(sysdate,'dd/mm/yy'),5);
insert into TurnoxMédico values (6,to_date(sysdate,'dd/mm/yy'),6);
insert into TurnoxMédico values (7,to_date(sysdate,'dd/mm/yy'),7);
insert into TurnoxMédico values (8,to_date(sysdate,'dd/mm/yy'),8);
insert into TurnoxMédico values (9,to_date(sysdate,'dd/mm/yy'),9);
insert into TurnoxMédico values (10,to_date(sysdate,'dd/mm/yy'),10);
/*Dueños*/
insert into Dueños values(1,'Alejandra','Daniela','Paola','Izaguirrez','1','La keneddy');
insert into Dueños values(2,'Daniela','Alejandra','Valladares','barahoha','2','La keneddy');
insert into Dueños values(3,'Amy','Mia','Mendoza','Barahoha','3','La keneddy');
insert into Dueños values(4,'Mirro','Angel','Klifa','Posada','4','La keneddy');
insert into Dueños values(5,'Angela','Rafaela','Sevilla','Posada','5','La keneddy');
insert into Dueños values(6,'Ani','Dayana','Alvarado','Diaz','6','La keneddy');
insert into Dueños values(7,'Anssony','Anthony','Uriel','Medrano','7','La keneddy');
insert into Dueños values(8,'Anthony','Joel','Osorio','Medrano','8','La keneddy');
insert into Dueños values(9,'Harold','Reñery','Ortega','Hernandez','9','La keneddy');
insert into Dueños values(10,'Lucila','Maria','Ortega','Hernandez','0','La keneddy');
/*Tel del dueño*/
insert into Tel_Dueño values (1,'1');
insert into Tel_Dueño values (2,'2');
insert into Tel_Dueño values (3,'3');
insert into Tel_Dueño values (4,'4');
insert into Tel_Dueño values (5,'5');
insert into Tel_Dueño values (6,'6');
insert into Tel_Dueño values (7,'7');
insert into Tel_Dueño values (8,'8');
insert into Tel_Dueño values (9,'9');
insert into Tel_Dueño values (10,'10');
/*Pacientes*/
insert into Pacientes values (1,'Fido',1,1,1,'',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
insert into Pacientes values (2,'Kira',2,2,2,'',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
insert into Pacientes values (3,'Rocky',3,3,3,'',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
insert into Pacientes values (4,'Tailon flare',4,4,4,'',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
insert into Pacientes values (5,'korvinith',5,5,5,'',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
insert into Pacientes values (6,'Garry',6,6,6,'',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
insert into Pacientes values (7,'Hunter',7,7,7,'',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
insert into Pacientes values (8,'Firulais',8,8,8,'',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
insert into Pacientes values (9,'Lola',9,9,9,'',to_date(sysdate,'dd/mm/yyyy hh24:mi:ss'));
insert into Pacientes values (10,'Otiz',10,10,10,'',to_date(sysdate,'dd/mm/yy hh24:mi:ss'));
/*Cirugias*/ 
insert into Cirugias values (1,'1hr','Eliminar A','Alto','Cirugia contra A','Si');
insert into Cirugias values (2,'2hr','Eliminar B','Medio','Cirugia contra B','Si');
insert into Cirugias values (3,'3hr','Eliminar C','Bajo','Cirugia contra C','Si');
insert into Cirugias values (4,'4min','Eliminar D','Alto','Cirugia contra D','Si');
insert into Cirugias values (5,'5hr','Eliminar E','Medio','Cirugia contra E','Si');
insert into Cirugias values (6,'6hr','Eliminar F','Bajo','Cirugia contra F','No');
insert into Cirugias values (7,'7min','Eliminar G','Alto','Cirugia contra G','No');
insert into Cirugias values (8,'8min','Eliminar H','Medio','Cirugia contra H','No');
insert into Cirugias values (9,'9min','Eliminar I','Bajo','Cirugia contra I','No');
insert into Cirugias values (10,'10min','Eliminar J','Alto','Cirugia contra J','No');
/*Citas*/
insert into Citas values (1,to_date(sysdate,'dd/mm/yy hh24:mi:ss'),1,1,to_date(sysdate,'dd/mm/yyyy hh24:mi:ss'),'Cita con cirugia contra A');
insert into Citas values (2,to_date(sysdate,'dd/mm/yy hh24:mi:ss'),2,2,to_date(sysdate,'dd/mm/yyyy hh24:mi:ss'),'Cita con cirugia contra B');
insert into Citas values (3,to_date(sysdate,'dd/mm/yy hh24:mi:ss'),3,3,to_date(sysdate,'dd/mm/yyyy hh24:mi:ss'),'Cita con cirugia contra C');
insert into Citas values (4,to_date(sysdate,'dd/mm/yy hh24:mi:ss'),4,4,to_date(sysdate,'dd/mm/yyyy hh24:mi:ss'),'Cita con cirugia contra D');
insert into Citas values (5,to_date(sysdate,'dd/mm/yy hh24:mi:ss'),5,5,to_date(sysdate,'dd/mm/yyyy hh24:mi:ss'),'Cita con cirugia contra E');
insert into Citas values (6,to_date(sysdate,'dd/mm/yy hh24:mi:ss'),6,6,to_date(sysdate,'dd/mm/yyyy hh24:mi:ss'),'Cita con cirugia contra F');
insert into Citas values (7,to_date(sysdate,'dd/mm/yy hh24:mi:ss'),7,7,to_date(sysdate,'dd/mm/yyyy hh24:mi:ss'),'Cita con cirugia contra G');
insert into Citas values (8,to_date(sysdate,'dd/mm/yy hh24:mi:ss'),8,8,to_date(sysdate,'dd/mm/yyyy hh24:mi:ss'),'Cita con cirugia contra H');
insert into Citas values (9,to_date(sysdate,'dd/mm/yy hh24:mi:ss'),9,9,to_date(sysdate,'dd/mm/yyyy hh24:mi:ss'),'Cita con cirugia contra I');
insert into Citas values (10,to_date(sysdate,'dd/mm/yy hh24:mi:ss'),10,10,to_date(sysdate,'dd/mm/yyyy hh24:mi:ss'),'Cita con cirugia contra J');
/*Fecha*/
insert into Fecha values(1,sysdate);
commit;
end;

/*Procedimientos almacenados 

Usuario

Insert*/
create or replace procedure I_Usuario (Usuario varchar2,Nombre1 varchar2,Nombre2 varchar2,Apellido1 varchar2,Apellido2 varchar2,Tel varchar2,Direccion varchar2,Contraseña varchar2,Tipo varchar2) is
begin
insert into Usuarios values (Usuario,Nombre1,Nombre2,Apellido1,Apellido2,Tel,Direccion,Contraseña,Tipo);
commit;
exception when others then
rollback;
end;

/* Update*/
create or replace procedure U_Usuario (Usuario varchar2,Nombre1 varchar2,Nombre2 varchar2,Apellido1 varchar2,Apellido2 varchar2,Tel varchar2,Direccion varchar2,Contraseña varchar2,Tipo varchar2) is
begin
update  Usuarios set usu_Nombre1= Nombre1,usu_Nombre2= Nombre2,usu_Apellido1 = Apellido1,usu_Apellido2 = Apellido2,usu_Tel = Tel,usu_Direccion = Direccion,usu_Contraseña = Contraseña,usu_Tipo = Tipo
where usu_Usuario=Usuario;
commit;
exception when others then
rollback;
end;

/*Delete*/
create or replace procedure D_Usuario (Usuario varchar2) is
begin
delete from Usuarios where usu_Usuario=Usuario;
commit;
exception when others then
rollback;
end;

/*Especie*/

/*Insert*/
create or replace procedure I_Especie (Especie varchar2,Familia varchar2) is
begin
insert into Especies values (Codigos.nextval,Especie,Familia);
commit;
exception when others then
rollback;
end;

/* Update*/
create or replace procedure U_Especie (CodigoE int,Especie varchar2,Familia varchar2) is
begin
update  Especies set esp_Especie= Especie,esp_Familia= Familia
where esp_CodigoE=CodigoE;
commit;
exception when others then
rollback;
end;

/*Delete*/
create or replace procedure D_Especie (CodigoE int) is
begin
delete from Especies where esp_CodigoE=CodigoE;
commit;
exception when others then
rollback;
end;

/*Raza*/

/*Insert*/
create or replace procedure I_Raza (Raza varchar2,CodigoE int) is
begin
insert into Razas values (Codigos.nextval,Raza,CodigoE);
commit;
exception when others then
rollback;
end;

/* Update*/
create or replace procedure U_Raza (CodigoR int,Raza varchar2,CodigoE int) is
begin
update  Razas set raz_Raza= Raza,esp_CodigoE= CodigoE
where raz_CodigoR=CodigoR;
commit;
exception when others then
rollback;
end;

/*Delete*/
create or replace procedure D_Raza (CodigoR int) is
begin
delete from Razas where raz_CodigoR=CodigoR;
commit;
exception when others then
rollback;
end;

/*Enfermedad*/

/*Insert*/
create or replace procedure I_Enfermedad (Enfermedad varchar2) is
begin
insert into Enfermedades values (Codigos.nextval,Enfermedad);
commit;
exception when others then
rollback;
end;

/* Update*/
create or replace procedure U_Enfermedad (CodigoE int,Enfermedad varchar2) is
begin
update  Enfermedades set enf_Enfermedad= Enfermedad
where enf_CodigoE=CodigoE;
commit;
exception when others then
rollback;
end;

/*Delete*/
create or replace procedure D_Enfermedad (CodigoE int) is
begin
delete from Enfermedades where enf_CodigoE=CodigoE;
commit;
exception when others then
rollback;
end;

/*Enfermedades por raza*/

/*Insert*/
create or replace procedure I_EnfermedadxRaza (CodigoE int,CodigoR int ) is
begin
insert into EnfermedadxRaza values (CodigoE,CodigoR);
commit;
exception when others then
rollback;
end;

/*Delete*/
create or replace procedure D_EnfermedadxRaza (CodigoE int,CodigoR int) is
begin
delete from EnfermedadxRaza where enf_CodigoE=CodigoE and raz_CodigoR=CodigoR;
commit;
exception when others then
rollback;
end;

/*Medicinas*/

/*Insert*/
create or replace procedure I_Medicina (Nombre varchar2,Dosis varchar2,Intervalo varchar2) is
begin
insert into Medicinas values (Codigos.nextval,Nombre,Dosis,Intervalo);
commit;
exception when others then
rollback;
end;

/* Update*/
create or replace procedure U_Medicina (CodigoMe int,Nombre varchar2,Dosis varchar2,Intervalo varchar2) is
begin
update  Medicinas set med_Nombre= Nombre,med_Dosis= Dosis, med_Intervalo= Intervalo
where med_CodigoMe=CodigoMe;
commit;
exception when others then
rollback;
end;

/*Delete*/
create or replace procedure D_Medicina (CodigoMe int) is
begin
delete from Medicinas where med_CodigoMe=CodigoMe;
commit;
exception when others then
rollback;
end;

/*Medicinas*Enfermedad*/

/*Insert*/
create or replace procedure I_MedicinaxEnfermedad (CodigoMe int,CodigoE int) is
begin
insert into MedicinaxEnfermedad values (CodigoMe,CodigoE);
commit;
exception when others then
rollback;
end;

/*Delete*/
create or replace procedure D_MedicinaxEnfermedad (CodigoMe int,CodigoE int) is
begin
delete from MedicinaxEnfermedad where med_CodigoMe=CodigoMe and enf_CodigoE=CodigoE;
commit;
exception when others then
rollback;
end;

/*Turnos*/

/*Insert*/
create or replace procedure I_Turno (HoraI date,HoraF date,Tipo varchar2) is
begin
insert into Turnos values (Codigos.nextval,to_date( HoraI,' hh24:mi:ss'),to_date( HoraF,' hh24:mi:ss'),Tipo);
commit;
exception when others then
rollback;
end;

/* Update*/
create or replace procedure U_Turno (CodigoT int,HoraI date,HoraF date,Tipo varchar2) is
begin
update  Turnos set tur_HoraI= to_date( HoraI,' hh24:mi:ss'),tur_HoraF= to_date( HoraF,' hh24:mi:ss'), tur_Tipo= Tipo
where tur_CodigoT=CodigoT;
commit;
exception when others then
rollback;
end;

/*Delete*/
create or replace procedure D_Turno (CodigoT int) is
begin
delete from Turnos where tur_CodigoT=CodigoT;
commit;
exception when others then
rollback;
end;

/*Medicos*/

/*Insert*/
create or replace procedure I_Médico (Nombre1 Varchar2,Nombre2 varchar2,Apellido1 varchar2,Apellido2 varchar2,Direccion varchar2,Emergencia varchar2,Ingreso date) is
begin
insert into Médicos values (Codigos.nextval,Nombre1,Nombre2,Apellido1,Apellido2,Direccion,Emergencia,Ingreso);
commit;
exception when others then
rollback;
end;

/* Update*/
create or replace procedure U_Médico (CodigoM int,Nombre1 Varchar2,Nombre2 varchar2,Apellido1 varchar2,Apellido2 varchar2,Direccion varchar2,Emergencia varchar2,Ingreso date) is
begin
update  Médicos set med_Nombre1= Nombre1,med_Nombre2= Nombre2, med_Apellido1= Apellido1, med_Apellido2=Apellido2,med_Direccion=Direccion,med_Emergencia=Emergencia, med_Ingreso=Ingreso
where med_CodigoM=CodigoM;
commit;
exception when others then
rollback;
end;

/*Delete*/
create or replace procedure D_Médico (CodigoM int) is
begin
delete from Médicos where med_CodigoM=CodigoM;
commit;
exception when others then
rollback;
end;

/*Select*/
create or replace view S_Médico as
select Distinct Médicos.med_CodigoM,MÉDICOS.MED_NOMBRE1,MÉDICOS.MED_NOMBRE2,MÉDICOS.MED_APELLIDO1,MÉDICOS.MED_APELLIDO2,MÉDICOS.MED_DIRECCION,MÉDICOS.MED_EMERGENCIA,MÉDICOS.MED_INGRESO,
(listagg(Tel_Médico.teme_Tel,chr(9)) within group (order by Tel_Médico.teme_Tel)over (partition by Tel_médico.med_CodigoM) )as TelefonosM
from Médicos inner join Tel_Médico on Médicos.med_CodigoM=Tel_Médico.med_CodigoM;

/*Tel_Medico*/

/*Insert*/
create or replace procedure I_Tel_Médico (Tel varchar2) is
begin
insert into Tel_Médico values ((select max(MÉDICOS.MED_CODIGOM) from Médicos),Tel);
commit;
exception when others then
rollback;
end;

/*Update*/
create or replace procedure U_Tel_Médico (CodigoM int,Tel varchar2,Teln varchar2 ) is
begin
update Tel_Médico set teme_Tel=Teln where med_CodigoM=CodigoM and teme_Tel=Tel;
commit;
exception when others then
rollback;
end;

/*Turno*Médico*/

/*Insert*/
create or replace procedure I_TurnoxMédico (CodigoM int,FechaT date,CodigoT int) is
begin
insert into TurnoxMédico values (CodigoM,FechaT,'dd/mm/yy',CodigoT );
commit;
exception when others then
rollback;
end;

/*Delete*/
create or replace procedure D_TurnoxMédico (CodigoM int,FechaT date,CodigoT int) is
begin
delete from TurnoxMédico where med_CodigoM=CodigoM and tume_Fecha=FechaT and tur_CodigoT=CodigoT;
commit;
exception when others then
rollback;
end;

/*Dueños*/

/*Insert*/
create or replace procedure I_Dueño (Nombre1 Varchar2,Nombre2 varchar2,Apellido1 varchar2,Apellido2 varchar2,Identificacion varchar2,Direccion varchar2) is
begin
insert into Dueños values (Codigos.nextval,Nombre1,Nombre2,Apellido1,Apellido2,Identificacion,Direccion);
commit;
exception when others then
rollback;
end;

/* Update*/
create or replace procedure U_Dueño (CodigoD int,Nombre1 Varchar2,Nombre2 varchar2,Apellido1 varchar2,Apellido2 varchar2,Identificacion varchar2,Direccion varchar2) is
begin
update  Dueños set due_Nombre1= Nombre1,due_Nombre2= Nombre2, due_Apellido1= Apellido1, due_Apellido2=Apellido2,due_Identificacion=Identificacion,due_Direccion=Direccion
where due_CodigoD=CodigoD;
commit;
exception when others then
rollback;
end;

/*Delete*/
create or replace procedure D_Dueño (CodigoD int) is
begin
delete from Dueños where due_CodigoD=CodigoD;
commit;
exception when others then
rollback;
end;

/*Select dueño*/
create or replace view S_Dueño as
select distinct DUEÑOS.DUE_CODIGOD ,Dueños.due_NOMBRE1,Dueños.due_NOMBRE2,Dueños.due_APELLIDO1,Dueños.due_APELLIDO2,DUEÑOS.DUE_IDENTIFICACION ,DUEÑOS.DUE_DIRECCION,
(listagg(Tel_Dueño.tedu_Tel,chr(9)) within group (order by Tel_Dueño.tedu_Tel)over (partition by Tel_dueño.due_CodigoD))as TelefonosM
from Dueños inner join Tel_Dueño on DUEÑOS.DUE_CODIGOD= Tel_Dueño.DUE_CODIGOD;

/*Tel del dueño*/

/*Insert*/
create or replace procedure I_Tel_Dueño (Tel varchar2 ) is
begin
insert into Tel_Dueño values ((select max(Dueños.due_CODIGOD) from Dueños),Tel);
commit;
exception when others then
rollback;
end;

/*Update*/
create or replace procedure U_Tel_Dueño (CodigoD int,Tel varchar2,Teln varchar2 ) is
begin
update Tel_Dueño set tedu_Tel=Teln where due_CodigoD=CodigoD and tedu_Tel=Tel;
commit;
exception when others then
rollback;
end;

/*Pacientes*/

/*Insert*/
create or replace procedure I_Paciente (NombreP varchar2,CodigoR int ,CodigoD int,CodigoM int,FotoP blob,FechaI date) is
begin
insert into Pacientes values (Codigos.nextval,NombreP,CodigoR,CodigoD,CodigoM,FotoP,FechaI);
commit;
exception when others then
rollback;
end;

/* Update*/
create or replace procedure U_Paciente (CodigoP int,NombreP varchar2,CodigoR int ,CodigoD int,CodigoM int,FotoP blob,FechaI date) is
begin
update  Pacientes set pac_NombreP= NombreP,raz_CodigoR= CodigoR, due_CodigoD= CodigoD, med_CodigoM=CodigoM,pac_FotoP=FotoP,pac_Fecha=FechaI
where pac_CodigoP=CodigoP;
commit;
exception when others then
rollback;
end;

/*Delete*/
create or replace procedure D_Paciente (CodigoP int) is
begin
delete from Pacientes where pac_CodigoP=CodigoP;
commit;
exception when others then
rollback;
end;

/*Cirugias*/

/*Insert*/
create or replace procedure I_Cirugia (Duracion varchar2,Descripcion varchar2,Riesgo varchar2,Nombre varchar2,Anestesía varchar2) is
begin
insert into Cirugias values (Codigos.nextval,Duracion,Descripcion,Riesgo,Nombre,Anestesía);
commit;
exception when others then
rollback;
end;

/* Update*/
create or replace procedure U_Cirugia (CodigoC int,Duracion varchar2,Descripcion varchar2,Riesgo varchar2,Nombre varchar2,Anestesía varchar2) is
begin
update  Cirugias set cir_Duracion= Duracion, cir_Descripcion= Descripcion, cir_Riesgo=Riesgo,cir_Nombre=Nombre,cir_Anestesía=Anestesía
where cir_CodigoC=CodigoC;
commit;
exception when others then
rollback;
end;

/*Delete*/
create or replace procedure D_Cirugia (CodigoC int) is
begin
delete from Cirugias where cir_CodigoC=CodigoC;
commit;
exception when others then
rollback;
end;

/*Citas*/

/*Insert*/
create or replace procedure I_Cita (Calendarizado date,CodigoP int,CodigoCi int,Hecha date,Descripcion varchar2) is
begin
insert into Citas values (Codigos.nextval,Calendarizado,CodigoP,CodigoCi,Hecha,Descripcion);
commit;
exception when others then
rollback;
end;

/* Update*/
create or replace procedure U_Cita (CodigoC int,Calendarizado date,CodigoP int,CodigoCi int,Hecha date,Descripcion varchar2) is
begin
update  Citas set cit_Calendarizado= Calendarizado, pac_CodigoP= CodigoP, cir_CodigoC=CodigoCi,cit_Hecha=Hecha,cit_Descripcion=Descripcion
where cit_CodigoC= CodigoC;
commit;
exception when others then
rollback;
end;

/*Delete*/
create or replace procedure D_Cita (CodigoC int) is
begin
delete from Citas where cit_CodigoC= CodigoC;
commit;
exception when others then
rollback;
end;

/*Reporte*/
/*Insertar*/
create or replace procedure I_Reporte (FechaH date,CodigoD int,CodigoP int,CodigoE int ,CodigoCi int,CodigoM int) is
begin
insert into Reporte values (((select count (rep_Secuencia) from Reporte where to_char(rep_FechaH,'YYYY')=to_char(FechaH,'YYYY') and to_char(rep_FechaH,'month')=to_char(FechaH,'month'))+1),to_char(FechaH,'month'),FechaH,CodigoD,CodigoP,CodigoE,CodigoCi,CodigoM);
commit;
exception when others then
rollback;
end;

/*Mostrar*/
create or replace view S_Reporte as
select distinct Reporte.rep_Secuencia,Reporte.rep_MesH,Reporte.rep_FechaH,
Reporte.due_CodigoD,(select (Dueños.due_Nombre1||' '||Dueños.due_Nombre2||' '||Dueños.due_Apellido1||' '||Dueños.due_Apellido2) from Dueños where Dueños.due_CodigoD=Reporte.due_CodigoD) as NombreD
,(select distinct listagg(Tel_Dueño.tedu_Tel,',') within group (order by Tel_Dueño.tedu_Tel)over (partition by Tel_Dueño.due_CodigoD) from Tel_Dueño where TEL_DUEÑO.DUE_CODIGOD=DUEÑOS.DUE_CODIGOD )as TelefonosD,
Reporte.pac_CodigoP,Pacientes.pac_NombreP,
Reporte.esp_CodigoE,Especies.esp_Especie,
Reporte.cit_CodigoC,Citas.cit_Calendarizado,
Reporte.med_CodigoM,(select (Médicos.med_Nombre1||' '||Médicos.med_Nombre2||' '||Médicos.med_Apellido1||' '||Médicos.med_Apellido2)from Médicos where Médicos.med_CodigoM=Reporte.med_CodigoM) as NombreM
 from Reporte inner join Dueños on Reporte.DUE_CODIGOD=Dueños.DUE_CODIGOD inner join Pacientes on Reporte.PAC_CODIGOP=Pacientes.PAC_CODIGOP inner join Especies on Reporte.ESP_CODIGOE=ESpecies.ESP_CODIGOE inner join Citas on Reporte.CIT_CODIGOC=Citas.CIT_CODIGOC inner join Médicos on Reporte.MED_CODIGOM=Médicos.MED_CODIGOM inner join Tel_Dueño on TEL_DUEÑO.DUE_CODIGOD=DUEÑOS.DUE_CODIGOD
 order by Reporte.REP_FECHAH;
 
/*Triger de auditorias*/
drop trigger I_AuditoriaP;
create or replace trigger I_AuditoriaP after delete or insert on Pacientes for each row
begin
if inserting then
insert into Auditorias values (USERENV('TERMINAL'),'Creo',sysdate,'Pacientes');
else
insert into Auditorias values (USERENV('TERMINAL'),'Elimino',sysdate,'Pacientes');
end if;
commit;
exception when others then
rollback;
end;

drop trigger I_AuditoriaM;
create or replace trigger I_AuditoriaM after delete or insert on Médicos for each row
begin
if inserting then
insert into Auditorias values (USERENV('TERMINAL'),'Creo',sysdate,'Médicos');
else
insert into Auditorias values (USERENV('TERMINAL'),'Elimino',sysdate,'Médicos');
end if;
commit;
exception when others then
rollback;
end;

drop trigger I_AuditoriaD;
create or replace trigger I_AuditoriaD after delete or insert on Dueños for each row
begin
if inserting then
insert into Auditorias values (USERENV('TERMINAL'),'Creo',sysdate,'Dueños');
else
insert into Auditorias values (USERENV('TERMINAL'),'Elimino',sysdate,'Dueños');
end if;
commit;
exception when others then
rollback;
end;

drop trigger I_AuditoriaC;
create or replace trigger I_AuditoriaC after delete or insert on Citas for each row
begin
if inserting then
insert into Auditorias values (USERENV('TERMINAL'),'Creo',sysdate,'Citas');
else
insert into Auditorias values (USERENV('TERMINAL'),'Elimino',sysdate,'Citas');
end if;
commit;
exception when others then
rollback;
end;

/*Jobs*/

DECLARE
  X NUMBER;
BEGIN
  SYS.DBMS_JOB.SUBMIT
    (
      job        => X
     ,what       => 'update Fecha set Fec_Fechahora= TRUNC(SYSDATE) where    Fec_Codigo= 1;
'
     ,next_date  => to_date('09/12/2019 13:22:13','dd/mm/yyyy hh24:mi:ss')
     ,interval   => 'TRUNC(SYSDATE+1)'
     ,no_parse   => FALSE
    );
:JobNumber := to_char(X);
commit;
END;

execute Llenar;
select *from Pacientes

