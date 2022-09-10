# Discount API 

ASP.NET Core Web API application
GRUD Operations,
PostgreSQL database connection and containerizatioN 
Repository pattern with PostgreSQL and Dapper (Dapper ORM + Npgsql)
Containerize Discount Microservices with PostgreSQL using Docker Compose

Architecture: 

	Data Access Layer
	Business Logic Layer
	Presentation Layer

# Discount GRPC

This Grpc application have the same data and structure as the discoun.api
We are going to expose grpc services for Basket.API microservices 
	(Example -> When the client add item into shopping cart, 
	Basket microservice will consume the discount through grpc services)

Synchronous backend microservice-to-microservice communication

Polyglot environments

Point-to-point real time communication 

Containerize Discount.GRPC 
