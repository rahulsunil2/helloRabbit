using System;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace HelloRabbitChat
{
    class Program
    {   
        static void Main(string[] args){
            Console.Write("Enter the Chat Session Name: ");
            var chatRoom = Console.ReadLine();

            var factory = new ConnectionFactory();
            factory.Uri = new Uri("amqp://guest:guest@localhost:5672");

            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();

            var exchangeName = "chatRoom";
            var queueName = Guid.NewGuid().ToString();

            channel.ExchangeDeclare(exchangeName, ExchangeType.Topic);
            channel.QueueDeclare(queueName, true, true, true);
            channel.QueueBind(queueName, exchangeName, chatRoom);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (sender, eventArgs) => {
                var msg = System.Text.Encoding.UTF8.GetString(eventArgs.Body.ToArray());
                Console.WriteLine($"Message: {msg}");
            };

            channel.BasicConsume(queueName, true, consumer);

            var input = Console.ReadLine();
            while (input != ""){
                var bytes = System.Text.Encoding.UTF8.GetBytes(input);
                channel.BasicPublish(exchangeName, chatRoom, null, bytes);
                input = Console.ReadLine();
            }

            channel.Close();
            connection.Close();
        }
    }
}
