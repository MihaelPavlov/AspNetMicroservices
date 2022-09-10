Basket API 

ASP.NET Core Web API application
GRUD Operations,
Redis database connection and containerization (We are usign Redis for distributing cache) 
Repository pattern with Redis
Containerize Basket Microservices with Redis using Docker Compose

Architecture: 

	- Data Access Layer
	- Business Logic Layer
	- Presentation Layer

....................................................................

Consuming Discount Grpc Service From Basket Microservice
We register the Basket.API as Client and the Discount.Grpc as a Server
And we are using Dapper for micro-orm to simplify the data access and ensure high performance