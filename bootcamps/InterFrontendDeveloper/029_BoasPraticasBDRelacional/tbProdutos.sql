create table Produtos (
  Codigo int not null
  ,Descricao varchar(50) not null
  ,DtValida datetime
  ,Ean varchar(15) not null,
  ,IndInativo int not null default 0
)
go
alter table Produtos add constraint PK_Produtos primary key(Codigo)
go
-- IDX_Table_Column
create index IDX_Produtos_Ean on Produtos(Ean)