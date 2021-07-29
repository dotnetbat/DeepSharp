-- Product
-- __________
-- ProductId   int
-- Name        nvarchar(max)
-- 
-- 
-- 
-- 
-- Customer
-- __________
-- CustomerId  int
-- Name        nvarchar(max)
-- 
-- создать структуру бд для хранения Order, при условии:
-- 1 - существующие таблицы менять нельзя
-- 2 - у одного ордера может быть много продуктов
-- 3 - у одного кастомера может быть много ордеров 
-- 
-- 
-- LineItem (OrderProduct)
-- ------------
-- LineItemId (OrderProductId)
-- OrderId
-- ProductId
-- 
-- 
-- Order
-- _________
-- OrderId PK
-- CustumerId FK 


SELECT Product.Name
FROM Product
         INNER JOIN LineItem on LineItem.ProductId = Product.ProductId
         INNER JOIN Order on Order.OrderId = LineItem.OrderId
         INNER JOIN Customer on Customer.CustomerId = Order.CustumerId
WHERE Customer.Name = 'Bill';