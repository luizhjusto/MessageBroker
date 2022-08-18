# .NET Core Web Api 3.1 and RabbitMQ

A simple implementation using RabbitMQ as a message broker.

<b>Docker command to run RabbitMQ container</b>

	docker run -it --rm --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.10-management

<b>RabbitMQ using Docker url</b>		

	http://localhost:15672/
	User: guest
	Password: guest

<b>Packages</b>

.NET Core 3.1   
.NET Standard 2.1   
RabbitMQ.Client 6.4.0
