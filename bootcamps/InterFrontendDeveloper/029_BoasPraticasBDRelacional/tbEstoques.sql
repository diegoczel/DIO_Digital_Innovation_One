create table Estoque(
  CodigoProduto int not null
  ,CodigoFilial int not null
  ,Quantidade decimal not null default 0
  ,constraint PK_Estoque primary key(CodigoProduto, CodigoFilial)
)
go
alter table Estoque add constraint FK_Estoque_Produtos foreign key(CodigoProduto) references Produtos(Codigo)

go 
alter table Estoque add constraint FK_Estoque_Loja foreign key(CodigoFilial) references Loja(Codigo)