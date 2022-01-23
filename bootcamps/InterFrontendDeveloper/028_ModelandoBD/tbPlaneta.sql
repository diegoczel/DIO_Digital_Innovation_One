create table Planetas (
  IdPlaneta int not null,
  Nome varchar(50) not null,
  Rotacao float not null,
  Orbita float not null,
  Diametro float not null,
  Clima varchar(50) not null,
  Populacao int not null
)
go -- fim de uma instrução e inicio de outra
alter table Planetas add constraint PK_Planetas primary key (IdPlaneta);