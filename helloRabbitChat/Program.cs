using System;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace HelloRabbitChat
{
    class Program
    {   
        static void Main(string[] args){
            var factory = new ConnectionFactory();
            factory.Uri = new Uri("amqp://guest:guest@localhost:5672");

            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();

            var exchangeName = "chat";
            var queueName = Guid.NewGuid().ToString();

            channel.ExchangeDeclare(exchangeName, ExchangeType.Fanout);
            channel.QueueDeclare(queueName, true, true, true);
            channel.QueueBind(queueName, exchangeName, "");

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (sender, eventArgs) => {
                var msg = System.Text.Encoding.UTF8.GetString(eventArgs.Body.ToArray());
                Console.WriteLine($"Message: {msg}");
            };

            channel.BasicConsume(queueName, true, consumer);

            var input = Console.ReadLine();
            while (input != ""){
                var bytes = System.Text.Encoding.UTF8.GetBytes(input);
                channel.BasicPublish(exchangeName, "", null, bytes);
                input = Console.ReadLine();
            }

            channel.Close();
            connection.Close();
        }
    }
}
