# Ordering API 

ASP.NET Core Web API application
GRUD Operations,

Implementing DDD(Domain Drive Design),CQRS and Cleant Architecture with SOLID principles
Developing CQQRS implementation on commands and queries with using MediatR, FluentValidation and AutoMapper Packages

Entity Framework Core Code-First Approach

High Level Design - Simplified CQRS and DDD microservice

Architecture: 

	Ordering.Domain Layer
	Ordering.Application Layer
	Ordering.API Layer
	Ordering.Infrastructure Layer

# Description 
Microservices Async Communication with RabbitMQ & MassTransit for Checkout Order Between Basket-Ordering Microservices

We have RabbitMQ connection on Basket and Ordering Microservices for producing and consuming events

Basket Microservice includes Publish BasketCheckout Queue, and Ordering Microservice is consuming that queue

When we create CheckoutCommand(which is coming from client application).
After this we removing for example the basket from Redis database.
And after this Basket Microservice publish Checkout Event to the queue.

And the Subcriber microservices will consume this event and create a order in sqlServer database.

- DIP (Dependency Inversion Principles)
<img width="737" alt="Dependency Inversion Schema" src="https://user-images.githubusercontent.com/57910640/189497758-97d23107-e9f1-4e87-acb8-c3670366d1ed.png">

Without Dependency Inversion -> Business Logic(Upper Level Layer) using(depend) the Data Access(Lower Level Layer)

With Dependency Inversion -> Business Logic(Upper Level Layer) must not depend on the Data Access(Lower Level Layer)
						  -> Data Access(Lower Level Layer) must depend on the higher level modules interface for example (Interface - IRepository)
								and in that way the lower level Layer depends on the higher level interface. And the business is using the higher level interface to communicate with the lower level


- SoC (Separation of Concerns)

Element in the software should be unique to them. Not share their responsibilities to other modules.
Allow us to develop in our application without destroying or affecting the other modules.


- DDD (Domain Drive Design)

concepts :
	Ubiquitous Language - is uses in Domain Driven Design for the practice of building up a common, rigorous language between developers and users.

	Entity Value Object - Value objects can typically be represented as immutable objects; changing one property of a value object essentially destroys the old object and creates a new one,
			because you're not as concerned with identity as with content. Properly,
			the Equals instance method on Name would return "true" as long as the object's properties are identical to the properties of another instance.

	Aggregate Root - Within an Aggregate there is an Aggregate Root. The Aggregate Root is the parent Entity to all other Entities and Value Objects within the Aggregate.
			A Repository operates upon an Aggregate Root.

	Bounded Context - A bounded context is simply the boundary within a domain where a particular domain model applies.


- Cleant Architecture 
<img width="448" alt="Cleant Architecture Schema" src="https://user-images.githubusercontent.com/57910640/189497735-28647464-ae85-42eb-9afd-10d435dd7231.png">

Clean architecture is a software design philosophy that separates the elements of a design into ring levels.
In a clean architecture, the business logic is not decoupled from the database by some artificial means, instead,
it provides a high-level interface implemented by a persistence mechanism.
This shifts the dependency from the data access layer to the business logic layer at the architecture level.
This leads to the business logic becoming independent of technical details. As a result, it is even possible to implement and test the business logic before even having a database.

- CQRS (Command Query Responsibility Segregation)

Separation of commands and query responsibility
CQS (Command Query Separtaion)
Commands- CommandHandlers -> Command type is the only way you can change something in the system
Query - QueryHandlers

- MediatR
MediatR Requests are very simple request-response style messages, where a single request is synchronously handled by a single handler (synchronous from the request point of view, not C# internal async/await).

- Eventual Consistent

Inconsistent for a while 
CQRS PATTERN
Asynchronous processes
No Transactional Dependency

Event Sourcing

Accumulating events
Assets are not recorded
Events Recording 
Generating state from the events

CQRS and Event Sourcing Together

Writing models on the CQRS Design pattern
Event information generated as a result
Triggered and out reading model

- Microservices Communication Types
