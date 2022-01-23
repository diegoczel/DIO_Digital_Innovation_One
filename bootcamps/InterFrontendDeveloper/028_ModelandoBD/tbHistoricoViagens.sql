create table HistoricoViagens (
  IdNave int not null,
  IdPiloto int not null,
  DtSaida datetime not null,
  DtChegada datetime null
)
go

alter table HistoricoViagens add constraint FK_HistoricoViagens_PilotosNaves foreign key (IdPiloto, IdNave) references PilotosNaves(IdPiloto, IdNave)
go 

alter table HistoricoViagens check constraint 
FK_HistoricoViagens_PilotosNaves