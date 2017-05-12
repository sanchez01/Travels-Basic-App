# Travels-Basic-App
 Basic application for travel using MassTransit with RabbitMQ as a service bus.
 
 Pre-requisites
 --------------
 - RabbitMQ Server >= 3.6.9 
 - Erlang >= 8.3
 - Microsoft .NET Core 1.1.0
 - SQL Server >= 2012
 
 Getting Started 
 ---------------
 To build this project, run Nuget Package restore and then run <a href = "https://msdn.microsoft.com/en-us/library/jj591621(v=vs.113).aspx"> Entity Framework Database Migrations </a> that are within the Travel.Data project
 on your SQL Server instance.
Create a virtual host named Travels on your RabbitMQ Server instance using the <a href = "https://www.rabbitmq.com/management.html">RabbitMQ Management plugin.</a>.
