create table Loja (
  Codigo int not null
  ,Nome varchar(50) not null
  ,IndInativo int not null default 0
  ,constraint  PK_Loja primary key(Codigo)
)