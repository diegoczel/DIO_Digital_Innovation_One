create table PilotosNaves(
  IdPiloto int not null,
  IdNave int not null,
  FlagAutorizado bit not null
)
go
alter table PilotosNaves add constraint PK_PilotosNaves primary key (IdPiloto, IdNave)
go
alter table PilotosNaves add constraint FK_PilotosNaves_Pilotos foreign key(IdPiloto) references Pilotos(IdPiloto)
go
alter table PilotosNaves add constraint FK_PilotosNaves_Naves foreign key(IdNave) references Naves(IdNave)
go
alter table PilotosNaves add constraint DF_PilotosNaves_FlagAutorizado default(1) for FlagAutorizado