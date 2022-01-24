insert into Produtos values (1, 'produto 1', getdate(), '1234567890', 0 )

-- insert campos especificos
insert into Produtos(Codigo, Descricao, Ean) values
(2, 'produto 2', '0987654321');