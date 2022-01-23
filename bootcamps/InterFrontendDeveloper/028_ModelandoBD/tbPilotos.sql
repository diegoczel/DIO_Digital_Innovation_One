create table Pilotos (
  IdPiloto int not null,
  Nome varchar(200) not null,
  AnoNascimento varchar(10),
  IdPlaneta int not null
)
go
alter table Pilotos add constraint PK_Pilotos primary key(IdPiloto);
go
alter table Pilotos add constraint FK_Pilotos_Planeta foreign key(IdPlaneta) references Planetas(IdPlaneta);