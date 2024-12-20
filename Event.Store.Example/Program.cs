using EventStore.Client;
using System.Text.Json;

string connectionString = "esdb://admin:changeit@localhost:2113?tls=false&tlsVerifyCert=false";

var settings = EventStoreClientSettings.Create(connectionString);

//bağlantıyı sağlayacak olan clienti oluşturduk.
var client = new EventStoreClient(settings);


OrderPlacedEvent orderPlacedEvent = new OrderPlacedEvent
{
    OrderId = 1,
    TotalAmount = 100
};

#region Eventleri eklemek için

//while (true)
//{
//    //EventStore'a event göndermek için bir eventdata oluşturduk.
//    EventData eventData = new EventData(
//        eventId: Uuid.NewUuid(),
//        type: orderPlacedEvent.GetType().Name,
//        data: JsonSerializer.SerializeToUtf8Bytes(orderPlacedEvent)
//    );

//    //EventStore'a event göndermek için bir stream oluşturduk.
//    await client.AppendToStreamAsync(
//        streamName: "order-stream",
//        expectedState: StreamState.Any,
//        eventData: new[] { eventData });

//}
#endregion

#region Eventleri okumak için

//var events = client.ReadStreamAsync(
//    streamName: "order-stream",
//    //Baştan sona okuma yapmak için
//    direction: Direction.Forwards,
//    //Kaçıncı eventten başlayacağımızı belirtiyoruz.
//    revision: StreamPosition.Start);

//var datas = await events.ToListAsync();

//Console.WriteLine();

#endregion

#region Stream Subscription(Eventleri Görüntüledik.)
//await client.SubscribeToStreamAsync(
//    streamName: "order-stream",
//    start: FromStream.Start,
//    eventAppeared: async (streamSubscription, resolvedEvent, cancellationToken) =>
//    {
//        var @event = JsonSerializer.Deserialize<OrderPlacedEvent>(resolvedEvent.Event.Data.ToArray());
//        await Console.Out.WriteLineAsync(JsonSerializer.Serialize(@event));
//    },
//    subscriptionDropped: (StreamSubscription, subscriptionDroppedReason, exception) => Console.WriteLine("Disconnected"));

//Console.Read();
#endregion


//EventStore'a event göndermek için bir event oluşturduk.
class OrderPlacedEvent
{
    public int OrderId { get; set; }
    public int TotalAmount { get; set; }
}