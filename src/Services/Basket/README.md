# Basket API 

ASP.NET Core Web API application
GRUD Operations,
Redis database connection and containerization (We are usign Redis for distributing cache) 
Repository pattern with Redis
Containerize Basket Microservices with Redis using Docker Compose

Architecture: 

	Data Access Layer
	Business Logic Layer
	Presentation Layer

# Consuming Discount Grpc Service From Basket Microservice
We register the Basket.API as Client and the Discount.Grpc as a Server
And we are using Dapper for micro-orm to simplify the data access and ensure high performance

# Example of Pub/Sub RabbitMQ Architecture
<img width="803" alt="Pub Sub RabbitMQ Architecture Schema" src="https://user-images.githubusercontent.com/57910640/189497823-6b2efb1e-33df-4daf-99b0-a147fb849733.png">

# Example of Pub/Sub of BasketCheckoutEvent with Basket and Ordering Microservice
<img width="710" alt="Pub Sub of BasketCheckout Event with Basket and Ordering Microservices" src="https://user-images.githubusercontent.com/57910640/189497854-8b9e56fb-529d-4912-ab36-d71bf799fd40.png">
